using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace EMS
{
    public partial class Form1: Form
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


        Timer fadeTimer = new Timer();
        Boolean fadeIn = true;
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            this.Opacity = 0;
            fadeTimer.Interval = 50;
            fadeTimer.Tick += FadeEffect;
            fadeTimer.Start();

            txtUname.KeyDown += txtUname_KeyDown;
            txtPword.KeyDown += txtPword_KeyDown;

            txtPword.TextChanged += txtPword__TextChanged;
        }

       
        private void logInBttn_MouseEnter(object sender, EventArgs e)
        {
          
        }
        private void logInBttn_MouseLeave(object sender, EventArgs e)
        {
            
           
        }
        private void FadeEffect(object sender, EventArgs e)
        {
            if (fadeIn)
            {
                if (this.Opacity < 1)
                    this.Opacity += 0.7;

                else
                    fadeTimer.Stop();
            }
            else
            {
                if (this.Opacity > 0)
                    this.Opacity += 0.7;

                else
                {
                    fadeTimer.Stop();
                    this.Close();
                }
            }
        }
        public void fadeOut()
        {
            fadeIn = false;
            fadeTimer.Start();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            logInBttn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, logInBttn.Width, logInBttn.Height, 10, 10));
            showPassBttn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, showPassBttn.Width, showPassBttn.Height, 15, 15));
            hidePassBttn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, hidePassBttn.Width, hidePassBttn.Height, 15, 15));
            exitBttn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, exitBttn.Width, exitBttn.Height, 5, 5));
            btnmin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnmin.Width, btnmin.Height, 15, 15));

            txtUname.Select();

        }

        private void exitBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectUserType f = new SelectUserType();
            f.Show();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtPword.Select();
            }

        }

        private void hidePassBttn_Click_1(object sender, EventArgs e)
        {
            if (txtPword.PasswordChar == true)
            {
                showPassBttn.BringToFront();
                txtPword.PasswordChar = false;

            }
        }

        private void showPassBttn_Click_1(object sender, EventArgs e)
        {
            if (txtPword.PasswordChar == false)
            {
                hidePassBttn.BringToFront();
                txtPword.PasswordChar = true;

            }
        }

        private void txtUname__TextChanged(object sender, EventArgs e)
        {
            

            if (!string.IsNullOrEmpty(txtUname.Texts))
            {
                label5.Visible = false;
            }
            else
            {
                label5.Visible = true;
            }
        }

        

    

        private void txtPword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                logInBttn.PerformClick();
            }
        }

        private void txtPword__TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPword.Texts))
            {
                label1.Visible = false;
            }
            else
            {
                label1.Visible = true;
            }
        }

        private void logInBttn_Click_1(object sender, EventArgs e)
        {
            string username = txtUname.Texts.Trim();
            string password = txtPword.Texts.Trim();

            if (txtUname.Texts == "" && txtPword.Texts == "")
            {
                label5.Text = "username can't be blank!";
                label1.Text = "password can't be blank!";
            }

            else
            {
                if (conn.State != ConnectionState.Open)
                {
                    try
                    {
                        conn.Open();

                        String selectData = "SELECT * FROM Admin WHERE BINARY_CHECKSUM (Username) = BINARY_CHECKSUM (@Username) AND BINARY_CHECKSUM (Password) = BINARY_CHECKSUM (@Pass)";
                        using (SqlCommand cmd = new SqlCommand(selectData, conn))
                        {
                            cmd.Parameters.AddWithValue("@Username", txtUname.Texts);
                            cmd.Parameters.AddWithValue("@Pass", txtPword.Texts);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {


                                AdminForm Form2 = new AdminForm();
                                Form2.Show();
                                this.Hide();

                            }
                            else if (txtUname.Texts == "")
                            {

                                label5.Text = "username can't be blank!";
                            }
                            else if (txtPword.Texts == "")
                            {

                                label1.Text = "password can't be blank!";
                            }

                            else
                            {
                                MessageBox.Show("Incorect Username or Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                //         txtUname.Texts.Clear();
                                //      txtBoxPword.Clear();
                                txtUname.Focus();
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

        private void txtUname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtPword.Select();
            }
        }
    }
}
