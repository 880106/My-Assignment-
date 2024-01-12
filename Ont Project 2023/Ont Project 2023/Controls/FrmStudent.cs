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
    public partial class FrmStudent : Form
    {
        Controls.UserControlStudentManagesAssessment AssessmentType = new Controls.UserControlStudentManagesAssessment();
        Controls.UserControlStudentReporting studentReporting = new Controls.UserControlStudentReporting();
        Controls.UserControlDisplayModules  moduleDisplay = new Controls.UserControlDisplayModules();
        public FrmStudent()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm logout = new LoginForm();
                logout.Show();
                this.Hide();
            }
        }

        private void btnManageAssessment_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            panel3.Controls.Add(AssessmentType);
            AssessmentType.Dock = DockStyle.Fill;
        }

        private void btnManageReporting_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            panel3.Controls.Add(studentReporting);
            studentReporting.Dock = DockStyle.Fill;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            panel3.Controls.Add(moduleDisplay);
            moduleDisplay.Dock = DockStyle.Fill;
        }
    }
}
