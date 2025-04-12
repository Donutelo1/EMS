namespace EMS
{
    partial class SelectUserType
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
            this.customPanel1 = new EMS.customPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.AdminBttn = new System.Windows.Forms.Button();
            this.EmployeeBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 30;
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientTopColor = System.Drawing.Color.DodgerBlue;
            this.customPanel1.GradinetAngle = System.Drawing.Color.CadetBlue;
            this.customPanel1.Location = new System.Drawing.Point(-14, -5);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(590, 19);
            this.customPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select User Type";
            // 
            // AdminBttn
            // 
            this.AdminBttn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AdminBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminBttn.FlatAppearance.BorderSize = 0;
            this.AdminBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminBttn.ForeColor = System.Drawing.Color.White;
            this.AdminBttn.Location = new System.Drawing.Point(179, 146);
            this.AdminBttn.Name = "AdminBttn";
            this.AdminBttn.Size = new System.Drawing.Size(217, 48);
            this.AdminBttn.TabIndex = 2;
            this.AdminBttn.Text = "Admin";
            this.AdminBttn.UseVisualStyleBackColor = false;
            this.AdminBttn.Click += new System.EventHandler(this.AdminBttn_Click);
            // 
            // EmployeeBttn
            // 
            this.EmployeeBttn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EmployeeBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmployeeBttn.FlatAppearance.BorderSize = 0;
            this.EmployeeBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeeBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeBttn.ForeColor = System.Drawing.Color.White;
            this.EmployeeBttn.Location = new System.Drawing.Point(179, 218);
            this.EmployeeBttn.Name = "EmployeeBttn";
            this.EmployeeBttn.Size = new System.Drawing.Size(217, 48);
            this.EmployeeBttn.TabIndex = 3;
            this.EmployeeBttn.Text = "Employee";
            this.EmployeeBttn.UseVisualStyleBackColor = false;
            this.EmployeeBttn.Click += new System.EventHandler(this.EmployeeBttn_Click);
            // 
            // SelectUserType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 340);
            this.Controls.Add(this.EmployeeBttn);
            this.Controls.Add(this.AdminBttn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectUserType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectUserType";
            this.Load += new System.EventHandler(this.SelectUserType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private customPanel customPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AdminBttn;
        private System.Windows.Forms.Button EmployeeBttn;
    }
}