namespace EMS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.loginlbl = new System.Windows.Forms.Label();
            this.exitBttn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnmin = new System.Windows.Forms.Button();
            this.showPassBttn = new System.Windows.Forms.Button();
            this.hidePassBttn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.logInBttn = new FontAwesome.Sharp.IconButton();
            this.txtPword = new EMS.RountTextBoxPassword();
            this.txtUname = new EMS.RoundTextBox();
            this.customPanel1 = new EMS.customPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customPanel2 = new EMS.customPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginlbl
            // 
            this.loginlbl.AutoSize = true;
            this.loginlbl.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginlbl.ForeColor = System.Drawing.Color.Black;
            this.loginlbl.Location = new System.Drawing.Point(457, 57);
            this.loginlbl.Name = "loginlbl";
            this.loginlbl.Size = new System.Drawing.Size(216, 39);
            this.loginlbl.TabIndex = 25;
            this.loginlbl.Text = "Admin Panel";
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
            this.exitBttn.Location = new System.Drawing.Point(736, 5);
            this.exitBttn.Name = "exitBttn";
            this.exitBttn.Size = new System.Drawing.Size(35, 32);
            this.exitBttn.TabIndex = 24;
            this.exitBttn.Text = "X";
            this.exitBttn.UseVisualStyleBackColor = false;
            this.exitBttn.Click += new System.EventHandler(this.exitBttn_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(404, 356);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(138, 20);
            this.linkLabel1.TabIndex = 36;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot Password?";
            // 
            // btnmin
            // 
            this.btnmin.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnmin.BackColor = System.Drawing.SystemColors.Control;
            this.btnmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmin.FlatAppearance.BorderSize = 0;
            this.btnmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmin.Location = new System.Drawing.Point(697, 5);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(35, 32);
            this.btnmin.TabIndex = 72;
            this.btnmin.Text = "--";
            this.btnmin.UseVisualStyleBackColor = false;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // showPassBttn
            // 
            this.showPassBttn.BackColor = System.Drawing.SystemColors.Control;
            this.showPassBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPassBttn.FlatAppearance.BorderSize = 0;
            this.showPassBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPassBttn.Image = ((System.Drawing.Image)(resources.GetObject("showPassBttn.Image")));
            this.showPassBttn.Location = new System.Drawing.Point(726, 224);
            this.showPassBttn.Name = "showPassBttn";
            this.showPassBttn.Size = new System.Drawing.Size(38, 35);
            this.showPassBttn.TabIndex = 76;
            this.showPassBttn.UseVisualStyleBackColor = false;
            this.showPassBttn.Click += new System.EventHandler(this.showPassBttn_Click_1);
            // 
            // hidePassBttn
            // 
            this.hidePassBttn.BackColor = System.Drawing.Color.Transparent;
            this.hidePassBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hidePassBttn.FlatAppearance.BorderSize = 0;
            this.hidePassBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hidePassBttn.Image = ((System.Drawing.Image)(resources.GetObject("hidePassBttn.Image")));
            this.hidePassBttn.Location = new System.Drawing.Point(726, 224);
            this.hidePassBttn.Name = "hidePassBttn";
            this.hidePassBttn.Size = new System.Drawing.Size(38, 35);
            this.hidePassBttn.TabIndex = 75;
            this.hidePassBttn.UseVisualStyleBackColor = false;
            this.hidePassBttn.Click += new System.EventHandler(this.hidePassBttn_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(407, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 74;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(409, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 73;
            this.label8.Text = "Username";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(376, 141);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 83;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(376, 234);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.IndianRed;
            this.label5.Location = new System.Drawing.Point(417, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(417, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 88;
            // 
            // logInBttn
            // 
            this.logInBttn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.logInBttn.FlatAppearance.BorderSize = 0;
            this.logInBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logInBttn.ForeColor = System.Drawing.Color.White;
            this.logInBttn.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.logInBttn.IconColor = System.Drawing.Color.Black;
            this.logInBttn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logInBttn.IconSize = 30;
            this.logInBttn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logInBttn.Location = new System.Drawing.Point(408, 312);
            this.logInBttn.Name = "logInBttn";
            this.logInBttn.Size = new System.Drawing.Size(314, 40);
            this.logInBttn.TabIndex = 89;
            this.logInBttn.Text = "LogIn";
            this.logInBttn.UseVisualStyleBackColor = false;
            this.logInBttn.Click += new System.EventHandler(this.logInBttn_Click_1);
            // 
            // txtPword
            // 
            this.txtPword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPword.BorderColorFocus = System.Drawing.Color.Cyan;
            this.txtPword.BorderRadius = 10;
            this.txtPword.BorderSize = 1;
            this.txtPword.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPword.Location = new System.Drawing.Point(408, 225);
            this.txtPword.MultiLine = true;
            this.txtPword.Name = "txtPword";
            this.txtPword.PasswordChar = true;
            this.txtPword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPword.Placeholdertext = "";
            this.txtPword.Size = new System.Drawing.Size(315, 43);
            this.txtPword.TabIndex = 87;
            this.txtPword.Texts = "";
            this.txtPword.UnderlinedStyle = false;
            this.txtPword._TextChanged += new System.EventHandler(this.txtPword__TextChanged);
            // 
            // txtUname
            // 
            this.txtUname.BackColor = System.Drawing.SystemColors.Control;
            this.txtUname.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtUname.BorderColorFocus = System.Drawing.Color.Cyan;
            this.txtUname.BorderRadius = 10;
            this.txtUname.BorderSize = 1;
            this.txtUname.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUname.Location = new System.Drawing.Point(408, 130);
            this.txtUname.MultiLine = true;
            this.txtUname.Name = "txtUname";
            this.txtUname.PasswordChar = true;
            this.txtUname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUname.Placeholdertext = "Enter Username";
            this.txtUname.Size = new System.Drawing.Size(315, 43);
            this.txtUname.TabIndex = 85;
            this.txtUname.Texts = "";
            this.txtUname.UnderlinedStyle = false;
            this.txtUname._TextChanged += new System.EventHandler(this.txtUname__TextChanged);
            this.txtUname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUname_KeyDown);
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 100;
            this.customPanel1.Controls.Add(this.label4);
            this.customPanel1.Controls.Add(this.label3);
            this.customPanel1.Controls.Add(this.customPanel2);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientTopColor = System.Drawing.Color.SlateBlue;
            this.customPanel1.GradinetAngle = System.Drawing.Color.MediumPurple;
            this.customPanel1.Location = new System.Drawing.Point(-41, -2);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(387, 408);
            this.customPanel1.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(165, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 72;
            this.label4.Text = "System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(87, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 23);
            this.label3.TabIndex = 71;
            this.label3.Text = "Employee Management";
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("customPanel2.BackgroundImage")));
            this.customPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customPanel2.BorderRadius = 117;
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 90F;
            this.customPanel2.GradientTopColor = System.Drawing.Color.Transparent;
            this.customPanel2.GradinetAngle = System.Drawing.Color.Transparent;
            this.customPanel2.Location = new System.Drawing.Point(145, 87);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(116, 116);
            this.customPanel2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(776, 405);
            this.Controls.Add(this.logInBttn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPword);
            this.Controls.Add(this.txtUname);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.showPassBttn);
            this.Controls.Add(this.hidePassBttn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnmin);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.loginlbl);
            this.Controls.Add(this.exitBttn);
            this.Controls.Add(this.customPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label loginlbl;
        private System.Windows.Forms.Button exitBttn;
        private customPanel customPanel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Timer timer1;
        private customPanel customPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnmin;
        private System.Windows.Forms.Button showPassBttn;
        private System.Windows.Forms.Button hidePassBttn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private RoundTextBox txtUname;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RountTextBoxPassword txtPword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton logInBttn;
    }
}

