using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using Microsoft.VisualBasic;

namespace TechGenics
{
    public partial class login_signup : Form
    {
        public login_signup()
        {
            InitializeComponent();
            
        }

        loading loadScreen = new loading();

        //email info
        public string emailAddress = "techGenics624@gmail.com";
        public string emailPassword = "@ITRI624";
        public string emailSubject = "Welcome to TechGenics";
        public string validationCode;
        public string userName;
        
                                      
        private void btnRegister_Click(object sender, EventArgs e)
        {
            userName = txtFirst.Text;

            pnlLogin.Visible = true;
            pnlLogin.Enabled = false;
            
            timer3.Start();


            //send email
            Random random = new Random();
            validationCode = random.Next(0, 1000).ToString();

            using (MailMessage mail = new MailMessage())
            {
                try
                {
                    //MailMessage mail = new MailMessage();
                    SmtpClient smpt = new SmtpClient("smtp.gmail.com", 587);
                    mail.From = new MailAddress(emailAddress);
                    mail.To.Add(new MailAddress(txtEmail.Text));
                    mail.Subject = emailSubject;
                    mail.Body = "Hello " + userName + ", \n\n " + "Please enter the following code before proceeding to Login." + "\n" + validationCode;

                    smpt.Port = 587;
                    smpt.Credentials = new System.Net.NetworkCredential(emailAddress, emailPassword);
                    smpt.EnableSsl = true;
                    smpt.Send(mail);

                    //popup saying email has been sent


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            //inputBox for email validate
            string userCode = Interaction.InputBox("Enter Code", "Validation");
            if (userCode == validationCode)
            {
                pnlLogin.Enabled = true;
            }
            
        }

        private void btnMode_Click(object sender, EventArgs e)
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
            pboUserIcon.Image = Properties.Resources.user2_dark;
            pboPassIcon.Image = Properties.Resources.pass2_dark;
            
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
            pboUserIcon.Image = Properties.Resources.uLightmode;
            pboPassIcon.Image = Properties.Resources.lightmode;
          
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
                        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Enabled = false;
            loadScreen.Show();
            
        }

        private void txtUsername_Click(object sender, EventArgs e)
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

        
        private void lblSignUp_Click(object sender, EventArgs e)
        {
            pnlSignUp.Visible = true;

            timer1.Start();
        }

        private void txtFirst_Click(object sender, EventArgs e)
        {
            txtFirst.Clear();
        }

        private void txtLast_Click(object sender, EventArgs e)
        {
            txtLast.Clear();
        }

        private void txtSUser_Click(object sender, EventArgs e)
        {
            txtSUser.Clear();
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
        }

        private void txtSPass_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void txtSCPass_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtPassword.UseSystemPasswordChar = true;
        }


        //backend
    }
}
