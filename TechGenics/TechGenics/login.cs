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
using TechGenics.Models;

namespace TechGenics
{
    public partial class login_signup : Form
    {
        /// <summary>
        /// All params that are used on this form
        /// </summary>
        #region  Params
        loading loadScreen = new loading();

        //email info
        public string emailAddress = "techGenics624@gmail.com";
        public string emailPassword = "@ITRI624";
        public string emailSubject = "Welcome to TechGenics";
        public string validationCode;
        public string userFirstName;

        //User model
        List<User> _users = new List<User>();
        #endregion

        /// <summary>
        /// Form Initialize
        /// </summary>
        #region Form Initialize
        public login_signup()
        {
            InitializeComponent();
        }
        #endregion

        /// <summary>
        /// Mehtods used for general purpose
        /// </summary>
        #region General Methods

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

        //enter default text if textbox empty
        public void defaultText()
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
            }

            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";

            }

            if (txtFirst.Text == "")
            {
                txtFirst.Text = "First Name";
            }

            if (txtLast.Text == "")
            {
                txtLast.Text = "Surname";
            }

            if (txtSUser.Text == "")
            {
                txtSUser.Text = "Username";
            }

            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
            }

            if (txtSPass.Text == "")
            {
                txtSPass.Text = "Password";

            }

            if (txtSCPass.Text == "")
            {
                txtSCPass.Text = "Confirm Password";
            }

            
        }

        public void passwordChar()
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.UseSystemPasswordChar = false;
                
            }
           

            if (txtSPass.Text == "Password")
            {
                txtSPass.UseSystemPasswordChar = false;
            }

            if (txtSCPass.Text == "Confirm Password")
            {
                txtSCPass.UseSystemPasswordChar = false;
            }
        }

        public bool validatePassword(string password)
        {
            //Length = 8, number, uppercase, lowercase, special character
            bool hasNumber = false;
            bool hasUpper = false;
            bool hasLower = false;
            bool hasSpecial = false;
            bool validate = false;

            char cCharacter;

            int minLength = 8;

            if (!(password.Length >= minLength))
            {
                validate = false;
                
            }

            for (int i = 0; i < password.Length; i++)
            {
                cCharacter = password[i];
                if (char.IsDigit(cCharacter))
                {
                    hasNumber = true;
                }
                else if (char.IsUpper(cCharacter))
                {
                    hasUpper = true;
                }
                else if (char.IsLower(cCharacter))
                {
                    hasLower = true;
                }
                else if (!char.IsLetterOrDigit(cCharacter))
                {
                    hasSpecial = true;
                }

                if (hasNumber && hasUpper && hasLower && hasSpecial)
                {
                    
                    validate = true;
                }
                else
                {
                    
                    validate = false;
                }
                    
            }

            return validate;
        }
        #endregion

        /// <summary>
        /// All control event handlers
        /// </summary>
        #region Event Handlers

        /// <summary>
        /// All On_Click event handlers
        /// </summary>
        #region On Click
        /// <summary>
        /// Logs in an existing user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //Finds entries in list where username = txtUsername.Text
                DataAccess db = new DataAccess();
                _users = db.GetUsers(txtUsername.Text);

                //Converts list to dataset using the ListToDataSet Class and ToDataSet method inside because lists<T> are a pain to work with
                DataSet ds = new DataSet();
                ds = ListToDataSet.ToDataSet(_users);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    //Checks if user name and password combination exists where returned data set is filtered by entered username, will always be Row[0] becaus of this
                    if (ds.Tables[0].Rows[0]["UserName"].ToString() != txtUsername.Text || ds.Tables[0].Rows[0]["UserPassword"].ToString() != txtPassword.Text)
                    {
                        MessageBox.Show("The username or password is incorrect.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (ds.Tables[0].Rows[0]["UserName"].ToString() == txtUsername.Text && ds.Tables[0].Rows[0]["UserPassword"].ToString() == txtPassword.Text)
                    {
                        MessageBox.Show("Loged in Successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else 
                {
                    MessageBox.Show("The username or password is incorrect.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
                //Can also use List<T> in this case "user" as a datasource for anything
                //cmbTest.Refresh();
                //cmbTest.DataSource = _users;
                //cmbTest.DisplayMember = "FullInfo";
                //cmbTest.ValueMember = "UserId";

                this.Hide();
                this.Enabled = false;
                loadScreen.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An errors has occurred while trying to login." + ex.Message);
            }           
        }

        /// <summary>
        /// Register a new user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                DataAccess db = new DataAccess();
                _users = db.GetUsers(txtSUser.Text);

                //Converts list to dataset using the ListToDataSet Class and ToDataSet method inside because lists<T> are a pain to work with
                DataSet ds = new DataSet();
                ds = ListToDataSet.ToDataSet(_users);

                //Checks if user name  exists where returned data set is filtered by entered username, will always be Row[0] becaus of this
                if (ds.Tables[0].Rows.Count == 0)
                {
                    //Inserts a new user when register is clicked
                    db.InsertUser(txtSUser.Text, txtSPass.Text, txtFirst.Text, txtLast.Text, txtEmail.Text);
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtFirst.Text = "";
                    txtLast.Text = "";
                    txtEmail.Text = "";
                    MessageBox.Show("Your account has been registered successfully.", "Registration Success.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ds.Tables[0].Rows.Count > 0)
                {                   
                    if (ds.Tables[0].Rows[0]["UserName"].ToString() == txtSUser.Text)
                    {
                        MessageBox.Show("The username already exists.", "Registration Failed.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                
                
                


                ////send email
                //Random random = new Random();
                //validationCode = random.Next(0, 1000).ToString();

                /*using (MailMessage mail = new MailMessage())
                {
                    try
                    {
                        //MailMessage mail = new MailMessage();
                        SmtpClient smpt = new SmtpClient("smtp.gmail.com", 587);
                        mail.From = new MailAddress(emailAddress);
                        mail.To.Add(new MailAddress(txtEmail.Text));
                        mail.Subject = emailSubject;
                        mail.Body = "Hello " + userFirstName + ", \n\n" + "Please enter the following code before proceeding to Login." + "\n" + validationCode;



                        smpt.Port = 587;
                        smpt.Credentials = new System.Net.NetworkCredential(emailAddress, emailPassword);
                        smpt.EnableSsl = true;
                        smpt.Send(mail);
                        pnlLogin.Enabled = true;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                inputBox for email validate
                string userCode = Interaction.InputBox("Enter Code", "Validation");
                if (userCode == validationCode)
                {
                    pnlLogin.Enabled = true;
                }*/



                //Validate password 
                if (validatePassword(txtSPass.Text) && validatePassword(txtSCPass.Text))
                {
                    pnlLogin.Visible = true;
                    pnlLogin.Enabled = false;

                    timer3.Start();
                }
                else if (!(validatePassword(txtSPass.Text)) || !(validatePassword(txtSCPass.Text)))
                {
                    MessageBox.Show("Invalid Password");
                }
                else if (txtSPass.Text == txtSCPass.Text)
                {
                    pnlLogin.Visible = true;
                    pnlLogin.Enabled = false;

                    timer3.Start();
                }
                else if (txtSPass.Text != txtSCPass.Text)
                {
                    MessageBox.Show("Passwords don't match");

                }
                                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An erro has occurred while trying to register." + ex.Message);
            }           
        }

        /// <summary>
        /// Change between dark and light mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMode_Click(object sender, EventArgs e)
        {
            if (btnMode.BackColor == Color.DarkGray)
            {
                darkMode();

            }
            else if (btnMode.BackColor == Color.Black)
            {

                lightMode();
            }
        }

        /// <summary>
        /// login form
        /// </summary>
        #region login

        //click functions
        private void txtUsername_Click(object sender, EventArgs e)
        {
            passwordChar();
            txtUsername.Clear();

            
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            passwordChar();
           
           
            //txtPassword.UseSystemPasswordChar = true;
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            pnlSignUp.Visible = true;
            timer1.Start();
           
            
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            //To be added later
        }

        //leave
        private void txtUsername_Leave_1(object sender, EventArgs e)
        {
            defaultText();
                        
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            defaultText();
            

        }

        //keypress
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

            txtPassword.UseSystemPasswordChar = true;
        }

        private void txtPassword_MouseHover(object sender, EventArgs e)
        {
            if (!(txtPassword.Text == "Password"))
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            
        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            if (!(txtPassword.Text == "Password"))
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
        #endregion

        /// <summary>
        /// register form
        /// </summary>
        #region register

        //click functions
        private void txtFirst_Click(object sender, EventArgs e)
        {
            passwordChar();
            txtFirst.Clear();
        }

        private void txtLast_Click(object sender, EventArgs e)
        {
            passwordChar();
            txtLast.Clear();
        }

        private void txtSUser_Click(object sender, EventArgs e)
        {
            passwordChar();
            txtSUser.Clear();
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            passwordChar();
            txtEmail.Clear();
        }

        private void txtSPass_Click(object sender, EventArgs e)
        {
            passwordChar();
            txtSPass.Clear();
            
        }

        private void txtSCPass_Click(object sender, EventArgs e)
        {
            passwordChar();
            txtSCPass.Clear();
           
        }

        //leave
        private void txtFirst_Leave(object sender, EventArgs e)
        {
            defaultText();
        }

        private void txtLast_Leave(object sender, EventArgs e)
        {
            defaultText();
        }

        private void txtSUser_Leave(object sender, EventArgs e)
        {
            defaultText();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            defaultText();
        }

        private void txtSPass_Leave(object sender, EventArgs e)
        {
            defaultText();

        }

        private void txtSCPass_Leave(object sender, EventArgs e)
        {
            defaultText();

        }
        //keypress
        private void txtSPass_KeyPress(object sender, KeyPressEventArgs e)
        {

            txtSPass.UseSystemPasswordChar = true;

        }

        private void txtSCPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtSCPass.UseSystemPasswordChar = true;
        }

        private void txtSPass_MouseHover(object sender, EventArgs e)
        {
            if (!(txtSPass.Text == "Password"))
            {
                txtSPass.UseSystemPasswordChar = false;
            }

        }

        private void txtSPass_MouseLeave(object sender, EventArgs e)
        {
            if (!(txtSPass.Text == "Password"))
            {
                txtSPass.UseSystemPasswordChar = true;
            }
        }

        private void txtSCPass_MouseHover(object sender, EventArgs e)
        {
            if (!(txtSCPass.Text == "Confirm Password"))
            {
                txtSCPass.UseSystemPasswordChar = false;
            }
        }

        private void txtSCPass_MouseLeave(object sender, EventArgs e)
        {
            if (!(txtSCPass.Text == "Confirm Password"))
            {
                txtSCPass.UseSystemPasswordChar = true;
            }
        }

        #endregion

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }
        #endregion

        /// <summary>
        /// All timer tick event handlers
        /// </summary>
        #region Timer
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
        #endregion

             
        #endregion

      
    }
}
