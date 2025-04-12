using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace EMS
{
    public partial class ViewEmployee : UserControl
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

        public ViewEmployee()
        {
            InitializeComponent();
        }

      

        private void btnviewemp_Click_1(object sender, EventArgs e)
        {
            ViewEmployeeForm f = new ViewEmployeeForm();

            try
            {

                conn.Open();

                String query = "select * from Employees where Employee_Id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", lblEmpId.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    try
                    {
                        byte[] img = (byte[])(dr["Image"]);
                        MemoryStream ms = new MemoryStream(img);
                        f.pictureBox1.Image = Image.FromStream(ms);
                    }
                    catch
                    {
                    }
                    f.txtid.Text = (dr["Employee_Id"]).ToString();
                    f.txtfname.Text = (dr["FirstName"]).ToString();
                    f.txtlaname.Text = (dr["LastName"]).ToString();
                    f.txtcon.Text = (dr["Contact"]).ToString();
                    f.txtgender.Text = (dr["Gender"]).ToString();
                    f.txtdepartment.Text = (dr["Department"]).ToString();
                    f.txtstatus.Text = (dr["Status"]).ToString();
                    f.txtgmail.Text = (dr["Gmail"]).ToString();
                }
                dr.Close();
                conn.Close();
                f.ShowDialog();

            }
            catch
            {
                MessageBox.Show("Error", "error Message", MessageBoxButtons.OK);
            }
        }

        private void BtnEdit_Click_1(object sender, EventArgs e)
        {
            AddEmployeeForm a = new AddEmployeeForm();
            try
            {
                a.addEmpBtn.Visible = false;
                a.BackBtn.Visible = false;
                a.BackBtn.Visible = true;
                a.UpdateBtn.Visible = true;
                a.txtPass.Visible = false;

                conn.Open();

                String query = "select * from Employees where Employee_Id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", lblEmpId.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    try
                    {
                        byte[] img = (byte[])(dr["Image"]);
                        MemoryStream ms = new MemoryStream(img);
                        a.empPic.Image = Image.FromStream(ms);
                    }
                    catch
                    {
                    }
                    a.label1.Text = "Edit Employee";
                    a.txtEmpid.Text = (dr["Employee_Id"]).ToString();
                    a.txtFname.Text = (dr["FirstName"]).ToString();
                    a.txtLname.Text = (dr["LastName"]).ToString();
                    a.txtcontact.Text = (dr["Contact"]).ToString();
                    a.cmbGender.Text = (dr["Gender"]).ToString();
                    a.cmbDept.Text = (dr["Department"].ToString());
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
    }
}
