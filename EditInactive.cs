using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace EMS
{
    public partial class EditInactive: Form
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
        public EditInactive()
        {
            InitializeComponent();


            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void exitBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void clearFields()
        {
            txtGmail.Text = "";
            txtEmpid.Text = "";
            cmbStatus.SelectedIndex = -1;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (txtGmail.Text == ""
             || txtEmpid.Text == ""
             || cmbStatus.Text == "")
            {
                MessageBox.Show("Please Fiil All Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to update " + "Employee ID: " + txtEmpid.Text.Trim() + "?", "Confimation Message"
                    , MessageBoxButtons.YesNo);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();


                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE Employees SET Status = @status, Gmail = @gmail, DateUpdate = @date WHERE Employee_Id = @id";

                        using (SqlCommand cmd = new SqlCommand(updateData, conn))
                        {
                            cmd.Parameters.AddWithValue("@status", cmbStatus.Text.Trim());
                            cmd.Parameters.AddWithValue("@gmail", txtGmail.Text.Trim());
                            cmd.Parameters.AddWithValue("@id", txtEmpid.Text.Trim());
                            cmd.Parameters.AddWithValue("date", today);

                            cmd.ExecuteNonQuery();
                            Salary salsal = new Salary();
                            salsal.displayEmployeeData();

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

        private void EditInactive_Load(object sender, EventArgs e)
        {
            exitBttn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, exitBttn.Width, exitBttn.Height, 15, 15));
            addEmpBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, addEmpBtn.Width, addEmpBtn.Height, 15, 15));
            cancelBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cancelBtn.Width, cancelBtn.Height, 15, 15));
            UpdateBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, UpdateBtn.Width, UpdateBtn.Height, 15, 15));
            BackBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BackBtn.Width, BackBtn.Height, 15, 15));
        }

        private void cmbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to delete " + "Employee Id: " + txtEmpid.Text.Trim() + "?", "Confimation Message"
        , MessageBoxButtons.YesNo);

            if (check == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    DateTime today = DateTime.Today;

                    string updateData = "Update Employees SET DateDelete = @dateDelete " +
                        "WHERE Employee_Id = @employeeId";

                    using (SqlCommand cmd = new SqlCommand(updateData, conn))
                    {
                        cmd.Parameters.AddWithValue("@dateDelete", today);
                        cmd.Parameters.AddWithValue("@employeeId", txtEmpid.Text.Trim());

                        cmd.ExecuteNonQuery();

                

                        MessageBox.Show("delete Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clearFields();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Del: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
}
