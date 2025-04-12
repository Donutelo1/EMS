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

namespace EMS
{
    public partial class LoadingScreen: Form
    {
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
        public LoadingScreen()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));


            this.Opacity = 0;
            fadeTimer.Interval = 50;
            fadeTimer.Tick += FadeEffect;
            fadeTimer.Start();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 6;
            if(panel2.Width >= 556)
            {
                timer1.Stop();
                this.Hide();
                SelectUserType f = new SelectUserType();
                f.Show();
            }

        }

        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
