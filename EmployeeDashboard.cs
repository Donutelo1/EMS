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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace EMS
{
    public partial class EmployeeDashboard: Form
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

        public EmployeeDashboard()
        {
            InitializeComponent();
       
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));

            customPanel4.Width = dashboardBtn.Width;
            customPanel4.Top = dashboardBtn.Bottom;
        }

        private void LogoutBttn_Click(object sender, EventArgs e)
        {
            DialogResult che = MessageBox.Show("Are you sure you want to logout?"
               , "", MessageBoxButtons.YesNo);
            if (che == DialogResult.Yes)
            {
                SelectUserType f = new SelectUserType();


                f.Show();
                this.Hide();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();

            CheckAndResetTimeInOut();
           
        }
        private void CheckAndResetTimeInOut()
        {
            try
            {
                conn.Open();
                DateTime now = DateTime.Now;
                string attendanceStatus = "Absent"; // Default status

                // Check if it's 9:01 PM or later
                if (now.Hour >= 21 && now.Minute >= 1) // 21 is 9 PM
                {
                    // Reset TimeIn to NULL for all employees
                    string resetQuery = "UPDATE Attendance SET TimeIn = NULL";
                    using (SqlCommand resetCmd = new SqlCommand(resetQuery, conn))
                    {
                        resetCmd.ExecuteNonQuery();
                        // Optionally, log or display a message that TimeIn was reset
                        Console.WriteLine("TimeIn reset at 9:00 PM."); // Or use a logger
                    }
                }

                // Reset TimeOut if it's 9:01 PM or later
                if (now.Hour >= 21 && now.Minute >= 1)
                {
                    string resetTimeOutQuery = "UPDATE Attendance SET TimeOut = NULL";
                    using (SqlCommand resetTimeOutCmd = new SqlCommand(resetTimeOutQuery, conn))
                    {
                        resetTimeOutCmd.ExecuteNonQuery();
                        Console.WriteLine("TimeOut reset at 9:00 PM or later.");
                    }
                }

                // Reset Attendance Status if it's 9:01 PM or later
                if (now.Hour >= 21 && now.Minute >= 1)
                {
                    string resetStatusQuery = "UPDATE Attendance SET AttendanceStatus = NULL";
                    using (SqlCommand resetTimeOutCmd = new SqlCommand(resetStatusQuery, conn))
                    {
                        resetTimeOutCmd.ExecuteNonQuery();
                        Console.WriteLine("Attendance Status reset at 9:00 PM or later.");
                    }
                }


                // Reset Date if it's 9:01 PM or later
                if (now.Hour >= 9 && now.Minute >= 1)
                {
                    string resetStatusQuery = "UPDATE Attendance SET Date = NULL";
                    using (SqlCommand resetTimeOutCmd = new SqlCommand(resetStatusQuery, conn))
                    {
                        resetTimeOutCmd.ExecuteNonQuery();
                        Console.WriteLine("Attendance Status reset at 9:00 PM or later.");
                    }
                }

                if (now.Hour >= 6 && now.Minute >= 00 && now.Hour >= 16 && now.Minute >= 00)
                {
                    string updateQuery = "  UPDATE Attendance SET AttendanceStatus = 'Absent' WHERE TimeIn IS NULL "; 
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", attendanceStatus);
            
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Attendance Status Marked as Absent.");
                    }
                }

            }
            catch (Exception ex)
            {
                // Handle database errors
                Console.WriteLine("Error resetting TimeIn: " + ex.Message); // Or use a logger
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }


        private void EmployeeDashboard_Load(object sender, EventArgs e)
        {


         


            timer1.Start();
            label2.Text = DateTime.Now.ToLongTimeString();

            label3.Text = DateTime.Now.ToLongDateString();

            labelfirstname.Text =  "Good Day, " + " " +  EmployeeLogIn.LoggedInFirstName + "!";


            CheckAndResetTimeInOut();
            // ... other form load code ...

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 60000;
            timer.Tick += timer1_Tick;
            timer.Start();


        }




        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            customPanel4.Width = dashboardBtn.Width;
            customPanel4.Top = dashboardBtn.Bottom;


            empAttendance1.Visible = false;
            editProfile1.Visible = false;
            employeeDBoard1.Visible = true;
        }

        private void attendanceBtn_Click_1(object sender, EventArgs e)
        {
            customPanel4.Width = attendanceBtn.Width;
            customPanel4.Top = attendanceBtn.Bottom;

            empAttendance1.Visible = true;
            editProfile1.Visible = false;
            employeeDBoard1.Visible = false;
        }

        private void myProfileBtn_Click_1(object sender, EventArgs e)
        {
            customPanel4.Width = myProfileBtn.Width;
            customPanel4.Top = myProfileBtn.Bottom;

            empAttendance1.Visible = false;
            editProfile1.Visible = true;
            employeeDBoard1.Visible = false;
        }

        private void salaryBtn_Click(object sender, EventArgs e)
        {
            customPanel4.Width = salaryBtn.Width;
            customPanel4.Top = salaryBtn.Bottom;

            empAttendance1.Visible = false;
            editProfile1.Visible = false;
            employeeDBoard1.Visible = false;
            printPaySlip1.Visible = true;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            // ask the admin if sure to log out
            DialogResult che = MessageBox.Show("Are you sure you want to logout?"
                , "", MessageBoxButtons.YesNo);
            if (che == DialogResult.Yes)
            {
                SelectUserType f = new SelectUserType();
                f.Show();
                this.Hide();
            }
        }
    }
}
