using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisioForge.MediaFramework.ONVIF;

namespace TechGenics
{
    static class controls
    {
        static bool isMax = false;
        static bool isFull = false;

        static Point location;
        static Point defLocation;

        static Size size;
        static Size defSize;

        public static void SetInitial(Form form)
        {
            location = form.Location;
            size = form.Size;
            defLocation = form.Location;
            defSize = form.Size;
        }

        public static void doMax(Form form, Button buttonMax)
        {
            if (isMax == false)
            {
                location = new Point(form.Location.X, form.Location.Y);
                size = new Size(form.Size.Width, form.Size.Height);

                maximize(form);
                isMax = true;
                isFull = false;

                buttonMax.Text = "2";
            }
            else
            {
                if (size.Width >= SystemInformation.WorkingArea.Width || size.Height >= SystemInformation.WorkingArea.Height)
                {
                    form.Location = defLocation;
                    form.Size = defSize;
                }
                else
                {
                    form.Location = defLocation;
                    form.Size = defSize;
                }
                
                isMax = false;
                isFull = false;
                buttonMax.Text = "1";
            }
        }

        public static void doFullscreen(Form form)
        {
            if (isFull == false)
            {
                location = new Point(form.Location.X, form.Location.Y);
                size = new Size(form.Size.Width, form.Size.Height);

                fullscreen(form);
                isMax = false;
                isFull = true;

                //buttonMax.Text = "2";
            }
            else
            {
                if (size.Width >= SystemInformation.WorkingArea.Width || size.Height >= SystemInformation.WorkingArea.Height)
                {
                    form.Location = defLocation;
                    form.Size = defSize;
                }
                else
                {
                    form.Location = defLocation;
                    form.Size = defSize;
                }
                fullscreen(form);
                isMax = false;
                isFull = false;
            }
        }

        public static void minimize(Form form)
        {
            if (form.WindowState == FormWindowState.Minimized)
            {

                form.WindowState = FormWindowState.Normal;
            }
            else if (form.WindowState == FormWindowState.Normal)
            {
                form.WindowState = FormWindowState.Minimized;
            }
        }

        static void fullscreen(Form form)
        {
            if (form.WindowState == FormWindowState.Maximized)
            {
                form.WindowState = FormWindowState.Normal;
            }
            else if (form.WindowState == FormWindowState.Normal)
            {
                form.WindowState = FormWindowState.Maximized;
            }
        }

        static void maximize(Form form)
        {
            int x = SystemInformation.WorkingArea.Width;
            int y = SystemInformation.WorkingArea.Height;
            form.WindowState = FormWindowState.Normal;
            form.Size = new Size(x, y);
        }
    }
}
