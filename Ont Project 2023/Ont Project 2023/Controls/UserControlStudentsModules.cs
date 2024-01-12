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
    public partial class UserControlStudentsModules : UserControl
    {
        public UserControlStudentsModules()
        {
            InitializeComponent();
        }
        BLL bll = new BLL();

        private void UserControlStudentsModules_Load(object sender, EventArgs e)
        {
            cmbLecturerModuleID.DataSource = bll.GetModIDForStud();
            cmbLecturerModuleID.ValueMember = "LecturerModuleID";
            cmbLecturerModuleID.DisplayMember = "Name";

            cmbUserID.DataSource = bll.GetUserIDForCmbStudent();
            cmbUserID.ValueMember = "UserId";
            cmbUserID.DisplayMember = "Name";

            cmbLecturerModuleID.SelectedIndex = -1;
            cmbUserID.SelectedIndex = -1;



        }

        private void btnAddStudentsModule_Click(object sender, EventArgs e)
        {
            errorProviderStudentModuleID.Clear();
            errorProviderLecturerModuleID.Clear();
            errorProviderUserID.Clear();
            errorProviderDate.Clear(); 

            bool hasError = false;

            if (string.IsNullOrWhiteSpace(txtStudentsModuleID.Text))
            {
                errorProviderStudentModuleID.SetError(txtStudentsModuleID, "Student Module ID is required.");
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(cmbLecturerModuleID.Text))
            {
                errorProviderLecturerModuleID.SetError(cmbLecturerModuleID, "Lecturer Module ID is required.");
                hasError = true;
            }

            if (string.IsNullOrEmpty(cmbUserID.Text))
            {
                errorProviderUserID.SetError(cmbUserID, "User ID is required.");
                hasError = true;
            }

           
            if (dateTimePicker1.Value == null)
            {
                errorProviderDate.SetError(dateTimePicker1, "Date is required.");
                hasError = true;
            }

            if (!hasError)
            {
                StudentModule addStudentModule = new StudentModule();

                if (int.TryParse(txtStudentsModuleID.Text, out int studentModuleID) &&
                    int.TryParse(cmbLecturerModuleID.SelectedValue.ToString(), out int lecturerModuleID) &&
                    int.TryParse(cmbUserID.SelectedValue.ToString(), out int userID))
                {
                    addStudentModule.StudentModuleID = studentModuleID;
                    addStudentModule.LecturerModuleID = lecturerModuleID;
                    addStudentModule.UserID = userID;
                    addStudentModule.Date = dateTimePicker1.Value.ToString("yyyy/MM/dd");

                    int result = bll.InsertStudentModule(addStudentModule);

                    if (result > 0)
                    {
                        MessageBox.Show("Failed to add the Student Module.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Student Module added successfully.");
                        refresher();
                        clear();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input. Please enter valid values for Student Module ID, Lecturer Module ID, and User ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

            private void btnUpdateStudentsModule_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtStudentsModuleID.Text, out int studentModuleID))
            {
                StudentModule updateStudentModule = new StudentModule();


                updateStudentModule.StudentModuleID = studentModuleID;
                updateStudentModule.Date = dateTimePicker1.Value.ToString("yyyy/MM/dd");
                

                int result = bll.UpdateStudentModule(updateStudentModule);

                if (result > 0)
                {
                   MessageBox.Show("Failed to update the Student Module.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Student Module updated successfully.");
                    refresher();
                    clear();
                }
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter valid values for Student Module ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteStudentsModule_Click(object sender, EventArgs e)
        {
            int studentModuleID = int.Parse(txtStudentsModuleID.Text);

            int result = bll.DeleteStudentModule(studentModuleID);

            if (result > 0)
            {
                MessageBox.Show("Failed to delete the Student Module.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Student Module deleted successfully.");
                refresher();
                clear();
            }

        }

        private void btnDisplayStudentsModule_Click(object sender, EventArgs e)
        {
            dgvDisplayStudentsModules.DataSource = bll.GetStudentModuleData();
        }

        private void dgvDisplayStudentsModules_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int studentModuleID = Convert.ToInt32(dgvDisplayStudentsModules.SelectedRows[0].Cells["StudentModuleID"].Value);
                cmbLecturerModuleID.Text = dgvDisplayStudentsModules.SelectedRows[0].Cells["LecturerModuleID"].Value.ToString();
                cmbUserID.Text = dgvDisplayStudentsModules.SelectedRows[0].Cells["UserID"].Value.ToString();
                dateTimePicker1.Value = DateTime.ParseExact(dgvDisplayStudentsModules.SelectedRows[0].Cells["Date"].Value.ToString(), "yyyy-MM-dd", null);

            }
        }

        private void gbManageStudentsModule_Enter(object sender, EventArgs e)
        {

        }
        private void refresher()
        {
            dgvDisplayStudentsModules.DataSource = bll.GetStudentModuleData();
        }

        private void clear()
        {
            txtStudentsModuleID.Clear();
            cmbLecturerModuleID.SelectedIndex = -1;
            cmbUserID.SelectedIndex = -1;
        }
    }

}
