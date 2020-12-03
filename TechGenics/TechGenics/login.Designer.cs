namespace TechGenics
{
    partial class login_signup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.gradient1 = new TechGenics.gradient();
            this.btnSettingsLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblLExit = new System.Windows.Forms.Label();
            this.btnLExit = new System.Windows.Forms.Button();
            this.pboPassIcon = new System.Windows.Forms.PictureBox();
            this.pboUserIcon = new System.Windows.Forms.PictureBox();
            this.pboLogo = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlSignUp = new System.Windows.Forms.Panel();
            this.lblBLog = new System.Windows.Forms.Label();
            this.lblsExit = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSExit = new System.Windows.Forms.Button();
            this.chckBoxAdmin = new System.Windows.Forms.CheckBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtSPass = new System.Windows.Forms.TextBox();
            this.pboLogoSignUp = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSCPass = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSUser = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.gradient1.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboPassIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboUserIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboLogo)).BeginInit();
            this.pnlSignUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboLogoSignUp)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 30;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 30;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick_1);
            // 
            // timer4
            // 
            this.timer4.Interval = 30;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick_1);
            // 
            // gradient1
            // 
            this.gradient1.angle = 120F;
            this.gradient1.BackColor = System.Drawing.Color.Black;
            this.gradient1.colourBot = System.Drawing.Color.Aquamarine;
            this.gradient1.colourTop = System.Drawing.Color.DarkSlateGray;
            this.gradient1.Controls.Add(this.btnSettingsLogin);
            this.gradient1.Controls.Add(this.label3);
            this.gradient1.Controls.Add(this.pnlLogin);
            this.gradient1.Controls.Add(this.pnlSignUp);
            this.gradient1.Location = new System.Drawing.Point(-6, 1);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(1157, 722);
            this.gradient1.TabIndex = 17;
            // 
            // btnSettingsLogin
            // 
            this.btnSettingsLogin.BackColor = System.Drawing.Color.Black;
            this.btnSettingsLogin.BackgroundImage = global::TechGenics.Properties.Resources.Settings;
            this.btnSettingsLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSettingsLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSettingsLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettingsLogin.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnSettingsLogin.Location = new System.Drawing.Point(1115, 4);
            this.btnSettingsLogin.Name = "btnSettingsLogin";
            this.btnSettingsLogin.Size = new System.Drawing.Size(39, 38);
            this.btnSettingsLogin.TabIndex = 13;
            this.btnSettingsLogin.UseVisualStyleBackColor = false;
            this.btnSettingsLogin.Click += new System.EventHandler(this.btnSettingsLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(872, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "go to admin";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.Black;
            this.pnlLogin.Controls.Add(this.lblLExit);
            this.pnlLogin.Controls.Add(this.btnLExit);
            this.pnlLogin.Controls.Add(this.pboPassIcon);
            this.pnlLogin.Controls.Add(this.pboUserIcon);
            this.pnlLogin.Controls.Add(this.pboLogo);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.lblSignUp);
            this.pnlLogin.Controls.Add(this.txtUsername);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.lblForgotPassword);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Controls.Add(this.label2);
            this.pnlLogin.Location = new System.Drawing.Point(433, 85);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(379, 549);
            this.pnlLogin.TabIndex = 11;
            // 
            // lblLExit
            // 
            this.lblLExit.AutoSize = true;
            this.lblLExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLExit.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.lblLExit.Location = new System.Drawing.Point(342, 36);
            this.lblLExit.Name = "lblLExit";
            this.lblLExit.Size = new System.Drawing.Size(29, 16);
            this.lblLExit.TabIndex = 28;
            this.lblLExit.Text = "Exit";
            this.lblLExit.Visible = false;
            // 
            // btnLExit
            // 
            this.btnLExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLExit.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnLExit.Location = new System.Drawing.Point(345, 3);
            this.btnLExit.Name = "btnLExit";
            this.btnLExit.Size = new System.Drawing.Size(31, 30);
            this.btnLExit.TabIndex = 26;
            this.btnLExit.Text = "X";
            this.btnLExit.UseVisualStyleBackColor = false;
            this.btnLExit.Click += new System.EventHandler(this.btnLExit_Click);
            this.btnLExit.MouseLeave += new System.EventHandler(this.btnLExit_MouseLeave);
            this.btnLExit.MouseHover += new System.EventHandler(this.btnLExit_MouseHover);
            // 
            // pboPassIcon
            // 
            this.pboPassIcon.Image = global::TechGenics.Properties.Resources.pass2_dark;
            this.pboPassIcon.Location = new System.Drawing.Point(73, 263);
            this.pboPassIcon.Name = "pboPassIcon";
            this.pboPassIcon.Size = new System.Drawing.Size(42, 36);
            this.pboPassIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboPassIcon.TabIndex = 14;
            this.pboPassIcon.TabStop = false;
            // 
            // pboUserIcon
            // 
            this.pboUserIcon.Image = global::TechGenics.Properties.Resources.user2_dark;
            this.pboUserIcon.Location = new System.Drawing.Point(73, 222);
            this.pboUserIcon.Name = "pboUserIcon";
            this.pboUserIcon.Size = new System.Drawing.Size(42, 36);
            this.pboUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboUserIcon.TabIndex = 13;
            this.pboUserIcon.TabStop = false;
            // 
            // pboLogo
            // 
            this.pboLogo.Image = global::TechGenics.Properties.Resources.logo2;
            this.pboLogo.Location = new System.Drawing.Point(111, 41);
            this.pboLogo.Name = "pboLogo";
            this.pboLogo.Size = new System.Drawing.Size(153, 145);
            this.pboLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboLogo.TabIndex = 12;
            this.pboLogo.TabStop = false;
            this.pboLogo.Tag = "2";
            // 
            // txtPassword
            // 
            this.txtPassword.AutoCompleteCustomSource.AddRange(new string[] {
            "None"});
            this.txtPassword.BackColor = System.Drawing.Color.Black;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(122, 273);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(115, 19);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Tag = "11";
            this.txtPassword.Text = "Password";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            this.txtPassword.MouseLeave += new System.EventHandler(this.txtPassword_MouseLeave);
            this.txtPassword.MouseHover += new System.EventHandler(this.txtPassword_MouseHover);
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblSignUp.Location = new System.Drawing.Point(155, 435);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(67, 18);
            this.lblSignUp.TabIndex = 4;
            this.lblSignUp.Text = "Sign Up";
            this.lblSignUp.Click += new System.EventHandler(this.lblSignUp_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Black;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(121, 226);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(115, 19);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Tag = "10";
            this.txtUsername.Text = "Username";
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave_1);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Aquamarine;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(112, 383);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(160, 31);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPassword.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblForgotPassword.Location = new System.Drawing.Point(124, 342);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(138, 18);
            this.lblForgotPassword.TabIndex = 2;
            this.lblForgotPassword.Text = "Forgot Password";
            this.lblForgotPassword.Click += new System.EventHandler(this.lblForgotPassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Aquamarine;
            this.label1.Location = new System.Drawing.Point(115, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "_________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Aquamarine;
            this.label2.Location = new System.Drawing.Point(115, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "_________________________";
            // 
            // pnlSignUp
            // 
            this.pnlSignUp.BackColor = System.Drawing.Color.Black;
            this.pnlSignUp.Controls.Add(this.lblBLog);
            this.pnlSignUp.Controls.Add(this.lblsExit);
            this.pnlSignUp.Controls.Add(this.btnBack);
            this.pnlSignUp.Controls.Add(this.btnSExit);
            this.pnlSignUp.Controls.Add(this.chckBoxAdmin);
            this.pnlSignUp.Controls.Add(this.lblTitle);
            this.pnlSignUp.Controls.Add(this.txtSPass);
            this.pnlSignUp.Controls.Add(this.pboLogoSignUp);
            this.pnlSignUp.Controls.Add(this.label9);
            this.pnlSignUp.Controls.Add(this.txtSCPass);
            this.pnlSignUp.Controls.Add(this.label10);
            this.pnlSignUp.Controls.Add(this.txtSUser);
            this.pnlSignUp.Controls.Add(this.label8);
            this.pnlSignUp.Controls.Add(this.txtEmail);
            this.pnlSignUp.Controls.Add(this.label7);
            this.pnlSignUp.Controls.Add(this.txtLast);
            this.pnlSignUp.Controls.Add(this.label6);
            this.pnlSignUp.Controls.Add(this.txtFirst);
            this.pnlSignUp.Controls.Add(this.label5);
            this.pnlSignUp.Controls.Add(this.btnRegister);
            this.pnlSignUp.Location = new System.Drawing.Point(434, 84);
            this.pnlSignUp.Name = "pnlSignUp";
            this.pnlSignUp.Size = new System.Drawing.Size(379, 549);
            this.pnlSignUp.TabIndex = 12;
            this.pnlSignUp.Visible = false;
            // 
            // lblBLog
            // 
            this.lblBLog.AutoSize = true;
            this.lblBLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBLog.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.lblBLog.Location = new System.Drawing.Point(5, 33);
            this.lblBLog.Name = "lblBLog";
            this.lblBLog.Size = new System.Drawing.Size(89, 16);
            this.lblBLog.TabIndex = 29;
            this.lblBLog.Text = "Back to Login";
            this.lblBLog.Visible = false;
            // 
            // lblsExit
            // 
            this.lblsExit.AutoSize = true;
            this.lblsExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsExit.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.lblsExit.Location = new System.Drawing.Point(345, 33);
            this.lblsExit.Name = "lblsExit";
            this.lblsExit.Size = new System.Drawing.Size(29, 16);
            this.lblsExit.TabIndex = 27;
            this.lblsExit.Text = "Exit";
            this.lblsExit.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnBack.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(31, 30);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            this.btnBack.MouseHover += new System.EventHandler(this.btnBack_MouseHover);
            // 
            // btnSExit
            // 
            this.btnSExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSExit.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnSExit.Location = new System.Drawing.Point(348, 0);
            this.btnSExit.Name = "btnSExit";
            this.btnSExit.Size = new System.Drawing.Size(31, 30);
            this.btnSExit.TabIndex = 25;
            this.btnSExit.Text = "X";
            this.btnSExit.UseVisualStyleBackColor = false;
            this.btnSExit.Click += new System.EventHandler(this.btnSExit_Click);
            this.btnSExit.MouseLeave += new System.EventHandler(this.btnSExit_MouseLeave);
            this.btnSExit.MouseHover += new System.EventHandler(this.btnSExit_MouseHover);
            // 
            // chckBoxAdmin
            // 
            this.chckBoxAdmin.AutoSize = true;
            this.chckBoxAdmin.ForeColor = System.Drawing.Color.White;
            this.chckBoxAdmin.Location = new System.Drawing.Point(99, 468);
            this.chckBoxAdmin.Name = "chckBoxAdmin";
            this.chckBoxAdmin.Size = new System.Drawing.Size(110, 17);
            this.chckBoxAdmin.TabIndex = 12;
            this.chckBoxAdmin.Text = "Register as admin";
            this.chckBoxAdmin.UseVisualStyleBackColor = true;
            this.chckBoxAdmin.CheckedChanged += new System.EventHandler(this.chckBoxAdmin_CheckedChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblTitle.Location = new System.Drawing.Point(166, 77);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(125, 33);
            this.lblTitle.TabIndex = 24;
            this.lblTitle.Text = "Sign Up";
            // 
            // txtSPass
            // 
            this.txtSPass.BackColor = System.Drawing.Color.Black;
            this.txtSPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSPass.ForeColor = System.Drawing.Color.White;
            this.txtSPass.Location = new System.Drawing.Point(24, 310);
            this.txtSPass.Name = "txtSPass";
            this.txtSPass.Size = new System.Drawing.Size(139, 19);
            this.txtSPass.TabIndex = 9;
            this.txtSPass.Text = "Password";
            this.txtSPass.Click += new System.EventHandler(this.txtSPass_Click);
            this.txtSPass.Leave += new System.EventHandler(this.txtSPass_Leave);
            this.txtSPass.MouseLeave += new System.EventHandler(this.txtSPass_MouseLeave);
            this.txtSPass.MouseHover += new System.EventHandler(this.txtSPass_MouseHover);
            // 
            // pboLogoSignUp
            // 
            this.pboLogoSignUp.Image = global::TechGenics.Properties.Resources.logo2;
            this.pboLogoSignUp.Location = new System.Drawing.Point(28, 64);
            this.pboLogoSignUp.Name = "pboLogoSignUp";
            this.pboLogoSignUp.Size = new System.Drawing.Size(100, 77);
            this.pboLogoSignUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboLogoSignUp.TabIndex = 22;
            this.pboLogoSignUp.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Aquamarine;
            this.label9.Location = new System.Drawing.Point(19, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "___________________________";
            // 
            // txtSCPass
            // 
            this.txtSCPass.BackColor = System.Drawing.Color.Black;
            this.txtSCPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSCPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSCPass.ForeColor = System.Drawing.Color.White;
            this.txtSCPass.Location = new System.Drawing.Point(22, 368);
            this.txtSCPass.Name = "txtSCPass";
            this.txtSCPass.Size = new System.Drawing.Size(139, 19);
            this.txtSCPass.TabIndex = 10;
            this.txtSCPass.Text = "Confirm Password";
            this.txtSCPass.Click += new System.EventHandler(this.txtSCPass_Click);
            this.txtSCPass.Leave += new System.EventHandler(this.txtSCPass_Leave);
            this.txtSCPass.MouseLeave += new System.EventHandler(this.txtSCPass_MouseLeave);
            this.txtSCPass.MouseHover += new System.EventHandler(this.txtSCPass_MouseHover);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Aquamarine;
            this.label10.Location = new System.Drawing.Point(16, 377);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "___________________________";
            // 
            // txtSUser
            // 
            this.txtSUser.BackColor = System.Drawing.Color.Black;
            this.txtSUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSUser.ForeColor = System.Drawing.Color.White;
            this.txtSUser.Location = new System.Drawing.Point(25, 249);
            this.txtSUser.Name = "txtSUser";
            this.txtSUser.Size = new System.Drawing.Size(115, 19);
            this.txtSUser.TabIndex = 7;
            this.txtSUser.Text = "Username";
            this.txtSUser.Click += new System.EventHandler(this.txtSUser_Click);
            this.txtSUser.Leave += new System.EventHandler(this.txtSUser_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Aquamarine;
            this.label8.Location = new System.Drawing.Point(19, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "_________________";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Black;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(196, 249);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(115, 19);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.Text = "Email";
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Aquamarine;
            this.label7.Location = new System.Drawing.Point(190, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "__________________";
            // 
            // txtLast
            // 
            this.txtLast.BackColor = System.Drawing.Color.Black;
            this.txtLast.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLast.ForeColor = System.Drawing.Color.White;
            this.txtLast.Location = new System.Drawing.Point(196, 179);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(115, 19);
            this.txtLast.TabIndex = 6;
            this.txtLast.Text = "Surname";
            this.txtLast.Click += new System.EventHandler(this.txtLast_Click);
            this.txtLast.Leave += new System.EventHandler(this.txtLast_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Aquamarine;
            this.label6.Location = new System.Drawing.Point(193, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "_________________";
            // 
            // txtFirst
            // 
            this.txtFirst.BackColor = System.Drawing.Color.Black;
            this.txtFirst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirst.ForeColor = System.Drawing.Color.White;
            this.txtFirst.Location = new System.Drawing.Point(28, 179);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(115, 19);
            this.txtFirst.TabIndex = 5;
            this.txtFirst.Text = "First Name";
            this.txtFirst.Click += new System.EventHandler(this.txtFirst_Click);
            this.txtFirst.Leave += new System.EventHandler(this.txtFirst_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Aquamarine;
            this.label5.Location = new System.Drawing.Point(22, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "_________________";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Aquamarine;
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.Location = new System.Drawing.Point(99, 422);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(160, 31);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // login_signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1151, 725);
            this.Controls.Add(this.gradient1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login_signup";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.login_signup_Load);
            this.gradient1.ResumeLayout(false);
            this.gradient1.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboPassIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboUserIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboLogo)).EndInit();
            this.pnlSignUp.ResumeLayout(false);
            this.pnlSignUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboLogoSignUp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Panel pnlSignUp;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSPass;
        private System.Windows.Forms.PictureBox pboLogoSignUp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSCPass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.PictureBox pboPassIcon;
        private System.Windows.Forms.PictureBox pboUserIcon;
        private System.Windows.Forms.PictureBox pboLogo;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblForgotPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private gradient gradient1;
        private System.Windows.Forms.Button btnSettingsLogin;
        private System.Windows.Forms.CheckBox chckBoxAdmin;
        private System.Windows.Forms.Button btnSExit;
        private System.Windows.Forms.Button btnLExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblsExit;
        private System.Windows.Forms.Label lblLExit;
        private System.Windows.Forms.Label lblBLog;
        private System.Windows.Forms.Label label3;
    }
}

