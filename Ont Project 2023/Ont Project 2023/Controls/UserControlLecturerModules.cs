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
    public partial class UserControlLecturerModules : UserControl
    {
        public UserControlLecturerModules()
        {
            InitializeComponent();
        }
        BLL bll = new BLL();




        private void UserControlLecturerModules_Load(object sender, EventArgs e)
        {
            cmbUserID.DataSource = bll.GetUserIDForCmbLecturerModule();
            cmbUserID.ValueMember = "UserId";
            cmbUserID.DisplayMember = "Name";

            cmbModuleID.DataSource = bll.GetModulIdForcmbLecturer(); ;
            cmbModuleID.ValueMember = "ModuleID";
            cmbModuleID.DisplayMember = "ModuleName";

            cmbUserID.SelectedIndex = -1;
            cmbModuleID.SelectedIndex = -1;

        }
        private void btnAddLecturerModule_Click(object sender, EventArgs e)
        {
            errorProviderLecturerModuleID.Clear();
            errorProviderUserID.Clear();
            errorProviderModuleID.Clear();

            bool hasError = false;

            if (!int.TryParse(txtLecturerModuleID.Text, out int lecturerModuleID))
            {
                errorProviderLecturerModuleID.SetError(txtLecturerModuleID, "Lecturer Module ID must be an integer.");
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(cmbUserID.Text))
            {
                errorProviderUserID.SetError(cmbUserID, "User ID is required.");
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(cmbModuleID.Text))
            {
                errorProviderModuleID.SetError(cmbModuleID, "Module ID is required.");
                hasError = true;
            }

            if (dateTimePicker1.Value == null)
            {
                errorProviderDate.SetError(dateTimePicker1, "Date is required.");
                hasError = true;
            }

            if (!hasError)
            {
                LecturerModule addLecturerModule = new LecturerModule();

                if (int.TryParse(txtLecturerModuleID.Text, out int lecturerModuleIDInt) &&
                    int.TryParse(cmbUserID.SelectedValue.ToString(), out int userID) &&
                    int.TryParse(cmbModuleID.SelectedValue.ToString(), out int moduleID))
                {
                    addLecturerModule.LecturerModuleID = lecturerModuleIDInt;
                    addLecturerModule.UserID = userID;
                    addLecturerModule.ModuleID = moduleID;
                    addLecturerModule.Date = dateTimePicker1.Value.ToString("yyyy/MM/dd");

                    int result = bll.InsertLecturerModule(addLecturerModule);

                    if (result > 0)
                    {
                        MessageBox.Show("Failed to add the Lecturer Module.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Lecturer Module added successfully.");
                        refresher();
                        clear();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input. Please enter valid values for Lecturer Module ID, User ID, and Module ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnUpdateLecturerModule_Click(object sender, EventArgs e)
        {
            errorProviderLecturerModuleID.Clear();
            errorProviderUserID.Clear();
            errorProviderModuleID.Clear();

            if (int.TryParse(txtLecturerModuleID.Text, out int lecturerModuleID))
            {
                if (cmbUserID.SelectedItem is DataRowView userRow &&
                    cmbModuleID.SelectedItem is DataRowView moduleRow)
                {
                 
                    LecturerModule updateLecturerModule = new LecturerModule();
                    updateLecturerModule.LecturerModuleID = lecturerModuleID;
                    updateLecturerModule.UserID = Convert.ToInt32(userRow["UserId"]);
                    updateLecturerModule.ModuleID = Convert.ToInt32(moduleRow["ModuleID"]);
                    updateLecturerModule.Date = dateTimePicker1.Value.ToString("yyyy/MM/dd");

                    int result = bll.UpdateLecturerModule(updateLecturerModule);

                    if (result > 0)
                    {
                        MessageBox.Show("Failed to update the Lecturer Module.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Lecturer Module updated successfully.");
                        refresher();
                        clear();
                    }
                }
                else
                {
                    MessageBox.Show("Please select valid values for UserID and ModuleID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                errorProviderLecturerModuleID.SetError(txtLecturerModuleID, "Lecturer Module ID must be an integer.");
            }
        }

        private void btnDeleteLecturerModule_Click(object sender, EventArgs e)
        {
            errorProviderLecturerModuleID.Clear();

            if (int.TryParse(txtLecturerModuleID.Text, out int lecturerModuleID))
            {
                int result = bll.DeleteLecturerModule(lecturerModuleID);

                if (result > 0)
                {
                    MessageBox.Show("Failed to delete the Lecturer Module.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lecturer Module deleted successfully.");
                    refresher();
                    clear();
                }
            }
            else
            {
                errorProviderLecturerModuleID.SetError(txtLecturerModuleID, "Lecturer Module ID must be an integer.");
            }
        }

        private void btnDisplayLecturerModule_Click(object sender, EventArgs e)
        {
            dgvDisplayLecturerModules.DataSource = bll.GetLecturerModuleData();
        }

        private void dgvDisplayLecturerModules_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDisplayLecturerModules.SelectedRows.Count > 0)
            {
                int lecturerModuleID = Convert.ToInt32(dgvDisplayLecturerModules.SelectedRows[0].Cells["LecturerModuleID"].Value);
                cmbUserID.Text = dgvDisplayLecturerModules.SelectedRows[0].Cells["UserID"].Value.ToString();
                cmbModuleID.Text = dgvDisplayLecturerModules.SelectedRows[0].Cells["ModuleID"].Value.ToString();
                dateTimePicker1.Value = DateTime.ParseExact(dgvDisplayLecturerModules.SelectedRows[0].Cells["Date"].Value.ToString(), "yyyy,MM,dd", null);

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void refresher()
        {
            dgvDisplayLecturerModules.DataSource = bll.GetLecturerModuleData();
        }
        private void clear()
        {
            txtLecturerModuleID.Clear();
            cmbModuleID.SelectedIndex = -1;
            cmbUserID.SelectedIndex = -1;
        }

    }
}
