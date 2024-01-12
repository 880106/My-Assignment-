namespace Ont_Project_2023.Controls
{
    partial class UserControlAssessment
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
            this.gbManageAssessment = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbAssessmentType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAssessmentTypeID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDisplayAssessement = new System.Windows.Forms.DataGridView();
            this.btnDisplayAssessment = new System.Windows.Forms.Button();
            this.btnDeleteAssessment = new System.Windows.Forms.Button();
            this.btnUpdateAssessment = new System.Windows.Forms.Button();
            this.btnAddAssessment = new System.Windows.Forms.Button();
            this.lblAssessmentTypeID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStudentLecturerModuleID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProviderStudentLecturerModuleID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAssessmentTypeID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAssessmentType = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtStudentLecturerModuleID = new System.Windows.Forms.TextBox();
            this.gbManageAssessment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayAssessement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderStudentLecturerModuleID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAssessmentTypeID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAssessmentType)).BeginInit();
            this.SuspendLayout();
            // 
            // gbManageAssessment
            // 
            this.gbManageAssessment.BackColor = System.Drawing.Color.Lavender;
            this.gbManageAssessment.Controls.Add(this.dateTimePicker1);
            this.gbManageAssessment.Controls.Add(this.cmbAssessmentType);
            this.gbManageAssessment.Controls.Add(this.label4);
            this.gbManageAssessment.Controls.Add(this.cmbAssessmentTypeID);
            this.gbManageAssessment.Controls.Add(this.label2);
            this.gbManageAssessment.Controls.Add(this.dgvDisplayAssessement);
            this.gbManageAssessment.Controls.Add(this.btnDisplayAssessment);
            this.gbManageAssessment.Controls.Add(this.btnDeleteAssessment);
            this.gbManageAssessment.Controls.Add(this.btnUpdateAssessment);
            this.gbManageAssessment.Controls.Add(this.btnAddAssessment);
            this.gbManageAssessment.Controls.Add(this.txtStudentLecturerModuleID);
            this.gbManageAssessment.Controls.Add(this.lblAssessmentTypeID);
            this.gbManageAssessment.Controls.Add(this.label3);
            this.gbManageAssessment.Controls.Add(this.lblStudentLecturerModuleID);
            this.gbManageAssessment.Controls.Add(this.label1);
            this.gbManageAssessment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbManageAssessment.Location = new System.Drawing.Point(3, 3);
            this.gbManageAssessment.Name = "gbManageAssessment";
            this.gbManageAssessment.Size = new System.Drawing.Size(1354, 551);
            this.gbManageAssessment.TabIndex = 5;
            this.gbManageAssessment.TabStop = false;
            this.gbManageAssessment.Text = "Manage Assessment";
            this.gbManageAssessment.Enter += new System.EventHandler(this.gbManageAssessment_Enter);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(230, 120);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(374, 34);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // cmbAssessmentType
            // 
            this.cmbAssessmentType.FormattingEnabled = true;
            this.cmbAssessmentType.Location = new System.Drawing.Point(934, 441);
            this.cmbAssessmentType.Name = "cmbAssessmentType";
            this.cmbAssessmentType.Size = new System.Drawing.Size(356, 37);
            this.cmbAssessmentType.TabIndex = 32;
            this.cmbAssessmentType.SelectedIndexChanged += new System.EventHandler(this.cmbAssessmentType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(644, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 29);
            this.label4.TabIndex = 31;
            this.label4.Text = "Select Assessment Type:";
            // 
            // cmbAssessmentTypeID
            // 
            this.cmbAssessmentTypeID.FormattingEnabled = true;
            this.cmbAssessmentTypeID.Location = new System.Drawing.Point(257, 180);
            this.cmbAssessmentTypeID.Name = "cmbAssessmentTypeID";
            this.cmbAssessmentTypeID.Size = new System.Drawing.Size(348, 37);
            this.cmbAssessmentTypeID.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "Date:";
            // 
            // dgvDisplayAssessement
            // 
            this.dgvDisplayAssessement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayAssessement.Location = new System.Drawing.Point(649, 33);
            this.dgvDisplayAssessement.Name = "dgvDisplayAssessement";
            this.dgvDisplayAssessement.RowHeadersWidth = 51;
            this.dgvDisplayAssessement.RowTemplate.Height = 24;
            this.dgvDisplayAssessement.Size = new System.Drawing.Size(688, 377);
            this.dgvDisplayAssessement.TabIndex = 23;
            this.dgvDisplayAssessement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayAssessement_CellContentClick);
            // 
            // btnDisplayAssessment
            // 
            this.btnDisplayAssessment.Location = new System.Drawing.Point(461, 269);
            this.btnDisplayAssessment.Name = "btnDisplayAssessment";
            this.btnDisplayAssessment.Size = new System.Drawing.Size(119, 35);
            this.btnDisplayAssessment.TabIndex = 22;
            this.btnDisplayAssessment.Text = "Display";
            this.btnDisplayAssessment.UseVisualStyleBackColor = true;
            this.btnDisplayAssessment.Click += new System.EventHandler(this.btnDisplayAssessment_Click);
            // 
            // btnDeleteAssessment
            // 
            this.btnDeleteAssessment.Location = new System.Drawing.Point(309, 269);
            this.btnDeleteAssessment.Name = "btnDeleteAssessment";
            this.btnDeleteAssessment.Size = new System.Drawing.Size(119, 35);
            this.btnDeleteAssessment.TabIndex = 21;
            this.btnDeleteAssessment.Text = "Delete";
            this.btnDeleteAssessment.UseVisualStyleBackColor = true;
            this.btnDeleteAssessment.Click += new System.EventHandler(this.btnDeleteAssessment_Click);
            // 
            // btnUpdateAssessment
            // 
            this.btnUpdateAssessment.Location = new System.Drawing.Point(169, 269);
            this.btnUpdateAssessment.Name = "btnUpdateAssessment";
            this.btnUpdateAssessment.Size = new System.Drawing.Size(119, 35);
            this.btnUpdateAssessment.TabIndex = 20;
            this.btnUpdateAssessment.Text = "Update";
            this.btnUpdateAssessment.UseVisualStyleBackColor = true;
            this.btnUpdateAssessment.Click += new System.EventHandler(this.btnUpdateAssessement_Click);
            // 
            // btnAddAssessment
            // 
            this.btnAddAssessment.Location = new System.Drawing.Point(16, 269);
            this.btnAddAssessment.Name = "btnAddAssessment";
            this.btnAddAssessment.Size = new System.Drawing.Size(119, 35);
            this.btnAddAssessment.TabIndex = 19;
            this.btnAddAssessment.Text = "Add ";
            this.btnAddAssessment.UseVisualStyleBackColor = true;
            this.btnAddAssessment.Click += new System.EventHandler(this.btnAddAssessemnt_Click);
            // 
            // lblAssessmentTypeID
            // 
            this.lblAssessmentTypeID.AutoSize = true;
            this.lblAssessmentTypeID.Location = new System.Drawing.Point(6, 188);
            this.lblAssessmentTypeID.Name = "lblAssessmentTypeID";
            this.lblAssessmentTypeID.Size = new System.Drawing.Size(239, 29);
            this.lblAssessmentTypeID.TabIndex = 9;
            this.lblAssessmentTypeID.Text = "Assessment Type ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 29);
            this.label3.TabIndex = 3;
            // 
            // lblStudentLecturerModuleID
            // 
            this.lblStudentLecturerModuleID.AutoSize = true;
            this.lblStudentLecturerModuleID.Location = new System.Drawing.Point(6, 67);
            this.lblStudentLecturerModuleID.Name = "lblStudentLecturerModuleID";
            this.lblStudentLecturerModuleID.Size = new System.Drawing.Size(311, 29);
            this.lblStudentLecturerModuleID.TabIndex = 2;
            this.lblStudentLecturerModuleID.Text = "Student Lecturer Module ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 1;
            // 
            // errorProviderStudentLecturerModuleID
            // 
            this.errorProviderStudentLecturerModuleID.ContainerControl = this;
            // 
            // errorProviderDate
            // 
            this.errorProviderDate.ContainerControl = this;
            // 
            // errorProviderAssessmentTypeID
            // 
            this.errorProviderAssessmentTypeID.ContainerControl = this;
            // 
            // errorProviderAssessmentType
            // 
            this.errorProviderAssessmentType.ContainerControl = this;
            // 
            // txtStudentLecturerModuleID
            // 
            this.txtStudentLecturerModuleID.Location = new System.Drawing.Point(323, 62);
            this.txtStudentLecturerModuleID.Name = "txtStudentLecturerModuleID";
            this.txtStudentLecturerModuleID.Size = new System.Drawing.Size(282, 34);
            this.txtStudentLecturerModuleID.TabIndex = 11;
            // 
            // UserControlAssessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbManageAssessment);
            this.Name = "UserControlAssessment";
            this.Size = new System.Drawing.Size(1357, 557);
            this.Load += new System.EventHandler(this.UserControlAssessment_Load);
            this.gbManageAssessment.ResumeLayout(false);
            this.gbManageAssessment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayAssessement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderStudentLecturerModuleID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAssessmentTypeID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAssessmentType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbManageAssessment;
        private System.Windows.Forms.ComboBox cmbAssessmentTypeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDisplayAssessement;
        private System.Windows.Forms.Button btnDisplayAssessment;
        private System.Windows.Forms.Button btnDeleteAssessment;
        private System.Windows.Forms.Button btnUpdateAssessment;
        private System.Windows.Forms.Button btnAddAssessment;
        private System.Windows.Forms.Label lblAssessmentTypeID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStudentLecturerModuleID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAssessmentType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ErrorProvider errorProviderStudentLecturerModuleID;
        private System.Windows.Forms.ErrorProvider errorProviderDate;
        private System.Windows.Forms.ErrorProvider errorProviderAssessmentTypeID;
        private System.Windows.Forms.ErrorProvider errorProviderAssessmentType;
        private System.Windows.Forms.TextBox txtStudentLecturerModuleID;
    }
}
