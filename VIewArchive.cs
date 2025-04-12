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
using System.Runtime.InteropServices;
using Microsoft.Data.SqlClient;

namespace EMS
{
    public partial class VIewArchive: UserControl
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

        public VIewArchive()
        {
            InitializeComponent();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            EditInactive a = new EditInactive();
            try
            {
                a.addEmpBtn.Visible = false;
                a.BackBtn.Visible = false;
                a.BackBtn.Visible = true;
                a.UpdateBtn.Visible = true;


                conn.Open();

                String query = "select * from Employees where Employee_Id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id",label1.Text);
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
                    a.txtEmpid.Text = (dr["Employee_Id"]).ToString();
                    a.cmbStatus.Text = (dr["Status"]).ToString();
                    a.txtGmail.Text = (dr["Gmail"]).ToString();
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

        private void btndelete_Click(object sender, EventArgs e)
        {

            EditInactive a = new EditInactive();
            try
            {
                a.addEmpBtn.Visible = false;
                a.BackBtn.Visible = false;
                a.BackBtn.Visible = false;
                a.UpdateBtn.Visible = false;
                a.cancelBtn.Visible = false;
                a.btndelete.Visible = true;
                a.cmbStatus.Enabled = false;
                conn.Open();
                DateTime today = DateTime.Today;

                String query = "select * from Employees where Employee_Id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", label1.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    try
                    {
                        //  byte[] img = (byte[])(dr["Image"]);
                        //   MemoryStream ms = new MemoryStream(img);
                        //   a.EmpPic.Image = Image.FromStream(ms);
                    }
                    catch
                    {
                    }
                    a.txtEmpid.Text = (dr["Employee_Id"]).ToString();
                    a.cmbStatus.Text = (dr["Status"]).ToString();
                    a.txtGmail.Text = (dr["Gmail"]).ToString();
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

        private void VIewArchive_Load(object sender, EventArgs e)
        {
            btndelete.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btndelete.Width, btndelete.Height, 15, 15));
            Btnrestore.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Btnrestore.Width, Btnrestore.Height, 15, 15));
        }
    }
}
