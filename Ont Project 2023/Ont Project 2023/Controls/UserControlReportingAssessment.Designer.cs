namespace Ont_Project_2023.Controls
{
    partial class UserControlReportingAssessment
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
            this.gbManageReporting = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAssessment = new System.Windows.Forms.TextBox();
            this.btnSearchBetwDat = new System.Windows.Forms.Button();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDisplaybyName = new System.Windows.Forms.DataGridView();
            this.gbManageReporting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplaybyName)).BeginInit();
            this.SuspendLayout();
            // 
            // gbManageReporting
            // 
            this.gbManageReporting.BackColor = System.Drawing.Color.Lavender;
            this.gbManageReporting.Controls.Add(this.label1);
            this.gbManageReporting.Controls.Add(this.txtAssessment);
            this.gbManageReporting.Controls.Add(this.btnSearchBetwDat);
            this.gbManageReporting.Controls.Add(this.dtEndDate);
            this.gbManageReporting.Controls.Add(this.dtStartDate);
            this.gbManageReporting.Controls.Add(this.label3);
            this.gbManageReporting.Controls.Add(this.label2);
            this.gbManageReporting.Controls.Add(this.dgvDisplaybyName);
            this.gbManageReporting.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbManageReporting.Location = new System.Drawing.Point(3, 3);
            this.gbManageReporting.Name = "gbManageReporting";
            this.gbManageReporting.Size = new System.Drawing.Size(1345, 543);
            this.gbManageReporting.TabIndex = 6;
            this.gbManageReporting.TabStop = false;
            this.gbManageReporting.Text = "Manage Reporting";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 29);
            this.label1.TabIndex = 36;
            this.label1.Text = "Assessment Type Description:";
            // 
            // txtAssessment
            // 
            this.txtAssessment.Location = new System.Drawing.Point(56, 107);
            this.txtAssessment.Name = "txtAssessment";
            this.txtAssessment.Size = new System.Drawing.Size(314, 34);
            this.txtAssessment.TabIndex = 35;
            // 
            // btnSearchBetwDat
            // 
            this.btnSearchBetwDat.Location = new System.Drawing.Point(1195, 102);
            this.btnSearchBetwDat.Name = "btnSearchBetwDat";
            this.btnSearchBetwDat.Size = new System.Drawing.Size(144, 37);
            this.btnSearchBetwDat.TabIndex = 34;
            this.btnSearchBetwDat.Text = "Search";
            this.btnSearchBetwDat.UseVisualStyleBackColor = true;
            this.btnSearchBetwDat.Click += new System.EventHandler(this.btnSearchBetwDat_Click);
            // 
            // dtEndDate
            // 
            this.dtEndDate.Location = new System.Drawing.Point(824, 105);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(355, 34);
            this.dtEndDate.TabIndex = 33;
            // 
            // dtStartDate
            // 
            this.dtStartDate.Location = new System.Drawing.Point(429, 107);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(332, 34);
            this.dtStartDate.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(964, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 29);
            this.label3.TabIndex = 31;
            this.label3.Text = "End date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(523, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 30;
            this.label2.Text = "Start date:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgvDisplaybyName
            // 
            this.dgvDisplaybyName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplaybyName.Location = new System.Drawing.Point(33, 147);
            this.dgvDisplaybyName.Name = "dgvDisplaybyName";
            this.dgvDisplaybyName.RowHeadersWidth = 51;
            this.dgvDisplaybyName.RowTemplate.Height = 24;
            this.dgvDisplaybyName.Size = new System.Drawing.Size(1306, 390);
            this.dgvDisplaybyName.TabIndex = 23;
            // 
            // UserControlReportingAssessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbManageReporting);
            this.Name = "UserControlReportingAssessment";
            this.Size = new System.Drawing.Size(1363, 566);
            this.Load += new System.EventHandler(this.UserControlReportingAssessment_Load);
            this.gbManageReporting.ResumeLayout(false);
            this.gbManageReporting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplaybyName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbManageReporting;
        private System.Windows.Forms.DataGridView dgvDisplaybyName;
        private System.Windows.Forms.Button btnSearchBetwDat;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAssessment;
        private System.Windows.Forms.Label label1;
    }
}
