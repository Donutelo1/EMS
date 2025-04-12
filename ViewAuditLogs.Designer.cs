namespace EMS
{
    partial class ViewAuditLogs
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
            this.lblTimeOut = new System.Windows.Forms.Label();
            this.lblstats = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbltimein = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 10;
            this.customPanel1.Controls.Add(this.flowLayoutPanel2);
            this.customPanel1.Controls.Add(this.lblTimeOut);
            this.customPanel1.Controls.Add(this.lblstats);
            this.customPanel1.Controls.Add(this.flowLayoutPanel1);
            this.customPanel1.Controls.Add(this.lbltimein);
            this.customPanel1.Controls.Add(this.panel1);
            this.customPanel1.Controls.Add(this.lbldate);
            this.customPanel1.Controls.Add(this.lblid);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientTopColor = System.Drawing.Color.White;
            this.customPanel1.GradinetAngle = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(0, 0);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(896, 43);
            this.customPanel1.TabIndex = 0;
            // 
            // lblTimeOut
            // 
            this.lblTimeOut.AutoSize = true;
            this.lblTimeOut.Location = new System.Drawing.Point(573, 11);
            this.lblTimeOut.Name = "lblTimeOut";
            this.lblTimeOut.Size = new System.Drawing.Size(138, 20);
            this.lblTimeOut.TabIndex = 7;
            this.lblTimeOut.Text = "17:05:18.7966667";
            // 
            // lblstats
            // 
            this.lblstats.AutoSize = true;
            this.lblstats.Location = new System.Drawing.Point(753, 12);
            this.lblstats.Name = "lblstats";
            this.lblstats.Size = new System.Drawing.Size(51, 20);
            this.lblstats.TabIndex = 4;
            this.lblstats.Text = "label5";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(455, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(97, 100);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // lbltimein
            // 
            this.lbltimein.AutoSize = true;
            this.lbltimein.Location = new System.Drawing.Point(388, 11);
            this.lbltimein.Name = "lbltimein";
            this.lbltimein.Size = new System.Drawing.Size(45, 20);
            this.lbltimein.TabIndex = 2;
            this.lbltimein.Text = "labell";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(269, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(87, 100);
            this.panel1.TabIndex = 5;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(197, 12);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(51, 20);
            this.lbldate.TabIndex = 1;
            this.lbldate.Text = "label2";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(16, 12);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(51, 20);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "label1";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(640, 5);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(97, 100);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // ViewAuditLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.customPanel1);
            this.Name = "ViewAuditLogs";
            this.Size = new System.Drawing.Size(899, 44);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private customPanel customPanel1;
        public System.Windows.Forms.Label lblstats;
        public System.Windows.Forms.Label lbltimein;
        public System.Windows.Forms.Label lbldate;
        public System.Windows.Forms.Label lblid;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblTimeOut;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}
