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
using System.Net;

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
        //Admin model
        List<Admin> _admins = new List<Admin>();

        //Is true if password to register admins is correct
        public bool canRegisterAsAdmin = false;
        public string masterPassword = String.Empty;
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
                bool loginFailed = false;

                //Finds entries in list where username = txtUsername.Text
                DataAccess db = new DataAccess();
                _users = db.GetUser(txtUsername.Text);

                //Finds entries in list where adminname = txtUsername.Text
                _admins = db.GetAdmin(txtUsername.Text);

                //Converts list to dataset using the ListToDataSet Class and ToDataSet method inside because lists<T> are a pain to work with
                DataSet dsUser = new DataSet();
                dsUser = ListToDataSet.ToDataSet(_users);

                DataSet dsAdmin = new DataSet();
                dsAdmin = ListToDataSet.ToDataSet(_admins);

                if (dsUser.Tables[0].Rows.Count > 0)
                {
                    //Checks if user name and password combination exists where returned data set is filtered by entered username, will always be Row[0] becaus of this
                    if (dsUser.Tables[0].Rows[0]["UserName"].ToString() != txtUsername.Text || dsAdmin.Tables[0].Rows[0]["UserPassword"].ToString() != txtPassword.Text)
                    {
                        loginFailed = true;
                    }
                    else if (dsUser.Tables[0].Rows[0]["UserName"].ToString() == txtUsername.Text && dsAdmin.Tables[0].Rows[0]["UserPassword"].ToString() == txtPassword.Text)
                    {
                        //MessageBox.Show("Loged in Successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SettingsConstructor settings = new SettingsConstructor();
                        settings.CurrentUser = txtUsername.Text;
                        settings.IsAdmin = false;
                        loginFailed = false;
                        this.Hide();
                        this.Enabled = false;
                        loadScreen.Show();
                    }
                }
                else if (dsAdmin.Tables[0].Rows.Count > 0)
                {
                    //Checks if user name and password combination exists where returned data set is filtered by entered username, will always be Row[0] becaus of this
                    if (dsAdmin.Tables[0].Rows[0]["AdminName"].ToString() != txtUsername.Text || dsAdmin.Tables[0].Rows[0]["AdminPassword"].ToString() != txtPassword.Text)
                    {
                        loginFailed = true;
                    }
                    else if (dsAdmin.Tables[0].Rows[0]["AdminName"].ToString() == txtUsername.Text && dsAdmin.Tables[0].Rows[0]["AdminPassword"].ToString() == txtPassword.Text)
                    {
                        //MessageBox.Show("Loged in Successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SettingsConstructor settings = new SettingsConstructor();
                        settings.CurrentUser = txtUsername.Text;
                        settings.IsAdmin = true;
                        loginFailed = false;
                        this.Hide();
                        this.Enabled = false;
                        loadScreen.Show();
                    }
                }
                if(loginFailed == true) 
                {
                    MessageBox.Show("The username or password is incorrect.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
                //Can also use List<T> in this case "user" as a datasource for anything
                //cmbTest.Refresh();
                //cmbTest.DataSource = _users;
                //cmbTest.DisplayMember = "FullInfo";
                //cmbTest.ValueMember = "UserId";

                
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
                _users = db.GetUser(txtSUser.Text);
                _admins = db.GetAdmin(txtSUser.Text);

                //Converts list to dataset using the ListToDataSet Class and ToDataSet method inside because lists<T> are a pain to work with
                DataSet dsUser = new DataSet();
                dsUser = ListToDataSet.ToDataSet(_users);

                DataSet dsAdmin = new DataSet();
                dsAdmin = ListToDataSet.ToDataSet(_admins);


                ////send email
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

                     //inputBox for email validate
                     string userCode = Interaction.InputBox("Enter Code", "Validation");
                     if (userCode == validationCode)
                     {
                         pnlLogin.Enabled = true;
                     }
                 }

                //Checks if user name  exists where returned data set is filtered by entered username, will always be Row[0] becaus of this
                if (chckBoxAdmin.Checked == false)
                {
                    if (dsUser.Tables[0].Rows.Count == 0)
                    {
                        //Inserts a new user when register is clicked
                        db.InsertUser(txtSUser.Text, txtSPass.Text, txtFirst.Text, txtLast.Text, txtEmail.Text);
                        txtUsername.Text = "";
                        txtPassword.Text = "";
                        txtFirst.Text = "";
                        txtLast.Text = "";
                        txtEmail.Text = "";
                        pnlLogin.Enabled = true;
                        //MessageBox.Show("Your account has been registered successfully.", "Registration Success.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (dsUser.Tables[0].Rows.Count > 0)
                    {
                        if (dsUser.Tables[0].Rows[0]["UserName"].ToString() == txtSUser.Text)
                        {
                            MessageBox.Show("The username already exists.", "Registration Failed.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else if (chckBoxAdmin.Checked == true)
                {
                    masterPassword = Interaction.InputBox("", "Enter master password", "Enter master password here...", -1, -1);
                    if (masterPassword == "TGA79135#")
                    {
                        if (dsAdmin.Tables[0].Rows.Count == 0)
                        {
                            //Inserts a new user when register is clicked
                            db.InsertAdmin(txtSUser.Text, txtSPass.Text, txtFirst.Text, txtLast.Text, txtEmail.Text);
                            txtUsername.Text = "";
                            txtPassword.Text = "";
                            txtFirst.Text = "";
                            txtLast.Text = "";
                            txtEmail.Text = "";
                            pnlLogin.Enabled = true;
                            //MessageBox.Show("Your account has been registered successfully.", "Registration Success.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (dsAdmin.Tables[0].Rows.Count > 0)
                        {
                            if (dsAdmin.Tables[0].Rows[0]["UserName"].ToString() == txtSUser.Text)
                            {
                                MessageBox.Show("The username already exists.", "Registration Failed.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect master password, cannot add an admin account.", "Registration Failed.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

               

                //Validate password 
                if (validatePassword(txtSPass.Text) && validatePassword(txtSCPass.Text))
                {
                    pnlLogin.Visible = true;
                    //pnlLogin.Enabled = false;

                    timer3.Start();
                }
                else if (!(validatePassword(txtSPass.Text)) || !(validatePassword(txtSCPass.Text)))
                {
                    MessageBox.Show("Invalid Password");
                }
                else if (txtSPass.Text == txtSCPass.Text)
                {
                    pnlLogin.Visible = true;
                    //pnlLogin.Enabled = false;
                    pnlLogin.Enabled = true;

                    timer3.Start();
                }
                else if (txtSPass.Text != txtSCPass.Text)
                {
                    MessageBox.Show("Passwords don't match");

                }
                                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred while trying to register." + ex.Message);
            }           
        }

        /// <summary>
        /// Change between dark and light mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        

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
            Cursor.Position = new Point(Cursor.Position.X + 10, Cursor.Position.Y + 18);
            
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
            txtSPass.Clear();
            passwordChar();
            Cursor.Position = new Point(Cursor.Position.X + 10, Cursor.Position.Y + 18);

        }

        private void txtSCPass_Click(object sender, EventArgs e)
        {
            txtSCPass.Clear();
            passwordChar();
            Cursor.Position = new Point(Cursor.Position.X + 10, Cursor.Position.Y + 18);

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

        //remove after testing & make visible for demo
        frmMainAdmin admin = new frmMainAdmin();
        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Enabled = false;
            admin.Show();

            //System.Diagnostics.Process.Start("https://www.google.com");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void login_signup_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSettingsLogin_Click(object sender, EventArgs e)
        {
            frmSettings frmSettings = new frmSettings();
            frmSettings.ShowDialog();
        }

        private void chckBoxAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlSignUp.Visible = false;
            pnlSignUp.SendToBack();

            pnlLogin.Visible = true;
            pnlLogin.BringToFront();
        }

        private void btnSExit_MouseHover(object sender, EventArgs e)
        {
            lblsExit.Visible = true;
        }

        private void btnSExit_MouseLeave(object sender, EventArgs e)
        {
            lblsExit.Visible = false;
        }

        private void btnLExit_MouseHover(object sender, EventArgs e)
        {
            lblLExit.Visible = true;
        }

        private void btnLExit_MouseLeave(object sender, EventArgs e)
        {
            lblLExit.Visible = false;
        }

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            lblBLog.Visible = true;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            lblBLog.Visible = false;
        }
    }
}
