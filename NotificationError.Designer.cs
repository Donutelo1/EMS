namespace EMS
{
    partial class NotificationError
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
            this.btnokay = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.customPanel1 = new EMS.customPanel();
            this.SuspendLayout();
            // 
            // btnokay
            // 
            this.btnokay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnokay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnokay.FlatAppearance.BorderSize = 0;
            this.btnokay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnokay.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnokay.IconColor = System.Drawing.Color.Black;
            this.btnokay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnokay.Location = new System.Drawing.Point(203, 91);
            this.btnokay.Name = "btnokay";
            this.btnokay.Size = new System.Drawing.Size(95, 29);
            this.btnokay.TabIndex = 0;
            this.btnokay.Text = "Okay";
            this.btnokay.UseVisualStyleBackColor = false;
            this.btnokay.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notification Error!";
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 30;
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientTopColor = System.Drawing.Color.MediumSlateBlue;
            this.customPanel1.GradinetAngle = System.Drawing.Color.MediumSlateBlue;
            this.customPanel1.Location = new System.Drawing.Point(-15, -6);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(327, 14);
            this.customPanel1.TabIndex = 2;
            // 
            // NotificationError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 123);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnokay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotificationError";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotificationError";
            this.Load += new System.EventHandler(this.NotificationError_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnokay;
        private System.Windows.Forms.Label label1;
        private customPanel customPanel1;
    }
}