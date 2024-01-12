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
    public partial class UserControlReporting : UserControl
    {
        public UserControlReporting()
        {
            InitializeComponent();
        }
        BLL bll = new BLL();
        private void UserControlReporting_Load(object sender, EventArgs e)
        {
            dgvDisplaybyName.DataSource = bll.GetUserData();
        }

        private void btnSearchStaffStudent_Click(object sender, EventArgs e)
        {
            dgvDisplaybyName.DataSource = bll.SearchByName(txtSearchStudent.Text);
        }
    }
}
