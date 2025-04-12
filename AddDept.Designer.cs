namespace EMS
{
    partial class AddDept
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDept));
            this.customPanel3 = new EMS.customPanel();
            this.addDeptBttn = new FontAwesome.Sharp.IconButton();
            this.TxtSearchBy = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.csharp1 = new EMS.Csharp();
            this.customPanel4 = new EMS.customPanel();
            this.RefreshBttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.customPanel2 = new EMS.customPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.customPanel3.SuspendLayout();
            this.customPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.Color.White;
            this.customPanel3.BorderRadius = 20;
            this.customPanel3.Controls.Add(this.addDeptBttn);
            this.customPanel3.Controls.Add(this.TxtSearchBy);
            this.customPanel3.Controls.Add(this.label7);
            this.customPanel3.Controls.Add(this.txtSearch);
            this.customPanel3.Controls.Add(this.btnSearch);
            this.customPanel3.Controls.Add(this.csharp1);
            this.customPanel3.Controls.Add(this.customPanel4);
            this.customPanel3.Controls.Add(this.RefreshBttn);
            this.customPanel3.Controls.Add(this.label1);
            this.customPanel3.ForeColor = System.Drawing.Color.Black;
            this.customPanel3.GradientAngle = 90F;
            this.customPanel3.GradientTopColor = System.Drawing.Color.White;
            this.customPanel3.GradinetAngle = System.Drawing.Color.White;
            this.customPanel3.Location = new System.Drawing.Point(1, 3);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(905, 50);
            this.customPanel3.TabIndex = 1;
            this.customPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.customPanel3_Paint);
            // 
            // addDeptBttn
            // 
            this.addDeptBttn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.addDeptBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addDeptBttn.FlatAppearance.BorderSize = 0;
            this.addDeptBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDeptBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDeptBttn.ForeColor = System.Drawing.Color.White;
            this.addDeptBttn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.addDeptBttn.IconColor = System.Drawing.Color.GhostWhite;
            this.addDeptBttn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addDeptBttn.IconSize = 25;
            this.addDeptBttn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addDeptBttn.Location = new System.Drawing.Point(769, 4);
            this.addDeptBttn.Name = "addDeptBttn";
            this.addDeptBttn.Size = new System.Drawing.Size(123, 39);
            this.addDeptBttn.TabIndex = 38;
            this.addDeptBttn.Text = "+ Add";
            this.addDeptBttn.UseVisualStyleBackColor = false;
            this.addDeptBttn.Click += new System.EventHandler(this.addDeptBttn_Click);
            // 
            // TxtSearchBy
            // 
            this.TxtSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtSearchBy.FormattingEnabled = true;
            this.TxtSearchBy.Items.AddRange(new object[] {
            "Department Name",
            "Status",
            "Id"});
            this.TxtSearchBy.Location = new System.Drawing.Point(548, 11);
            this.TxtSearchBy.Name = "TxtSearchBy";
            this.TxtSearchBy.Size = new System.Drawing.Size(160, 28);
            this.TxtSearchBy.TabIndex = 36;
            this.TxtSearchBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearchBy_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(466, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Search By";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(219, 16);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(174, 24);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.Text = "Search here...";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(397, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(29, 28);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // csharp1
            // 
            this.csharp1.BackColor = System.Drawing.Color.Transparent;
            this.csharp1.Br = System.Drawing.Color.White;
            this.csharp1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csharp1.ForeColor = System.Drawing.Color.Black;
            this.csharp1.Location = new System.Drawing.Point(203, 12);
            this.csharp1.Name = "csharp1";
            this.csharp1.Size = new System.Drawing.Size(232, 30);
            this.csharp1.TabIndex = 3;
            // 
            // customPanel4
            // 
            this.customPanel4.BackColor = System.Drawing.SystemColors.Control;
            this.customPanel4.BorderRadius = 30;
            this.customPanel4.ForeColor = System.Drawing.Color.Black;
            this.customPanel4.GradientAngle = 90F;
            this.customPanel4.GradientTopColor = System.Drawing.Color.White;
            this.customPanel4.GradinetAngle = System.Drawing.Color.White;
            this.customPanel4.Location = new System.Drawing.Point(629, 5);
            this.customPanel4.Name = "customPanel4";
            this.customPanel4.Size = new System.Drawing.Size(58, 28);
            this.customPanel4.TabIndex = 2;
            // 
            // RefreshBttn
            // 
            this.RefreshBttn.BackColor = System.Drawing.Color.Transparent;
            this.RefreshBttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RefreshBttn.BackgroundImage")));
            this.RefreshBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RefreshBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshBttn.FlatAppearance.BorderSize = 0;
            this.RefreshBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBttn.Location = new System.Drawing.Point(730, 10);
            this.RefreshBttn.Name = "RefreshBttn";
            this.RefreshBttn.Size = new System.Drawing.Size(29, 28);
            this.RefreshBttn.TabIndex = 1;
            this.RefreshBttn.UseVisualStyleBackColor = false;
            this.RefreshBttn.Click += new System.EventHandler(this.RefreshBttn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Department";
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.customPanel2.BorderRadius = 30;
            this.customPanel2.Controls.Add(this.label5);
            this.customPanel2.Controls.Add(this.label4);
            this.customPanel2.Controls.Add(this.label3);
            this.customPanel2.Controls.Add(this.label2);
            this.customPanel2.Controls.Add(this.flowLayoutPanel1);
            this.customPanel2.ForeColor = System.Drawing.Color.Black;
            this.customPanel2.GradientAngle = 90F;
            this.customPanel2.GradientTopColor = System.Drawing.Color.White;
            this.customPanel2.GradinetAngle = System.Drawing.Color.White;
            this.customPanel2.Location = new System.Drawing.Point(0, 55);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(907, 580);
            this.customPanel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(806, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Action";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(497, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(183, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(37, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 34);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(901, 556);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // AddDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customPanel3);
            this.Controls.Add(this.customPanel2);
            this.Name = "AddDept";
            this.Size = new System.Drawing.Size(907, 650);
            this.Load += new System.EventHandler(this.AddHr_Load);
            this.customPanel3.ResumeLayout(false);
            this.customPanel3.PerformLayout();
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private customPanel customPanel2;
        private customPanel customPanel3;
        private customPanel customPanel4;
        private System.Windows.Forms.Button RefreshBttn;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private Csharp csharp1;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox TxtSearchBy;
        private FontAwesome.Sharp.IconButton addDeptBttn;
    }
}
