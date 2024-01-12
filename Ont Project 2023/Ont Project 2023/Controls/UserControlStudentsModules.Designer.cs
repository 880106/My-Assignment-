namespace Ont_Project_2023.Controls
{
    partial class UserControlStudentsModules
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
            this.gbManageStudentsModule = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbUserID = new System.Windows.Forms.ComboBox();
            this.cmbLecturerModuleID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDisplayStudentsModules = new System.Windows.Forms.DataGridView();
            this.btnDisplayStudentsModule = new System.Windows.Forms.Button();
            this.btnDeleteStudentsModule = new System.Windows.Forms.Button();
            this.btnUpdateStudentsModule = new System.Windows.Forms.Button();
            this.btnAddStudentsModule = new System.Windows.Forms.Button();
            this.txtStudentsModuleID = new System.Windows.Forms.TextBox();
            this.lblModuleID = new System.Windows.Forms.Label();
            this.lblModuleDuration = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblModelNme = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProviderStudentModuleID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderLecturerModuleID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderUserID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbManageStudentsModule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayStudentsModules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderStudentModuleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLecturerModuleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDate)).BeginInit();
            this.SuspendLayout();
            // 
            // gbManageStudentsModule
            // 
            this.gbManageStudentsModule.BackColor = System.Drawing.Color.Lavender;
            this.gbManageStudentsModule.Controls.Add(this.dateTimePicker1);
            this.gbManageStudentsModule.Controls.Add(this.cmbUserID);
            this.gbManageStudentsModule.Controls.Add(this.cmbLecturerModuleID);
            this.gbManageStudentsModule.Controls.Add(this.label2);
            this.gbManageStudentsModule.Controls.Add(this.dgvDisplayStudentsModules);
            this.gbManageStudentsModule.Controls.Add(this.btnDisplayStudentsModule);
            this.gbManageStudentsModule.Controls.Add(this.btnDeleteStudentsModule);
            this.gbManageStudentsModule.Controls.Add(this.btnUpdateStudentsModule);
            this.gbManageStudentsModule.Controls.Add(this.btnAddStudentsModule);
            this.gbManageStudentsModule.Controls.Add(this.txtStudentsModuleID);
            this.gbManageStudentsModule.Controls.Add(this.lblModuleID);
            this.gbManageStudentsModule.Controls.Add(this.lblModuleDuration);
            this.gbManageStudentsModule.Controls.Add(this.label3);
            this.gbManageStudentsModule.Controls.Add(this.lblModelNme);
            this.gbManageStudentsModule.Controls.Add(this.label1);
            this.gbManageStudentsModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbManageStudentsModule.Location = new System.Drawing.Point(3, 3);
            this.gbManageStudentsModule.Name = "gbManageStudentsModule";
            this.gbManageStudentsModule.Size = new System.Drawing.Size(1314, 536);
            this.gbManageStudentsModule.TabIndex = 5;
            this.gbManageStudentsModule.TabStop = false;
            this.gbManageStudentsModule.Text = "Manage Student Module";
            this.gbManageStudentsModule.Enter += new System.EventHandler(this.gbManageStudentsModule_Enter);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(171, 243);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(427, 34);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // cmbUserID
            // 
            this.cmbUserID.FormattingEnabled = true;
            this.cmbUserID.Location = new System.Drawing.Point(235, 180);
            this.cmbUserID.Name = "cmbUserID";
            this.cmbUserID.Size = new System.Drawing.Size(364, 37);
            this.cmbUserID.TabIndex = 28;
            // 
            // cmbLecturerModuleID
            // 
            this.cmbLecturerModuleID.FormattingEnabled = true;
            this.cmbLecturerModuleID.Location = new System.Drawing.Point(235, 118);
            this.cmbLecturerModuleID.Name = "cmbLecturerModuleID";
            this.cmbLecturerModuleID.Size = new System.Drawing.Size(364, 37);
            this.cmbLecturerModuleID.TabIndex = 27;
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
            // dgvDisplayStudentsModules
            // 
            this.dgvDisplayStudentsModules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayStudentsModules.Location = new System.Drawing.Point(615, 43);
            this.dgvDisplayStudentsModules.Name = "dgvDisplayStudentsModules";
            this.dgvDisplayStudentsModules.RowHeadersWidth = 51;
            this.dgvDisplayStudentsModules.RowTemplate.Height = 24;
            this.dgvDisplayStudentsModules.Size = new System.Drawing.Size(688, 377);
            this.dgvDisplayStudentsModules.TabIndex = 23;
            this.dgvDisplayStudentsModules.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayStudentsModules_CellContentClick);
            // 
            // btnDisplayStudentsModule
            // 
            this.btnDisplayStudentsModule.Location = new System.Drawing.Point(448, 319);
            this.btnDisplayStudentsModule.Name = "btnDisplayStudentsModule";
            this.btnDisplayStudentsModule.Size = new System.Drawing.Size(119, 35);
            this.btnDisplayStudentsModule.TabIndex = 22;
            this.btnDisplayStudentsModule.Text = "Display";
            this.btnDisplayStudentsModule.UseVisualStyleBackColor = true;
            this.btnDisplayStudentsModule.Click += new System.EventHandler(this.btnDisplayStudentsModule_Click);
            // 
            // btnDeleteStudentsModule
            // 
            this.btnDeleteStudentsModule.Location = new System.Drawing.Point(291, 319);
            this.btnDeleteStudentsModule.Name = "btnDeleteStudentsModule";
            this.btnDeleteStudentsModule.Size = new System.Drawing.Size(119, 35);
            this.btnDeleteStudentsModule.TabIndex = 21;
            this.btnDeleteStudentsModule.Text = "Delete";
            this.btnDeleteStudentsModule.UseVisualStyleBackColor = true;
            this.btnDeleteStudentsModule.Click += new System.EventHandler(this.btnDeleteStudentsModule_Click);
            // 
            // btnUpdateStudentsModule
            // 
            this.btnUpdateStudentsModule.Location = new System.Drawing.Point(146, 319);
            this.btnUpdateStudentsModule.Name = "btnUpdateStudentsModule";
            this.btnUpdateStudentsModule.Size = new System.Drawing.Size(119, 35);
            this.btnUpdateStudentsModule.TabIndex = 20;
            this.btnUpdateStudentsModule.Text = "Update";
            this.btnUpdateStudentsModule.UseVisualStyleBackColor = true;
            this.btnUpdateStudentsModule.Click += new System.EventHandler(this.btnUpdateStudentsModule_Click);
            // 
            // btnAddStudentsModule
            // 
            this.btnAddStudentsModule.Location = new System.Drawing.Point(6, 319);
            this.btnAddStudentsModule.Name = "btnAddStudentsModule";
            this.btnAddStudentsModule.Size = new System.Drawing.Size(119, 35);
            this.btnAddStudentsModule.TabIndex = 19;
            this.btnAddStudentsModule.Text = "Add ";
            this.btnAddStudentsModule.UseVisualStyleBackColor = true;
            this.btnAddStudentsModule.Click += new System.EventHandler(this.btnAddStudentsModule_Click);
            // 
            // txtStudentsModuleID
            // 
            this.txtStudentsModuleID.Location = new System.Drawing.Point(235, 64);
            this.txtStudentsModuleID.Name = "txtStudentsModuleID";
            this.txtStudentsModuleID.Size = new System.Drawing.Size(364, 34);
            this.txtStudentsModuleID.TabIndex = 11;
            // 
            // lblModuleID
            // 
            this.lblModuleID.AutoSize = true;
            this.lblModuleID.Location = new System.Drawing.Point(11, 67);
            this.lblModuleID.Name = "lblModuleID";
            this.lblModuleID.Size = new System.Drawing.Size(217, 29);
            this.lblModuleID.TabIndex = 9;
            this.lblModuleID.Text = "Student Module ID:";
            // 
            // lblModuleDuration
            // 
            this.lblModuleDuration.AutoSize = true;
            this.lblModuleDuration.Location = new System.Drawing.Point(10, 188);
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
            this.lblModelNme.Location = new System.Drawing.Point(6, 126);
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
            // errorProviderStudentModuleID
            // 
            this.errorProviderStudentModuleID.ContainerControl = this;
            // 
            // errorProviderLecturerModuleID
            // 
            this.errorProviderLecturerModuleID.ContainerControl = this;
            // 
            // errorProviderUserID
            // 
            this.errorProviderUserID.ContainerControl = this;
            // 
            // errorProviderDate
            // 
            this.errorProviderDate.ContainerControl = this;
            // 
            // UserControlStudentsModules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbManageStudentsModule);
            this.Name = "UserControlStudentsModules";
            this.Size = new System.Drawing.Size(1327, 542);
            this.Load += new System.EventHandler(this.UserControlStudentsModules_Load);
            this.gbManageStudentsModule.ResumeLayout(false);
            this.gbManageStudentsModule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayStudentsModules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderStudentModuleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLecturerModuleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbManageStudentsModule;
        private System.Windows.Forms.ComboBox cmbUserID;
        private System.Windows.Forms.ComboBox cmbLecturerModuleID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDisplayStudentsModules;
        private System.Windows.Forms.Button btnDisplayStudentsModule;
        private System.Windows.Forms.Button btnDeleteStudentsModule;
        private System.Windows.Forms.Button btnUpdateStudentsModule;
        private System.Windows.Forms.Button btnAddStudentsModule;
        private System.Windows.Forms.TextBox txtStudentsModuleID;
        private System.Windows.Forms.Label lblModuleID;
        private System.Windows.Forms.Label lblModuleDuration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblModelNme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ErrorProvider errorProviderStudentModuleID;
        private System.Windows.Forms.ErrorProvider errorProviderLecturerModuleID;
        private System.Windows.Forms.ErrorProvider errorProviderUserID;
        private System.Windows.Forms.ErrorProvider errorProviderDate;
    }
}
