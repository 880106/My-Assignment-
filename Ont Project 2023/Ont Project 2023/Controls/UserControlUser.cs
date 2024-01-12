using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Data_Access_Layer;
using BusinessLogicLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Ont_Project_2023.Controls
{
    public partial class UserControlUser : UserControl
    {
        public UserControlUser()
        {
            InitializeComponent();
        }
        BLL bll = new BLL();


        private void UserControlUser_Load(object sender, EventArgs e)
        {


            cmbTitle.Items.Add("MR");
            cmbTitle.Items.Add("MS");
            cmbTitle.Items.Add("MRS");
            cmbTitle.Items.Add("MISS");

            cmbRole.Items.Add("Administrator");
            cmbRole.Items.Add("Lecturer");
            cmbRole.Items.Add("Student");




        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            errorProviderName.Clear();
            errorProviderSurname.Clear();
            errorProviderTitle.Clear();
            errorProviderRole.Clear();
            errorProviderEmail.Clear();
            errorProviderPassword.Clear();

            bool hasError = false;
            bool emailExists = bll.CheckIfEmailExits(txtEmail.Text);

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProviderName.SetError(txtName, "Name is required.");
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                errorProviderSurname.SetError(txtSurname, "Surname is required.");
                hasError = true;
            }

            if (string.IsNullOrEmpty(cmbTitle.Text))
            {
                errorProviderTitle.SetError(cmbTitle, "Title is required.");
                hasError = true;
            }

            if (string.IsNullOrEmpty(cmbRole.Text))
            {
                errorProviderRole.SetError(cmbRole, "Role is required.");
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProviderEmail.SetError(txtEmail, "Email is required.");
                hasError = true;
            }
            else if (!IsValidEmail(txtEmail.Text))
            {
                errorProviderEmail.SetError(txtEmail, "Invalid email format.");
                hasError = true;
            }
            else if (emailExists)
            {
                MessageBox.Show("User with this email already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hasError = true;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProviderPassword.SetError(txtPassword, "Password is required.");
                hasError = true;
            }
            if (!hasError) 
            {
                User newUser = new User();
                newUser.Name = txtName.Text;
                newUser.Surname = txtSurname.Text;
                newUser.Title = cmbTitle.Text;
                newUser.Role = cmbRole.Text;
                newUser.Email = txtEmail.Text;
                newUser.Password = txtPassword.Text;

                int result = bll.InsertUser(newUser);

                if (result > 0)
                {
                    MessageBox.Show("Failed to add user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("User added successfully.");
                    clearControls();
                    refresher();
                }
            }
        }



        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            errorProviderName.Clear();
            errorProviderSurname.Clear();
            errorProviderTitle.Clear();
            errorProviderRole.Clear();
            errorProviderPassword.Clear();

            string emailToUpdate = txtEmail.Text;

            if (IsValidEmail(emailToUpdate))
            {
                User updateUser = new User();
                updateUser.Name = txtName.Text;
                updateUser.Surname = txtSurname.Text;
                updateUser.Title = cmbTitle.Text;
                updateUser.Role = cmbRole.Text;
                updateUser.Email = txtEmail.Text;
                updateUser.Password = txtPassword.Text;

                int result = bll.UpdateUser(updateUser);

                if (result > 0)
                {
                    MessageBox.Show("Failed to update the user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("User updated successfully.");
                    clearControls();
                    refresher();
                }
            }
            else
            {
                errorProviderEmail.SetError(txtEmail, "Invalid email format.");
                MessageBox.Show("Invalid email format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {

            errorProviderName.Clear();
            errorProviderSurname.Clear();
            errorProviderTitle.Clear();
            errorProviderRole.Clear();
            errorProviderPassword.Clear();

            string emailToDelete = txtEmail.Text;

            if (IsValidEmail(emailToDelete))
            {
                int x = bll.DeleteUser(emailToDelete);

                if (x > 0)
                {
                    MessageBox.Show("Failed to delete the user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("User deleted successfully.");
                    clearControls();
                    refresher();
                }
            }
            else
            {
                errorProviderEmail.SetError(txtEmail, "Invalid email format.");
                MessageBox.Show("Invalid email format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisplayUser_Click(object sender, EventArgs e)
        {

            dgvDisplayUsers.DataSource = bll.GetUserData();
        }

        private void dgvDisplayUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDisplayUsers.SelectedRows.Count > 0)
            {
                int userID = Convert.ToInt32(dgvDisplayUsers.SelectedRows[0].Cells["UserID"].Value);
                txtName.Text = dgvDisplayUsers.SelectedRows[0].Cells["Name"].Value.ToString();
                txtSurname.Text = dgvDisplayUsers.SelectedRows[0].Cells["Surname"].Value.ToString();
                cmbTitle.Text = dgvDisplayUsers.SelectedRows[0].Cells["Title"].Value.ToString();
                cmbRole.Text = dgvDisplayUsers.SelectedRows[0].Cells["Role"].Value.ToString();
                txtEmail.Text = dgvDisplayUsers.SelectedRows[0].Cells["Email"].Value.ToString();
                txtPassword.Text = dgvDisplayUsers.SelectedRows[0].Cells["Password"].Value.ToString();

            }

        }

        public static bool IsValidEmail(string email)
        {
          
            string pattern = @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$";
            return Regex.IsMatch(email, pattern);
        }

        private void errorProviderTitle_RightToLeftChanged(object sender, EventArgs e)
        {

        }

        private void refresher()
        {
            dgvDisplayUsers.DataSource = bll.GetUserData();
        }
        private void clearControls()
        {
            txtName.Clear();
            txtSurname.Clear();
            cmbTitle.SelectedIndex = -1;
            cmbRole.SelectedIndex = -1;
            txtEmail.Clear();
            txtPassword.Clear();
        }
    }
}
