using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace EMS
{
    public partial class AddDepartment : Form
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
        public AddDepartment()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));


        }
        private void cancelBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddDept f = new AddDept();
            f.Show();
        }
        public void clearFields()
        {
            txtDeptName.Text = "";
            txtStatus.Text = "";

        }
        private void browseBttn_Click(object sender, EventArgs e)
        {

            try
            {

                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)| *.jpg;*.png";
                string imagePath = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    //    pictureBox1.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddHrFrm_Load(object sender, EventArgs e)
        {
            exitBttn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, exitBttn.Width, exitBttn.Height, 15, 15));
            adddeptBttn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, adddeptBttn.Width, adddeptBttn.Height, 15, 15));
            cancelBttn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cancelBttn.Width, cancelBttn.Height, 15, 15));
            updateBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, updateBtn.Width, updateBtn.Height, 15, 15));
            backBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, backBtn.Width, backBtn.Height, 15, 15));
        }

        private void labelhrid_Click(object sender, EventArgs e)
        {

        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (txtStatus.Text == ""
               || txtDeptName.Text == ""
           )
            {
                MessageBox.Show("Please Fiil All Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to update " + "Department: " + txtDeptName.Text.Trim() + "?", "Confimation Message"
                    , MessageBoxButtons.YesNo);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE Department SET Status = @status,Department_Name  = @deptName, DateEdited = @date WHERE ID = @id";

                        using (SqlCommand cmd = new SqlCommand(updateData, conn))
                        {
                            cmd.Parameters.AddWithValue("@status", txtStatus.Text.Trim());
                            cmd.Parameters.AddWithValue("@deptName", txtDeptName.Text.Trim());
                            cmd.Parameters.AddWithValue("@date", today);
                            cmd.Parameters.AddWithValue("@id", DEPTID.Text);


                            cmd.ExecuteNonQuery();
   
                            MessageBox.Show("Update Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public event Action DepartmentAdded;
        private void adddeptBttn_Click(object sender, EventArgs e)
        {
            if (txtDeptName.Text == ""
            || txtStatus.Text == "")
            {
                MessageBox.Show("Please Fill All Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (conn.State == ConnectionState.Closed)
                {
                    try
                    {
                        conn.Open();
                        string checkEmID = "SELECT COUNT (*) FROM Department WHERE Department_Name = @deptName ";        //AND DateEdited IS NOT NULL

                        using (SqlCommand checkEm = new SqlCommand(checkEmID, conn))
                        {
                            checkEm.Parameters.AddWithValue("@deptName", txtDeptName.Text.Trim());

                            int count = (int)checkEm.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(txtDeptName.Text.Trim() + "is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;

                                string insertData = "INSERT INTO Department (Status, Department_Name)"
                                    + "VALUES (@status, @department)";



                                using (SqlCommand cmd = new SqlCommand(insertData, conn))
                                {
                                    cmd.Parameters.AddWithValue("@status", txtStatus.Text.Trim());
                                    cmd.Parameters.AddWithValue("@department", txtDeptName.Text.Trim());
                  
                                    cmd.ExecuteNonQuery();
                                    DepartmentAdded?.Invoke();
                                    MessageBox.Show("Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    
                                    clearFields();
                                }

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();


                    }
                }
            }
        }
    }
}