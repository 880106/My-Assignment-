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
    public partial class UserControlModuleType : UserControl
    {
        public UserControlModuleType()
        {
            InitializeComponent();
        }
        BLL bll = new BLL();
        private void UserControlModuletype_Load(object sender, EventArgs e)
        {

        }

        private void btnAddModuleType_Click(object sender, EventArgs e)
        {
            errorProviderModuleTypeDescription.Clear();

            bool hasError = false;

            if (string.IsNullOrWhiteSpace(txtModuleTypeDescription.Text))
            {
                errorProviderModuleTypeDescription.SetError(txtModuleTypeDescription, "Module Type Description is required.");
                hasError = true;
            }
            if (!hasError)
            {
                ModuleType addModuleType = new ModuleType();
                addModuleType.ModuleTypeDescription = txtModuleTypeDescription.Text;
               

              
                    int result = bll.InsertModuleType(addModuleType);

                    if (result > 0)
                    {
                        MessageBox.Show("Failed to add the Module Type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Module Type added successfully.");
                       refresher();
                        clearControl();
                    }

            }
        }

        private void btnUpdateModuleType_Click(object sender, EventArgs e)
        {
            if (dgvDisplayModuleType.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDisplayModuleType.SelectedRows[0];

                ModuleType updateModuleType = new ModuleType();
                updateModuleType.ModuleTypeDescription = txtModuleTypeDescription.Text;

                int ModuleTypeID = (int)selectedRow.Cells["ModuleTypeID"].Value;

                int result = bll.UpdateModuleType(updateModuleType);

                if (result > 0)
                {
                    MessageBox.Show("Failed to update the Module Type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Module Type updated successfully.");
                    clearControl();
                    refresher();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void btnDeleteModuleType_Click(object sender, EventArgs e)
        {
            if (dgvDisplayModuleType.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDisplayModuleType.SelectedRows[0];

                int ModuleTypeID = (int)selectedRow.Cells["ModuleTypeID"].Value;

                int result = bll.DeleteModuleType(ModuleTypeID);

                if (result > 0)
                {
                    MessageBox.Show("Failed to delete the Module Type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Module Type deleted successfully.");
                    clearControl();
                    refresher();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisplayModuleType_Click(object sender, EventArgs e)
        {
            dgvDisplayModuleType.DataSource = bll.GetModuleTypeData();
        }

        private void dgvDisplayModuleType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int assessmentTypeID = Convert.ToInt32(dgvDisplayModuleType.SelectedRows[0].Cells["ModuleTypeID"].Value);
            txtModuleTypeDescription.Text = dgvDisplayModuleType.SelectedRows[0].Cells["ModuleTypeDescription"].Value.ToString();

        }

        private void refresher()
        {
            dgvDisplayModuleType.DataSource = bll.GetModuleTypeData();
        }
        private void clearControl()
        {
            txtModuleTypeDescription.Clear();
        }
    }
}
