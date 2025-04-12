using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Data.SqlClient;
using System.Runtime.InteropServices;

namespace EMS
{
    public partial class ViewSalary: UserControl
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

        public ViewSalary()
        {
            InitializeComponent();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            UpdateSalary a = new UpdateSalary();
            try
            {
        
                conn.Open();

                String query = "select * from Payroll where Employee_Id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", lblempid.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    try
                    {
                        byte[] img = (byte[])(dr["Image"]);
                        MemoryStream ms = new MemoryStream(img);
                        //   a.EmpPic.Image = Image.FromStream(ms);
                    }
                    catch
                    {
                    }
                    a.txtpayrollid.Text = (dr["Payroll_Id"]).ToString();
                    a.txtempid.Text = (dr["Employee_Id"]).ToString();
                    a.txtnoofpres.Text = (dr["No_Of_Present"]).ToString();
                    a.txtdep.Text = (dr["Department"]).ToString();
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
