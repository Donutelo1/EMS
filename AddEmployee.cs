using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32.SafeHandles;
using System.IO;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System.Data.SqlTypes;
using System.Linq.Expressions;
using System.Windows.Markup;
using System.Runtime.InteropServices;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.Remoting.Contexts;
using System.IdentityModel.Protocols.WSTrust;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Data.SqlClient;

namespace EMS
{
    public partial class AddEmployee: UserControl
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
        
        public AddEmployee()
        {
            InitializeComponent();

            displayEmployeesData();
                
            RefreshData();

            txtSearch.KeyDown += txtSearch_KeyDown;

        }

    
        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            displayEmployeesData();
        }
       
        public void displayEmployeesData()
        {
            EmployeeData ed = new EmployeeData();
            List<EmployeeData> listData = ed.employeeListData();

         // dataGridView2.DataSource = listData;
        }

        void AddEmployee_Load(object sender, EventArgs e)
        {

            AddEmp.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, AddEmp.Width, AddEmp.Height, 8, 8));
            refreshBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, refreshBtn.Width, refreshBtn.Height, 15, 15));
            btnSearch.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSearch.Width, btnSearch.Height, 15, 15));
            RefreshData();
        }
        
        private void AddEmp_Click(object sender, EventArgs e)
        {
            AddEmployeeForm f = new AddEmployeeForm();
            f.ShowDialog();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            Retrieve();
        }
        public void Retrieve()
        {
            
            flowLayoutPanel1.Controls.Clear();
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GOK6444\SQLEXPRESS01;Initial Catalog=ConnectionDb;Integrated Security=True;Encrypt=False");
           
            try
            {
             


                String query = "select * from Employees WHERE  Status = 'Active' ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandTimeout = 500;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ViewEmployee a = new ViewEmployee();
                    try
                    {
                        byte[] img = (byte[])(dt.Rows[i]["Image"]);
                        MemoryStream ms = new MemoryStream(img);
                        a.EmpPic.Image = Image.FromStream(ms);
                       
                    }
                    catch
                    {

                    }
                    a.lblEmpId.Text = dt.Rows[i]["Employee_Id"].ToString();
                    a.lblFname.Text = dt.Rows[i]["FirstName"].ToString();
                    a.lblLname.Text = dt.Rows[i]["LastName"].ToString();
                    a.lblStatus.Text = dt.Rows[i]["Status"].ToString();
                    a.lblGmail.Text = dt.Rows[i]["Gmail"].ToString();
                   a.lblDateInsert.Text = dt.Rows[i]["DateInsert"].ToString();

                    flowLayoutPanel1.Controls.Add(a);
                }
                da.Dispose();
            }
            catch
            {
                MessageBox.Show("Error", "Error Message", MessageBoxButtons.OK);
               
            }
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

            if (TxtSearchBy.Text == "Employee_Id")
            {
                GlobalVar.EmployeeSearch = "Employee_Id";
            }
            if (TxtSearchBy.Text == "First Name")
            {
                GlobalVar.EmployeeSearch = "FirstName";
            }
            if (TxtSearchBy.Text == "Last Name")
            {
                GlobalVar.EmployeeSearch = "LastName";
            }
            if (TxtSearchBy.Text == "Department")
            {
                GlobalVar.EmployeeSearch = "Dapartment";
            }
            if (TxtSearchBy.Text == "Status")
            {
                GlobalVar.EmployeeSearch = "Status";
            }
            if (TxtSearchBy.Text == "Gmail")
            {
                GlobalVar.EmployeeSearch = "Gmail";
            }
            if (TxtSearchBy.Text == "DateInsert")
            {
                GlobalVar.EmployeeSearch = "DateInsert";
            }
            RetrieveOne(GlobalVar.EmployeeSearch);
        }
        public void RetrieveOne(string EmployeeSearch)
        {
            flowLayoutPanel1.Controls.Clear();
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GOK6444\SQLEXPRESS01;Initial Catalog=ConnectionDb;Integrated Security=True;Encrypt=False");
            try
            {
                String query = "select * from Employees where " + EmployeeSearch + " = @Search AND Status = 'Active'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandTimeout = 500;
                cmd.Parameters.AddWithValue("@Search", txtSearch.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ViewEmployee a = new ViewEmployee();
                    try
                    {
                        byte[] img = (byte[])(dt.Rows[i]["Image"]);
                        MemoryStream ms = new MemoryStream(img);
                        a.EmpPic.Image = Image.FromStream(ms);
                    }
                    catch
                    {
                    }
                    a.lblEmpId.Text = dt.Rows[i]["Employee_Id"].ToString();
                    a.lblLname.Text = dt.Rows[i]["LastName"].ToString();
                    a.lblFname.Text = dt.Rows[i]["FirstName"].ToString();
                    a.lblStatus.Text = dt.Rows[i]["Status"].ToString();
                    a.lblGmail.Text = dt.Rows[i]["Gmail"].ToString();
                    a.lblDateInsert.Text = dt.Rows[i]["DateInsert"].ToString();
                    flowLayoutPanel1.Controls.Add(a);
                }
                da.Dispose();
            }
            catch
            {
                MessageBox.Show("Error Searching", "error message", MessageBoxButtons.OK);

            }
        }

        private void TxtSearchBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
                e.SuppressKeyPress = true;
                
            }
        }
    }
}