using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace EMS
{

 
    public partial class EmployeeLogIn: Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GOK6444\SQLEXPRESS01;Initial Catalog=ConnectionDb;Integrated Security=True;Encrypt=False");

        public static string LoggedInUSername = "";

        public static string LoggedInFirstName = "";


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

        public EmployeeLogIn()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            txtBoxUname.KeyDown += txtBoxUname_KeyDown;
            txtBoxPword.KeyDown += txtBoxPword_KeyDown;

        }


        private void txtBoxUname_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtBoxPword.Select();
            }
        }

        private void txtBoxPword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                logInBttn.PerformClick();
            }
        }
        private void EmployeeLogIn_Load(object sender, EventArgs e)
        {
            logInBttn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, logInBttn.Width, logInBttn.Height, 30, 30));
            showPassBttn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, showPassBttn.Width, showPassBttn.Height, 15, 15));
            hidePassBttn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, hidePassBttn.Width, hidePassBttn.Height, 15, 15));
            exitBttn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, exitBttn.Width, exitBttn.Height, 15, 15));
            btnmin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnmin.Width, btnmin.Height, 15, 15));

            txtBoxUname.Select();
        }

        private void exitBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectUserType f = new SelectUserType();
            f.Show();
        }
      
        private void logInBttn_Click(object sender, EventArgs e)
        {
            string username = txtBoxUname.Text.Trim();
            string password = txtBoxPword.Text.Trim();

            if (txtBoxUname.Text.Trim() == "" && txtBoxPword.Text.Trim() == "")
            {
                label5.Text = "username can't be blank!";
                label6.Text = "password can't be blank!";
            }

            else
            {
                if (conn.State != ConnectionState.Open)
                {
                    try
                    {
                        conn.Open();                           

                        String selectData = "SELECT FirstName, LastName From Employees WHERE  (Employee_Id) =  (@empId) AND BINARY_CHECKSUM (Password) = BINARY_CHECKSUM (@password)  ";
                        using (SqlCommand cmd = new SqlCommand(selectData, conn))
                        {
                            cmd.Parameters.AddWithValue("@empId", txtBoxUname.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", SHA256Hasher.ComputeSha256Hash(txtBoxPword.Text));

                            object result = cmd.ExecuteScalar();

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                         
                            if (table.Rows.Count >= 1)
                            {

                                LoggedInFirstName = result.ToString();

                                LoggedInUSername = username;

                             //   MessageBox.Show("Login Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                               EmployeeDashboard g = new EmployeeDashboard();
                                g.Show();
                                this.Hide();
                            }
                            else if (txtBoxUname.Text == "")
                            {
                                label5.Text = "username can't be blank!";
                            }
                            else if (txtBoxPword.Text == "")
                            {
                                label6.Text = "password can't be blank!";
                            }
                            else
                            {
                                MessageBox.Show("Inncorect Username or Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtBoxUname.Clear();
                                txtBoxPword.Clear();
                                txtBoxUname.Focus();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Connecting: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void hidePassBttn_Click(object sender, EventArgs e)
        {
            if (txtBoxPword.PasswordChar == '\0')
            {
                showPassBttn.BringToFront();
                txtBoxPword.PasswordChar = '•';

            }
        }

        private void showPassBttn_Click(object sender, EventArgs e)
        {
            if (txtBoxPword.PasswordChar == '•')
            {
                hidePassBttn.BringToFront();
                txtBoxPword.PasswordChar = '\0';

            }
        }

        private void txtBoxUname_Enter(object sender, EventArgs e)
        {
            

            if (label5.Text == "username can't be blank!")
            {
                label5.Text = "";
                label5.ForeColor = Color.IndianRed;

            }
        }


        private void txtBoxUname_Leave(object sender, EventArgs e)
        {
          


            if (label5.Text == "")
            {
                label5.Text = "username can't be blank!";
                label5.ForeColor = Color.IndianRed;
            }
        }



        private void txtBoxPword_Enter(object sender, EventArgs e)
        {
       


            if (label6.Text == "password can't be blank!")
            {
                label6.Text = "";
                label6.ForeColor = Color.IndianRed;
            }
        }

        private void txtBoxPword_Leave(object sender, EventArgs e)
        {
           


            if (label6.Text == "")
            {
                label6.Text = "password can't be blank!";
                label6.ForeColor = Color.IndianRed;
            }
        }

        private void txtBoxPword_TextChanged(object sender, EventArgs e)
        {
           

            string pattern = @"\p{Cs}";
            txtBoxPword.Text = Regex.Replace(txtBoxPword.Text, pattern, "");
            txtBoxPword.SelectionStart = txtBoxPword.Text.Length;
            if (!string.IsNullOrEmpty(txtBoxPword.Text))
            {
                label6.Visible = false;
            }
            else
            {
                label6.Visible = true;
            }
        }

        private void txtBoxUname_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"\p{Cs}";
            txtBoxUname.Text = Regex.Replace(txtBoxUname.Text, pattern, "");
            txtBoxUname.SelectionStart = txtBoxUname.Text.Length;

            if (!string.IsNullOrEmpty(txtBoxUname.Text))
            {
                label5.Visible = false;
            }
            else
            {
                label5.Visible = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void txtBoxUname_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits, backspace (if needed at the beginning)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && txtBoxUname.SelectionStart == 0)
            {

                e.Handled = true; // Prevent the character from being entered
            }
            // Prevent space character
            else if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
            // Prevent negative sign
            else if (e.KeyChar == '-')
            {
                e.Handled = true;
            }
        }
    }
}
