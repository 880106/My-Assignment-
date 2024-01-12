
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
using BusinessLogicLayer;
using System.Xml.Linq;

namespace Ont_Project_2023.Controls
{
    public partial class UserControlModules : UserControl
    {
        public UserControlModules()
        {
            InitializeComponent();
            this.Load += UserControlModules_Load;
        }
        BLL bll = new BLL();

        private void UserControlModules_Load(object sender, EventArgs e)
        {
            cmbModulTypeID.DataSource = bll.GetForComboxModuleTypeID();
            cmbModulTypeID.ValueMember = "ModuleTypeID";
            cmbModulTypeID.DisplayMember = "ModuleTypeDescription";
           
        }
        
        private void btnAddModule_Click(object sender, EventArgs e)
        {

            errorProviderModuleName.Clear();
            errorProviderModuleDuration.Clear();
            errorProviderModuleTypeID.Clear();

            if (string.IsNullOrWhiteSpace(txtModuleName.Text))
            {
                errorProviderModuleName.SetError(txtModuleName, "Module name is required.");
            }
            if (string.IsNullOrWhiteSpace(txtModuleDuration.Text))
            {
                errorProviderModuleDuration.SetError(txtModuleDuration, "Module duration is required.");
            }
            if (string.IsNullOrWhiteSpace(cmbModulTypeID.Text))
            {
                errorProviderModuleTypeID.SetError(cmbModulTypeID, "Module type ID is required.");
            }

            if (!string.IsNullOrWhiteSpace(txtModuleName.Text) &&
                !string.IsNullOrWhiteSpace(txtModuleDuration.Text))
            {
                if (int.TryParse(cmbModulTypeID.SelectedValue.ToString(), out int moduleTypeID))
                {
                    Module addModule = new Module();
                    addModule.ModuleName = txtModuleName.Text;
                    addModule.ModuleDuration = txtModuleDuration.Text;
                    addModule.ModuleTypeID = moduleTypeID;

                    int result = bll.InsertModule(addModule);

                    if (result > 0)
                    {
                        MessageBox.Show("Failed to add the Module.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Module added successfully.");
                        refresher();
                        clear();
                    }
                }
                else
                {
                    errorProviderModuleTypeID.SetError(cmbModulTypeID, "Invalid Module type ID.");
                }
            }

        }

        private void btnUpdateModule_Click(object sender, EventArgs e)
        {
            errorProviderModuleName.Clear();
            errorProviderModuleDuration.Clear();
            errorProviderModuleTypeID.Clear();

            if (string.IsNullOrWhiteSpace(txtModuleName.Text))
            {
                errorProviderModuleName.SetError(txtModuleName, "Module name is required.");
            }
            if (string.IsNullOrWhiteSpace(txtModuleDuration.Text))
            {
                errorProviderModuleDuration.SetError(txtModuleDuration, "Module duration is required.");
            }

            
            if (cmbModulTypeID.SelectedItem != null)
            {
                
                Module addModule = new Module();
                addModule.ModuleName = txtModuleName.Text;
                addModule.ModuleDuration = txtModuleDuration.Text;
                addModule.ModuleTypeID = (int)cmbModulTypeID.SelectedValue;

                int result = bll.InsertModule(addModule);

                if (result > 0)
                {
                    MessageBox.Show("Failed to add the Module.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Module added successfully.");
                    refresher();
                    clear();
                }
            }
            else
            {
             
                errorProviderModuleTypeID.SetError(cmbModulTypeID, "Module type is required.");
            }
        }

        private void btnDeleteModule_Click(object sender, EventArgs e)
        {
            errorProviderModuleTypeID.Clear();

            if (string.IsNullOrWhiteSpace(cmbModulTypeID.Text))
            {
                errorProviderModuleTypeID.SetError(cmbModulTypeID, "Module type ID is required.");
            }

            if (!string.IsNullOrWhiteSpace(cmbModulTypeID.Text))
            {
                int deleteModule = int.Parse(cmbModulTypeID.Text);

                int x = bll.DeleteModule(deleteModule);

                if (x > 0)
                {
                    MessageBox.Show("Failed to delete the Module.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Module Deleted");
                    refresher();
                    clear();
                }
            }
        }

        private void btnDisplayModule_Click(object sender, EventArgs e)
        {
            dgvDisplayModules.DataSource = bll.GetModuleData();
        }

        private void dgvDisplayModules_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDisplayModules.SelectedRows.Count > 0)
            {
                int ModuleID = Convert.ToInt32(dgvDisplayModules.SelectedRows[0].Cells["ModuleID"].Value);
                txtModuleName.Text = dgvDisplayModules.SelectedRows[0].Cells["ModuleName"].Value.ToString();
                txtModuleDuration.Text = dgvDisplayModules.SelectedRows[0].Cells["ModuleDuration"].Value.ToString();
                cmbModulTypeID.Text = dgvDisplayModules.SelectedRows[0].Cells["ModuleTypeID"].Value.ToString();
            }
        }

        private void btnSearchModule_Click(object sender, EventArgs e)
        {
            errorProviderSearchModuleName.Clear();

            if (string.IsNullOrWhiteSpace(txtSearhModuleName.Text))
            {
                errorProviderSearchModuleName.SetError(txtSearhModuleName, "Module name for search is required.");
                return;
            }

            try
            {
                dgvDisplayModules.DataSource = bll.GetModuleByName(txtSearhModuleName.Text);
                txtSearhModuleName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refresher()
        {
            dgvDisplayModules.DataSource = bll.GetModuleData();
        }
        private void clear()
        {
            txtModuleName.Clear();
            txtModuleDuration.Clear();
            cmbModulTypeID.SelectedIndex = -1;

        }

    }
}
