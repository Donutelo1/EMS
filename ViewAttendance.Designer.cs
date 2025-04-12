namespace EMS
{
    partial class ViewAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAttendance));
            this.labelID = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTimeIn = new System.Windows.Forms.Label();
            this.labelTimeOut = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.White;
            this.labelID.Location = new System.Drawing.Point(1, 15);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(51, 20);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "label1";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.BackColor = System.Drawing.Color.White;
            this.labelStatus.Location = new System.Drawing.Point(140, 15);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(51, 20);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.Text = "label2";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.White;
            this.labelDate.Location = new System.Drawing.Point(313, 15);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(51, 20);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "label3";
            // 
            // labelTimeIn
            // 
            this.labelTimeIn.AutoSize = true;
            this.labelTimeIn.BackColor = System.Drawing.Color.White;
            this.labelTimeIn.Location = new System.Drawing.Point(481, 15);
            this.labelTimeIn.Name = "labelTimeIn";
            this.labelTimeIn.Size = new System.Drawing.Size(51, 20);
            this.labelTimeIn.TabIndex = 3;
            this.labelTimeIn.Text = "label4";
            // 
            // labelTimeOut
            // 
            this.labelTimeOut.AutoSize = true;
            this.labelTimeOut.BackColor = System.Drawing.Color.White;
            this.labelTimeOut.Location = new System.Drawing.Point(628, 15);
            this.labelTimeOut.Name = "labelTimeOut";
            this.labelTimeOut.Size = new System.Drawing.Size(51, 20);
            this.labelTimeOut.TabIndex = 4;
            this.labelTimeOut.Text = "label5";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(822, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 30);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(392, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(89, 66);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(548, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(70, 62);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(694, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(70, 62);
            this.panel3.TabIndex = 8;
            // 
            // ViewAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelTimeOut);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelTimeIn);
            this.Name = "ViewAttendance";
            this.Size = new System.Drawing.Size(898, 50);
            this.Load += new System.EventHandler(this.ViewAttendance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label labelID;
        public System.Windows.Forms.Label labelStatus;
        public System.Windows.Forms.Label labelDate;
        public System.Windows.Forms.Label labelTimeIn;
        public System.Windows.Forms.Label labelTimeOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}
