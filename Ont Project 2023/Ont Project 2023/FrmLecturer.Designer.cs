namespace Ont_Project_2023
{
    partial class FrmLecturer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnManageAssessmentType = new System.Windows.Forms.Button();
            this.btnManageReporting = new System.Windows.Forms.Button();
            this.btnManageAssessment = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SlateGray;
            this.panel3.Location = new System.Drawing.Point(-3, 195);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1356, 562);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Location = new System.Drawing.Point(-3, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1359, 93);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.btnManageAssessmentType);
            this.panel1.Controls.Add(this.btnManageReporting);
            this.panel1.Controls.Add(this.btnManageAssessment);
            this.panel1.Location = new System.Drawing.Point(0, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1356, 64);
            this.panel1.TabIndex = 4;
            // 
            // btnManageAssessmentType
            // 
            this.btnManageAssessmentType.BackColor = System.Drawing.Color.Lavender;
            this.btnManageAssessmentType.Location = new System.Drawing.Point(4, 6);
            this.btnManageAssessmentType.Name = "btnManageAssessmentType";
            this.btnManageAssessmentType.Size = new System.Drawing.Size(170, 50);
            this.btnManageAssessmentType.TabIndex = 4;
            this.btnManageAssessmentType.Text = "Manage Assessment Type";
            this.btnManageAssessmentType.UseVisualStyleBackColor = false;
            this.btnManageAssessmentType.Click += new System.EventHandler(this.btnManageAssessmentType_Click);
            // 
            // btnManageReporting
            // 
            this.btnManageReporting.BackColor = System.Drawing.Color.Lavender;
            this.btnManageReporting.Location = new System.Drawing.Point(359, 6);
            this.btnManageReporting.Name = "btnManageReporting";
            this.btnManageReporting.Size = new System.Drawing.Size(170, 50);
            this.btnManageReporting.TabIndex = 6;
            this.btnManageReporting.Text = "Manage Reporting";
            this.btnManageReporting.UseVisualStyleBackColor = false;
            this.btnManageReporting.Click += new System.EventHandler(this.btnManageReporting_Click);
            // 
            // btnManageAssessment
            // 
            this.btnManageAssessment.BackColor = System.Drawing.Color.Lavender;
            this.btnManageAssessment.Location = new System.Drawing.Point(180, 6);
            this.btnManageAssessment.Name = "btnManageAssessment";
            this.btnManageAssessment.Size = new System.Drawing.Size(170, 50);
            this.btnManageAssessment.TabIndex = 3;
            this.btnManageAssessment.Text = "Manage Assessment";
            this.btnManageAssessment.UseVisualStyleBackColor = false;
            this.btnManageAssessment.Click += new System.EventHandler(this.btnManageAssessment_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(-3, 90);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(177, 49);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FrmLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1351, 749);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmLecturer";
            this.Text = "Lecturer Form";
            this.Load += new System.EventHandler(this.FrmLecturer_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnManageReporting;
        private System.Windows.Forms.Button btnManageAssessmentType;
        private System.Windows.Forms.Button btnManageAssessment;
        private System.Windows.Forms.Button btnLogout;
    }
}