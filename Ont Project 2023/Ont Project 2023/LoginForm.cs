using BusinessLogicLayer;
using Ont_Project_2023.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ont_Project_2023
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        BLL bll = new BLL();
        private void btnLoginPassword_Click(object sender, EventArgs e)
        {
               
               if (radioAdmin.Checked || radioLecturer.Checked || radioStudent.Checked)
               {
                   
                   string email = txtEmail.Text;
                   string password = txtPassword.Text;

                 
                   if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                   {
                       MessageBox.Show("Please enter both email and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       clear();
                   }
                   else
                   {
                       try
                       {
                           
                           DataTable dt = bll.Login(email, password);

                           if (dt.Rows.Count > 0)
                           {
                               string userRole = dt.Rows[0]["Role"].ToString(); 

                               if (radioAdmin.Checked && userRole == "Administrator")
                               {
                                   AdminForm mainForm = new AdminForm();
                                   mainForm.Show();
                                   this.Hide();
                               }
                               else if (radioLecturer.Checked && userRole == "Lecturer")
                               {
                                   FrmLecturer lecturer = new FrmLecturer();
                                   lecturer.Show();
                                   this.Hide();
                               }
                               else if (radioStudent.Checked && userRole == "Student")
                               {
                                   FrmStudent student = new FrmStudent();
                                   student.Show();
                                   this.Hide();
                               }
                               else
                               {
                                   MessageBox.Show("User's role doesn't match the selected option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                   clear();
                               }


                           }
                           else
                           {
                               MessageBox.Show("Authentication failed. Please check your credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                               clear();
                           }
                       }
                       catch (Exception ex)
                       {
                           MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                           clear();
                       }
                   }
               }
               else
               {
                   MessageBox.Show("Please select a user type (Admin, Lecturer, or Student) before logging in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
            
          /*  if (radioAdmin.Checked )
            {
                AdminForm mainForm = new AdminForm();
                mainForm.Show();
                this.Hide();
            }
            else if (radioLecturer.Checked )
            {
                FrmLecturer lecturer = new FrmLecturer();
                lecturer.Show();
                this.Hide();
            }
            else if (radioStudent.Checked )
            {
                FrmStudent student = new FrmStudent();
                student.Show();
                this.Hide();
            } 
          */
        }

        public void clear()
        {
            txtEmail.Clear();
            txtPassword.Clear();
        } 
    }
}
