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
using System.Runtime.InteropServices;

namespace EMS
{
    public partial class Salary : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-GOK6444\SQLEXPRESS01;Initial Catalog=ConnectionDb;Integrated Security=True;Encrypt=False");

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

        public Salary()
        {
            InitializeComponent();

            displayEmployeeData();
      
        }
        public void RefreshData()
        {
            if(InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            displayEmployeeData();
         
        }
       
        public void displayEmployeeData()
        {
            SalaryData ed = new SalaryData();
            List<SalaryData> listData = ed.salaryEmployeeListData();

     
        }
        private void Salary_Load(object sender, EventArgs e)
        {
         // update.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, update.Width, update.Height, 20, 20));
      

            displayEmployeeData();
        }
       
        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void searchTxt_Enter(object sender, EventArgs e)
        {
            if(searchTxt.Text =="Search here")
            {
                searchTxt.Text = "";
                searchTxt.ForeColor = Color.Gray;
            }
        }

        private void searchTxt_Leave(object sender, EventArgs e)
        {
            if (searchTxt.Text == "")
            { 
                searchTxt.Text = "Search here";
                searchTxt.ForeColor = Color.Gray;
            }
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


                String query = "select * from Payroll";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandTimeout = 500;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ViewSalary a = new ViewSalary();
                    try
                    {

                    }
                    catch
                    {

                    }
                    a.lblpayid.Text = dt.Rows[i]["Payroll_Id"].ToString();
                    a.lblempid.Text = dt.Rows[i]["Employee_Id"].ToString();
                    a.lblnoofpres.Text = dt.Rows[i]["No_Of_Present"].ToString();
                    a.lblsalary.Text = dt.Rows[i]["Salary"].ToString();
                    a.lblupdate.Text = dt.Rows[i]["DateUpdate"].ToString();
                    flowLayoutPanel1.Controls.Add(a);
                }
                da.Dispose();
            }
            catch
            {
                MessageBox.Show("Error", "Error Message", MessageBoxButtons.OK);
            }
        }
    }
}

