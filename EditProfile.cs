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
using System.Net.NetworkInformation;
using System.Drawing.Text;

namespace EMS
{
    public partial class EditProfile: UserControl
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
        public EditProfile()
        {
            InitializeComponent();
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            savechangeBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, savechangeBtn.Width, savechangeBtn.Height, 5, 5));
        }
        public void clearFields()
        {
            EMPID.Text = "";
            txtCurrentPass.Text = "";
            txtnewPass.Text = "";
            txtrepeatnewpass.Text = "";
        }

        private void savechangeBtn_Click(object sender, EventArgs e)
        {
            //Get User Ipnut
            string id = EMPID.Text;
            string currentPass = txtCurrentPass.Text;
            string newPass = txtnewPass.Text;
            string confirmPass = txtrepeatnewpass.Text;
           
            //Validate Input Fields
            if(string.IsNullOrEmpty(currentPass) || string.IsNullOrEmpty(newPass) || string.IsNullOrEmpty(confirmPass) || string.IsNullOrEmpty(id))
            {
                MessageBox.Show("All Fields are required", "Error", MessageBoxButtons.OK);
                return;
            }
            if(!IsCurrentPasswordCorrect( id, currentPass))
            {
                MessageBox.Show("Incorrect current Password or ID", "Error", MessageBoxButtons.OK);
                return;
            }
            if(newPass.Length < 8)
            {
                MessageBox.Show("New Password must be at least 8 Characters long!", "information Message", MessageBoxButtons.OK);
                return;
            }

            if(newPass != confirmPass)
            {
                MessageBox.Show("Password do not Match", "error", MessageBoxButtons.OK);
                return;
            }
           if(UpdatePassword(newPass))
            {
                MessageBox.Show("SuccessFully changed", "Information message", MessageBoxButtons.OK);

                clearFields();
            }
            else
            {
                MessageBox.Show("Error update password!", " Error", MessageBoxButtons.OK);
            }
          
        }
       private bool IsCurrentPasswordCorrect(string id, string currentPass)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GOK6444\SQLEXPRESS01;Initial Catalog=ConnectionDb;Integrated Security=True;Encrypt=False");
            {
                string query = "SELECT COUNT (*) FROM Employees WHERE Employee_Id = @id AND Password = @password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@password", currentPass);


                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
        private bool UpdatePassword(string newPass)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GOK6444\SQLEXPRESS01;Initial Catalog=ConnectionDb;Integrated Security=True;Encrypt=False");
            {
                string query = "Update Employees SET Password = @password WHERE Employee_Id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@password", newPass);
                cmd.Parameters.AddWithValue("@id", EMPID.Text);
              
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
