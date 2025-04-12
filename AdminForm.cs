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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
namespace EMS
{
    public partial class AdminForm: Form
    {
        private Timer refreshTimer;

        // connection string
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

        public AdminForm()
        {
            InitializeComponent();

            // for form border to make it round
            this.FormBorderStyle = FormBorderStyle.None; 
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));


            this.Opacity = 0;
            fadeTimer.Interval = 50;
            fadeTimer.Tick += FadeEffect;
            fadeTimer.Start();


            customPanel4.Width = dashboardBttn.Width;
            customPanel4.Top = dashboardBttn.Bottom;

        }
       
        private void FadeEffect(object sender, EventArgs e)
        {
            // effect
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

        private void AdminForm_Load(object sender, EventArgs e)
        {
     
            // Date and time
            timer1.Start();
            label2.Text = DateTime.Now.ToLongTimeString();

            label3.Text = DateTime.Now.ToLongDateString();
        }

    
  
     

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        


        private void dashboardBttn_Click_1(object sender, EventArgs e)
        {
            // side panel indicator
            customPanel4.Width = dashboardBttn.Width;
            customPanel4.Top = dashboardBttn.Bottom;

            archive1.Visible = false;
            viewAuditLogs1.Visible = false;
            attendance1.Visible = false;
            dashboard1.Visible = true; // show the dashboard control
            addEmployee1.Visible = false;
            salary1.Visible = false;
            addHr1.Visible = false;
            logHistory1.Visible = false;

            Dashboard dashForm = dashboard1 as Dashboard;

            if (dashForm != null)
            {
                dashForm.RefreshData();
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            // side panel indicator
            customPanel4.Width = AddDepartmentBttn.Width;
            customPanel4.Top = AddDepartmentBttn.Bottom;


            archive1.Visible = false;
            viewAuditLogs1.Visible = false;
            attendance1.Visible = false;
            dashboard1.Visible = false;
            addEmployee1.Visible = false;
            salary1.Visible = false;
            addHr1.Visible = true; // show the panel to add department
            logHistory1.Visible = false;

            AddDept addDept = addHr1 as AddDept;
            if (addDept != null)
            {
                addDept.Refresh();
            }
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            // side panel indicator
            customPanel4.Width = AddEmpBttn.Width;
            customPanel4.Top = AddEmpBttn.Bottom;


            archive1.Visible = false;
            viewAuditLogs1.Visible = false;
            attendance1.Visible = false;
            dashboard1.Visible = false;
            addEmployee1.Visible = true; // the control to add employee
            salary1.Visible = false;
            addHr1.Visible = false;
            logHistory1.Visible = false;

            AddEmployee addEmFrom = addEmployee1 as AddEmployee;
            if (addEmFrom != null)
            {
                addEmFrom.RefreshData();
            }
        }

        private void iconButton1_Click_2(object sender, EventArgs e)
        {
            // side panel indicator
            customPanel4.Width = attendanceBtn.Width;
            customPanel4.Top = attendanceBtn.Bottom;


            dashboard1.Visible = false;
            addEmployee1.Visible = false;
            addHr1.Visible = false;
            logHistory1.Visible = false;
            salary1.Visible = false;
            archive1.Visible = false;
            attendance1.Visible = true; // show the attendance control to view attendance
            viewAuditLogs1.Visible = false;
        }

        private void archiveBtn_Click_1(object sender, EventArgs e)
        {
            // side panel indicator
            customPanel4.Width = archiveBtn.Width;
            customPanel4.Top = archiveBtn.Bottom;


            dashboard1.Visible = false;
            addEmployee1.Visible = false;
            salary1.Visible = false;
            addHr1.Visible = false;
            logHistory1.Visible = false;
            archive1.Visible = true; // show the control to view archive
            viewAuditLogs1.Visible = false;
            attendance1.Visible = false;

        }

        private void LogHistoryBtn_Click_1(object sender, EventArgs e)
        {
            // side panel indicator
            customPanel4.Width = LogHistoryBtn.Width;
            customPanel4.Top = LogHistoryBtn.Bottom;


            dashboard1.Visible = false;
            addEmployee1.Visible = false;
            salary1.Visible = false;
            addHr1.Visible = false;
            logHistory1.Visible = true; // show the control view wthe log history
            archive1.Visible = false;
            viewAuditLogs1.Visible = false;
            attendance1.Visible = false;
        }

        private void SalaryBtn_Click_1(object sender, EventArgs e)
        {
            // side panel indicator
            customPanel4.Width = SalaryBtn.Width;
            customPanel4.Top = SalaryBtn.Bottom;


            attendance1.Visible = false;
            dashboard1.Visible = false;
            addEmployee1.Visible = false;
            salary1.Visible = true; // show the salary control
            addHr1.Visible = false;
            logHistory1.Visible = false;
            archive1.Visible = false;
            viewAuditLogs1.Visible = false;
        }

        private void btnAuditlogs_Click_1(object sender, EventArgs e)
        {
            // side panel indicator
            customPanel4.Width = btnAuditlogs.Width;
            customPanel4.Top = btnAuditlogs.Bottom;


            dashboard1.Visible = false;
            addEmployee1.Visible = false;
            addHr1.Visible = false;
            logHistory1.Visible = false;
            salary1.Visible = false;
            archive1.Visible = false;
            attendance1.Visible = false;
            viewAuditLogs1.Visible = true; // show the control to view audit logs
        }

        private void logoutbtn_Click(object sender, EventArgs e)
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
