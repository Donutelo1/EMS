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
    public partial class LogHistory: UserControl
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
        public LogHistory()
        {
            InitializeComponent();
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
               

                String query = "select * from Employees";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandTimeout = 500;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DateTime today = DateTime.Today;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ViewLogHistory a = new ViewLogHistory();

                  a.lblaccountid.Text = dt.Rows[i]["Employee_Id"].ToString();
                  a.lblFName.Text = dt.Rows[i]["FirstName"].ToString();
                  a.lblLName.Text = dt.Rows[i]["LastName"].ToString();

                    flowLayoutPanel1.Controls.Add(a);
                }
                da.Dispose();
            }
            catch
            {
                MessageBox.Show("Error", " Error Message", MessageBoxButtons.OK);
            }
        }

        private void LogHistory_Load(object sender, EventArgs e)
        {
            refreshBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, refreshBtn.Width, refreshBtn.Height, 15, 15));
        }
    }
}
