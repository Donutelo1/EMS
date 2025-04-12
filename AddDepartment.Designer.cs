namespace EMS
{
    partial class AddDepartment
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
            this.cancelBttn = new System.Windows.Forms.Button();
            this.adddeptBttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelhrid = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.ComboBox();
            this.exitBttn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DEPTID = new System.Windows.Forms.TextBox();
            this.customPanel2 = new EMS.customPanel();
            this.customPanel1 = new EMS.customPanel();
            this.txtDeptName = new EMS.Csharp();
            this.SuspendLayout();
            // 
            // cancelBttn
            // 
            this.cancelBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cancelBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBttn.FlatAppearance.BorderSize = 0;
            this.cancelBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBttn.ForeColor = System.Drawing.Color.White;
            this.cancelBttn.Location = new System.Drawing.Point(127, 218);
            this.cancelBttn.Name = "cancelBttn";
            this.cancelBttn.Size = new System.Drawing.Size(80, 28);
            this.cancelBttn.TabIndex = 1;
            this.cancelBttn.Text = "Cancel";
            this.cancelBttn.UseVisualStyleBackColor = false;
            this.cancelBttn.Click += new System.EventHandler(this.cancelBttn_Click);
            // 
            // adddeptBttn
            // 
            this.adddeptBttn.BackColor = System.Drawing.Color.SandyBrown;
            this.adddeptBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adddeptBttn.FlatAppearance.BorderSize = 0;
            this.adddeptBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adddeptBttn.ForeColor = System.Drawing.Color.White;
            this.adddeptBttn.Location = new System.Drawing.Point(214, 218);
            this.adddeptBttn.Name = "adddeptBttn";
            this.adddeptBttn.Size = new System.Drawing.Size(80, 28);
            this.adddeptBttn.TabIndex = 2;
            this.adddeptBttn.Text = "Add";
            this.adddeptBttn.UseVisualStyleBackColor = false;
            this.adddeptBttn.Click += new System.EventHandler(this.adddeptBttn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Department name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(205, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 23);
            this.label4.TabIndex = 14;
            // 
            // labelhrid
            // 
            this.labelhrid.AutoSize = true;
            this.labelhrid.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhrid.ForeColor = System.Drawing.Color.Black;
            this.labelhrid.Location = new System.Drawing.Point(276, 30);
            this.labelhrid.Name = "labelhrid";
            this.labelhrid.Size = new System.Drawing.Size(0, 23);
            this.labelhrid.TabIndex = 15;
            this.labelhrid.Click += new System.EventHandler(this.labelhrid_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(214, 218);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(80, 28);
            this.updateBtn.TabIndex = 17;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Visible = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Location = new System.Drawing.Point(127, 218);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(80, 28);
            this.backBtn.TabIndex = 18;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Visible = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.FormattingEnabled = true;
            this.txtStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.txtStatus.Location = new System.Drawing.Point(50, 170);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(211, 28);
            this.txtStatus.TabIndex = 50;
            this.txtStatus.Text = "Active";
            // 
            // exitBttn
            // 
            this.exitBttn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.exitBttn.BackColor = System.Drawing.SystemColors.Control;
            this.exitBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBttn.FlatAppearance.BorderSize = 0;
            this.exitBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBttn.Location = new System.Drawing.Point(267, 3);
            this.exitBttn.Name = "exitBttn";
            this.exitBttn.Size = new System.Drawing.Size(35, 32);
            this.exitBttn.TabIndex = 52;
            this.exitBttn.Text = "X";
            this.exitBttn.UseVisualStyleBackColor = false;
            this.exitBttn.Click += new System.EventHandler(this.exitBttn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 21);
            this.label2.TabIndex = 54;
            this.label2.Text = "Add New Department";
            // 
            // DEPTID
            // 
            this.DEPTID.Enabled = false;
            this.DEPTID.Location = new System.Drawing.Point(63, 54);
            this.DEPTID.Name = "DEPTID";
            this.DEPTID.Size = new System.Drawing.Size(100, 26);
            this.DEPTID.TabIndex = 56;
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderRadius = 30;
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 90F;
            this.customPanel2.GradientTopColor = System.Drawing.SystemColors.Control;
            this.customPanel2.GradinetAngle = System.Drawing.SystemColors.Control;
            this.customPanel2.Location = new System.Drawing.Point(48, 54);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(143, 29);
            this.customPanel2.TabIndex = 57;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 30;
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientTopColor = System.Drawing.SystemColors.ControlLight;
            this.customPanel1.GradinetAngle = System.Drawing.SystemColors.ControlLight;
            this.customPanel1.Location = new System.Drawing.Point(-16, 45);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(350, 3);
            this.customPanel1.TabIndex = 55;
            // 
            // txtDeptName
            // 
            this.txtDeptName.BackColor = System.Drawing.Color.Transparent;
            this.txtDeptName.Br = System.Drawing.Color.White;
            this.txtDeptName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeptName.ForeColor = System.Drawing.Color.Black;
            this.txtDeptName.Location = new System.Drawing.Point(50, 108);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(210, 32);
            this.txtDeptName.TabIndex = 51;
            // 
            // AddDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(307, 256);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.DEPTID);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exitBttn);
            this.Controls.Add(this.txtDeptName);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.labelhrid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adddeptBttn);
            this.Controls.Add(this.cancelBttn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddHrFrm";
            this.Load += new System.EventHandler(this.AddHrFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelBttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label labelhrid;
        public System.Windows.Forms.Button adddeptBttn;
        public System.Windows.Forms.Button updateBtn;
        public System.Windows.Forms.Button backBtn;
        public System.Windows.Forms.ComboBox txtStatus;
        private System.Windows.Forms.Button exitBttn;
        private System.Windows.Forms.Label label2;
        public Csharp txtDeptName;
        private customPanel customPanel1;
        public System.Windows.Forms.TextBox DEPTID;
        private customPanel customPanel2;
    }
}