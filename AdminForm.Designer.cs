namespace EMS
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.customPanel2 = new EMS.customPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customPanel3 = new EMS.customPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dashboard1 = new EMS.Dashboard();
            this.salary1 = new EMS.Salary();
            this.addEmployee1 = new EMS.AddEmployee();
            this.addHr1 = new EMS.AddDept();
            this.logHistory1 = new EMS.LogHistory();
            this.archive1 = new EMS.Archive();
            this.attendance1 = new EMS.Attendance();
            this.viewAuditLogs1 = new EMS.AuditLogs();
            this.customPanel1 = new EMS.customPanel();
            this.LogHistoryBtn = new FontAwesome.Sharp.IconButton();
            this.archiveBtn = new FontAwesome.Sharp.IconButton();
            this.attendanceBtn = new FontAwesome.Sharp.IconButton();
            this.AddEmpBttn = new FontAwesome.Sharp.IconButton();
            this.AddDepartmentBttn = new FontAwesome.Sharp.IconButton();
            this.customPanel4 = new EMS.customPanel();
            this.dashboardBttn = new FontAwesome.Sharp.IconButton();
            this.SalaryBtn = new FontAwesome.Sharp.IconButton();
            this.btnAuditlogs = new FontAwesome.Sharp.IconButton();
            this.logoutbtn = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.customPanel2.SuspendLayout();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dashboard1);
            this.panel1.Controls.Add(this.salary1);
            this.panel1.Controls.Add(this.addEmployee1);
            this.panel1.Controls.Add(this.addHr1);
            this.panel1.Controls.Add(this.logHistory1);
            this.panel1.Controls.Add(this.archive1);
            this.panel1.Controls.Add(this.attendance1);
            this.panel1.Controls.Add(this.viewAuditLogs1);
            this.panel1.Location = new System.Drawing.Point(194, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 626);
            this.panel1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderRadius = 30;
            this.customPanel2.Controls.Add(this.label3);
            this.customPanel2.Controls.Add(this.label2);
            this.customPanel2.Controls.Add(this.customPanel3);
            this.customPanel2.Controls.Add(this.label1);
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 90F;
            this.customPanel2.GradientTopColor = System.Drawing.Color.White;
            this.customPanel2.GradinetAngle = System.Drawing.Color.White;
            this.customPanel2.Location = new System.Drawing.Point(-3, -7);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(1103, 81);
            this.customPanel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(859, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(861, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.Color.White;
            this.customPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("customPanel3.BackgroundImage")));
            this.customPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customPanel3.BorderRadius = 60;
            this.customPanel3.ForeColor = System.Drawing.Color.Black;
            this.customPanel3.GradientAngle = 90F;
            this.customPanel3.GradientTopColor = System.Drawing.Color.Transparent;
            this.customPanel3.GradinetAngle = System.Drawing.Color.Transparent;
            this.customPanel3.Location = new System.Drawing.Point(13, 15);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(59, 60);
            this.customPanel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Poging Admin";
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dashboard1.Location = new System.Drawing.Point(0, 3);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(904, 620);
            this.dashboard1.TabIndex = 2;
            // 
            // salary1
            // 
            this.salary1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.salary1.Location = new System.Drawing.Point(0, 5);
            this.salary1.Name = "salary1";
            this.salary1.Size = new System.Drawing.Size(904, 618);
            this.salary1.TabIndex = 1;
            // 
            // addEmployee1
            // 
            this.addEmployee1.Location = new System.Drawing.Point(0, 8);
            this.addEmployee1.Name = "addEmployee1";
            this.addEmployee1.Size = new System.Drawing.Size(907, 618);
            this.addEmployee1.TabIndex = 0;
            // 
            // addHr1
            // 
            this.addHr1.Location = new System.Drawing.Point(2, 5);
            this.addHr1.Name = "addHr1";
            this.addHr1.Size = new System.Drawing.Size(904, 618);
            this.addHr1.TabIndex = 3;
            // 
            // logHistory1
            // 
            this.logHistory1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.logHistory1.Location = new System.Drawing.Point(-1, 3);
            this.logHistory1.Name = "logHistory1";
            this.logHistory1.Size = new System.Drawing.Size(908, 623);
            this.logHistory1.TabIndex = 4;
            // 
            // archive1
            // 
            this.archive1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.archive1.Location = new System.Drawing.Point(-1, 3);
            this.archive1.Name = "archive1";
            this.archive1.Size = new System.Drawing.Size(907, 623);
            this.archive1.TabIndex = 5;
            // 
            // attendance1
            // 
            this.attendance1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.attendance1.Location = new System.Drawing.Point(0, 5);
            this.attendance1.Name = "attendance1";
            this.attendance1.Size = new System.Drawing.Size(904, 618);
            this.attendance1.TabIndex = 6;
            // 
            // viewAuditLogs1
            // 
            this.viewAuditLogs1.Location = new System.Drawing.Point(-2, 5);
            this.viewAuditLogs1.Name = "viewAuditLogs1";
            this.viewAuditLogs1.Size = new System.Drawing.Size(906, 619);
            this.viewAuditLogs1.TabIndex = 7;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 20;
            this.customPanel1.Controls.Add(this.logoutbtn);
            this.customPanel1.Controls.Add(this.btnAuditlogs);
            this.customPanel1.Controls.Add(this.SalaryBtn);
            this.customPanel1.Controls.Add(this.LogHistoryBtn);
            this.customPanel1.Controls.Add(this.archiveBtn);
            this.customPanel1.Controls.Add(this.attendanceBtn);
            this.customPanel1.Controls.Add(this.AddEmpBttn);
            this.customPanel1.Controls.Add(this.AddDepartmentBttn);
            this.customPanel1.Controls.Add(this.customPanel4);
            this.customPanel1.Controls.Add(this.dashboardBttn);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientTopColor = System.Drawing.Color.White;
            this.customPanel1.GradinetAngle = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(-1, 77);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(191, 644);
            this.customPanel1.TabIndex = 0;
            // 
            // LogHistoryBtn
            // 
            this.LogHistoryBtn.BackColor = System.Drawing.Color.White;
            this.LogHistoryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogHistoryBtn.FlatAppearance.BorderSize = 0;
            this.LogHistoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogHistoryBtn.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.LogHistoryBtn.IconColor = System.Drawing.Color.Black;
            this.LogHistoryBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LogHistoryBtn.IconSize = 33;
            this.LogHistoryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogHistoryBtn.Location = new System.Drawing.Point(2, 363);
            this.LogHistoryBtn.Name = "LogHistoryBtn";
            this.LogHistoryBtn.Size = new System.Drawing.Size(191, 50);
            this.LogHistoryBtn.TabIndex = 25;
            this.LogHistoryBtn.Text = "Log History";
            this.LogHistoryBtn.UseVisualStyleBackColor = false;
            this.LogHistoryBtn.Click += new System.EventHandler(this.LogHistoryBtn_Click_1);
            // 
            // archiveBtn
            // 
            this.archiveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.archiveBtn.FlatAppearance.BorderSize = 0;
            this.archiveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.archiveBtn.IconChar = FontAwesome.Sharp.IconChar.Archive;
            this.archiveBtn.IconColor = System.Drawing.Color.Black;
            this.archiveBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.archiveBtn.IconSize = 35;
            this.archiveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.archiveBtn.Location = new System.Drawing.Point(1, 310);
            this.archiveBtn.Name = "archiveBtn";
            this.archiveBtn.Size = new System.Drawing.Size(191, 50);
            this.archiveBtn.TabIndex = 24;
            this.archiveBtn.Text = "Archive";
            this.archiveBtn.UseVisualStyleBackColor = true;
            this.archiveBtn.Click += new System.EventHandler(this.archiveBtn_Click_1);
            // 
            // attendanceBtn
            // 
            this.attendanceBtn.BackColor = System.Drawing.Color.White;
            this.attendanceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.attendanceBtn.FlatAppearance.BorderSize = 0;
            this.attendanceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attendanceBtn.IconChar = FontAwesome.Sharp.IconChar.ClipboardUser;
            this.attendanceBtn.IconColor = System.Drawing.Color.Black;
            this.attendanceBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.attendanceBtn.IconSize = 33;
            this.attendanceBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.attendanceBtn.Location = new System.Drawing.Point(1, 254);
            this.attendanceBtn.Name = "attendanceBtn";
            this.attendanceBtn.Size = new System.Drawing.Size(191, 50);
            this.attendanceBtn.TabIndex = 23;
            this.attendanceBtn.Text = "Attendance";
            this.attendanceBtn.UseVisualStyleBackColor = false;
            this.attendanceBtn.Click += new System.EventHandler(this.iconButton1_Click_2);
            // 
            // AddEmpBttn
            // 
            this.AddEmpBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddEmpBttn.FlatAppearance.BorderSize = 0;
            this.AddEmpBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmpBttn.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.AddEmpBttn.IconColor = System.Drawing.Color.Black;
            this.AddEmpBttn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddEmpBttn.IconSize = 40;
            this.AddEmpBttn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddEmpBttn.Location = new System.Drawing.Point(0, 198);
            this.AddEmpBttn.Name = "AddEmpBttn";
            this.AddEmpBttn.Size = new System.Drawing.Size(191, 50);
            this.AddEmpBttn.TabIndex = 22;
            this.AddEmpBttn.Text = "Employee";
            this.AddEmpBttn.UseVisualStyleBackColor = true;
            this.AddEmpBttn.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // AddDepartmentBttn
            // 
            this.AddDepartmentBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddDepartmentBttn.FlatAppearance.BorderSize = 0;
            this.AddDepartmentBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDepartmentBttn.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.AddDepartmentBttn.IconColor = System.Drawing.Color.Black;
            this.AddDepartmentBttn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddDepartmentBttn.IconSize = 35;
            this.AddDepartmentBttn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddDepartmentBttn.Location = new System.Drawing.Point(-2, 144);
            this.AddDepartmentBttn.Name = "AddDepartmentBttn";
            this.AddDepartmentBttn.Size = new System.Drawing.Size(194, 50);
            this.AddDepartmentBttn.TabIndex = 21;
            this.AddDepartmentBttn.Text = "Department";
            this.AddDepartmentBttn.UseVisualStyleBackColor = true;
            this.AddDepartmentBttn.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // customPanel4
            // 
            this.customPanel4.BackColor = System.Drawing.Color.LightGray;
            this.customPanel4.BorderRadius = 0;
            this.customPanel4.ForeColor = System.Drawing.Color.Black;
            this.customPanel4.GradientAngle = 90F;
            this.customPanel4.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.customPanel4.GradinetAngle = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.customPanel4.Location = new System.Drawing.Point(-1, 138);
            this.customPanel4.Name = "customPanel4";
            this.customPanel4.Size = new System.Drawing.Size(193, 3);
            this.customPanel4.TabIndex = 4;
            // 
            // dashboardBttn
            // 
            this.dashboardBttn.BackColor = System.Drawing.Color.White;
            this.dashboardBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardBttn.FlatAppearance.BorderSize = 0;
            this.dashboardBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBttn.ForeColor = System.Drawing.Color.Black;
            this.dashboardBttn.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.dashboardBttn.IconColor = System.Drawing.Color.Black;
            this.dashboardBttn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dashboardBttn.IconSize = 30;
            this.dashboardBttn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBttn.Location = new System.Drawing.Point(0, 91);
            this.dashboardBttn.Name = "dashboardBttn";
            this.dashboardBttn.Size = new System.Drawing.Size(191, 50);
            this.dashboardBttn.TabIndex = 20;
            this.dashboardBttn.Text = "Dashboad";
            this.dashboardBttn.UseVisualStyleBackColor = false;
            this.dashboardBttn.Click += new System.EventHandler(this.dashboardBttn_Click_1);
            // 
            // SalaryBtn
            // 
            this.SalaryBtn.BackColor = System.Drawing.Color.White;
            this.SalaryBtn.FlatAppearance.BorderSize = 0;
            this.SalaryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalaryBtn.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            this.SalaryBtn.IconColor = System.Drawing.Color.Black;
            this.SalaryBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SalaryBtn.IconSize = 35;
            this.SalaryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalaryBtn.Location = new System.Drawing.Point(1, 417);
            this.SalaryBtn.Name = "SalaryBtn";
            this.SalaryBtn.Size = new System.Drawing.Size(191, 50);
            this.SalaryBtn.TabIndex = 26;
            this.SalaryBtn.Text = "Payroll";
            this.SalaryBtn.UseVisualStyleBackColor = false;
            this.SalaryBtn.Click += new System.EventHandler(this.SalaryBtn_Click_1);
            // 
            // btnAuditlogs
            // 
            this.btnAuditlogs.FlatAppearance.BorderSize = 0;
            this.btnAuditlogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuditlogs.IconChar = FontAwesome.Sharp.IconChar.BoxesPacking;
            this.btnAuditlogs.IconColor = System.Drawing.Color.Black;
            this.btnAuditlogs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAuditlogs.IconSize = 35;
            this.btnAuditlogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuditlogs.Location = new System.Drawing.Point(1, 471);
            this.btnAuditlogs.Name = "btnAuditlogs";
            this.btnAuditlogs.Size = new System.Drawing.Size(191, 50);
            this.btnAuditlogs.TabIndex = 27;
            this.btnAuditlogs.Text = "Audit Logs";
            this.btnAuditlogs.UseVisualStyleBackColor = true;
            this.btnAuditlogs.Click += new System.EventHandler(this.btnAuditlogs_Click_1);
            // 
            // logoutbtn
            // 
            this.logoutbtn.FlatAppearance.BorderSize = 0;
            this.logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutbtn.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.logoutbtn.IconColor = System.Drawing.Color.Black;
            this.logoutbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logoutbtn.IconSize = 35;
            this.logoutbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutbtn.Location = new System.Drawing.Point(1, 558);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(191, 50);
            this.logoutbtn.TabIndex = 28;
            this.logoutbtn.Text = "Log Out";
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            this.customPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private customPanel customPanel1;
        private AddEmployee addEmployee1;
        private Salary salary1;
        private Dashboard dashboard1;
        private customPanel customPanel2;
        private System.Windows.Forms.Label label1;
        private customPanel customPanel3;
        private AddDept addHr1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private LogHistory logHistory1;
        private Archive archive1;
        private Attendance attendance1;
        private AuditLogs viewAuditLogs1;
        private customPanel customPanel4;
        private FontAwesome.Sharp.IconButton dashboardBttn;
        private FontAwesome.Sharp.IconButton AddDepartmentBttn;
        private FontAwesome.Sharp.IconButton AddEmpBttn;
        private FontAwesome.Sharp.IconButton attendanceBtn;
        private FontAwesome.Sharp.IconButton archiveBtn;
        private FontAwesome.Sharp.IconButton LogHistoryBtn;
        private FontAwesome.Sharp.IconButton SalaryBtn;
        private FontAwesome.Sharp.IconButton btnAuditlogs;
        private FontAwesome.Sharp.IconButton logoutbtn;
    }
}