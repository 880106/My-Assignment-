using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data_Access_Layer;
using System.Xml.Linq;

namespace Ont_Project_2023.Controls
{
    public partial class UserControlStudentManagesAssessment : UserControl
    {
        public UserControlStudentManagesAssessment()
        {
            InitializeComponent();
        }

        BLL bll = new BLL();
        private void UserControlStudentManagesAssessment_Load(object sender, EventArgs e)
        {
            cmbAssessmentStatus.Items.Add("completed");
            cmbAssessmentStatus.Items.Add("missed");
            cmbAssessmentStatus.Items.Add("rescheduled");

            cmbAssessmentTypeID.DataSource = bll.GetDataForCmbType();
            cmbAssessmentTypeID.ValueMember = "AssessmentTypeID";
            cmbAssessmentTypeID.DisplayMember = "AssessmentTypeDescription";

            cmbAssessmentStatus.SelectedIndex = -1;
            cmbAssessmentTypeID.SelectedIndex = -1;
            dgvDisplayAssessement.DataSource = bll.GetManageAssessment();
        }

        private void btnAddAssessemnt_Click(object sender, EventArgs e)
        {
            errorProviderAssessmentTypeID.Clear();
            errorProviderMarkAssessment.Clear();
            errorProviderDate.Clear();

            bool hasError = false;


            if (string.IsNullOrWhiteSpace(cmbAssessmentTypeID.Text))
            {
                errorProviderAssessmentTypeID.SetError(cmbAssessmentTypeID, "Assessment Type ID is required.");
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(cmbAssessmentStatus.Text))
            {
                errorProviderMarkAssessment.SetError(cmbAssessmentStatus, "Marks Assessment is required.");
                hasError = true;
            }

            if (dateTimePicker1.Value == null)
            {
                errorProviderDate.SetError(dateTimePicker1, "Date is required.");
                hasError = true;
            }
            if (!hasError)
            {
                ManageAssessment addAssessment = new ManageAssessment();
                addAssessment.AssessmentTypeID = Convert.ToInt32(cmbAssessmentTypeID.SelectedValue);
                addAssessment.MarkAssessment = cmbAssessmentStatus.Text;
                addAssessment.Date = dateTimePicker1.Value.ToString("yyyy/MM/dd");



                int rowsAffected = bll.InsertManageAssessment(addAssessment);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Failed to add the assessment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Assessment added successfully.");
                    refresh();
                    clear();
                }
            }
        }

        private void btnUpdateAssessement_Click(object sender, EventArgs e)
        {
            ManageAssessment updateAssessment = new ManageAssessment();


            updateAssessment.AssessmentTypeID = Convert.ToInt32(cmbAssessmentTypeID.SelectedValue);
            updateAssessment.MarkAssessment = cmbAssessmentStatus.Text;
            updateAssessment.Date = dateTimePicker1.Value.ToString("yyyy/MM/dd");



            int rowsAffected = bll.UpdateManageAssessment(updateAssessment);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Failed to update the assessment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Assessment updated successfully.");
                refresh();
                clear();
            }
        }

        private void btnDeleteAssessment_Click(object sender, EventArgs e)
        {
            int assessmentTypeID = Convert.ToInt32(cmbAssessmentTypeID.SelectedValue);

            int rowsAffected = bll.DeleteManageAssessment(assessmentTypeID);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Failed to delete the assessment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Assessment deleted successfully.");
                refresh();
                clear();
            }
        }

        private void btnDisplayAssessment_Click(object sender, EventArgs e)
        {
            dgvDisplayAssessement.DataSource = bll.GetManageAssessment();
        }

        private void dgvDisplayAssessement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refresh()
        {
            dgvDisplayAssessement.DataSource = bll.GetManageAssessment();
        }

        private void clear()
        {
            cmbAssessmentStatus.SelectedIndex = -1;
            cmbAssessmentTypeID.SelectedIndex = -1;
        }
    }
}
