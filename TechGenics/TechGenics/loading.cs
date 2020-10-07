using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace TechGenics
{
    public partial class loading : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
                int left,
                int top,
                int right,
                int bottom,
                int width,
                int height
            );

        int[] rainSpeeds = { 4, 6, 8, 3, 5, 6, 7, 4 };
        int loadingSpeed = 2;
        float initialPercentage = 0;

        frmMainAdmin admin = new frmMainAdmin();

        public loading()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));
        }
             
     
        private void loading_Load_1(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                switch (i)
                {
                    case 0:
                        //animation for rain 1
                        pboRain1.Location = new Point(pboRain1.Location.X, pboRain1.Location.Y + rainSpeeds[i]);
                        if (pboRain1.Location.Y > pnlRain.Size.Height + pboRain1.Size.Height)
                        {
                            pboRain1.Location = new Point(pboRain1.Location.X, 0 - pboRain1.Size.Height);
                        }
                        break;
                    case 1:
                        //animation for rain 2
                        pboRain2.Location = new Point(pboRain2.Location.X, pboRain2.Location.Y + rainSpeeds[i]);
                        if (pboRain2.Location.Y > pnlRain.Size.Height + pboRain2.Size.Height)
                        {
                            pboRain2.Location = new Point(pboRain2.Location.X, 0 - pboRain2.Size.Height);
                        }
                        break;
                    case 2:
                        //animation for rain 3
                        pboRain3.Location = new Point(pboRain3.Location.X, pboRain3.Location.Y + rainSpeeds[i]);
                        if (pboRain3.Location.Y > pnlRain.Size.Height + pboRain3.Size.Height)
                        {
                            pboRain3.Location = new Point(pboRain3.Location.X, 0 - pboRain3.Size.Height);
                        }
                        break;
                    case 3:
                        //animation for rain 4
                        pboRain4.Location = new Point(pboRain4.Location.X, pboRain4.Location.Y + rainSpeeds[i]);
                        if (pboRain4.Location.Y > pnlRain.Size.Height + pboRain4.Size.Height)
                        {
                            pboRain4.Location = new Point(pboRain4.Location.X, 0 - pboRain4.Size.Height);
                        }
                        break;
                    case 4:
                        //animation for rain 5
                        pboRain5.Location = new Point(pboRain5.Location.X, pboRain5.Location.Y + rainSpeeds[i]);
                        if (pboRain5.Location.Y > pnlRain.Size.Height + pboRain5.Size.Height)
                        {
                            pboRain5.Location = new Point(pboRain5.Location.X, 0 - pboRain5.Size.Height);
                        }
                        break;
                    case 5:
                        //animation for rain 6
                        pboRain6.Location = new Point(pboRain6.Location.X, pboRain6.Location.Y + rainSpeeds[i]);
                        if (pboRain6.Location.Y > pnlRain.Size.Height + pboRain6.Size.Height)
                        {
                            pboRain6.Location = new Point(pboRain6.Location.X, 0 - pboRain6.Size.Height);
                        }
                        break;
                    case 6:
                        //animation for rain 7
                        pboRain7.Location = new Point(pboRain7.Location.X, pboRain7.Location.Y + rainSpeeds[i]);
                        if (pboRain7.Location.Y > pnlRain.Size.Height + pboRain7.Size.Height)
                        {
                            pboRain7.Location = new Point(pboRain7.Location.X, 0 - pboRain7.Size.Height);
                        }
                        break;
                    case 7:
                        //animation for rain 8
                        pboRain8.Location = new Point(pboRain8.Location.X, pboRain8.Location.Y + rainSpeeds[i]);
                        if (pboRain8.Location.Y > pnlRain.Size.Height + pboRain8.Size.Height)
                        {
                            pboRain8.Location = new Point(pboRain8.Location.X, 0 - pboRain8.Size.Height);
                        }
                        break;
                }
            }
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            initialPercentage += loadingSpeed;
            float percentage = initialPercentage / pboPuddle.Height * 100;

            lblLoaded.Text = (int)percentage + " %";

            pnlHidePuddle.Location = new Point(pnlHidePuddle.Location.X, pnlHidePuddle.Location.Y + loadingSpeed);
            if (pnlHidePuddle.Location.Y > pboPuddle.Location.Y + pboPuddle.Height)
            {
                lblLoaded.Text = "100 %";
                

            }

            if(lblLoaded.Text == "100 %")
            {
                System.Threading.Thread.Sleep(2000);
                this.Close();
                admin.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
