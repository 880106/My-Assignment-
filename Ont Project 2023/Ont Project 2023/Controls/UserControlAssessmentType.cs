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

namespace Ont_Project_2023.Controls
{
    public partial class UserControlAssessmentType : UserControl
    {
        public UserControlAssessmentType()
        {
            InitializeComponent();
        }
        BLL bll = new BLL();
        private void btnAddAssessemnt_Click(object sender, EventArgs e)
        {

            errorProviderAssessmentTypeDescription.Clear();

            bool hasError = false;

            if (string.IsNullOrWhiteSpace(txtAssessmentTypeDescription.Text))
            {
                errorProviderAssessmentTypeDescription.SetError(txtAssessmentTypeDescription, "Assessment Type Description is required.");
                hasError = true;
            }
            if (!hasError)
            {
                AssessmentType addAssessmentType = new AssessmentType();
                addAssessmentType.AssessmentTypeDescription = txtAssessmentTypeDescription.Text;
                bool assessmentTypeExists = bll.CheckAssessmentTypeExists(addAssessmentType.AssessmentTypeDescription);

                if (assessmentTypeExists)
                {
                    MessageBox.Show("Assessment type '" + addAssessmentType.AssessmentTypeDescription + "' already exists. You cannot add it again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int result = bll.InsertAssessmentType(addAssessmentType);

                    if (result > 0)
                    {
                        MessageBox.Show("Failed to add the Assessment Type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Assessment Type added successfully.");
                        refresher();
                    }
                }
            }
            }

            private void btnUpdateAssessement_Click(object sender, EventArgs e)
        {
            if (dgvDisplayAssessmentType.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDisplayAssessmentType.SelectedRows[0];

                AssessmentType updateAssessmentType = new AssessmentType();
                updateAssessmentType.AssessmentTypeDescription = txtAssessmentTypeDescription.Text;
                int assessmentTypeID = (int)selectedRow.Cells["AssessmentTypeID"].Value;

                int result = bll.UpdateAssessmentType(updateAssessmentType);

                if (result > 0)
                {
                    MessageBox.Show("Failed to update the Assessment Type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Assessment Type updated successfully.");
                    refresher();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void btnDeleteAssessment_Click(object sender, EventArgs e)
        {
            if (dgvDisplayAssessmentType.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDisplayAssessmentType.SelectedRows[0];

                int assessmentTypeID = (int)selectedRow.Cells["AssessmentTypeID"].Value;

                int result = bll.DeleteAssessmentType(assessmentTypeID);

                if (result > 0)
                {
                    MessageBox.Show("Failed to delete the Assessment Type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Assessment Type deleted successfully.");
                    refresher();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisplayAssessment_Click(object sender, EventArgs e)
        {
            dgvDisplayAssessmentType.DataSource = bll.GetAssessmentTypeData();
        }

        private void dgvDisplayAssessmentType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int assessmentTypeID = Convert.ToInt32(dgvDisplayAssessmentType.SelectedRows[0].Cells["AssessmentTypeID"].Value);
            txtAssessmentTypeDescription.Text = dgvDisplayAssessmentType.SelectedRows[0].Cells["AssessmentTypeDescription"].Value.ToString();

        }

        private void refresher()
        {
            dgvDisplayAssessmentType.DataSource = bll.GetAssessmentTypeData();
        }
    }
}
