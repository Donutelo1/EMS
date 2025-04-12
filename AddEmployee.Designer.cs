namespace EMS
{
    partial class AddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
            this.customPanel1 = new EMS.customPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSearchBy = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SEARCHTXT = new EMS.Csharp();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.AddEmp = new System.Windows.Forms.Button();
            this.customPanel3 = new EMS.customPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.customPanel1.SuspendLayout();
            this.customPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BorderRadius = 20;
            this.customPanel1.Controls.Add(this.label2);
            this.customPanel1.Controls.Add(this.TxtSearchBy);
            this.customPanel1.Controls.Add(this.txtSearch);
            this.customPanel1.Controls.Add(this.btnSearch);
            this.customPanel1.Controls.Add(this.label1);
            this.customPanel1.Controls.Add(this.SEARCHTXT);
            this.customPanel1.Controls.Add(this.refreshBtn);
            this.customPanel1.Controls.Add(this.AddEmp);
            this.customPanel1.ForeColor = System.Drawing.Color.Black;
            this.customPanel1.GradientAngle = 90F;
            this.customPanel1.GradientTopColor = System.Drawing.Color.White;
            this.customPanel1.GradinetAngle = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(3, 1);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(905, 50);
            this.customPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(475, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Search By";
            // 
            // TxtSearchBy
            // 
            this.TxtSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtSearchBy.FormattingEnabled = true;
            this.TxtSearchBy.Items.AddRange(new object[] {
            "First Name",
            "Last Name",
            "Employee_Id",
            "Gender",
            "Contact",
            "Status",
            "Deapartment",
            "Gmail",
            "DateInsert"});
            this.TxtSearchBy.Location = new System.Drawing.Point(557, 11);
            this.TxtSearchBy.Name = "TxtSearchBy";
            this.TxtSearchBy.Size = new System.Drawing.Size(148, 28);
            this.TxtSearchBy.TabIndex = 34;
            this.TxtSearchBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearchBy_KeyPress);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(217, 16);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(206, 24);
            this.txtSearch.TabIndex = 33;
            this.txtSearch.Text = "Search here...";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(426, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(28, 25);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Manage Employee";
            // 
            // SEARCHTXT
            // 
            this.SEARCHTXT.BackColor = System.Drawing.Color.Transparent;
            this.SEARCHTXT.Br = System.Drawing.Color.White;
            this.SEARCHTXT.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEARCHTXT.ForeColor = System.Drawing.Color.Gray;
            this.SEARCHTXT.Location = new System.Drawing.Point(205, 10);
            this.SEARCHTXT.Name = "SEARCHTXT";
            this.SEARCHTXT.Size = new System.Drawing.Size(258, 34);
            this.SEARCHTXT.TabIndex = 30;
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshBtn.BackgroundImage")));
            this.refreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn.FlatAppearance.BorderSize = 0;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Location = new System.Drawing.Point(715, 9);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(31, 31);
            this.refreshBtn.TabIndex = 29;
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // AddEmp
            // 
            this.AddEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddEmp.FlatAppearance.BorderSize = 0;
            this.AddEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmp.ForeColor = System.Drawing.Color.White;
            this.AddEmp.Location = new System.Drawing.Point(774, 4);
            this.AddEmp.Name = "AddEmp";
            this.AddEmp.Size = new System.Drawing.Size(123, 39);
            this.AddEmp.TabIndex = 8;
            this.AddEmp.Text = "+ Add";
            this.AddEmp.UseVisualStyleBackColor = false;
            this.AddEmp.Click += new System.EventHandler(this.AddEmp_Click);
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.customPanel3.BorderRadius = 30;
            this.customPanel3.Controls.Add(this.label12);
            this.customPanel3.Controls.Add(this.label8);
            this.customPanel3.Controls.Add(this.label9);
            this.customPanel3.Controls.Add(this.label10);
            this.customPanel3.Controls.Add(this.label11);
            this.customPanel3.Controls.Add(this.flowLayoutPanel1);
            this.customPanel3.ForeColor = System.Drawing.Color.Black;
            this.customPanel3.GradientAngle = 90F;
            this.customPanel3.GradientTopColor = System.Drawing.Color.White;
            this.customPanel3.GradinetAngle = System.Drawing.Color.White;
            this.customPanel3.Location = new System.Drawing.Point(1, 53);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(907, 593);
            this.customPanel3.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(602, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Gmail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(794, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Action";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(402, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "RegDate/Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(232, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(95, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "ID";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 33);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(901, 557);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customPanel3);
            this.Controls.Add(this.customPanel1);
            this.Name = "AddEmployee";
            this.Size = new System.Drawing.Size(907, 650);
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.customPanel3.ResumeLayout(false);
            this.customPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddEmp;
        private customPanel customPanel1;
        private System.Windows.Forms.Button refreshBtn;
        private Csharp SEARCHTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.ComboBox TxtSearchBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private customPanel customPanel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label12;
    }
}
