namespace EMS
{
    partial class AddEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployeeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitBttn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addEmpBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.txtGmail = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtEmpid = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.browsebtn = new FontAwesome.Sharp.IconButton();
            this.empPic = new FontAwesome.Sharp.IconPictureBox();
            this.cmbDept = new System.Windows.Forms.ComboBox();
            this.no = new EMS.Csharp();
            this.yes = new EMS.Csharp();
            this.back = new EMS.Csharp();
            this.okay = new EMS.Csharp();
            this.meron = new EMS.Csharp();
            this.wala = new EMS.Csharp();
            ((System.ComponentModel.ISupportInitialize)(this.empPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Employee";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(-6, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 3);
            this.panel1.TabIndex = 1;
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
            this.exitBttn.Location = new System.Drawing.Point(590, 0);
            this.exitBttn.Name = "exitBttn";
            this.exitBttn.Size = new System.Drawing.Size(35, 32);
            this.exitBttn.TabIndex = 25;
            this.exitBttn.Text = "X";
            this.exitBttn.UseVisualStyleBackColor = false;
            this.exitBttn.Click += new System.EventHandler(this.exitBttn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Contact No.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(450, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Gmail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(227, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "Department";
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(431, 339);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(190, 28);
            this.cmbGender.TabIndex = 40;
            this.cmbGender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbGender_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(450, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 41;
            this.label9.Text = "Gender";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Coral;
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(396, 406);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 32);
            this.cancelBtn.TabIndex = 44;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            // 
            // addEmpBtn
            // 
            this.addEmpBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.addEmpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmpBtn.FlatAppearance.BorderSize = 0;
            this.addEmpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmpBtn.ForeColor = System.Drawing.Color.White;
            this.addEmpBtn.Location = new System.Drawing.Point(504, 406);
            this.addEmpBtn.Name = "addEmpBtn";
            this.addEmpBtn.Size = new System.Drawing.Size(100, 32);
            this.addEmpBtn.TabIndex = 45;
            this.addEmpBtn.Text = "Add";
            this.addEmpBtn.UseVisualStyleBackColor = false;
            this.addEmpBtn.Click += new System.EventHandler(this.addEmpBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(450, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 46;
            this.label10.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cmbStatus.Location = new System.Drawing.Point(431, 113);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(190, 28);
            this.cmbStatus.TabIndex = 47;
            this.cmbStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbStatus_KeyPress);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.FlatAppearance.BorderSize = 0;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(504, 406);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(100, 32);
            this.UpdateBtn.TabIndex = 48;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Visible = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.FlatAppearance.BorderSize = 0;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(396, 406);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(100, 32);
            this.BackBtn.TabIndex = 49;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // txtFname
            // 
            this.txtFname.BackColor = System.Drawing.Color.White;
            this.txtFname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFname.Location = new System.Drawing.Point(228, 191);
            this.txtFname.Multiline = true;
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(164, 21);
            this.txtFname.TabIndex = 50;
            this.txtFname.TextChanged += new System.EventHandler(this.txtFname_TextChanged);
            // 
            // txtLname
            // 
            this.txtLname.BackColor = System.Drawing.Color.White;
            this.txtLname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLname.Location = new System.Drawing.Point(444, 191);
            this.txtLname.Multiline = true;
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(164, 21);
            this.txtLname.TabIndex = 51;
            this.txtLname.TextChanged += new System.EventHandler(this.txtLname_TextChanged);
            // 
            // txtcontact
            // 
            this.txtcontact.BackColor = System.Drawing.Color.White;
            this.txtcontact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcontact.Location = new System.Drawing.Point(228, 271);
            this.txtcontact.Multiline = true;
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(164, 21);
            this.txtcontact.TabIndex = 52;
            this.txtcontact.TextChanged += new System.EventHandler(this.txtcontact_TextChanged);
            this.txtcontact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcontact_KeyPress);
            // 
            // txtGmail
            // 
            this.txtGmail.BackColor = System.Drawing.Color.White;
            this.txtGmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGmail.Location = new System.Drawing.Point(444, 270);
            this.txtGmail.Multiline = true;
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Size = new System.Drawing.Size(164, 21);
            this.txtGmail.TabIndex = 53;
            this.txtGmail.TextChanged += new System.EventHandler(this.txtGmail_TextChanged);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Location = new System.Drawing.Point(228, 336);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '•';
            this.txtPass.Size = new System.Drawing.Size(164, 21);
            this.txtPass.TabIndex = 55;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 412);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 56;
            // 
            // txtEmpid
            // 
            this.txtEmpid.BackColor = System.Drawing.Color.White;
            this.txtEmpid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmpid.Location = new System.Drawing.Point(18, 369);
            this.txtEmpid.Multiline = true;
            this.txtEmpid.Name = "txtEmpid";
            this.txtEmpid.Size = new System.Drawing.Size(164, 21);
            this.txtEmpid.TabIndex = 54;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(11, 410);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 38);
            this.panel2.TabIndex = 57;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(6, 359);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(195, 47);
            this.panel3.TabIndex = 58;
            // 
            // browsebtn
            // 
            this.browsebtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.browsebtn.FlatAppearance.BorderSize = 0;
            this.browsebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browsebtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.browsebtn.IconColor = System.Drawing.Color.Black;
            this.browsebtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.browsebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.browsebtn.Location = new System.Drawing.Point(25, 259);
            this.browsebtn.Name = "browsebtn";
            this.browsebtn.Size = new System.Drawing.Size(150, 33);
            this.browsebtn.TabIndex = 59;
            this.browsebtn.Text = "Browse";
            this.browsebtn.UseVisualStyleBackColor = false;
            this.browsebtn.Click += new System.EventHandler(this.browsebtn_Click);
            // 
            // empPic
            // 
            this.empPic.BackColor = System.Drawing.Color.White;
            this.empPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("empPic.BackgroundImage")));
            this.empPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.empPic.ForeColor = System.Drawing.SystemColors.ControlText;
            this.empPic.IconChar = FontAwesome.Sharp.IconChar.None;
            this.empPic.IconColor = System.Drawing.SystemColors.ControlText;
            this.empPic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.empPic.IconSize = 127;
            this.empPic.Location = new System.Drawing.Point(25, 113);
            this.empPic.Name = "empPic";
            this.empPic.Size = new System.Drawing.Size(150, 127);
            this.empPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.empPic.TabIndex = 60;
            this.empPic.TabStop = false;
            // 
            // cmbDept
            // 
            this.cmbDept.FormattingEnabled = true;
            this.cmbDept.Location = new System.Drawing.Point(216, 113);
            this.cmbDept.Name = "cmbDept";
            this.cmbDept.Size = new System.Drawing.Size(190, 28);
            this.cmbDept.TabIndex = 61;
            this.cmbDept.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbDept_KeyPress_1);
            // 
            // no
            // 
            this.no.BackColor = System.Drawing.Color.Transparent;
            this.no.Br = System.Drawing.Color.White;
            this.no.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.no.Enabled = false;
            this.no.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no.ForeColor = System.Drawing.Color.Black;
            this.no.Location = new System.Drawing.Point(215, 335);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(190, 32);
            this.no.TabIndex = 37;
            // 
            // yes
            // 
            this.yes.BackColor = System.Drawing.Color.Transparent;
            this.yes.Br = System.Drawing.Color.White;
            this.yes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.yes.Enabled = false;
            this.yes.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yes.ForeColor = System.Drawing.Color.Black;
            this.yes.Location = new System.Drawing.Point(6, 360);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(190, 32);
            this.yes.TabIndex = 35;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.Br = System.Drawing.Color.White;
            this.back.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.back.Enabled = false;
            this.back.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.Black;
            this.back.Location = new System.Drawing.Point(431, 262);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(190, 32);
            this.back.TabIndex = 34;
            // 
            // okay
            // 
            this.okay.BackColor = System.Drawing.Color.Transparent;
            this.okay.Br = System.Drawing.Color.White;
            this.okay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.okay.Enabled = false;
            this.okay.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okay.ForeColor = System.Drawing.Color.Black;
            this.okay.Location = new System.Drawing.Point(216, 262);
            this.okay.Name = "okay";
            this.okay.Size = new System.Drawing.Size(190, 32);
            this.okay.TabIndex = 33;
            // 
            // meron
            // 
            this.meron.BackColor = System.Drawing.Color.Transparent;
            this.meron.Br = System.Drawing.Color.White;
            this.meron.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.meron.Enabled = false;
            this.meron.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meron.ForeColor = System.Drawing.Color.Black;
            this.meron.Location = new System.Drawing.Point(431, 184);
            this.meron.Name = "meron";
            this.meron.Size = new System.Drawing.Size(190, 32);
            this.meron.TabIndex = 29;
            // 
            // wala
            // 
            this.wala.BackColor = System.Drawing.Color.Transparent;
            this.wala.Br = System.Drawing.Color.White;
            this.wala.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.wala.Enabled = false;
            this.wala.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wala.ForeColor = System.Drawing.Color.Black;
            this.wala.Location = new System.Drawing.Point(216, 184);
            this.wala.Name = "wala";
            this.wala.Size = new System.Drawing.Size(190, 32);
            this.wala.TabIndex = 26;
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(629, 450);
            this.Controls.Add(this.cmbDept);
            this.Controls.Add(this.empPic);
            this.Controls.Add(this.browsebtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.exitBttn);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtEmpid);
            this.Controls.Add(this.txtGmail);
            this.Controls.Add(this.txtcontact);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.addEmpBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.no);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.yes);
            this.Controls.Add(this.back);
            this.Controls.Add(this.okay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.meron);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wala);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEmployeeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEmployeeForm_FormClosing);
            this.Load += new System.EventHandler(this.AddEmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitBttn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cancelBtn;
        public System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox cmbStatus;
        public System.Windows.Forms.Button UpdateBtn;
        public System.Windows.Forms.Button BackBtn;
        public System.Windows.Forms.Button addEmpBtn;
        private Csharp no;
        private Csharp wala;
        private Csharp meron;
        private Csharp okay;
        private Csharp back;
        public System.Windows.Forms.TextBox txtFname;
        public System.Windows.Forms.TextBox txtLname;
        public System.Windows.Forms.TextBox txtcontact;
        public System.Windows.Forms.TextBox txtGmail;
        public System.Windows.Forms.TextBox txtPass;
        public System.Windows.Forms.TextBox textBox1;
        private Csharp yes;
        public System.Windows.Forms.TextBox txtEmpid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton browsebtn;
        public System.Windows.Forms.ComboBox cmbDept;
        public FontAwesome.Sharp.IconPictureBox empPic;
        public System.Windows.Forms.Label label1;
    }
}