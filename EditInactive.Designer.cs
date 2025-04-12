namespace EMS
{
    partial class EditInactive
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
            this.exitBttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEmpid = new System.Windows.Forms.TextBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.addEmpBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.back = new EMS.Csharp();
            this.yes = new EMS.Csharp();
            this.btndelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitBttn
            // 
            this.exitBttn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.exitBttn.BackColor = System.Drawing.Color.Transparent;
            this.exitBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBttn.FlatAppearance.BorderSize = 0;
            this.exitBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBttn.Location = new System.Drawing.Point(386, 2);
            this.exitBttn.Name = "exitBttn";
            this.exitBttn.Size = new System.Drawing.Size(35, 32);
            this.exitBttn.TabIndex = 28;
            this.exitBttn.Text = "X";
            this.exitBttn.UseVisualStyleBackColor = false;
            this.exitBttn.Click += new System.EventHandler(this.exitBttn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Edit Inactive Employee";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(-4, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 3);
            this.panel1.TabIndex = 27;
            // 
            // txtEmpid
            // 
            this.txtEmpid.BackColor = System.Drawing.Color.White;
            this.txtEmpid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmpid.Enabled = false;
            this.txtEmpid.Location = new System.Drawing.Point(20, 160);
            this.txtEmpid.Multiline = true;
            this.txtEmpid.Name = "txtEmpid";
            this.txtEmpid.Size = new System.Drawing.Size(164, 21);
            this.txtEmpid.TabIndex = 82;
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.FlatAppearance.BorderSize = 0;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(211, 149);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(100, 32);
            this.BackBtn.TabIndex = 77;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.FlatAppearance.BorderSize = 0;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(319, 149);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(100, 32);
            this.UpdateBtn.TabIndex = 76;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Visible = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cmbStatus.Location = new System.Drawing.Point(224, 79);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(190, 28);
            this.cmbStatus.TabIndex = 75;
            this.cmbStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbStatus_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(243, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 74;
            this.label10.Text = "Status";
            // 
            // addEmpBtn
            // 
            this.addEmpBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.addEmpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmpBtn.FlatAppearance.BorderSize = 0;
            this.addEmpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmpBtn.ForeColor = System.Drawing.Color.White;
            this.addEmpBtn.Location = new System.Drawing.Point(319, 149);
            this.addEmpBtn.Name = "addEmpBtn";
            this.addEmpBtn.Size = new System.Drawing.Size(100, 32);
            this.addEmpBtn.TabIndex = 73;
            this.addEmpBtn.Text = "Add";
            this.addEmpBtn.UseVisualStyleBackColor = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Coral;
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(211, 149);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 32);
            this.cancelBtn.TabIndex = 72;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 62;
            this.label6.Text = "Employee ID";
            // 
            // txtGmail
            // 
            this.txtGmail.BackColor = System.Drawing.Color.White;
            this.txtGmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGmail.Enabled = false;
            this.txtGmail.Location = new System.Drawing.Point(20, 88);
            this.txtGmail.Multiline = true;
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Size = new System.Drawing.Size(164, 21);
            this.txtGmail.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 83;
            this.label5.Text = "Gmail";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.Br = System.Drawing.Color.White;
            this.back.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.back.Enabled = false;
            this.back.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.Black;
            this.back.Location = new System.Drawing.Point(7, 80);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(190, 32);
            this.back.TabIndex = 84;
            // 
            // yes
            // 
            this.yes.BackColor = System.Drawing.Color.Transparent;
            this.yes.Br = System.Drawing.Color.White;
            this.yes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.yes.Enabled = false;
            this.yes.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yes.ForeColor = System.Drawing.Color.Black;
            this.yes.Location = new System.Drawing.Point(7, 151);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(190, 32);
            this.yes.TabIndex = 65;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(321, 149);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(100, 32);
            this.btndelete.TabIndex = 86;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Visible = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // EditInactive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 198);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.txtGmail);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmpid);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.addEmpBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.yes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.exitBttn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditInactive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.EditInactive_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtEmpid;
        public System.Windows.Forms.Button BackBtn;
        public System.Windows.Forms.Button UpdateBtn;
        public System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Button addEmpBtn;
        private Csharp yes;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtGmail;
        private Csharp back;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btndelete;
        public System.Windows.Forms.Button cancelBtn;
    }
}