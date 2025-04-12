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
    public partial class SelectUserType: Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-GOK6444\SQLEXPRESS01;Initial Catalog=ConnectionDb;Integrated Security=True;Encrypt=False");

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

        public SelectUserType()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void SelectUserType_Load(object sender, EventArgs e)
        {
            //HrBttn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, HrBttn.Width, HrBttn.Height, 15, 15));
            AdminBttn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, AdminBttn.Width, AdminBttn.Height, 15, 15));
            EmployeeBttn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, EmployeeBttn.Width, EmployeeBttn.Height, 15, 15));
        }

        private void AdminBttn_Click(object sender, EventArgs e)
        {
            
            Form1 f = new Form1();
            f.Show();
            this.Hide();
           
        }

        private void BackBttn_Click(object sender, EventArgs e)
        {
           
        }

        private void EmployeeBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeLogIn f = new EmployeeLogIn();
            f.Show();
        }

        private void HrBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HrLogIn f = new HrLogIn();
            f.Show();
        }
    }
}
