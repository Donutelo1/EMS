namespace EMS
{
    partial class ViewLogHistory
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
            this.customPanel1 = new EMS.customPanel();
            this.lblLName = new System.Windows.Forms.Label();
            this.lbllastupdate = new System.Windows.Forms.Label();
            this.lbllog = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblaccounttype = new System.Windows.Forms.Label();
            this.lblaccountid = new System.Windows.Forms.Label();
            this.lbllogid = new System.Windows.Forms.Label();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 10;
            this.customPanel1.Controls.Add(this.lblLName);
            this.customPanel1.Controls.Add(this.lbllastupdate);
            this.customPanel1.Controls.Add(this.lbllog);
            this.customPanel1.Controls.Add(this.lblFName);
            this.customPanel1.Controls.Add(this.lblaccounttype);
            this.customPanel1.Controls.Add(this.lblaccountid);
            this.customPanel1.Controls.Add(this.lbllogid);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientTopColor = System.Drawing.Color.White;
            this.customPanel1.GradinetAngle = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(1, 1);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(894, 73);
            this.customPanel1.TabIndex = 0;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.BackColor = System.Drawing.Color.White;
            this.lblLName.ForeColor = System.Drawing.Color.IndianRed;
            this.lblLName.Location = new System.Drawing.Point(402, 38);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(0, 20);
            this.lblLName.TabIndex = 19;
            // 
            // lbllastupdate
            // 
            this.lbllastupdate.AutoSize = true;
            this.lbllastupdate.BackColor = System.Drawing.Color.White;
            this.lbllastupdate.ForeColor = System.Drawing.Color.IndianRed;
            this.lbllastupdate.Location = new System.Drawing.Point(712, 32);
            this.lbllastupdate.Name = "lbllastupdate";
            this.lbllastupdate.Size = new System.Drawing.Size(0, 20);
            this.lbllastupdate.TabIndex = 18;
            // 
            // lbllog
            // 
            this.lbllog.AutoSize = true;
            this.lbllog.BackColor = System.Drawing.Color.White;
            this.lbllog.ForeColor = System.Drawing.Color.IndianRed;
            this.lbllog.Location = new System.Drawing.Point(561, 32);
            this.lbllog.Name = "lbllog";
            this.lbllog.Size = new System.Drawing.Size(0, 20);
            this.lbllog.TabIndex = 17;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.BackColor = System.Drawing.Color.White;
            this.lblFName.ForeColor = System.Drawing.Color.IndianRed;
            this.lblFName.Location = new System.Drawing.Point(402, 14);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(0, 20);
            this.lblFName.TabIndex = 16;
            // 
            // lblaccounttype
            // 
            this.lblaccounttype.AutoSize = true;
            this.lblaccounttype.BackColor = System.Drawing.Color.White;
            this.lblaccounttype.ForeColor = System.Drawing.Color.IndianRed;
            this.lblaccounttype.Location = new System.Drawing.Point(252, 32);
            this.lblaccounttype.Name = "lblaccounttype";
            this.lblaccounttype.Size = new System.Drawing.Size(79, 20);
            this.lblaccounttype.TabIndex = 15;
            this.lblaccounttype.Text = "Employee";
            // 
            // lblaccountid
            // 
            this.lblaccountid.AutoSize = true;
            this.lblaccountid.BackColor = System.Drawing.Color.White;
            this.lblaccountid.ForeColor = System.Drawing.Color.IndianRed;
            this.lblaccountid.Location = new System.Drawing.Point(120, 32);
            this.lblaccountid.Name = "lblaccountid";
            this.lblaccountid.Size = new System.Drawing.Size(0, 20);
            this.lblaccountid.TabIndex = 14;
            // 
            // lbllogid
            // 
            this.lbllogid.AutoSize = true;
            this.lbllogid.BackColor = System.Drawing.Color.White;
            this.lbllogid.ForeColor = System.Drawing.Color.IndianRed;
            this.lbllogid.Location = new System.Drawing.Point(37, 32);
            this.lbllogid.Name = "lbllogid";
            this.lbllogid.Size = new System.Drawing.Size(0, 20);
            this.lbllogid.TabIndex = 13;
            // 
            // ViewLogHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.customPanel1);
            this.Name = "ViewLogHistory";
            this.Size = new System.Drawing.Size(895, 75);
            this.Load += new System.EventHandler(this.ViewLogHistory_Load);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private customPanel customPanel1;
        public System.Windows.Forms.Label lblLName;
        public System.Windows.Forms.Label lbllastupdate;
        public System.Windows.Forms.Label lbllog;
        public System.Windows.Forms.Label lblFName;
        public System.Windows.Forms.Label lblaccounttype;
        public System.Windows.Forms.Label lblaccountid;
        public System.Windows.Forms.Label lbllogid;
    }
}
