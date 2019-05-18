using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            menü11.BringToFront();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            menü11.BringToFront();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            menu21.BringToFront();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            menu31.BringToFront();

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            menu41.BringToFront();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.facebook.com/xelarmen");
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.twitter.com/xelarmen");
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.instagram.com/xelarmennn/");
        }
        int Mov;
        int mx;
        int my;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = 1;
            mx = e.X;
            my = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = 0;

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;//simge durumuna getirir
        }
    }
}
