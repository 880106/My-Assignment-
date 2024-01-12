namespace Ont_Project_2023.Controls
{
    partial class UserControlStudentManagesAssessment
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
            this.cmbAssessmentTypeID = new System.Windows.Forms.ComboBox();
            this.cmbAssessmentStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDisplayAssessement = new System.Windows.Forms.DataGridView();
            this.btnDisplayAssessment = new System.Windows.Forms.Button();
            this.btnDeleteAssessment = new System.Windows.Forms.Button();
            this.btnUpdateAssessement = new System.Windows.Forms.Button();
            this.btnAddAssessemnt = new System.Windows.Forms.Button();
            this.lblAssessmentTypeID = new System.Windows.Forms.Label();
            this.lblModuleDuration = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProviderAssessmentTypeID = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMarkAssessment = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbManageAssessment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayAssessement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAssessmentTypeID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMarkAssessment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDate)).BeginInit();
            this.SuspendLayout();
            // 
            // gbManageAssessment
            // 
            this.gbManageAssessment.BackColor = System.Drawing.Color.Lavender;
            this.gbManageAssessment.Controls.Add(this.dateTimePicker1);
            this.gbManageAssessment.Controls.Add(this.cmbAssessmentTypeID);
            this.gbManageAssessment.Controls.Add(this.cmbAssessmentStatus);
            this.gbManageAssessment.Controls.Add(this.label2);
            this.gbManageAssessment.Controls.Add(this.dgvDisplayAssessement);
            this.gbManageAssessment.Controls.Add(this.btnDisplayAssessment);
            this.gbManageAssessment.Controls.Add(this.btnDeleteAssessment);
            this.gbManageAssessment.Controls.Add(this.btnUpdateAssessement);
            this.gbManageAssessment.Controls.Add(this.btnAddAssessemnt);
            this.gbManageAssessment.Controls.Add(this.lblAssessmentTypeID);
            this.gbManageAssessment.Controls.Add(this.lblModuleDuration);
            this.gbManageAssessment.Controls.Add(this.label3);
            this.gbManageAssessment.Controls.Add(this.label1);
            this.gbManageAssessment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbManageAssessment.Location = new System.Drawing.Point(3, 3);
            this.gbManageAssessment.Name = "gbManageAssessment";
            this.gbManageAssessment.Size = new System.Drawing.Size(1354, 551);
            this.gbManageAssessment.TabIndex = 6;
            this.gbManageAssessment.TabStop = false;
            this.gbManageAssessment.Text = "Manage Assessment";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(229, 188);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(380, 34);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // cmbAssessmentTypeID
            // 
            this.cmbAssessmentTypeID.FormattingEnabled = true;
            this.cmbAssessmentTypeID.Location = new System.Drawing.Point(261, 58);
            this.cmbAssessmentTypeID.Name = "cmbAssessmentTypeID";
            this.cmbAssessmentTypeID.Size = new System.Drawing.Size(348, 37);
            this.cmbAssessmentTypeID.TabIndex = 28;
            // 
            // cmbAssessmentStatus
            // 
            this.cmbAssessmentStatus.FormattingEnabled = true;
            this.cmbAssessmentStatus.Location = new System.Drawing.Point(258, 118);
            this.cmbAssessmentStatus.Name = "cmbAssessmentStatus";
            this.cmbAssessmentStatus.Size = new System.Drawing.Size(351, 37);
            this.cmbAssessmentStatus.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "Date:";
            // 
            // dgvDisplayAssessement
            // 
            this.dgvDisplayAssessement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayAssessement.Location = new System.Drawing.Point(660, 44);
            this.dgvDisplayAssessement.Name = "dgvDisplayAssessement";
            this.dgvDisplayAssessement.RowHeadersWidth = 51;
            this.dgvDisplayAssessement.RowTemplate.Height = 24;
            this.dgvDisplayAssessement.Size = new System.Drawing.Size(688, 377);
            this.dgvDisplayAssessement.TabIndex = 23;
            this.dgvDisplayAssessement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayAssessement_CellContentClick);
            // 
            // btnDisplayAssessment
            // 
            this.btnDisplayAssessment.Location = new System.Drawing.Point(469, 261);
            this.btnDisplayAssessment.Name = "btnDisplayAssessment";
            this.btnDisplayAssessment.Size = new System.Drawing.Size(119, 35);
            this.btnDisplayAssessment.TabIndex = 22;
            this.btnDisplayAssessment.Text = "Display";
            this.btnDisplayAssessment.UseVisualStyleBackColor = true;
            this.btnDisplayAssessment.Click += new System.EventHandler(this.btnDisplayAssessment_Click);
            // 
            // btnDeleteAssessment
            // 
            this.btnDeleteAssessment.Location = new System.Drawing.Point(305, 261);
            this.btnDeleteAssessment.Name = "btnDeleteAssessment";
            this.btnDeleteAssessment.Size = new System.Drawing.Size(119, 35);
            this.btnDeleteAssessment.TabIndex = 21;
            this.btnDeleteAssessment.Text = "Delete";
            this.btnDeleteAssessment.UseVisualStyleBackColor = true;
            this.btnDeleteAssessment.Click += new System.EventHandler(this.btnDeleteAssessment_Click);
            // 
            // btnUpdateAssessement
            // 
            this.btnUpdateAssessement.Location = new System.Drawing.Point(168, 261);
            this.btnUpdateAssessement.Name = "btnUpdateAssessement";
            this.btnUpdateAssessement.Size = new System.Drawing.Size(119, 35);
            this.btnUpdateAssessement.TabIndex = 20;
            this.btnUpdateAssessement.Text = "Update";
            this.btnUpdateAssessement.UseVisualStyleBackColor = true;
            this.btnUpdateAssessement.Click += new System.EventHandler(this.btnUpdateAssessement_Click);
            // 
            // btnAddAssessemnt
            // 
            this.btnAddAssessemnt.Location = new System.Drawing.Point(11, 261);
            this.btnAddAssessemnt.Name = "btnAddAssessemnt";
            this.btnAddAssessemnt.Size = new System.Drawing.Size(119, 35);
            this.btnAddAssessemnt.TabIndex = 19;
            this.btnAddAssessemnt.Text = "Add ";
            this.btnAddAssessemnt.UseVisualStyleBackColor = true;
            this.btnAddAssessemnt.Click += new System.EventHandler(this.btnAddAssessemnt_Click);
            // 
            // lblAssessmentTypeID
            // 
            this.lblAssessmentTypeID.AutoSize = true;
            this.lblAssessmentTypeID.Location = new System.Drawing.Point(-5, 58);
            this.lblAssessmentTypeID.Name = "lblAssessmentTypeID";
            this.lblAssessmentTypeID.Size = new System.Drawing.Size(239, 29);
            this.lblAssessmentTypeID.TabIndex = 9;
            this.lblAssessmentTypeID.Text = "Assessment Type ID:";
            // 
            // lblModuleDuration
            // 
            this.lblModuleDuration.AutoSize = true;
            this.lblModuleDuration.Location = new System.Drawing.Point(0, 126);
            this.lblModuleDuration.Name = "lblModuleDuration";
            this.lblModuleDuration.Size = new System.Drawing.Size(208, 29);
            this.lblModuleDuration.TabIndex = 4;
            this.lblModuleDuration.Text = "Mark Assessment:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 29);
            this.label3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 1;
            // 
            // errorProviderAssessmentTypeID
            // 
            this.errorProviderAssessmentTypeID.ContainerControl = this;
            // 
            // errorProviderMarkAssessment
            // 
            this.errorProviderMarkAssessment.ContainerControl = this;
            // 
            // errorProviderDate
            // 
            this.errorProviderDate.ContainerControl = this;
            // 
            // UserControlStudentManagesAssessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbManageAssessment);
            this.Name = "UserControlStudentManagesAssessment";
            this.Size = new System.Drawing.Size(1362, 562);
            this.Load += new System.EventHandler(this.UserControlStudentManagesAssessment_Load);
            this.gbManageAssessment.ResumeLayout(false);
            this.gbManageAssessment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayAssessement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAssessmentTypeID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMarkAssessment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbManageAssessment;
        private System.Windows.Forms.ComboBox cmbAssessmentTypeID;
        private System.Windows.Forms.ComboBox cmbAssessmentStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDisplayAssessement;
        private System.Windows.Forms.Button btnDisplayAssessment;
        private System.Windows.Forms.Button btnDeleteAssessment;
        private System.Windows.Forms.Button btnUpdateAssessement;
        private System.Windows.Forms.Button btnAddAssessemnt;
        private System.Windows.Forms.Label lblAssessmentTypeID;
        private System.Windows.Forms.Label lblModuleDuration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ErrorProvider errorProviderAssessmentTypeID;
        private System.Windows.Forms.ErrorProvider errorProviderMarkAssessment;
        private System.Windows.Forms.ErrorProvider errorProviderDate;
    }
}
