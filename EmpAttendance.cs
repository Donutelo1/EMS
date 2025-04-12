using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Data.SqlClient;
using System.IO;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace EMS
{
    public partial class EmpAttendance: UserControl
    {
        private string employeeId;

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
        public EmpAttendance()
        {
            InitializeComponent();
        }
        private void Attendace_Load(object sender, EventArgs e)
        {
            timeInBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0,    timeInBtn.Width, timeInBtn.Height, 5, 5));
            timeOutBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, timeOutBtn.Width, timeOutBtn.Height, 5, 5));

            txtEmpId.Text = EmployeeLogIn.LoggedInUSername;

            txtTimeOut.Text = EmployeeLogIn.LoggedInUSername;

            CheckAndResetMonthly();
            //... rest of form load code.
            System.Windows.Forms.Timer monthlyResetTimer = new System.Windows.Forms.Timer();
            monthlyResetTimer.Interval = 60000; //  minute (check once a day)
            monthlyResetTimer.Tick += monthlyreset_Tick;
            monthlyResetTimer.Start();

        }
        private void ResetNoOfPresentMonthly()
        {
            try
            {
                conn.Open();

                // Reset No_Of_Present for all employees
                string resetQuery = "UPDATE Attendance SET No_Of_Present = 0";

                using (SqlCommand resetCmd = new SqlCommand(resetQuery, conn))
                {
                    resetCmd.ExecuteNonQuery();
                    //      Console.WriteLine("No_Of_Present reset for all employees.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error resetting No_Of_Present: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        private void CheckAndResetMonthly()
        {
            DateTime today = DateTime.Today;

            if (today.Day == 1 && today.Hour == 0 && today.Minute >= 0 && today.Minute <= 10) // Check if it's the first day of the month
            {
                ResetNoOfPresentMonthly();
            }
        }

        private void txtTimeIn_Enter(object sender, EventArgs e)
        {
            if (txtEmpId.Text == "enter employee ID here...")
            {
                txtEmpId.Text = "";
                txtEmpId.ForeColor = Color.Gray;
            }
        }

        private void txtTimeIn_Leave(object sender, EventArgs e)
        {
            if (txtEmpId.Text == "")
            {
                txtEmpId.Text = "enter employee ID here...";
                txtEmpId.ForeColor = Color.Gray;
            }
        }
        private void txtTimeOut_Enter(object sender, EventArgs e)
        {
            if (txtTimeOut.Text == "enter employee ID here...")
            {
                txtTimeOut.Text = "";
                txtTimeOut.ForeColor = Color.Gray;
            }
        }
        private void txtTimeOut_Leave(object sender, EventArgs e)
        {
            if (txtTimeOut.Text == "")
            {
                txtTimeOut.Text = "enter employee ID here...";
                txtTimeOut.ForeColor = Color.Gray;
            }
        }



        private void timeInBtn_Click(object sender, EventArgs e)
        {
            if (txtEmpId.Text.Trim() == "")
            {
                MessageBox.Show("Enter your Employee id", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want Time In " + "?", "Confimation Message"
                    , MessageBoxButtons.YesNo);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();

                        DateTime today = DateTime.Now;
                   

                        string empId = txtEmpId.Text.Trim();
                        string attendanceStatus = "Absent"; // Default status

                        //Check if there is already a time -in for this employee today

                        string checkQuery = " SELECT COUNT(*) FROM Attendance WHERE Employee_Id = @id AND TimeIn is NOT NULL ";
                        using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                        {
                            checkCmd.Parameters.AddWithValue("@id", empId);
                            checkCmd.Parameters.AddWithValue("@today", today);
                            int count = (int)checkCmd.ExecuteScalar();

                            if (count > 0)
                            {
                                MessageBox.Show("You have already timed in today.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return; // Exit the method
                            }
                        }

                        // 2. Determine Attendance Status
                        if (today.Hour == 6 && today.Minute >= 30 || today.Hour == 7 && today.Minute <= 10)
                        {
                            attendanceStatus = "Present";
                        }
                        else if (today.Hour >= 7 && today.Minute > 11 && today.Hour < 16) // up to 2pm
                        {
                            attendanceStatus = "Late";
                        }

                        // 2. Check if the time is within 7AM - 4PM
                        if (today.Hour >= 7 && today.Hour < 16)
                        {

                            string updateData = "UPDATE Attendance SET AttendanceStatus = @status ,Date = @date ,TimeIn = @timeIn WHERE (Employee_Id) =  (@id); INSERT INTO AuditLogsTimeIn (Employee_Id ,Date, TimeIn, AttendanceStatus) Values (@id, @date, @timeIn, @status) ";

                            using (SqlCommand cmd = new SqlCommand(updateData, conn))
                            {

                                cmd.Parameters.AddWithValue("@id", txtEmpId.Text.Trim());
                                cmd.Parameters.AddWithValue("@date", today);
                                cmd.Parameters.AddWithValue("@timeIn", today);
                                cmd.Parameters.AddWithValue("@status", attendanceStatus);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Time In Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                IncrementNoOfPresent(empId);
                            }
                           
                        }

                        else
                        {
                            MessageBox.Show("Time in is only allowed between 7:00 AM and 4:00 PM.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close(); //connenction close
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void IncrementNoOfPresent(string empId)
        {
            try
            {

                string incrementQuery = "UPDATE Attendance SET No_Of_Present = ISNULl (No_Of_Present, 0)  + 1 WHERE Employee_Id = @id; UPDATE Payroll SET No_Of_Present = ISNULl (No_Of_Present, 0)  + 1 WHERE Employee_Id = @id ";
                using (SqlCommand incrementCmd = new SqlCommand(incrementQuery, conn))
                {
                    incrementCmd.Parameters.AddWithValue("@id", empId);
                    incrementCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error incrementing No_Of_Present: " + ex.Message);
            }
        }






        private void timeOutBtn_Click(object sender, EventArgs e)
        {
            if (txtTimeOut.Text == "")

            {
                MessageBox.Show("Enter your Employee id", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want Time Out" + "?", "Confimation Message"
                    , MessageBoxButtons.YesNo);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();


                        DateTime today = DateTime.Now;
                        DateTime now = DateTime.Now;

                        string empId = txtTimeOut.Text.Trim();


                        // 1. Check if the employee has timed in today                 SELECT COUNT(*) FROM Attendance WHERE Employee_Id = @id AND CAST(Date AS DATE) = CAST(@today AS DATE) AND TimeIn IS NOT NULL
                        string checkTimeInQuery = "SELECT COUNT(*) FROM Attendance WHERE Employee_Id = @id AND TimeIn IS NOT NULL";
                            using (SqlCommand checkTimeInCmd = new SqlCommand(checkTimeInQuery, conn))
                            {
                                checkTimeInCmd.Parameters.AddWithValue("@id", empId);
                                checkTimeInCmd.Parameters.AddWithValue("@today", today);

                                int timeInCount = (int)checkTimeInCmd.ExecuteScalar();

                                if (timeInCount == 0)
                                {
                                    MessageBox.Show("You must time in before you can time out.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return; // Exit the method
                                }
                            }

                        //Check if there is already a time -out for this employee today

                        string checkQuery = " SELECT COUNT(*) FROM Attendance WHERE Employee_Id = @id AND TimeOut is NOT NULL ";
                        using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                        {
                            checkCmd.Parameters.AddWithValue("@id", empId);
                            checkCmd.Parameters.AddWithValue("@today", today);
                            int count = (int)checkCmd.ExecuteScalar();

                            if (count > 0)
                            {
                                MessageBox.Show("You have already timed Out today.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return; // Exit the method
                            }
                        }


                        string updateData = "UPDATE Attendance SET TimeOut = @timeOut WHERE Employee_Id = @id ; UPDATE AuditLogsTimeIn SET TimeOut = @timeOut Where Employee_Id = @id "; 

                            using (SqlCommand cmd = new SqlCommand(updateData, conn))
                            {

                                cmd.Parameters.AddWithValue("@id", txtTimeOut.Text.Trim());
                                cmd.Parameters.AddWithValue("@timeOut", today);
                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("TIme Out Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void monthlyreset_Tick(object sender, EventArgs e)
        {
            CheckAndResetMonthly();
        }
    }
}
