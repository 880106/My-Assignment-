namespace Ont_Project_2023.Controls
{
    partial class UserControlModules
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbManageModule = new System.Windows.Forms.GroupBox();
            this.cmbModulTypeID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchModule = new System.Windows.Forms.Button();
            this.txtSearhModuleName = new System.Windows.Forms.TextBox();
            this.txtModuleDuration = new System.Windows.Forms.TextBox();
            this.dgvDisplayModules = new System.Windows.Forms.DataGridView();
            this.btnDisplayModule = new System.Windows.Forms.Button();
            this.btnDeleteModule = new System.Windows.Forms.Button();
            this.btnUpdateModule = new System.Windows.Forms.Button();
            this.btnAddModule = new System.Windows.Forms.Button();
            this.txtModuleName = new System.Windows.Forms.TextBox();
            this.lblModuleTypeID = new System.Windows.Forms.Label();
            this.lblModuleDuration = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblModelNme = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProviderModuleName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderModuleDuration = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderModuleTypeID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSearchModuleName = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbManageModule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayModules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderModuleName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderModuleDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderModuleTypeID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSearchModuleName)).BeginInit();
            this.SuspendLayout();
            // 
            // gbManageModule
            // 
            this.gbManageModule.BackColor = System.Drawing.Color.Lavender;
            this.gbManageModule.Controls.Add(this.cmbModulTypeID);
            this.gbManageModule.Controls.Add(this.label2);
            this.gbManageModule.Controls.Add(this.btnSearchModule);
            this.gbManageModule.Controls.Add(this.txtSearhModuleName);
            this.gbManageModule.Controls.Add(this.txtModuleDuration);
            this.gbManageModule.Controls.Add(this.dgvDisplayModules);
            this.gbManageModule.Controls.Add(this.btnDisplayModule);
            this.gbManageModule.Controls.Add(this.btnDeleteModule);
            this.gbManageModule.Controls.Add(this.btnUpdateModule);
            this.gbManageModule.Controls.Add(this.btnAddModule);
            this.gbManageModule.Controls.Add(this.txtModuleName);
            this.gbManageModule.Controls.Add(this.lblModuleTypeID);
            this.gbManageModule.Controls.Add(this.lblModuleDuration);
            this.gbManageModule.Controls.Add(this.label3);
            this.gbManageModule.Controls.Add(this.lblModelNme);
            this.gbManageModule.Controls.Add(this.label1);
            this.gbManageModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbManageModule.Location = new System.Drawing.Point(14, 3);
            this.gbManageModule.Name = "gbManageModule";
            this.gbManageModule.Size = new System.Drawing.Size(1314, 540);
            this.gbManageModule.TabIndex = 3;
            this.gbManageModule.TabStop = false;
            this.gbManageModule.Text = "Manage Module";
            // 
            // cmbModulTypeID
            // 
            this.cmbModulTypeID.FormattingEnabled = true;
            this.cmbModulTypeID.Location = new System.Drawing.Point(213, 176);
            this.cmbModulTypeID.Name = "cmbModulTypeID";
            this.cmbModulTypeID.Size = new System.Drawing.Size(365, 37);
            this.cmbModulTypeID.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(643, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "Search Module:";
            // 
            // btnSearchModule
            // 
            this.btnSearchModule.Location = new System.Drawing.Point(1174, 18);
            this.btnSearchModule.Name = "btnSearchModule";
            this.btnSearchModule.Size = new System.Drawing.Size(134, 35);
            this.btnSearchModule.TabIndex = 27;
            this.btnSearchModule.Text = "Search";
            this.btnSearchModule.UseVisualStyleBackColor = true;
            this.btnSearchModule.Click += new System.EventHandler(this.btnSearchModule_Click);
            // 
            // txtSearhModuleName
            // 
            this.txtSearhModuleName.Location = new System.Drawing.Point(831, 19);
            this.txtSearhModuleName.Name = "txtSearhModuleName";
            this.txtSearhModuleName.Size = new System.Drawing.Size(311, 34);
            this.txtSearhModuleName.TabIndex = 26;
            // 
            // txtModuleDuration
            // 
            this.txtModuleDuration.Location = new System.Drawing.Point(213, 118);
            this.txtModuleDuration.Name = "txtModuleDuration";
            this.txtModuleDuration.Size = new System.Drawing.Size(365, 34);
            this.txtModuleDuration.TabIndex = 24;
            // 
            // dgvDisplayModules
            // 
            this.dgvDisplayModules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayModules.Location = new System.Drawing.Point(620, 100);
            this.dgvDisplayModules.Name = "dgvDisplayModules";
            this.dgvDisplayModules.RowHeadersWidth = 51;
            this.dgvDisplayModules.RowTemplate.Height = 24;
            this.dgvDisplayModules.Size = new System.Drawing.Size(688, 377);
            this.dgvDisplayModules.TabIndex = 23;
            this.dgvDisplayModules.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayModules_CellContentClick);
            // 
            // btnDisplayModule
            // 
            this.btnDisplayModule.Location = new System.Drawing.Point(449, 281);
            this.btnDisplayModule.Name = "btnDisplayModule";
            this.btnDisplayModule.Size = new System.Drawing.Size(119, 35);
            this.btnDisplayModule.TabIndex = 22;
            this.btnDisplayModule.Text = "Display";
            this.btnDisplayModule.UseVisualStyleBackColor = true;
            this.btnDisplayModule.Click += new System.EventHandler(this.btnDisplayModule_Click);
            // 
            // btnDeleteModule
            // 
            this.btnDeleteModule.Location = new System.Drawing.Point(308, 281);
            this.btnDeleteModule.Name = "btnDeleteModule";
            this.btnDeleteModule.Size = new System.Drawing.Size(119, 35);
            this.btnDeleteModule.TabIndex = 21;
            this.btnDeleteModule.Text = "Delete";
            this.btnDeleteModule.UseVisualStyleBackColor = true;
            this.btnDeleteModule.Click += new System.EventHandler(this.btnDeleteModule_Click);
            // 
            // btnUpdateModule
            // 
            this.btnUpdateModule.Location = new System.Drawing.Point(163, 281);
            this.btnUpdateModule.Name = "btnUpdateModule";
            this.btnUpdateModule.Size = new System.Drawing.Size(119, 35);
            this.btnUpdateModule.TabIndex = 20;
            this.btnUpdateModule.Text = "Update";
            this.btnUpdateModule.UseVisualStyleBackColor = true;
            this.btnUpdateModule.Click += new System.EventHandler(this.btnUpdateModule_Click);
            // 
            // btnAddModule
            // 
            this.btnAddModule.Location = new System.Drawing.Point(14, 281);
            this.btnAddModule.Name = "btnAddModule";
            this.btnAddModule.Size = new System.Drawing.Size(119, 35);
            this.btnAddModule.TabIndex = 19;
            this.btnAddModule.Text = "Add ";
            this.btnAddModule.UseVisualStyleBackColor = true;
            this.btnAddModule.Click += new System.EventHandler(this.btnAddModule_Click);
            // 
            // txtModuleName
            // 
            this.txtModuleName.Location = new System.Drawing.Point(213, 64);
            this.txtModuleName.Name = "txtModuleName";
            this.txtModuleName.Size = new System.Drawing.Size(365, 34);
            this.txtModuleName.TabIndex = 11;
            // 
            // lblModuleTypeID
            // 
            this.lblModuleTypeID.AutoSize = true;
            this.lblModuleTypeID.Location = new System.Drawing.Point(9, 184);
            this.lblModuleTypeID.Name = "lblModuleTypeID";
            this.lblModuleTypeID.Size = new System.Drawing.Size(190, 29);
            this.lblModuleTypeID.TabIndex = 9;
            this.lblModuleTypeID.Text = "Module Type ID:";
            // 
            // lblModuleDuration
            // 
            this.lblModuleDuration.AutoSize = true;
            this.lblModuleDuration.Location = new System.Drawing.Point(6, 121);
            this.lblModuleDuration.Name = "lblModuleDuration";
            this.lblModuleDuration.Size = new System.Drawing.Size(196, 29);
            this.lblModuleDuration.TabIndex = 4;
            this.lblModuleDuration.Text = "Module Duration:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 29);
            this.label3.TabIndex = 3;
            // 
            // lblModelNme
            // 
            this.lblModelNme.AutoSize = true;
            this.lblModelNme.Location = new System.Drawing.Point(6, 67);
            this.lblModelNme.Name = "lblModelNme";
            this.lblModelNme.Size = new System.Drawing.Size(171, 29);
            this.lblModelNme.TabIndex = 2;
            this.lblModelNme.Text = "Module Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 1;
            // 
            // errorProviderModuleName
            // 
            this.errorProviderModuleName.ContainerControl = this;
            // 
            // errorProviderModuleDuration
            // 
            this.errorProviderModuleDuration.ContainerControl = this;
            // 
            // errorProviderModuleTypeID
            // 
            this.errorProviderModuleTypeID.ContainerControl = this;
            // 
            // errorProviderSearchModuleName
            // 
            this.errorProviderSearchModuleName.ContainerControl = this;
            // 
            // UserControlModules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbManageModule);
            this.Name = "UserControlModules";
            this.Size = new System.Drawing.Size(1334, 554);
            this.Load += new System.EventHandler(this.UserControlModules_Load);
            this.gbManageModule.ResumeLayout(false);
            this.gbManageModule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayModules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderModuleName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderModuleDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderModuleTypeID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSearchModuleName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbManageModule;
        private System.Windows.Forms.DataGridView dgvDisplayModules;
        private System.Windows.Forms.Button btnDisplayModule;
        private System.Windows.Forms.Button btnDeleteModule;
        private System.Windows.Forms.Button btnUpdateModule;
        private System.Windows.Forms.Button btnAddModule;
        private System.Windows.Forms.TextBox txtModuleName;
        private System.Windows.Forms.Label lblModuleTypeID;
        private System.Windows.Forms.Label lblModuleDuration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblModelNme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModuleDuration;
        private System.Windows.Forms.Button btnSearchModule;
        private System.Windows.Forms.TextBox txtSearhModuleName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProviderModuleName;
        private System.Windows.Forms.ErrorProvider errorProviderModuleDuration;
        private System.Windows.Forms.ErrorProvider errorProviderModuleTypeID;
        private System.Windows.Forms.ErrorProvider errorProviderSearchModuleName;
        private System.Windows.Forms.ComboBox cmbModulTypeID;
    }
}
