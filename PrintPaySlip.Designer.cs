namespace EMS
{
    partial class PrintPaySlip
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
            this.printBtn = new FontAwesome.Sharp.IconButton();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.customPanel1 = new EMS.customPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // printBtn
            // 
            this.printBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.printBtn.FlatAppearance.BorderSize = 0;
            this.printBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printBtn.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.printBtn.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.printBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.printBtn.IconSize = 30;
            this.printBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printBtn.Location = new System.Drawing.Point(734, 14);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(145, 38);
            this.printBtn.TabIndex = 0;
            this.printBtn.Text = "Print";
            this.printBtn.UseVisualStyleBackColor = false;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(518, 20);
            this.txtEmpID.Multiline = true;
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(154, 26);
            this.txtEmpID.TabIndex = 1;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 30;
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientTopColor = System.Drawing.SystemColors.Control;
            this.customPanel1.GradinetAngle = System.Drawing.SystemColors.Control;
            this.customPanel1.Location = new System.Drawing.Point(-1, 68);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(905, 548);
            this.customPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(499, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 42);
            this.panel1.TabIndex = 4;
            // 
            // PrintPaySlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.printBtn);
            this.Name = "PrintPaySlip";
            this.Size = new System.Drawing.Size(904, 616);
            this.Load += new System.EventHandler(this.PrintPaySlip_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton printBtn;
        private System.Windows.Forms.TextBox txtEmpID;
        private customPanel customPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}
