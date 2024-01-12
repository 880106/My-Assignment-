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
    public partial class AdminForm : Form
    {
        Controls.UserControlUser udUser = new Controls.UserControlUser();
        Controls.UserControlModuleType udModuleType = new Controls.UserControlModuleType();
        Controls.UserControlModules udModules = new Controls.UserControlModules();
        Controls.UserControlLecturerModules udLecturerModules = new Controls.UserControlLecturerModules();
        Controls.UserControlStudentsModules udStudentsModules = new Controls.UserControlStudentsModules();
        Controls.UserControlReporting udReporting = new Controls.UserControlReporting();

        public AdminForm()
        {

            InitializeComponent();
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
           
                LoginForm logout = new LoginForm();
                logout.Show();
                this.Hide();
            }
         
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {

            panel3.Controls.Clear();
            panel3.Controls.Add(udUser);
            udUser.Dock = DockStyle.Fill;
        }

        private void btnManageModuleType_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            panel3.Controls.Add(udModuleType);
            udModuleType.Dock = DockStyle.Fill;
        }

        private void btnManageModules_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            panel3.Controls.Add(udModules);
            udModules.Dock = DockStyle.Fill;
        }

        private void btnManageLecturerModules_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            panel3.Controls.Add(udLecturerModules);
            udLecturerModules.Dock = DockStyle.Fill;
        }

        private void btnManageStudentsModules_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            panel3.Controls.Add(udStudentsModules);
            udStudentsModules.Dock = DockStyle.Fill;
        }

        private void btnManageReporting_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            panel3.Controls.Add(udReporting);
            udReporting.Dock = DockStyle.Fill;
        }

      

    }
}
