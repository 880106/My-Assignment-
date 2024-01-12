namespace Ont_Project_2023.Controls
{
    partial class UserControlModuleType
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
            this.gbManageModuleType = new System.Windows.Forms.GroupBox();
            this.dgvDisplayModuleType = new System.Windows.Forms.DataGridView();
            this.btnDisplayModuleType = new System.Windows.Forms.Button();
            this.btnDeleteModuleType = new System.Windows.Forms.Button();
            this.btnUpdateModuleType = new System.Windows.Forms.Button();
            this.btnAddModuleType = new System.Windows.Forms.Button();
            this.txtModuleTypeDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblModuleTypeDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProviderModuleTypeDescription = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbManageModuleType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayModuleType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderModuleTypeDescription)).BeginInit();
            this.SuspendLayout();
            // 
            // gbManageModuleType
            // 
            this.gbManageModuleType.BackColor = System.Drawing.Color.Lavender;
            this.gbManageModuleType.Controls.Add(this.dgvDisplayModuleType);
            this.gbManageModuleType.Controls.Add(this.btnDisplayModuleType);
            this.gbManageModuleType.Controls.Add(this.btnDeleteModuleType);
            this.gbManageModuleType.Controls.Add(this.btnUpdateModuleType);
            this.gbManageModuleType.Controls.Add(this.btnAddModuleType);
            this.gbManageModuleType.Controls.Add(this.txtModuleTypeDescription);
            this.gbManageModuleType.Controls.Add(this.label3);
            this.gbManageModuleType.Controls.Add(this.lblModuleTypeDescription);
            this.gbManageModuleType.Controls.Add(this.label1);
            this.gbManageModuleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbManageModuleType.Location = new System.Drawing.Point(3, 3);
            this.gbManageModuleType.Name = "gbManageModuleType";
            this.gbManageModuleType.Size = new System.Drawing.Size(1335, 551);
            this.gbManageModuleType.TabIndex = 7;
            this.gbManageModuleType.TabStop = false;
            this.gbManageModuleType.Text = "Manage Module Type";
            // 
            // dgvDisplayModuleType
            // 
            this.dgvDisplayModuleType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayModuleType.Location = new System.Drawing.Point(580, 33);
            this.dgvDisplayModuleType.Name = "dgvDisplayModuleType";
            this.dgvDisplayModuleType.RowHeadersWidth = 51;
            this.dgvDisplayModuleType.RowTemplate.Height = 24;
            this.dgvDisplayModuleType.Size = new System.Drawing.Size(737, 377);
            this.dgvDisplayModuleType.TabIndex = 23;
            this.dgvDisplayModuleType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisplayModuleType_CellContentClick);
            // 
            // btnDisplayModuleType
            // 
            this.btnDisplayModuleType.Location = new System.Drawing.Point(439, 214);
            this.btnDisplayModuleType.Name = "btnDisplayModuleType";
            this.btnDisplayModuleType.Size = new System.Drawing.Size(119, 35);
            this.btnDisplayModuleType.TabIndex = 22;
            this.btnDisplayModuleType.Text = "Display";
            this.btnDisplayModuleType.UseVisualStyleBackColor = true;
            this.btnDisplayModuleType.Click += new System.EventHandler(this.btnDisplayModuleType_Click);
            // 
            // btnDeleteModuleType
            // 
            this.btnDeleteModuleType.Location = new System.Drawing.Point(287, 214);
            this.btnDeleteModuleType.Name = "btnDeleteModuleType";
            this.btnDeleteModuleType.Size = new System.Drawing.Size(119, 35);
            this.btnDeleteModuleType.TabIndex = 21;
            this.btnDeleteModuleType.Text = "Delete";
            this.btnDeleteModuleType.UseVisualStyleBackColor = true;
            this.btnDeleteModuleType.Click += new System.EventHandler(this.btnDeleteModuleType_Click);
            // 
            // btnUpdateModuleType
            // 
            this.btnUpdateModuleType.Location = new System.Drawing.Point(147, 214);
            this.btnUpdateModuleType.Name = "btnUpdateModuleType";
            this.btnUpdateModuleType.Size = new System.Drawing.Size(119, 35);
            this.btnUpdateModuleType.TabIndex = 20;
            this.btnUpdateModuleType.Text = "Update";
            this.btnUpdateModuleType.UseVisualStyleBackColor = true;
            this.btnUpdateModuleType.Click += new System.EventHandler(this.btnUpdateModuleType_Click);
            // 
            // btnAddModuleType
            // 
            this.btnAddModuleType.Location = new System.Drawing.Point(11, 214);
            this.btnAddModuleType.Name = "btnAddModuleType";
            this.btnAddModuleType.Size = new System.Drawing.Size(119, 35);
            this.btnAddModuleType.TabIndex = 19;
            this.btnAddModuleType.Text = "Add ";
            this.btnAddModuleType.UseVisualStyleBackColor = true;
            this.btnAddModuleType.Click += new System.EventHandler(this.btnAddModuleType_Click);
            // 
            // txtModuleTypeDescription
            // 
            this.txtModuleTypeDescription.Location = new System.Drawing.Point(53, 118);
            this.txtModuleTypeDescription.Name = "txtModuleTypeDescription";
            this.txtModuleTypeDescription.Size = new System.Drawing.Size(482, 34);
            this.txtModuleTypeDescription.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 29);
            this.label3.TabIndex = 3;
            // 
            // lblModuleTypeDescription
            // 
            this.lblModuleTypeDescription.AutoSize = true;
            this.lblModuleTypeDescription.Location = new System.Drawing.Point(151, 65);
            this.lblModuleTypeDescription.Name = "lblModuleTypeDescription";
            this.lblModuleTypeDescription.Size = new System.Drawing.Size(283, 29);
            this.lblModuleTypeDescription.TabIndex = 2;
            this.lblModuleTypeDescription.Text = "Module Type Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 1;
            // 
            // errorProviderModuleTypeDescription
            // 
            this.errorProviderModuleTypeDescription.ContainerControl = this;
            // 
            // UserControlModuleType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbManageModuleType);
            this.Name = "UserControlModuleType";
            this.Size = new System.Drawing.Size(1361, 565);
            this.Load += new System.EventHandler(this.UserControlModuletype_Load);
            this.gbManageModuleType.ResumeLayout(false);
            this.gbManageModuleType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayModuleType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderModuleTypeDescription)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbManageModuleType;
        private System.Windows.Forms.DataGridView dgvDisplayModuleType;
        private System.Windows.Forms.Button btnDisplayModuleType;
        private System.Windows.Forms.Button btnDeleteModuleType;
        private System.Windows.Forms.Button btnUpdateModuleType;
        private System.Windows.Forms.Button btnAddModuleType;
        private System.Windows.Forms.TextBox txtModuleTypeDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblModuleTypeDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProviderModuleTypeDescription;
    }
}
