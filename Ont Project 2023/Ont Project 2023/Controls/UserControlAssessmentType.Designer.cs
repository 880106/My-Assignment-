namespace Ont_Project_2023.Controls
{
    partial class UserControlAssessmentType
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
            this.gbManageAssessmentType = new System.Windows.Forms.GroupBox();
            this.dgvDisplayAssessmentType = new System.Windows.Forms.DataGridView();
            this.btnDisplayAssessment = new System.Windows.Forms.Button();
            this.btnDeleteAssessment = new System.Windows.Forms.Button();
            this.btnUpdateAssessement = new System.Windows.Forms.Button();
            this.btnAddAssessemnt = new System.Windows.Forms.Button();
            this.txtAssessmentTypeDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAssessmentTypeDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProviderAssessmentTypeDescription = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbManageAssessmentType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayAssessmentType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAssessmentTypeDescription)).BeginInit();
            this.SuspendLayout();
            // 
            // gbManageAssessmentType
            // 
            this.gbManageAssessmentType.BackColor = System.Drawing.Color.Lavender;
            this.gbManageAssessmentType.Controls.Add(this.dgvDisplayAssessmentType);
            this.gbManageAssessmentType.Controls.Add(this.btnDisplayAssessment);
            this.gbManageAssessmentType.Controls.Add(this.btnDeleteAssessment);
            this.gbManageAssessmentType.Controls.Add(this.btnUpdateAssessement);
            this.gbManageAssessmentType.Controls.Add(this.btnAddAssessemnt);
            this.gbManageAssessmentType.Controls.Add(this.txtAssessmentTypeDescription);
            this.gbManageAssessmentType.Controls.Add(this.label3);
            this.gbManageAssessmentType.Controls.Add(this.lblAssessmentTypeDescription);
            this.gbManageAssessmentType.Controls.Add(this.label1);
            this.gbManageAssessmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbManageAssessmentType.Location = new System.Drawing.Point(3, 3);
            this.gbManageAssessmentType.Name = "gbManageAssessmentType";
            this.gbManageAssessmentType.Size = new System.Drawing.Size(1354, 551);
            this.gbManageAssessmentType.TabIndex = 6;
            this.gbManageAssessmentType.TabStop = false;
            this.gbManageAssessmentType.Text = "Manage Assessment Type";
            // 
            // dgvDisplayAssessmentType
            // 
            this.dgvDisplayAssessmentType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayAssessmentType.Location = new System.Drawing.Point(600, 33);
            this.dgvDisplayAssessmentType.Name = "dgvDisplayAssessmentType";
            this.dgvDisplayAssessmentType.RowHeadersWidth = 51;
            this.dgvDisplayAssessmentType.RowTemplate.Height = 24;
            this.dgvDisplayAssessmentType.Size = new System.Drawing.Size(737, 377);
            this.dgvDisplayAssessmentType.TabIndex = 23;
            this.dgvDisplayAssessmentType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayAssessmentType_CellContentClick);
            // 
            // btnDisplayAssessment
            // 
            this.btnDisplayAssessment.Location = new System.Drawing.Point(456, 214);
            this.btnDisplayAssessment.Name = "btnDisplayAssessment";
            this.btnDisplayAssessment.Size = new System.Drawing.Size(119, 35);
            this.btnDisplayAssessment.TabIndex = 22;
            this.btnDisplayAssessment.Text = "Display";
            this.btnDisplayAssessment.UseVisualStyleBackColor = true;
            this.btnDisplayAssessment.Click += new System.EventHandler(this.btnDisplayAssessment_Click);
            // 
            // btnDeleteAssessment
            // 
            this.btnDeleteAssessment.Location = new System.Drawing.Point(287, 214);
            this.btnDeleteAssessment.Name = "btnDeleteAssessment";
            this.btnDeleteAssessment.Size = new System.Drawing.Size(119, 35);
            this.btnDeleteAssessment.TabIndex = 21;
            this.btnDeleteAssessment.Text = "Delete";
            this.btnDeleteAssessment.UseVisualStyleBackColor = true;
            this.btnDeleteAssessment.Click += new System.EventHandler(this.btnDeleteAssessment_Click);
            // 
            // btnUpdateAssessement
            // 
            this.btnUpdateAssessement.Location = new System.Drawing.Point(147, 214);
            this.btnUpdateAssessement.Name = "btnUpdateAssessement";
            this.btnUpdateAssessement.Size = new System.Drawing.Size(119, 35);
            this.btnUpdateAssessement.TabIndex = 20;
            this.btnUpdateAssessement.Text = "Update";
            this.btnUpdateAssessement.UseVisualStyleBackColor = true;
            this.btnUpdateAssessement.Click += new System.EventHandler(this.btnUpdateAssessement_Click);
            // 
            // btnAddAssessemnt
            // 
            this.btnAddAssessemnt.Location = new System.Drawing.Point(11, 214);
            this.btnAddAssessemnt.Name = "btnAddAssessemnt";
            this.btnAddAssessemnt.Size = new System.Drawing.Size(119, 35);
            this.btnAddAssessemnt.TabIndex = 19;
            this.btnAddAssessemnt.Text = "Add ";
            this.btnAddAssessemnt.UseVisualStyleBackColor = true;
            this.btnAddAssessemnt.Click += new System.EventHandler(this.btnAddAssessemnt_Click);
            // 
            // txtAssessmentTypeDescription
            // 
            this.txtAssessmentTypeDescription.Location = new System.Drawing.Point(53, 118);
            this.txtAssessmentTypeDescription.Name = "txtAssessmentTypeDescription";
            this.txtAssessmentTypeDescription.Size = new System.Drawing.Size(482, 34);
            this.txtAssessmentTypeDescription.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 29);
            this.label3.TabIndex = 3;
            // 
            // lblAssessmentTypeDescription
            // 
            this.lblAssessmentTypeDescription.AutoSize = true;
            this.lblAssessmentTypeDescription.Location = new System.Drawing.Point(93, 66);
            this.lblAssessmentTypeDescription.Name = "lblAssessmentTypeDescription";
            this.lblAssessmentTypeDescription.Size = new System.Drawing.Size(332, 29);
            this.lblAssessmentTypeDescription.TabIndex = 2;
            this.lblAssessmentTypeDescription.Text = "Assessment Type Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 1;
            // 
            // errorProviderAssessmentTypeDescription
            // 
            this.errorProviderAssessmentTypeDescription.ContainerControl = this;
            // 
            // UserControlAssessmentType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbManageAssessmentType);
            this.Name = "UserControlAssessmentType";
            this.Size = new System.Drawing.Size(1361, 561);
            this.gbManageAssessmentType.ResumeLayout(false);
            this.gbManageAssessmentType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayAssessmentType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAssessmentTypeDescription)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbManageAssessmentType;
        private System.Windows.Forms.DataGridView dgvDisplayAssessmentType;
        private System.Windows.Forms.Button btnDisplayAssessment;
        private System.Windows.Forms.Button btnDeleteAssessment;
        private System.Windows.Forms.Button btnUpdateAssessement;
        private System.Windows.Forms.Button btnAddAssessemnt;
        private System.Windows.Forms.TextBox txtAssessmentTypeDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAssessmentTypeDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProviderAssessmentTypeDescription;
    }
}
