using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.IO;
using System.Runtime.InteropServices;

namespace EMS
{
    public partial class AddDept: UserControl
    {
       

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GOK6444\SQLEXPRESS01;Initial Catalog=ConnectionDb;Integrated Security=True;Encrypt=False");

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]


        private static extern IntPtr CreateRoundRectRgn
           (
           int nLeft,
           int nRight,
           int ntop,
           int nBottom,
           int nWidthEllipse,
           int nHeightEllipse
           );
        public AddDept()
        {
            InitializeComponent();

            txtSearch.KeyDown += txtSearch_KeyDown;
        }

        private void addHrBttn_Click(object sender, EventArgs e)
        {
            AddDepartment a = new AddDepartment();
            a.ShowDialog();

        }
      
        private void RefreshBttn_Click(object sender, EventArgs e)
        {
           Retrieve();

        }
      
        public void Retrieve()
        {
            flowLayoutPanel1.Controls.Clear();
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GOK6444\SQLEXPRESS01;Initial Catalog=ConnectionDb;Integrated Security=True;Encrypt=False");

            try
            {
                String query = "select * from Department";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandTimeout = 500;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ViewDepartment a = new ViewDepartment();
                    try
                    {
                    }
                    catch
                    {

                    }
                    a.lblDeptId.Text = dt.Rows[i]["ID"].ToString();
                    a.lblDeptStatus.Text = dt.Rows[i]["Status"].ToString();
                    a.lblDeptName.Text = dt.Rows[i]["Department_Name"].ToString();

                    flowLayoutPanel1.Controls.Add(a);
                }
                da.Dispose();
            }
            catch
            {
                MessageBox.Show("Error", "Error Message", MessageBoxButtons.OK);
            }
        }

        private void customPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddHr_Load(object sender, EventArgs e)
        {
            addDeptBttn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, addDeptBttn.Width, addDeptBttn.Height, 7, 7));
            RefreshBttn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, RefreshBttn.Width, RefreshBttn.Height, 15, 15));
           btnSearch.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSearch.Width, btnSearch.Height, 15, 15));

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtSearchBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search here...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search here...";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            if (TxtSearchBy.Text == "Status")
            {
                GlobalVar.DepartmentSearch = "Status";
            }
            if (TxtSearchBy.Text == "Department Name")
            {
                GlobalVar.DepartmentSearch = "Department_Name";
            }
            if (TxtSearchBy.Text == "Id")
            {
                GlobalVar.DepartmentSearch = "ID";
            }
            RetrieveOne(GlobalVar.DepartmentSearch);
        }
        public void RetrieveOne(string DepartmentSearch)
        {
            flowLayoutPanel1.Controls.Clear();
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GOK6444\SQLEXPRESS01;Initial Catalog=ConnectionDb;Integrated Security=True;Encrypt=False");
            try
            {
                String query = "select * from Department where " + DepartmentSearch + " = @Search";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandTimeout = 500;
                cmd.Parameters.AddWithValue("@Search", txtSearch.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ViewDepartment a = new ViewDepartment();
                    try
                    {
                        //byte[] img = (byte[])(dt.Rows[i]["img"]);
                        //MemoryStream ms = new MemoryStream(img);
                        //a.pictureBox1.Image = Image.FromStream(ms);
                    }
                    catch
                    {
                    }
                    a.lblDeptId.Text = dt.Rows[i]["ID"].ToString();
                    a.lblDeptName.Text = dt.Rows[i]["Department_Name"].ToString();
                    a.lblDeptStatus.Text = dt.Rows[i]["Status"].ToString();


                    flowLayoutPanel1.Controls.Add(a);
                }
                da.Dispose();
            }
            catch
            {
                MessageBox.Show("Error fetching", "error message", MessageBoxButtons.OK);
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
                e.SuppressKeyPress = true;

            }
        }

        private void addDeptBttn_Click(object sender, EventArgs e)
        {
            AddDepartment f = new AddDepartment();
            f.ShowDialog();
        }
    }
}
