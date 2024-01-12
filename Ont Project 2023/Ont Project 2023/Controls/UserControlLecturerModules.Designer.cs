namespace Ont_Project_2023.Controls
{
    partial class UserControlLecturerModules
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
            this.gbManageLecturerModule = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbModuleID = new System.Windows.Forms.ComboBox();
            this.cmbUserID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDisplayLecturerModules = new System.Windows.Forms.DataGridView();
            this.btnDisplayLecturerModule = new System.Windows.Forms.Button();
            this.btnDeleteLecturerModule = new System.Windows.Forms.Button();
            this.btnUpdateLecturerModule = new System.Windows.Forms.Button();
            this.btnAddLecturerModule = new System.Windows.Forms.Button();
            this.txtLecturerModuleID = new System.Windows.Forms.TextBox();
            this.lblModuleID = new System.Windows.Forms.Label();
            this.lblModuleDuration = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblModelNme = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProviderLecturerModuleID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderUserID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderModuleID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbManageLecturerModule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayLecturerModules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLecturerModuleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderModuleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDate)).BeginInit();
            this.SuspendLayout();
            // 
            // gbManageLecturerModule
            // 
            this.gbManageLecturerModule.BackColor = System.Drawing.Color.Lavender;
            this.gbManageLecturerModule.Controls.Add(this.dateTimePicker1);
            this.gbManageLecturerModule.Controls.Add(this.cmbModuleID);
            this.gbManageLecturerModule.Controls.Add(this.cmbUserID);
            this.gbManageLecturerModule.Controls.Add(this.label2);
            this.gbManageLecturerModule.Controls.Add(this.dgvDisplayLecturerModules);
            this.gbManageLecturerModule.Controls.Add(this.btnDisplayLecturerModule);
            this.gbManageLecturerModule.Controls.Add(this.btnDeleteLecturerModule);
            this.gbManageLecturerModule.Controls.Add(this.btnUpdateLecturerModule);
            this.gbManageLecturerModule.Controls.Add(this.btnAddLecturerModule);
            this.gbManageLecturerModule.Controls.Add(this.txtLecturerModuleID);
            this.gbManageLecturerModule.Controls.Add(this.lblModuleID);
            this.gbManageLecturerModule.Controls.Add(this.lblModuleDuration);
            this.gbManageLecturerModule.Controls.Add(this.label3);
            this.gbManageLecturerModule.Controls.Add(this.lblModelNme);
            this.gbManageLecturerModule.Controls.Add(this.label1);
            this.gbManageLecturerModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbManageLecturerModule.Location = new System.Drawing.Point(3, 12);
            this.gbManageLecturerModule.Name = "gbManageLecturerModule";
            this.gbManageLecturerModule.Size = new System.Drawing.Size(1314, 524);
            this.gbManageLecturerModule.TabIndex = 4;
            this.gbManageLecturerModule.TabStop = false;
            this.gbManageLecturerModule.Text = "Manage Lecturer Module";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(192, 240);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(395, 34);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // cmbModuleID
            // 
            this.cmbModuleID.FormattingEnabled = true;
            this.cmbModuleID.Location = new System.Drawing.Point(235, 180);
            this.cmbModuleID.Name = "cmbModuleID";
            this.cmbModuleID.Size = new System.Drawing.Size(352, 37);
            this.cmbModuleID.TabIndex = 28;
            // 
            // cmbUserID
            // 
            this.cmbUserID.FormattingEnabled = true;
            this.cmbUserID.Location = new System.Drawing.Point(235, 118);
            this.cmbUserID.Name = "cmbUserID";
            this.cmbUserID.Size = new System.Drawing.Size(352, 37);
            this.cmbUserID.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "Date:";
            // 
            // dgvDisplayLecturerModules
            // 
            this.dgvDisplayLecturerModules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayLecturerModules.Location = new System.Drawing.Point(615, 43);
            this.dgvDisplayLecturerModules.Name = "dgvDisplayLecturerModules";
            this.dgvDisplayLecturerModules.RowHeadersWidth = 51;
            this.dgvDisplayLecturerModules.RowTemplate.Height = 24;
            this.dgvDisplayLecturerModules.Size = new System.Drawing.Size(688, 377);
            this.dgvDisplayLecturerModules.TabIndex = 23;
            this.dgvDisplayLecturerModules.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayLecturerModules_CellContentClick);
            // 
            // btnDisplayLecturerModule
            // 
            this.btnDisplayLecturerModule.Location = new System.Drawing.Point(454, 331);
            this.btnDisplayLecturerModule.Name = "btnDisplayLecturerModule";
            this.btnDisplayLecturerModule.Size = new System.Drawing.Size(119, 35);
            this.btnDisplayLecturerModule.TabIndex = 22;
            this.btnDisplayLecturerModule.Text = "Display";
            this.btnDisplayLecturerModule.UseVisualStyleBackColor = true;
            this.btnDisplayLecturerModule.Click += new System.EventHandler(this.btnDisplayLecturerModule_Click);
            // 
            // btnDeleteLecturerModule
            // 
            this.btnDeleteLecturerModule.Location = new System.Drawing.Point(312, 331);
            this.btnDeleteLecturerModule.Name = "btnDeleteLecturerModule";
            this.btnDeleteLecturerModule.Size = new System.Drawing.Size(119, 35);
            this.btnDeleteLecturerModule.TabIndex = 21;
            this.btnDeleteLecturerModule.Text = "Delete";
            this.btnDeleteLecturerModule.UseVisualStyleBackColor = true;
            this.btnDeleteLecturerModule.Click += new System.EventHandler(this.btnDeleteLecturerModule_Click);
            // 
            // btnUpdateLecturerModule
            // 
            this.btnUpdateLecturerModule.Location = new System.Drawing.Point(157, 331);
            this.btnUpdateLecturerModule.Name = "btnUpdateLecturerModule";
            this.btnUpdateLecturerModule.Size = new System.Drawing.Size(119, 35);
            this.btnUpdateLecturerModule.TabIndex = 20;
            this.btnUpdateLecturerModule.Text = "Update";
            this.btnUpdateLecturerModule.UseVisualStyleBackColor = true;
            this.btnUpdateLecturerModule.Click += new System.EventHandler(this.btnUpdateLecturerModule_Click);
            // 
            // btnAddLecturerModule
            // 
            this.btnAddLecturerModule.Location = new System.Drawing.Point(9, 331);
            this.btnAddLecturerModule.Name = "btnAddLecturerModule";
            this.btnAddLecturerModule.Size = new System.Drawing.Size(119, 35);
            this.btnAddLecturerModule.TabIndex = 19;
            this.btnAddLecturerModule.Text = "Add ";
            this.btnAddLecturerModule.UseVisualStyleBackColor = true;
            this.btnAddLecturerModule.Click += new System.EventHandler(this.btnAddLecturerModule_Click);
            // 
            // txtLecturerModuleID
            // 
            this.txtLecturerModuleID.Location = new System.Drawing.Point(235, 64);
            this.txtLecturerModuleID.Name = "txtLecturerModuleID";
            this.txtLecturerModuleID.Size = new System.Drawing.Size(352, 34);
            this.txtLecturerModuleID.TabIndex = 11;
            // 
            // lblModuleID
            // 
            this.lblModuleID.AutoSize = true;
            this.lblModuleID.Location = new System.Drawing.Point(6, 188);
            this.lblModuleID.Name = "lblModuleID";
            this.lblModuleID.Size = new System.Drawing.Size(129, 29);
            this.lblModuleID.TabIndex = 9;
            this.lblModuleID.Text = "Module ID:";
            // 
            // lblModuleDuration
            // 
            this.lblModuleDuration.AutoSize = true;
            this.lblModuleDuration.Location = new System.Drawing.Point(4, 124);
            this.lblModuleDuration.Name = "lblModuleDuration";
            this.lblModuleDuration.Size = new System.Drawing.Size(99, 29);
            this.lblModuleDuration.TabIndex = 4;
            this.lblModuleDuration.Text = "User ID:";
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
            this.lblModelNme.Size = new System.Drawing.Size(223, 29);
            this.lblModelNme.TabIndex = 2;
            this.lblModelNme.Text = "Lecturer Module ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 1;
            // 
            // errorProviderLecturerModuleID
            // 
            this.errorProviderLecturerModuleID.ContainerControl = this;
            // 
            // errorProviderUserID
            // 
            this.errorProviderUserID.ContainerControl = this;
            // 
            // errorProviderModuleID
            // 
            this.errorProviderModuleID.ContainerControl = this;
            // 
            // errorProviderDate
            // 
            this.errorProviderDate.ContainerControl = this;
            // 
            // UserControlLecturerModules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbManageLecturerModule);
            this.Name = "UserControlLecturerModules";
            this.Size = new System.Drawing.Size(1324, 548);
            this.Load += new System.EventHandler(this.UserControlLecturerModules_Load);
            this.gbManageLecturerModule.ResumeLayout(false);
            this.gbManageLecturerModule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayLecturerModules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLecturerModuleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderModuleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbManageLecturerModule;
        private System.Windows.Forms.DataGridView dgvDisplayLecturerModules;
        private System.Windows.Forms.Button btnDisplayLecturerModule;
        private System.Windows.Forms.Button btnDeleteLecturerModule;
        private System.Windows.Forms.Button btnUpdateLecturerModule;
        private System.Windows.Forms.Button btnAddLecturerModule;
        private System.Windows.Forms.TextBox txtLecturerModuleID;
        private System.Windows.Forms.Label lblModuleID;
        private System.Windows.Forms.Label lblModuleDuration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblModelNme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbModuleID;
        private System.Windows.Forms.ComboBox cmbUserID;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ErrorProvider errorProviderLecturerModuleID;
        private System.Windows.Forms.ErrorProvider errorProviderUserID;
        private System.Windows.Forms.ErrorProvider errorProviderModuleID;
        private System.Windows.Forms.ErrorProvider errorProviderDate;
    }
}
