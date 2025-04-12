namespace EMS
{
    partial class ViewDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewDepartment));
            this.lblDeptId = new System.Windows.Forms.Label();
            this.lblDeptName = new System.Windows.Forms.Label();
            this.lblDeptStatus = new System.Windows.Forms.Label();
            this.editBttn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeptId
            // 
            this.lblDeptId.AutoSize = true;
            this.lblDeptId.Location = new System.Drawing.Point(36, 16);
            this.lblDeptId.Name = "lblDeptId";
            this.lblDeptId.Size = new System.Drawing.Size(51, 20);
            this.lblDeptId.TabIndex = 0;
            this.lblDeptId.Text = "label1";
            // 
            // lblDeptName
            // 
            this.lblDeptName.AutoSize = true;
            this.lblDeptName.Location = new System.Drawing.Point(192, 15);
            this.lblDeptName.Name = "lblDeptName";
            this.lblDeptName.Size = new System.Drawing.Size(51, 20);
            this.lblDeptName.TabIndex = 1;
            this.lblDeptName.Text = "label2";
            // 
            // lblDeptStatus
            // 
            this.lblDeptStatus.AutoSize = true;
            this.lblDeptStatus.Location = new System.Drawing.Point(495, 17);
            this.lblDeptStatus.Name = "lblDeptStatus";
            this.lblDeptStatus.Size = new System.Drawing.Size(51, 20);
            this.lblDeptStatus.TabIndex = 2;
            this.lblDeptStatus.Text = "label3";
            // 
            // editBttn
            // 
            this.editBttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editBttn.BackgroundImage")));
            this.editBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editBttn.FlatAppearance.BorderSize = 0;
            this.editBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBttn.Location = new System.Drawing.Point(816, 11);
            this.editBttn.Name = "editBttn";
            this.editBttn.Size = new System.Drawing.Size(27, 26);
            this.editBttn.TabIndex = 3;
            this.editBttn.UseVisualStyleBackColor = true;
            this.editBttn.Click += new System.EventHandler(this.editBttn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 13);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 21);
            this.panel2.TabIndex = 5;
            // 
            // ViewDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.editBttn);
            this.Controls.Add(this.lblDeptStatus);
            this.Controls.Add(this.lblDeptName);
            this.Controls.Add(this.lblDeptId);
            this.Name = "ViewDepartment";
            this.Size = new System.Drawing.Size(895, 52);
            this.Load += new System.EventHandler(this.ViewHr_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblDeptId;
        public System.Windows.Forms.Label lblDeptName;
        public System.Windows.Forms.Label lblDeptStatus;
        public System.Windows.Forms.Button editBttn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
