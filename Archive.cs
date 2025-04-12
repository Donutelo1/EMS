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
    public partial class Archive : UserControl
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
        public Archive()
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

                String query = "select * from Employees WHERE Status = 'Inactive' AND DateDelete Is Null";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandTimeout = 500;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                   
                    VIewArchive a = new VIewArchive();
                    try
                    {

                    }
                    catch
                    {

                    }
                    a.label1.Text = dt.Rows[i]["Employee_Id"].ToString();
                    a.label3.Text = dt.Rows[i]["Status"].ToString();
                    a.label2.Text = dt.Rows[i]["Gmail"].ToString();

                    flowLayoutPanel1.Controls.Add(a);
                }
                da.Dispose();
            }
            catch
            {
                MessageBox.Show("Error", "Error Message", MessageBoxButtons.OK);
            }
        }

        private void Archive_Load(object sender, EventArgs e)
        {
            // make round the corner of button
            refreshBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, refreshBtn.Width, refreshBtn.Height, 15, 15));
        }
    }
}
