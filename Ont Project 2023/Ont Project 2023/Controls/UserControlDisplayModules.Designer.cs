namespace Ont_Project_2023.Controls
{
    partial class UserControlDisplayModules
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
            this.gbDisplay = new System.Windows.Forms.GroupBox();
            this.btnDisplayModule = new System.Windows.Forms.Button();
            this.dgvDisplaybyName = new System.Windows.Forms.DataGridView();
            this.gbDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplaybyName)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDisplay
            // 
            this.gbDisplay.BackColor = System.Drawing.Color.Lavender;
            this.gbDisplay.Controls.Add(this.btnDisplayModule);
            this.gbDisplay.Controls.Add(this.dgvDisplaybyName);
            this.gbDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDisplay.Location = new System.Drawing.Point(3, 3);
            this.gbDisplay.Name = "gbDisplay";
            this.gbDisplay.Size = new System.Drawing.Size(1314, 524);
            this.gbDisplay.TabIndex = 6;
            this.gbDisplay.TabStop = false;
            this.gbDisplay.Text = "Display Module Enrolled To";
            // 
            // btnDisplayModule
            // 
            this.btnDisplayModule.Location = new System.Drawing.Point(1034, 474);
            this.btnDisplayModule.Name = "btnDisplayModule";
            this.btnDisplayModule.Size = new System.Drawing.Size(232, 44);
            this.btnDisplayModule.TabIndex = 24;
            this.btnDisplayModule.Text = "Search";
            this.btnDisplayModule.UseVisualStyleBackColor = true;
            this.btnDisplayModule.Click += new System.EventHandler(this.btnDisplayModule_Click);
            // 
            // dgvDisplaybyName
            // 
            this.dgvDisplaybyName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplaybyName.Location = new System.Drawing.Point(6, 33);
            this.dgvDisplaybyName.Name = "dgvDisplaybyName";
            this.dgvDisplaybyName.RowHeadersWidth = 51;
            this.dgvDisplaybyName.RowTemplate.Height = 24;
            this.dgvDisplaybyName.Size = new System.Drawing.Size(1302, 418);
            this.dgvDisplaybyName.TabIndex = 23;
            // 
            // UserControlDisplayModules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbDisplay);
            this.Name = "UserControlDisplayModules";
            this.Size = new System.Drawing.Size(1322, 534);
            this.gbDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplaybyName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDisplay;
        private System.Windows.Forms.Button btnDisplayModule;
        private System.Windows.Forms.DataGridView dgvDisplaybyName;
    }
}
