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
    public partial class NotificationError: Form
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
        public NotificationError()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));


        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void NotificationError_Load(object sender, EventArgs e)
        {
            btnokay.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnokay.Width, btnokay.Height, 5, 5));
        }
    }
}
