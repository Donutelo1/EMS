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
using Microsoft.Identity.Client;

namespace EMS
{
    public partial class UpdateSalary: Form
    {
        private decimal dailyRate = 0;
        private int numberOfPresent = 0;

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
        public UpdateSalary()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            InitializeGovernmentBenefitsToZero();
            CalculateSalary();

            txtdailyrate.TextChanged += txtdailyrate_TextChanged;
            txtnoofpres.TextChanged += txtnoofpres_TextChanged;

            txtdailyrate.KeyPress += txtdailyrate_KeyPress;
        }
        private void txtdailyrate_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits, backspace (if needed at the beginning)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b'  && txtdailyrate.SelectionStart == 0)
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

        private void exitBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateSalary_Load(object sender, EventArgs e)
        {
            exitBttn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, exitBttn.Width, exitBttn.Height, 15, 15));
        }
        public void clearFields()
        {
            txtpayrollid.Text = "";
            txtempid.Text = "";
            txtnoofpres.Text = "";
            txtdailyrate.Text = "";
            txtsalary.Text = "";
            txtdep.Text = "";

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
        

            if (txtempid.Text == ""
              || txtpayrollid.Text == "")
            {
                MessageBox.Show("Please Fiil All Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to update " + "Employee ID: " + txtempid.Text.Trim() + "?", "Confimation Message"
                    , MessageBoxButtons.YesNo);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        DateTime today = DateTime.Now;

                        string updateData = "UPDATE Payroll SET Salary = @salary, DateUpdate = @date, SSS = @sss, PagIbig = @pagibig, PhilHealth = @philhealth, TotalDeduction = @deduc WHERE Employee_Id = @id";

                        using (SqlCommand cmd = new SqlCommand(updateData, conn))
                        {
                            cmd.Parameters.AddWithValue("@salary", txtsalary.Text.Trim());
                            cmd.Parameters.AddWithValue("@date", today);
                            cmd.Parameters.AddWithValue("@id", txtempid.Text);
                            cmd.Parameters.AddWithValue("@sss", txtsss.Text);
                            cmd.Parameters.AddWithValue("@pagibig", txtpagibig.Text);
                            cmd.Parameters.AddWithValue("@philhealth", txtphilhealth.Text);
                            cmd.Parameters.AddWithValue("@deduc", txtdeduction.Text);



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

        private void txtdailyrate_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtdailyrate.Text))
            {
                dailyRate = 0;
            }
            else if (decimal.TryParse(txtdailyrate.Text, out dailyRate))
            {
                // Parsing successful, dailyRate is updated
            } 
            else
            {
                dailyRate = 0; // Reset to 0 if invalid input
       
            }
            CalculateSalary(); // Recalculate after any change to dailyRate

            if (decimal.TryParse(txtdailyrate.Text, out dailyRate))
            {
                CalculateSalary();
            }
            else
            {
                dailyRate = 0; // Reset to 0 if invalid
             
            }
        }

        private void txtnoofpres_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtnoofpres.Text, out numberOfPresent))
            {
                CalculateSalary();
            }
            else
            {
                numberOfPresent = 0; // Reset to 0 if invalid
              
            }
        }

        private void CalculateSalary()
        {
            decimal monthlySalary = dailyRate * numberOfPresent;
            decimal sss = CalculateSSS(monthlySalary);
            decimal philhealth = CalculatePhilHealth(monthlySalary);
            decimal pagibig = CalculatePagIbig(monthlySalary);

            decimal netSalary = monthlySalary - sss - philhealth - pagibig;


       

            txtsalary.Text = netSalary.ToString("N2");
            txtsss.Text = sss.ToString("N2");
            txtphilhealth.Text = philhealth.ToString("N2");
            txtpagibig.Text = pagibig.ToString("N2");

            decimal totalDeductions = sss + philhealth + pagibig;
            txtdeduction.Text = totalDeductions.ToString("N2");
        }

        private decimal CalculateSSS(decimal monthlySalary)
        {
            return monthlySalary *0.02m / 2;

            //// Replace with your actual SSS calculation logic
            //if (monthlySalary <= 10000)
            //{
            //    return 450;
            //}
            //else if (monthlySalary <= 15000)
            //{
            //    return 600;
            //}
            //else
            //{
            //    return 750;
            //}
        }

        private decimal CalculatePhilHealth(decimal monthlySalary)
        {
            // Replace with your actual PhilHealth calculation logic
            return monthlySalary * 0.04m / 2;
        }
        private decimal CalculatePagIbig(decimal monthlySalary)
        {
            return monthlySalary * 0.06m / 2;
            // Replace with your actual Pag-IBIG calculation logic
            // return Math.Min(100, monthlySalary * 0.02m);
        }
        private void InitializeGovernmentBenefitsToZero()
        {
            txtsss.Text = "0.00";
            txtphilhealth.Text = "0.00";
            txtpagibig.Text = "0.00";
            txtdeduction.Text = "0.00";
            txtsalary.Text = "0.00"; // Initialize salary to zero as well
        }
        private void txtsalary_Enter(object sender, EventArgs e)
        {
            if (txtsalary.Text == "0")
            {
                txtsalary.Text = "";
                txtsalary.ForeColor = Color.Gray;
            }
        }

        private void txtsalary_Leave(object sender, EventArgs e)
        {
            if (txtsalary.Text == "")
            {
                txtsalary.Text = "0";
                txtsalary.ForeColor = Color.Gray;
            }
        }

        private void txtdailyrate_Enter(object sender, EventArgs e)
        {
            if (txtdailyrate.Text == "0")
            {
                txtdailyrate.Text = "";
                txtdailyrate.ForeColor = Color.Gray;
            }
        }

        private void txtdailyrate_Leave(object sender, EventArgs e)
        {
            if (txtdailyrate.Text == "0")
            {
                txtdailyrate.Text = "";
                txtdailyrate.ForeColor = Color.Gray;
            }
        }

     
    }
}
