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
    public partial class FrmLecturer : Form
    {
        Controls.UserControlAssessment Assessment = new Controls.UserControlAssessment();
        Controls.UserControlAssessmentType AssessmentType = new Controls.UserControlAssessmentType();
        Controls.UserControlReportingAssessment AssessmentReporting = new Controls.UserControlReportingAssessment();

        public FrmLecturer()
        {
            InitializeComponent();
        }

        private void FrmLecturer_Load(object sender, EventArgs e)
        {

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
            panel3.Controls.Add(Assessment);
            Assessment.Dock = DockStyle.Fill;
        }

        private void btnManageAssessmentType_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            panel3.Controls.Add(AssessmentType);
            AssessmentType.Dock = DockStyle.Fill;
        }

        private void btnManageReporting_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            panel3.Controls.Add(AssessmentReporting);
            AssessmentReporting.Dock = DockStyle.Fill;
        }

       
    }
}
