namespace Ont_Project_2023.Controls
{
    partial class UserControlStudentReporting
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
            this.txtSearchAssessment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchAssessment = new System.Windows.Forms.Button();
            this.dgvDisplaybyName = new System.Windows.Forms.DataGridView();
            this.gbManageReporting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplaybyName)).BeginInit();
            this.SuspendLayout();
            // 
            // gbManageReporting
            // 
            this.gbManageReporting.BackColor = System.Drawing.Color.Lavender;
            this.gbManageReporting.Controls.Add(this.txtSearchAssessment);
            this.gbManageReporting.Controls.Add(this.label1);
            this.gbManageReporting.Controls.Add(this.btnSearchAssessment);
            this.gbManageReporting.Controls.Add(this.dgvDisplaybyName);
            this.gbManageReporting.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbManageReporting.Location = new System.Drawing.Point(3, 0);
            this.gbManageReporting.Name = "gbManageReporting";
            this.gbManageReporting.Size = new System.Drawing.Size(1345, 556);
            this.gbManageReporting.TabIndex = 7;
            this.gbManageReporting.TabStop = false;
            this.gbManageReporting.Text = "Manage Reporting";
            // 
            // txtSearchAssessment
            // 
            this.txtSearchAssessment.Location = new System.Drawing.Point(503, 69);
            this.txtSearchAssessment.Name = "txtSearchAssessment";
            this.txtSearchAssessment.Size = new System.Drawing.Size(425, 34);
            this.txtSearchAssessment.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "Search Assessment:";
            // 
            // btnSearchAssessment
            // 
            this.btnSearchAssessment.Location = new System.Drawing.Point(977, 64);
            this.btnSearchAssessment.Name = "btnSearchAssessment";
            this.btnSearchAssessment.Size = new System.Drawing.Size(180, 37);
            this.btnSearchAssessment.TabIndex = 24;
            this.btnSearchAssessment.Text = "Search";
            this.btnSearchAssessment.UseVisualStyleBackColor = true;
            this.btnSearchAssessment.Click += new System.EventHandler(this.btnSearchModule_Click);
            // 
            // dgvDisplaybyName
            // 
            this.dgvDisplaybyName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplaybyName.Location = new System.Drawing.Point(19, 131);
            this.dgvDisplaybyName.Name = "dgvDisplaybyName";
            this.dgvDisplaybyName.RowHeadersWidth = 51;
            this.dgvDisplaybyName.RowTemplate.Height = 24;
            this.dgvDisplaybyName.Size = new System.Drawing.Size(1306, 390);
            this.dgvDisplaybyName.TabIndex = 23;
            // 
            // UserControlStudentReporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbManageReporting);
            this.Name = "UserControlStudentReporting";
            this.Size = new System.Drawing.Size(1367, 559);
            this.Load += new System.EventHandler(this.UserControlStudentReporting_Load);
            this.gbManageReporting.ResumeLayout(false);
            this.gbManageReporting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplaybyName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbManageReporting;
        private System.Windows.Forms.TextBox txtSearchAssessment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchAssessment;
        private System.Windows.Forms.DataGridView dgvDisplaybyName;
    }
}
