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
using Microsoft.SqlServer.Server;
using System.IO;
using System.Runtime.InteropServices;
using System.Net.NetworkInformation;




namespace EMS
{
    public partial class ViewDepartment : UserControl
    {
        public event EventHandler OnDeleted;


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
        public ViewDepartment()
        {
            InitializeComponent();


        }

        private void ViewHr_Load(object sender, EventArgs e)
        {

        }
 

        private void editBttn_Click(object sender, EventArgs e)
        {
            AddDepartment a = new AddDepartment();
            try
            {
                a.adddeptBttn.Visible = false;
                a.backBtn.Visible = true;
                a.updateBtn.Visible = true;

                conn.Open();

                String query = "select * from Department where ID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", lblDeptId.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    a.txtStatus.Text = (dr["Status"]).ToString();
                    a.txtDeptName.Text = (dr["Department_Name"]).ToString();
                    a.DEPTID.Text = (dr["ID"]).ToString();

                }
                dr.Close();
                conn.Close();
                a.ShowDialog();

            }
            catch
            {
                MessageBox.Show("Error", "error Message", MessageBoxButtons.OK);
            }
        }
    }
}