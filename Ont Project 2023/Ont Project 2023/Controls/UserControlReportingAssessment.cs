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
    public partial class UserControlReportingAssessment : UserControl
    {
        public UserControlReportingAssessment()
        {
            InitializeComponent();
        }
        BLL bll = new BLL();

        private void UserControlReportingAssessment_Load(object sender, EventArgs e)
        {
            dgvDisplaybyName.DataSource = bll.GetAssessmentData();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchBetwDat_Click(object sender, EventArgs e)
        {
            string startDate = dtStartDate.Value.ToString("yyyy/MM/dd");
            string endDate = dtEndDate.Value.ToString("yyyy/MM/dd");
            dgvDisplaybyName.DataSource = bll.GetRepotingInformation(txtAssessment.Text, startDate, endDate);
        }

       
    }
}
