namespace EMS
{
    partial class VIewArchive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VIewArchive));
            this.customPanel1 = new EMS.customPanel();
            this.btndelete = new System.Windows.Forms.Button();
            this.Btnrestore = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 10;
            this.customPanel1.Controls.Add(this.btndelete);
            this.customPanel1.Controls.Add(this.Btnrestore);
            this.customPanel1.Controls.Add(this.label3);
            this.customPanel1.Controls.Add(this.label2);
            this.customPanel1.Controls.Add(this.label1);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientTopColor = System.Drawing.Color.White;
            this.customPanel1.GradinetAngle = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(1, 0);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(901, 66);
            this.customPanel1.TabIndex = 0;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.White;
            this.btndelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndelete.BackgroundImage")));
            this.btndelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Location = new System.Drawing.Point(845, 14);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(31, 35);
            this.btndelete.TabIndex = 15;
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // Btnrestore
            // 
            this.Btnrestore.BackColor = System.Drawing.Color.White;
            this.Btnrestore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btnrestore.BackgroundImage")));
            this.Btnrestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btnrestore.FlatAppearance.BorderSize = 0;
            this.Btnrestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnrestore.Location = new System.Drawing.Point(808, 14);
            this.Btnrestore.Name = "Btnrestore";
            this.Btnrestore.Size = new System.Drawing.Size(31, 35);
            this.Btnrestore.TabIndex = 14;
            this.Btnrestore.UseVisualStyleBackColor = false;
            this.Btnrestore.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // VIewArchive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.customPanel1);
            this.Name = "VIewArchive";
            this.Size = new System.Drawing.Size(902, 64);
            this.Load += new System.EventHandler(this.VIewArchive_Load);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private customPanel customPanel1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btnrestore;
        private System.Windows.Forms.Button btndelete;
    }
}
