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
    public partial class Attendance: UserControl
    {
        // connection string
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
        public Attendance()
        {
            InitializeComponent();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            // make round the corner of button
            refreshBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, refreshBtn.Width, refreshBtn.Height, 15, 15));
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            Retrieve();
        }

        public void Retrieve() // retrieve the attendance from database
        {

            flowLayoutPanel1.Controls.Clear();
            // connection string 
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GOK6444\SQLEXPRESS01;Initial Catalog=ConnectionDb;Integrated Security=True;Encrypt=False");

            try
            {

                // query
                String query = "select * from Attendance";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandTimeout = 500;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    ViewAttendance a = new ViewAttendance();
                    try
                    {

                    }
                    catch
                    {

                    }
                    a.labelID.Text = dt.Rows[i]["Employee_Id"].ToString();
                    a.labelTimeIn.Text = dt.Rows[i]["TimeIn"].ToString();
                    a.labelTimeOut.Text = dt.Rows[i]["TimeOut"].ToString();
                    a.labelDate.Text = dt.Rows[i]["Date"].ToString();
                    a.labelStatus.Text = dt.Rows[i]["AttendanceStatus"].ToString();

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
