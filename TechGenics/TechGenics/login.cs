using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechGenics
{
    public partial class login_signup : Form
    {
        public login_signup()
        {
            InitializeComponent();
            //testing
        }

        loading loadScreen = new loading();

        private void label4_Click(object sender, EventArgs e)
        {
            //pnlLogin.Visible = false;
            pnlSignUp.Visible = true;

            timer1.Start();
        }
                               
        private void button1_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = true;
            //pnlSignUp.Visible = false;
            timer3.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(btnMode.BackColor == Color.DarkGray)
            {
                darkMode();

            }
            else if(btnMode.BackColor == Color.Black)
            {

                lightMode();
            }
        }

        public void darkMode()
        {
            this.BackColor = Color.Black;

            btnMode.BackColor = Color.Black;
            btnMode.Text = "Dark Mode";

            //login
            userIcon.Image = Properties.Resources.user2_dark;
            passIcon.Image = Properties.Resources.pass2_dark;
            
            txtUsername.BackColor = Color.Black;
            txtUsername.ForeColor = Color.White;
            txtPassword.BackColor = Color.Black;
            txtPassword.ForeColor = Color.White;

            //sign up
            txtFirst.BackColor = Color.Black;
            txtFirst.ForeColor = Color.White;
            txtLast.BackColor = Color.Black;
            txtLast.ForeColor = Color.White;
            txtEmail.BackColor = Color.Black;
            txtEmail.ForeColor = Color.White;
            txtSUser.BackColor = Color.Black;
            txtSUser.ForeColor = Color.White;
            txtSPass.BackColor = Color.Black;
            txtSPass.ForeColor = Color.White;
            txtSCPass.BackColor = Color.Black;
            txtSCPass.ForeColor = Color.White;
        }

        public void lightMode()
        {
            this.BackColor = Color.DarkGray;

            btnMode.BackColor = Color.DarkGray;
            btnMode.Text = "Light Mode";

            //login
            userIcon.Image = Properties.Resources.uLightmode;
            passIcon.Image = Properties.Resources.lightmode;
          
            txtUsername.BackColor = Color.DarkGray;
            txtUsername.ForeColor = Color.Black;
            txtPassword.BackColor = Color.DarkGray;
            txtPassword.ForeColor = Color.Black;

            //sign up
            txtFirst.BackColor = Color.DarkGray;
            txtFirst.ForeColor = Color.Black;
            txtLast.BackColor = Color.DarkGray;
            txtLast.ForeColor = Color.Black;
            txtEmail.BackColor = Color.DarkGray;
            txtEmail.ForeColor = Color.Black;
            txtSUser.BackColor = Color.DarkGray;
            txtSUser.ForeColor = Color.Black;
            txtSPass.BackColor = Color.DarkGray;
            txtSPass.ForeColor = Color.Black;
            txtSCPass.BackColor = Color.DarkGray;
            txtSCPass.ForeColor = Color.Black;
        }
                        
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            //txtUsername.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Enabled = false;
            loadScreen.Show();
            
        }

        private void txtUsername_Click_1(object sender, EventArgs e)
        {
            txtUsername.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

                pnlSignUp.Left += 10;
                if (pnlSignUp.Left >= 650)
                {
                    timer1.Stop();
                    timer2.Start();
                    
            }
                       
        }

        private void timer2_Tick(object sender, EventArgs e)
        {           
                pnlSignUp.Left -= 10;
                
                pnlLogin.SendToBack();
            
            if (pnlSignUp.Left <= 455)
                {
                  
                  timer2.Stop();
                pnlLogin.Visible = false;
            }
                                        
        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {
            pnlLogin.Left -= 10;
            if (pnlLogin.Left <= 175)
            {
                timer3.Stop();
                
                timer4.Start();
                
            }
        }

        private void timer4_Tick_1(object sender, EventArgs e)
        {

            pnlLogin.Left += 10;
            pnlLogin.BringToFront();
            if (pnlLogin.Left >= 435)
            {
                timer4.Stop();
                pnlSignUp.Visible = false;
            }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtPassword.UseSystemPasswordChar = true;
        }

        //backend
    }
}
