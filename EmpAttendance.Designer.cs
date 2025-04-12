namespace EMS
{
    partial class EmpAttendance
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.customPanel1 = new EMS.customPanel();
            this.dashboardEmpName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.customPanel3 = new EMS.customPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.csharp1 = new EMS.Csharp();
            this.timeInBtn = new System.Windows.Forms.Button();
            this.customPanel2 = new EMS.customPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTimeOut = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.csharp2 = new EMS.Csharp();
            this.timeOutBtn = new System.Windows.Forms.Button();
            this.monthlyreset = new System.Windows.Forms.Timer(this.components);
            this.customPanel1.SuspendLayout();
            this.customPanel3.SuspendLayout();
            this.customPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
//            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 20;
            this.customPanel1.Controls.Add(this.dashboardEmpName);
            this.customPanel1.Controls.Add(this.label5);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientTopColor = System.Drawing.Color.White;
            this.customPanel1.GradinetAngle = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(0, 1);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(904, 63);
            this.customPanel1.TabIndex = 3;
            // 
            // dashboardEmpName
            // 
            this.dashboardEmpName.AutoSize = true;
            this.dashboardEmpName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardEmpName.Location = new System.Drawing.Point(186, 23);
            this.dashboardEmpName.Name = "dashboardEmpName";
            this.dashboardEmpName.Size = new System.Drawing.Size(0, 21);
            this.dashboardEmpName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Welcome Back,";
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.Color.White;
            this.customPanel3.BorderRadius = 30;
            this.customPanel3.Controls.Add(this.label6);
            this.customPanel3.Controls.Add(this.txtEmpId);
            this.customPanel3.Controls.Add(this.panel1);
            this.customPanel3.Controls.Add(this.label3);
            this.customPanel3.Controls.Add(this.label1);
            this.customPanel3.Controls.Add(this.csharp1);
            this.customPanel3.Controls.Add(this.timeInBtn);
            this.customPanel3.ForeColor = System.Drawing.Color.Black;
            this.customPanel3.GradientAngle = 90F;
            this.customPanel3.GradientTopColor = System.Drawing.Color.White;
            this.customPanel3.GradinetAngle = System.Drawing.Color.White;
            this.customPanel3.Location = new System.Drawing.Point(1, 135);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(443, 323);
            this.customPanel3.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(17, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(270, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Click the time in button to time in";
            // 
            // txtEmpId
            // 
            this.txtEmpId.BackColor = System.Drawing.Color.White;
            this.txtEmpId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmpId.Enabled = false;
            this.txtEmpId.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpId.ForeColor = System.Drawing.Color.Gray;
            this.txtEmpId.Location = new System.Drawing.Point(25, 169);
            this.txtEmpId.Multiline = true;
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.ReadOnly = true;
            this.txtEmpId.Size = new System.Drawing.Size(374, 35);
            this.txtEmpId.TabIndex = 5;
            this.txtEmpId.Enter += new System.EventHandler(this.txtTimeIn_Enter);
            this.txtEmpId.Leave += new System.EventHandler(this.txtTimeIn_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(1, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 3);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter Employee ID to Time In";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "EMPLOYEE TIME-BOOK";
            // 
            // csharp1
            // 
            this.csharp1.BackColor = System.Drawing.Color.Transparent;
            this.csharp1.Br = System.Drawing.Color.White;
            this.csharp1.Enabled = false;
            this.csharp1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csharp1.ForeColor = System.Drawing.Color.Black;
            this.csharp1.Location = new System.Drawing.Point(17, 158);
            this.csharp1.Name = "csharp1";
            this.csharp1.Size = new System.Drawing.Size(394, 49);
            this.csharp1.TabIndex = 1;
            // 
            // timeInBtn
            // 
            this.timeInBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.timeInBtn.FlatAppearance.BorderSize = 0;
            this.timeInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeInBtn.ForeColor = System.Drawing.Color.White;
            this.timeInBtn.Location = new System.Drawing.Point(17, 252);
            this.timeInBtn.Name = "timeInBtn";
            this.timeInBtn.Size = new System.Drawing.Size(111, 39);
            this.timeInBtn.TabIndex = 0;
            this.timeInBtn.Text = "Time In";
            this.timeInBtn.UseVisualStyleBackColor = false;
            this.timeInBtn.Click += new System.EventHandler(this.timeInBtn_Click);
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderRadius = 30;
            this.customPanel2.Controls.Add(this.label7);
            this.customPanel2.Controls.Add(this.txtTimeOut);
            this.customPanel2.Controls.Add(this.panel2);
            this.customPanel2.Controls.Add(this.label4);
            this.customPanel2.Controls.Add(this.label2);
            this.customPanel2.Controls.Add(this.csharp2);
            this.customPanel2.Controls.Add(this.timeOutBtn);
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 90F;
            this.customPanel2.GradientTopColor = System.Drawing.Color.White;
            this.customPanel2.GradinetAngle = System.Drawing.Color.White;
            this.customPanel2.Location = new System.Drawing.Point(458, 135);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(443, 323);
            this.customPanel2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(23, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(298, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Click the time out button to time out";
            // 
            // txtTimeOut
            // 
            this.txtTimeOut.BackColor = System.Drawing.Color.White;
            this.txtTimeOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimeOut.Enabled = false;
            this.txtTimeOut.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeOut.ForeColor = System.Drawing.Color.Gray;
            this.txtTimeOut.Location = new System.Drawing.Point(27, 166);
            this.txtTimeOut.Multiline = true;
            this.txtTimeOut.Name = "txtTimeOut";
            this.txtTimeOut.Size = new System.Drawing.Size(374, 35);
            this.txtTimeOut.TabIndex = 6;
            this.txtTimeOut.Enter += new System.EventHandler(this.txtTimeOut_Enter);
            this.txtTimeOut.Leave += new System.EventHandler(this.txtTimeOut_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 3);
            this.panel2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Enter Employee ID to Time Out";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "EMPLOYEE TIME-BOOK";
            // 
            // csharp2
            // 
            this.csharp2.BackColor = System.Drawing.Color.Transparent;
            this.csharp2.Br = System.Drawing.Color.White;
            this.csharp2.Enabled = false;
            this.csharp2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csharp2.ForeColor = System.Drawing.Color.Black;
            this.csharp2.Location = new System.Drawing.Point(20, 155);
            this.csharp2.Name = "csharp2";
            this.csharp2.Size = new System.Drawing.Size(394, 49);
            this.csharp2.TabIndex = 2;
            // 
            // timeOutBtn
            // 
            this.timeOutBtn.BackColor = System.Drawing.Color.IndianRed;
            this.timeOutBtn.FlatAppearance.BorderSize = 0;
            this.timeOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeOutBtn.ForeColor = System.Drawing.Color.White;
            this.timeOutBtn.Location = new System.Drawing.Point(20, 249);
            this.timeOutBtn.Name = "timeOutBtn";
            this.timeOutBtn.Size = new System.Drawing.Size(111, 39);
            this.timeOutBtn.TabIndex = 1;
            this.timeOutBtn.Text = "Time Out";
            this.timeOutBtn.UseVisualStyleBackColor = false;
            this.timeOutBtn.Click += new System.EventHandler(this.timeOutBtn_Click);
            // 
            // monthlyreset
            // 
            this.monthlyreset.Tick += new System.EventHandler(this.monthlyreset_Tick);
            // 
            // EmpAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.customPanel3);
            this.Controls.Add(this.customPanel2);
            this.Name = "EmpAttendance";
            this.Size = new System.Drawing.Size(904, 616);
            this.Load += new System.EventHandler(this.Attendace_Load);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.customPanel3.ResumeLayout(false);
            this.customPanel3.PerformLayout();
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private customPanel customPanel2;
        private customPanel customPanel3;
        private System.Windows.Forms.Button timeInBtn;
        private Csharp csharp2;
        private System.Windows.Forms.Button timeOutBtn;
        private Csharp csharp1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTimeOut;
        private customPanel customPanel1;
        private System.Windows.Forms.Label dashboardEmpName;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer monthlyreset;
    }
}
