using BusinessLogicLayer;
using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ont_Project_2023.Controls
{
    public partial class UserControlAssessment : UserControl
    {
        public UserControlAssessment()
        {
            InitializeComponent();
            cmbAssessmentType.SelectedIndexChanged += new EventHandler(cmbAssessmentType_SelectedIndexChanged);
        }
        BLL bll = new BLL();

        private void UserControlAssessment_Load(object sender, EventArgs e)
        {
            cmbAssessmentTypeID.DataSource = bll.GetDataForCmbType();
            cmbAssessmentTypeID.ValueMember = "AssessmentTypeID";
            cmbAssessmentTypeID.DisplayMember = "AssessmentTypeDescription";


            cmbAssessmentType.DataSource = bll.GetDataForCmbType();
            cmbAssessmentType.ValueMember = "AssessmentTypeID";
            cmbAssessmentType.DisplayMember = "AssessmentTypeDescription";

            cmbAssessmentTypeID.SelectedIndex = -1;
            cmbAssessmentType.SelectedIndex = -1;

            dgvDisplayAssessement.DataSource = null;
           
        }
        private void btnAddAssessemnt_Click(object sender, EventArgs e)
        {
            errorProviderStudentLecturerModuleID.Clear();
            errorProviderDate.Clear();
            errorProviderAssessmentTypeID.Clear();

            bool hasError = false;


            if (string.IsNullOrWhiteSpace(txtStudentLecturerModuleID.Text))
            {
                errorProviderAssessmentTypeID.SetError(txtStudentLecturerModuleID, "Student Lecturer Module ID is required.");
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(cmbAssessmentTypeID.Text))
            {
                errorProviderAssessmentTypeID.SetError(cmbAssessmentTypeID, "Assessment Type ID is required.");
                hasError = true;
            }

            if (dateTimePicker1.Value == null)
            {
                errorProviderDate.SetError(dateTimePicker1, "Date is required.");
                hasError = true;
            }
            if (!hasError)
            {
                Assessment assess = new Assessment();
                assess.StudentLecturerModuleID = int.Parse(txtStudentLecturerModuleID.Text);
                assess.DueDate = dateTimePicker1.Value.ToString("yyyy/MM/dd");
                assess.AssessmentTypeID = (int)cmbAssessmentTypeID.SelectedValue;

                int result = bll.InsertAssessment(assess);

                if (result > 0)
                {
                    MessageBox.Show("Failed to add the Assessment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Assessment added successfully.");
                }
            }
            }

            private void btnUpdateAssessement_Click(object sender, EventArgs e)
        {
            Assessment assessUpdate = new Assessment();

            assessUpdate.StudentLecturerModuleID = int.Parse(txtStudentLecturerModuleID.Text);

            assessUpdate.DueDate = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            assessUpdate.AssessmentTypeID = (int)cmbAssessmentTypeID.SelectedValue;

            int result = bll.UpdateAssessment(assessUpdate);

            if (result > 0)
            {
                MessageBox.Show("Failed to update the Assessment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Assessment updated successfully.");
            }
        }

        private void btnDeleteAssessment_Click(object sender, EventArgs e)
        {
            int assessmentID = int.Parse(txtStudentLecturerModuleID.Text);

            int result = bll.DeleteAssessment(assessmentID);

            if (result > 0)
            {
                MessageBox.Show("Failed to delete the Assessment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Assessment deleted successfully.");
            }

        }

        private void btnDisplayAssessment_Click(object sender, EventArgs e)
        {
            dgvDisplayAssessement.DataSource = bll.GetAssessmentData();
        }

        private void dgvDisplayAssessement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int AssessmentID = Convert.ToInt32(dgvDisplayAssessement.SelectedRows[0].Cells["AssessmentID"].Value);
            txtStudentLecturerModuleID.Text = dgvDisplayAssessement.SelectedRows[0].Cells["StudentLecturerModuleID"].Value.ToString();
            dateTimePicker1.Value = DateTime.ParseExact(dgvDisplayAssessement.SelectedRows[0].Cells["DueDate"].Value.ToString(), "yyyy,MM,dd", null);
            cmbAssessmentTypeID.Text = dgvDisplayAssessement.SelectedRows[0].Cells["AssessmentTypeID"].Value.ToString();
           
        }

        private void cmbAssessmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProviderAssessmentType.Clear();
            if (cmbAssessmentType.SelectedItem != null)
            {
                errorProviderAssessmentType.SetError(cmbAssessmentType, "Assessment Type is required.");
                if (cmbAssessmentType.SelectedValue is int selectedAssessmentTypeID)
                {
                    
                    DataTable assessments = bll.GetByAssessmentType(selectedAssessmentTypeID);
                    dgvDisplayAssessement.DataSource = assessments;

                    dgvDisplayAssessement.ClearSelection();
                }
                else
                {
                    
                    dgvDisplayAssessement.DataSource = null;
                }
            }
        }

        private void gbManageAssessment_Enter(object sender, EventArgs e)
        {

        }

      
    }
}
