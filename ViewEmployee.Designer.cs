namespace EMS
{
    partial class ViewEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEmployee));
            this.BtnEdit = new System.Windows.Forms.Button();
            this.btnviewemp = new System.Windows.Forms.Button();
            this.lblGmail = new System.Windows.Forms.Label();
            this.lblEmpId = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblDateInsert = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.EmpPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EmpPic)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.Transparent;
            this.BtnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEdit.BackgroundImage")));
            this.BtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEdit.FlatAppearance.BorderSize = 0;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Location = new System.Drawing.Point(803, 25);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(25, 29);
            this.BtnEdit.TabIndex = 29;
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click_1);
            // 
            // btnviewemp
            // 
            this.btnviewemp.BackColor = System.Drawing.Color.Transparent;
            this.btnviewemp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnviewemp.BackgroundImage")));
            this.btnviewemp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnviewemp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnviewemp.FlatAppearance.BorderSize = 0;
            this.btnviewemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnviewemp.Location = new System.Drawing.Point(858, 6);
            this.btnviewemp.Name = "btnviewemp";
            this.btnviewemp.Size = new System.Drawing.Size(28, 28);
            this.btnviewemp.TabIndex = 33;
            this.btnviewemp.UseVisualStyleBackColor = false;
            this.btnviewemp.Click += new System.EventHandler(this.btnviewemp_Click_1);
            // 
            // lblGmail
            // 
            this.lblGmail.AutoSize = true;
            this.lblGmail.BackColor = System.Drawing.Color.Transparent;
            this.lblGmail.ForeColor = System.Drawing.Color.Black;
            this.lblGmail.Location = new System.Drawing.Point(599, 27);
            this.lblGmail.Name = "lblGmail";
            this.lblGmail.Size = new System.Drawing.Size(51, 20);
            this.lblGmail.TabIndex = 28;
            this.lblGmail.Text = "label2";
            // 
            // lblEmpId
            // 
            this.lblEmpId.AutoSize = true;
            this.lblEmpId.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpId.ForeColor = System.Drawing.Color.Black;
            this.lblEmpId.Location = new System.Drawing.Point(88, 27);
            this.lblEmpId.Name = "lblEmpId";
            this.lblEmpId.Size = new System.Drawing.Size(51, 20);
            this.lblEmpId.TabIndex = 25;
            this.lblEmpId.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(492, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 28);
            this.panel1.TabIndex = 32;
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.BackColor = System.Drawing.Color.Transparent;
            this.lblFname.ForeColor = System.Drawing.Color.Black;
            this.lblFname.Location = new System.Drawing.Point(226, 19);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(51, 20);
            this.lblFname.TabIndex = 26;
            this.lblFname.Text = "label2";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.BackColor = System.Drawing.Color.Transparent;
            this.lblLname.ForeColor = System.Drawing.Color.Black;
            this.lblLname.Location = new System.Drawing.Point(226, 41);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(51, 20);
            this.lblLname.TabIndex = 27;
            this.lblLname.Text = "label2";
            // 
            // lblDateInsert
            // 
            this.lblDateInsert.AutoSize = true;
            this.lblDateInsert.BackColor = System.Drawing.Color.Transparent;
            this.lblDateInsert.ForeColor = System.Drawing.Color.Black;
            this.lblDateInsert.Location = new System.Drawing.Point(418, 19);
            this.lblDateInsert.Name = "lblDateInsert";
            this.lblDateInsert.Size = new System.Drawing.Size(84, 20);
            this.lblDateInsert.TabIndex = 31;
            this.lblDateInsert.Text = "4/3/2025 1";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(418, 41);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 20);
            this.lblStatus.TabIndex = 30;
            this.lblStatus.Text = "label2";
            // 
            // EmpPic
            // 
            this.EmpPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EmpPic.BackgroundImage")));
            this.EmpPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EmpPic.Location = new System.Drawing.Point(15, 11);
            this.EmpPic.Name = "EmpPic";
            this.EmpPic.Size = new System.Drawing.Size(53, 50);
            this.EmpPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EmpPic.TabIndex = 34;
            this.EmpPic.TabStop = false;
            // 
            // ViewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.EmpPic);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.btnviewemp);
            this.Controls.Add(this.lblGmail);
            this.Controls.Add(this.lblEmpId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.lblDateInsert);
            this.Controls.Add(this.lblStatus);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "ViewEmployee";
            this.Size = new System.Drawing.Size(894, 72);
            ((System.ComponentModel.ISupportInitialize)(this.EmpPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button btnviewemp;
        public System.Windows.Forms.Label lblGmail;
        public System.Windows.Forms.Label lblEmpId;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblFname;
        public System.Windows.Forms.Label lblLname;
        public System.Windows.Forms.Label lblDateInsert;
        public System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.PictureBox EmpPic;
    }
}
