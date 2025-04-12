namespace EMS
{
    partial class EmployeeDashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDashboard));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.customPanel2 = new EMS.customPanel();
            this.employeeDBoard1 = new EMS.EmployeeDBoard();
            this.editProfile1 = new EMS.EditProfile();
            this.empAttendance1 = new EMS.EmpAttendance();
            this.printPaySlip1 = new EMS.PrintPaySlip();
            this.customPanel6 = new EMS.customPanel();
            this.salaryBtn = new FontAwesome.Sharp.IconButton();
            this.picEmp = new FontAwesome.Sharp.IconPictureBox();
            this.myProfileBtn = new FontAwesome.Sharp.IconButton();
            this.customPanel4 = new EMS.customPanel();
            this.attendanceBtn = new FontAwesome.Sharp.IconButton();
            this.dashboardBtn = new FontAwesome.Sharp.IconButton();
            this.labelfirstname = new System.Windows.Forms.Label();
            this.customPanel1 = new EMS.customPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customPanel5 = new EMS.customPanel();
            this.logoutBtn = new FontAwesome.Sharp.IconButton();
            this.customPanel2.SuspendLayout();
            this.customPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmp)).BeginInit();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderRadius = 30;
            this.customPanel2.Controls.Add(this.employeeDBoard1);
            this.customPanel2.Controls.Add(this.editProfile1);
            this.customPanel2.Controls.Add(this.empAttendance1);
            this.customPanel2.Controls.Add(this.printPaySlip1);
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 90F;
            this.customPanel2.GradientTopColor = System.Drawing.SystemColors.ControlLight;
            this.customPanel2.GradinetAngle = System.Drawing.SystemColors.ControlLight;
            this.customPanel2.Location = new System.Drawing.Point(196, 83);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(904, 616);
            this.customPanel2.TabIndex = 7;
            // 
            // employeeDBoard1
            // 
            this.employeeDBoard1.BackColor = System.Drawing.SystemColors.Control;
            this.employeeDBoard1.Location = new System.Drawing.Point(-3, 1);
            this.employeeDBoard1.Name = "employeeDBoard1";
            this.employeeDBoard1.Size = new System.Drawing.Size(904, 615);
            this.employeeDBoard1.TabIndex = 2;
            // 
            // editProfile1
            // 
            this.editProfile1.BackColor = System.Drawing.SystemColors.Control;
            this.editProfile1.Location = new System.Drawing.Point(3, 3);
            this.editProfile1.Name = "editProfile1";
            this.editProfile1.Size = new System.Drawing.Size(901, 610);
            this.editProfile1.TabIndex = 1;
            // 
            // empAttendance1
            // 
            this.empAttendance1.BackColor = System.Drawing.SystemColors.Control;
            this.empAttendance1.Location = new System.Drawing.Point(0, -3);
            this.empAttendance1.Name = "empAttendance1";
            this.empAttendance1.Size = new System.Drawing.Size(904, 616);
            this.empAttendance1.TabIndex = 3;
            // 
            // printPaySlip1
            // 
            this.printPaySlip1.Location = new System.Drawing.Point(-3, -3);
            this.printPaySlip1.Name = "printPaySlip1";
            this.printPaySlip1.Size = new System.Drawing.Size(907, 619);
            this.printPaySlip1.TabIndex = 4;
            // 
            // customPanel6
            // 
            this.customPanel6.BackColor = System.Drawing.Color.White;
            this.customPanel6.BorderRadius = 20;
            this.customPanel6.Controls.Add(this.logoutBtn);
            this.customPanel6.Controls.Add(this.salaryBtn);
            this.customPanel6.Controls.Add(this.picEmp);
            this.customPanel6.Controls.Add(this.myProfileBtn);
            this.customPanel6.Controls.Add(this.customPanel4);
            this.customPanel6.Controls.Add(this.attendanceBtn);
            this.customPanel6.Controls.Add(this.dashboardBtn);
            this.customPanel6.Controls.Add(this.labelfirstname);
            this.customPanel6.ForeColor = System.Drawing.Color.Black;
            this.customPanel6.GradientAngle = 90F;
            this.customPanel6.GradientTopColor = System.Drawing.Color.White;
            this.customPanel6.GradinetAngle = System.Drawing.Color.White;
            this.customPanel6.Location = new System.Drawing.Point(-1, 80);
            this.customPanel6.Name = "customPanel6";
            this.customPanel6.Size = new System.Drawing.Size(191, 641);
            this.customPanel6.TabIndex = 6;
            // 
            // salaryBtn
            // 
            this.salaryBtn.BackColor = System.Drawing.Color.White;
            this.salaryBtn.FlatAppearance.BorderSize = 0;
            this.salaryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salaryBtn.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            this.salaryBtn.IconColor = System.Drawing.Color.Black;
            this.salaryBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.salaryBtn.IconSize = 30;
            this.salaryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salaryBtn.Location = new System.Drawing.Point(1, 291);
            this.salaryBtn.Name = "salaryBtn";
            this.salaryBtn.Size = new System.Drawing.Size(191, 49);
            this.salaryBtn.TabIndex = 18;
            this.salaryBtn.Text = "Salary";
            this.salaryBtn.UseVisualStyleBackColor = false;
            this.salaryBtn.Click += new System.EventHandler(this.salaryBtn_Click);
            // 
            // picEmp
            // 
            this.picEmp.BackColor = System.Drawing.Color.White;
            this.picEmp.ForeColor = System.Drawing.Color.Black;
            this.picEmp.IconChar = FontAwesome.Sharp.IconChar.None;
            this.picEmp.IconColor = System.Drawing.Color.Black;
            this.picEmp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picEmp.IconSize = 90;
            this.picEmp.Location = new System.Drawing.Point(44, 26);
            this.picEmp.Name = "picEmp";
            this.picEmp.Size = new System.Drawing.Size(95, 90);
            this.picEmp.TabIndex = 17;
            this.picEmp.TabStop = false;
            // 
            // myProfileBtn
            // 
            this.myProfileBtn.FlatAppearance.BorderSize = 0;
            this.myProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myProfileBtn.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.myProfileBtn.IconColor = System.Drawing.Color.Black;
            this.myProfileBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.myProfileBtn.IconSize = 35;
            this.myProfileBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.myProfileBtn.Location = new System.Drawing.Point(0, 344);
            this.myProfileBtn.Name = "myProfileBtn";
            this.myProfileBtn.Size = new System.Drawing.Size(191, 50);
            this.myProfileBtn.TabIndex = 16;
            this.myProfileBtn.Text = "My Profile";
            this.myProfileBtn.UseVisualStyleBackColor = true;
            this.myProfileBtn.Click += new System.EventHandler(this.myProfileBtn_Click_1);
            // 
            // customPanel4
            // 
            this.customPanel4.BackColor = System.Drawing.Color.LightGray;
            this.customPanel4.BorderRadius = 0;
            this.customPanel4.ForeColor = System.Drawing.Color.Black;
            this.customPanel4.GradientAngle = 90F;
            this.customPanel4.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.customPanel4.GradinetAngle = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.customPanel4.Location = new System.Drawing.Point(-1, 231);
            this.customPanel4.Name = "customPanel4";
            this.customPanel4.Size = new System.Drawing.Size(198, 3);
            this.customPanel4.TabIndex = 14;
            // 
            // attendanceBtn
            // 
            this.attendanceBtn.BackColor = System.Drawing.Color.White;
            this.attendanceBtn.FlatAppearance.BorderSize = 0;
            this.attendanceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attendanceBtn.IconChar = FontAwesome.Sharp.IconChar.ClipboardUser;
            this.attendanceBtn.IconColor = System.Drawing.Color.Black;
            this.attendanceBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.attendanceBtn.IconSize = 35;
            this.attendanceBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.attendanceBtn.Location = new System.Drawing.Point(0, 237);
            this.attendanceBtn.Name = "attendanceBtn";
            this.attendanceBtn.Size = new System.Drawing.Size(191, 50);
            this.attendanceBtn.TabIndex = 15;
            this.attendanceBtn.Text = "Attendance";
            this.attendanceBtn.UseVisualStyleBackColor = false;
            this.attendanceBtn.Click += new System.EventHandler(this.attendanceBtn_Click_1);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackColor = System.Drawing.Color.White;
            this.dashboardBtn.FlatAppearance.BorderSize = 0;
            this.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBtn.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.dashboardBtn.IconColor = System.Drawing.Color.Black;
            this.dashboardBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dashboardBtn.IconSize = 35;
            this.dashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.Location = new System.Drawing.Point(0, 184);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(191, 50);
            this.dashboardBtn.TabIndex = 14;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.UseVisualStyleBackColor = false;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // labelfirstname
            // 
            this.labelfirstname.AutoSize = true;
            this.labelfirstname.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfirstname.ForeColor = System.Drawing.Color.Black;
            this.labelfirstname.Location = new System.Drawing.Point(18, 129);
            this.labelfirstname.Name = "labelfirstname";
            this.labelfirstname.Size = new System.Drawing.Size(62, 21);
            this.labelfirstname.TabIndex = 9;
            this.labelfirstname.Text = "label4";
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 30;
            this.customPanel1.Controls.Add(this.label1);
            this.customPanel1.Controls.Add(this.label2);
            this.customPanel1.Controls.Add(this.label3);
            this.customPanel1.Controls.Add(this.customPanel5);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientTopColor = System.Drawing.Color.White;
            this.customPanel1.GradinetAngle = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(-3, -4);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(1103, 81);
            this.customPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Welcome, Employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(861, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(859, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // customPanel5
            // 
            this.customPanel5.BackColor = System.Drawing.Color.White;
            this.customPanel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("customPanel5.BackgroundImage")));
            this.customPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customPanel5.BorderRadius = 60;
            this.customPanel5.ForeColor = System.Drawing.Color.Black;
            this.customPanel5.GradientAngle = 90F;
            this.customPanel5.GradientTopColor = System.Drawing.Color.Transparent;
            this.customPanel5.GradinetAngle = System.Drawing.Color.Transparent;
            this.customPanel5.Location = new System.Drawing.Point(13, 14);
            this.customPanel5.Name = "customPanel5";
            this.customPanel5.Size = new System.Drawing.Size(59, 60);
            this.customPanel5.TabIndex = 5;
            // 
            // logoutBtn
            // 
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.logoutBtn.IconColor = System.Drawing.Color.Black;
            this.logoutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logoutBtn.IconSize = 30;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(1, 558);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(191, 50);
            this.logoutBtn.TabIndex = 19;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // EmployeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.customPanel6);
            this.Controls.Add(this.customPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeDashboard";
            this.Load += new System.EventHandler(this.EmployeeDashboard_Load);
            this.customPanel2.ResumeLayout(false);
            this.customPanel6.ResumeLayout(false);
            this.customPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmp)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private customPanel customPanel1;
        private customPanel customPanel5;
        private customPanel customPanel6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private customPanel customPanel2;
        private EmpAttendance attendace1;
        private EditProfile editProfile1;
        private EmployeeDBoard employeeDBoard1;
        public System.Windows.Forms.Label labelfirstname;
        public System.Windows.Forms.Label label1;
        private EmpAttendance empAttendance1;
        private customPanel customPanel4;
        private FontAwesome.Sharp.IconButton dashboardBtn;
        private FontAwesome.Sharp.IconButton attendanceBtn;
        private FontAwesome.Sharp.IconButton myProfileBtn;
        public FontAwesome.Sharp.IconPictureBox picEmp;
        private FontAwesome.Sharp.IconButton salaryBtn;
        private PrintPaySlip printPaySlip1;
        private FontAwesome.Sharp.IconButton logoutBtn;
    }
}