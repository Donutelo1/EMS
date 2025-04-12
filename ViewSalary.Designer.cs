namespace EMS
{
    partial class ViewSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSalary));
            this.lblpayid = new System.Windows.Forms.Label();
            this.lblempid = new System.Windows.Forms.Label();
            this.lblnoofpres = new System.Windows.Forms.Label();
            this.lblsalary = new System.Windows.Forms.Label();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.lblupdate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblpayid
            // 
            this.lblpayid.AutoSize = true;
            this.lblpayid.Location = new System.Drawing.Point(16, 25);
            this.lblpayid.Name = "lblpayid";
            this.lblpayid.Size = new System.Drawing.Size(61, 20);
            this.lblpayid.TabIndex = 0;
            this.lblpayid.Text = "lblpayid";
            // 
            // lblempid
            // 
            this.lblempid.AutoSize = true;
            this.lblempid.Location = new System.Drawing.Point(146, 25);
            this.lblempid.Name = "lblempid";
            this.lblempid.Size = new System.Drawing.Size(67, 20);
            this.lblempid.TabIndex = 1;
            this.lblempid.Text = "lblempid";
            // 
            // lblnoofpres
            // 
            this.lblnoofpres.AutoSize = true;
            this.lblnoofpres.Location = new System.Drawing.Point(303, 25);
            this.lblnoofpres.Name = "lblnoofpres";
            this.lblnoofpres.Size = new System.Drawing.Size(80, 20);
            this.lblnoofpres.TabIndex = 2;
            this.lblnoofpres.Text = "no of pres";
            // 
            // lblsalary
            // 
            this.lblsalary.AutoSize = true;
            this.lblsalary.Location = new System.Drawing.Point(461, 25);
            this.lblsalary.Name = "lblsalary";
            this.lblsalary.Size = new System.Drawing.Size(51, 20);
            this.lblsalary.TabIndex = 3;
            this.lblsalary.Text = "label4";
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.Transparent;
            this.BtnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEdit.BackgroundImage")));
            this.BtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEdit.FlatAppearance.BorderSize = 0;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Location = new System.Drawing.Point(821, 21);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(25, 29);
            this.BtnEdit.TabIndex = 30;
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // lblupdate
            // 
            this.lblupdate.AutoSize = true;
            this.lblupdate.Location = new System.Drawing.Point(584, 25);
            this.lblupdate.Name = "lblupdate";
            this.lblupdate.Size = new System.Drawing.Size(93, 20);
            this.lblupdate.TabIndex = 31;
            this.lblupdate.Text = "4/11/2025 1";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(667, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 29);
            this.panel1.TabIndex = 32;
            // 
            // ViewSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblupdate);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.lblsalary);
            this.Controls.Add(this.lblnoofpres);
            this.Controls.Add(this.lblempid);
            this.Controls.Add(this.lblpayid);
            this.Name = "ViewSalary";
            this.Size = new System.Drawing.Size(894, 77);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblpayid;
        public System.Windows.Forms.Label lblempid;
        public System.Windows.Forms.Label lblnoofpres;
        public System.Windows.Forms.Label lblsalary;
        private System.Windows.Forms.Button BtnEdit;
        public System.Windows.Forms.Label lblupdate;
        private System.Windows.Forms.Panel panel1;
    }
}
