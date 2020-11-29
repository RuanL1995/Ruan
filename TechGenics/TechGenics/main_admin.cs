using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using TechGenics.Models;


namespace TechGenics
{
    public partial class frmMainAdmin : Form
    {
        int slider;
        bool hide;
        bool initiation = false;
        bool execution = false;
        bool closeOut = false;
        bool planning = false;

        bool leftDock = false;
        bool rightDock = false;

        public static bool isAdmin = false;
        public static string currentUser = String.Empty;
        //projects ctrl
        private Control ctrl;
        //Tasks ctrl
        private Control ctrlTask;
        private Control ctrlTaskToMove;

        private int numberOfProjectsToRemove = 0;
        private string buttonTag;
        private int numberOfTasksToRemove = 0;
        private string taskToMoveId;


        private int backlogLocationStartX = 18;
        private int progressLocationStartX = 221;
        private int completedLocationStartX = 447;
        private int removedLocationStartX = 662;
        private int backlogLocationStartY = 13;
        private int progressLocationStartY = 13;
        private int completedLocationStartY = 13;
        private int removedLocationStartY = 13;
        private int lastBacklogLocationX = 0;
        private int lastBacklogLocationY = 0;
        private int lastProgressLocationX = 0;
        private int lastProgressLocationY = 0;
        private int lastCompletedLocationX = 0;
        private int lastCompletedLocationY = 0;
        private int lastRemovedLocationX = 0;
        private int lastRemovedLocationY = 0;

        DataTable dtGeneratedTasksFilter;

        //Projects and tasks model
        List<ProjectsAndTasksByUserPhase> _ProjectsAndTasks = new List<ProjectsAndTasksByUserPhase>();
        //Tasks
        List<ProjectsAndTasksByUserPhase> _GeneratedTasks = new List<ProjectsAndTasksByUserPhase>();

        public frmMainAdmin()
        {
            InitializeComponent();
            customDesign();
            controls.SetInitial(this);

            //sliding panel
            slider = pnlSideMenu.Width;
            hide = false;
        }
              

        /// <summary>
        /// Methods used for general purpose
        /// </summary>
        #region General Methods
        //set SubMenus to invisible
        private void customDesign()
        {
            pnlPhasesSub.Visible = false;
            pnlProjectsSub.Visible = false;
            pnlMembersSub.Visible = false;
            pnlHelpSub.Visible = false;
        }

        //hide SubMenus
        private void hideSubs()
        {
            if(pnlPhasesSub.Visible == true)
            {
                pnlPhasesSub.Visible = false;
            }

            if (pnlProjectsSub.Visible == true)
            {
                pnlProjectsSub.Visible = false;
            }

            if (pnlMembersSub.Visible == true)
            {
                pnlMembersSub.Visible = false;
            }
            if (pnlHelpSub.Visible == true)
            {
                pnlHelpSub.Visible = false;
            }
        }

        //show SubMenus
        private void showSubs(Panel pnlSideMenu)
        {
            if (pnlSideMenu.Visible == false)
            {
                hideSubs();
                pnlSideMenu.Visible = true;
            }
            else
            {
                pnlSideMenu.Visible = false;
            }
        }

        #endregion

        /// <summary>
        /// CHild forms needed to display info
        /// </summary>
        #region child forms
        //child forms
        private Form frmActive = null;
        private void openChildForm(Form frmChild)
        {
            if (frmActive != null)
            {
                frmActive.Close();
            }

            frmActive = frmChild;
            frmChild.TopLevel = false;
            frmChild.FormBorderStyle = FormBorderStyle.None;
            frmChild.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(frmChild);
            pnlChildForm.Tag = frmChild;
            frmChild.BringToFront();
            frmChild.Show();
        }

        
        
        #endregion

        /// <summary>
        /// Phases submenu
        /// </summary>
        #region Phases menu

        private void btnPhases_Click(object sender, EventArgs e)
        {
            showSubs(pnlPhasesSub);
            pnlChildForm.BringToFront();
        }

        //dual view 
        private void btnInitiation_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                
                initiation = true;

            }
            else//left or middle click
            {
                
                openChildForm(new frmInitiation());
                
                             
            }
        }

        private void btnPlanning_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                planning = true;

            }
            else//left or middle click
            {
               
                openChildForm(new frmPlanning());
                

                
            }
        }

        private void btnExecution_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                execution = true;

            }
            else//left or middle click
            {
                
                openChildForm(new frmExecution());
                

                
            }
        }

        private void btnCloseOut_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                closeOut = true;

            }
            else//left or middle click
            {
                
                openChildForm(new frmCloseOut());
                

            }
        }

        #endregion

        /// <summary>
        /// Diagrams submenu 
        /// </summary>
        #region Diagrams menu
        //diagrams menu
        private void btnDiagrams_Click(object sender, EventArgs e)
        {
            //pnlChildForm.BringToFront();
            
        }

        #endregion

        /// <summary>
        /// Projects submenu
        /// </summary>
        #region Projects menu
        //projects menu
        private void btnProjects_Click(object sender, EventArgs e)
        {
            pnlChildForm.SendToBack();
            showSubs(pnlProjectsSub);
            //pnlChildForm.BringToFront();

            //DB connection here
            string dbConnection = "";

            SqlConnection sqlConnection;

            dbConnection = @"Data Source=WIN-50GP30FGO75;Initial Catalog=Demodb;User ID=sa;Password=demol23";
            sqlConnection = new SqlConnection(dbConnection);
            //sqlConnection.Open();
            //MessageBox.Show("Connection Open!");
            //sqlConnection.Close();



            List<string> projNames = new List<string>();



            
        }

        #endregion

        /// <summary>
        /// Members submenu
        /// </summary>
        #region Members section
        private void btnMembers_Click(object sender, EventArgs e)
        {
            showSubs(pnlMembersSub);
        }

        #endregion

        /// <summary>
        /// Google and manual access
        /// </summary>
        #region Help section

        private void btnHelp_Click(object sender, EventArgs e)
        {
            showSubs(pnlHelpSub);
            //pnlChildForm.BringToFront();
        }

        private void btnGoogle_Click(object sender, EventArgs e)
        {
            openChildForm(new frmGoogle());
        }




        #endregion

        /// <summary>
        /// Logout section
        /// </summary>
        #region Logout
        private void btnSettings_Click(object sender, EventArgs e)
        {
            
            frmSettings frmSettings = new frmSettings();
            frmSettings.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            login_signup login = new login_signup();
            login.Show();
            this.Dispose();
        }

        #endregion

        private void btnExpand_Click(object sender, EventArgs e)
        {
            tmrSliding.Start();
        }

        private void tmrSliding_Tick(object sender, EventArgs e)
        {
            if(hide)
            {
                pnlSideMenu.Width = pnlSideMenu.Width + 12;
                if(pnlSideMenu.Width >= slider)
                {
                    tmrSliding.Stop();
                    hide = false;
                    btnExpand.Text = "<<";
                    this.Refresh();
                    
                }
            }
            else
            {
                pnlSideMenu.Width = pnlSideMenu.Width - 20;
                if (pnlSideMenu.Width <= 0)
                {
                    tmrSliding.Stop();
                    hide = true;
                    btnExpand.Text = ">>";
                    hideSubs();
                    this.Refresh();
                    
                }
            }


        }
                
        private void frmMainAdmin_Load(object sender, EventArgs e)
        {                      
            tmrSliding.Start();
            pnlSideMenu.Width = 0;
            btnExpand.Text = ">>";
            SettingsConstructor settings = new SettingsConstructor();
            currentUser = settings.CurrentUser;
            isAdmin = settings.IsAdmin;
            lblCurrentUser.Text = "Welcome " + currentUser;

            cboPhases.SelectedIndex = 0;
            generateProjects();

            if (isAdmin == true)
            {
                btnAddTasl.Visible = true;

                btnMembers.Visible = true;
                btnNewMem.Visible = true;
            }
            else if (isAdmin == false)
            {
                btnAddTasl.Visible = false;

                btnMembers.Visible = false;
                btnNewMem.Visible = false;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            controls.minimize(this);
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            controls.doMax(this, btn);
        }

        private void btnFull_Click(object sender, EventArgs e)
        {
            controls.doFullscreen(this);
                
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            pnlChildForm.BringToFront();
        }

        
        private void btnTemplate_Click(object sender, EventArgs e)
        {
            Docs docs = new Docs();
            openDocsFrom(docs);
        }

        private void openDocsFrom(Docs docs)
        {
            docs.TopLevel = false;
            docs.FormBorderStyle = FormBorderStyle.None;
            docs.Dock = DockStyle.Fill;
            pnlViewTask.Controls.Add(docs);
            pnlViewTask.Tag = docs;
            docs.BringToFront();
            docs.Show();
        }
           
       

        

        private void btnPlanning_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExecution_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCloseOut_Click(object sender, EventArgs e)
        {
            
        }
        
        

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

              

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TechGenics.Properties.Settings.Default.Theme == "Light")
            {
                pnlSideMenu.BackColor = SystemColors.AppWorkspace;
                btnInitiation.BackColor = SystemColors.AppWorkspace;
                btnPlanning.BackColor = SystemColors.AppWorkspace;
                btnExecution.BackColor = SystemColors.AppWorkspace;
                btnCloseOut.BackColor = SystemColors.AppWorkspace;
                btnViewTemplateDocs.BackColor = SystemColors.AppWorkspace;
                btnNewMem.BackColor = SystemColors.AppWorkspace;
                btnGoogle.BackColor = SystemColors.AppWorkspace;
                btnManualA.BackColor = SystemColors.AppWorkspace;
                btnHelp.BackColor = SystemColors.AppWorkspace;
                btnFull.BackColor = SystemColors.AppWorkspace;
                btnMin.BackColor = SystemColors.AppWorkspace;
                btnMax.BackColor = SystemColors.AppWorkspace;
                btnNewProj.BackColor = SystemColors.AppWorkspace;
                btnNewMem.BackColor = SystemColors.AppWorkspace;
                btnHelp.ForeColor = SystemColors.Desktop;

                btnPhases.BackColor = SystemColors.AppWorkspace;
                btnPhases.ForeColor = SystemColors.Desktop;


                btnProjects.BackColor = SystemColors.AppWorkspace;
                btnProjects.ForeColor = SystemColors.Desktop;

                btnMembers.BackColor = SystemColors.AppWorkspace;
                btnMembers.ForeColor = SystemColors.Desktop;

                btnSettings.BackColor = SystemColors.AppWorkspace;
                btnSettings.ForeColor = SystemColors.Desktop;

                btnLogout.BackColor = SystemColors.AppWorkspace;
                btnLogout.ForeColor = SystemColors.Desktop;

                btnClose.BackColor = SystemColors.AppWorkspace;
                btnClose.ForeColor = SystemColors.Desktop;

                this.BackColor = SystemColors.AppWorkspace;
                btnExpand.BackColor = SystemColors.AppWorkspace;

                pnlHide.BackColor = SystemColors.AppWorkspace;
                pnlChildForm.BackColor = SystemColors.AppWorkspace;
                pnlPhasesSub.BackColor = SystemColors.AppWorkspace;
                pnlProjectsSub.BackColor = SystemColors.AppWorkspace;
                pnlHelpSub.BackColor = SystemColors.AppWorkspace;
                pnlMembersSub.BackColor = SystemColors.AppWorkspace;
                pnlChildForm.BackColor = SystemColors.Desktop;
                //panel1.BackColor = SystemColors.AppWorkspace;
            }
            if (TechGenics.Properties.Settings.Default.Theme == "Dark")
            {

                pnlSideMenu.BackColor = SystemColors.Desktop;
                btnInitiation.BackColor = SystemColors.Desktop;
                btnPlanning.BackColor = SystemColors.Desktop;
                btnExecution.BackColor = SystemColors.Desktop;
                btnCloseOut.BackColor = SystemColors.Desktop;
                btnNewProj.BackColor = SystemColors.Desktop;
                btnNewMem.BackColor = SystemColors.Desktop;
                btnGoogle.BackColor = SystemColors.Desktop;
                btnManualA.BackColor = SystemColors.Desktop;
                btnHelp.BackColor = SystemColors.Desktop;
                btnFull.BackColor = SystemColors.Desktop;
                btnMin.BackColor = SystemColors.Desktop;
                btnMax.BackColor = SystemColors.Desktop;
                btnViewTemplateDocs.BackColor = SystemColors.Desktop;
                btnNewProj.BackColor = SystemColors.Desktop;
                btnNewMem.BackColor = SystemColors.Desktop;
                btnHelp.ForeColor = SystemColors.ActiveBorder;

                btnPhases.BackColor = SystemColors.Desktop;
                btnPhases.ForeColor = SystemColors.ActiveBorder;

                btnProjects.BackColor = SystemColors.Desktop;
                btnProjects.ForeColor = SystemColors.ActiveBorder;

                btnMembers.BackColor = SystemColors.Desktop;
                btnMembers.ForeColor = SystemColors.ActiveBorder;

                btnSettings.BackColor = SystemColors.Desktop;
                btnSettings.ForeColor = SystemColors.ActiveBorder;

                btnLogout.BackColor = SystemColors.Desktop;
                btnLogout.ForeColor = SystemColors.ActiveBorder;

                btnClose.BackColor = SystemColors.Desktop;
                btnClose.ForeColor = SystemColors.ActiveBorder;

                this.BackColor = SystemColors.Desktop;
                btnExpand.BackColor = SystemColors.Desktop;

                pnlHide.BackColor = SystemColors.Desktop;

                pnlPhasesSub.BackColor = SystemColors.Desktop;
                pnlProjectsSub.BackColor = SystemColors.Desktop;
                pnlHelpSub.BackColor = SystemColors.Desktop;
                pnlMembersSub.BackColor = SystemColors.Desktop;
                pnlChildForm.BackColor = SystemColors.Desktop;
                //panel1.BackColor = SystemColors.Desktop;
            }

            //Custom
            if (TechGenics.Properties.Settings.Default.Theme == "LBlueC")
            {
                

                pnlSideMenu.BackColor = SystemColors.ActiveCaption;
                btnInitiation.BackColor = SystemColors.ActiveCaption;
                btnPlanning.BackColor = SystemColors.ActiveCaption;
                btnExecution.BackColor = SystemColors.ActiveCaption;
                btnCloseOut.BackColor = SystemColors.ActiveCaption;
                btnNewProj.BackColor = SystemColors.ActiveCaption;
                btnNewMem.BackColor = SystemColors.ActiveCaption;
                btnGoogle.BackColor = SystemColors.ActiveCaption;
                btnManualA.BackColor = SystemColors.ActiveCaption;
                btnHelp.BackColor = SystemColors.ActiveCaption;
                btnFull.BackColor = SystemColors.ActiveCaption;
                btnMin.BackColor = SystemColors.ActiveCaption;
                btnMax.BackColor = SystemColors.ActiveCaption;


                btnPhases.BackColor = SystemColors.ActiveCaption;


                btnProjects.BackColor = SystemColors.ActiveCaption;


                btnMembers.BackColor = SystemColors.ActiveCaption;


                btnSettings.BackColor = SystemColors.ActiveCaption;


                btnLogout.BackColor = SystemColors.ActiveCaption;
                

                btnClose.BackColor = SystemColors.ActiveCaption;


                this.BackColor = SystemColors.ActiveCaption;
                btnExpand.BackColor = SystemColors.ActiveCaption;

                pnlHide.BackColor = SystemColors.ActiveCaption;

                pnlPhasesSub.BackColor = SystemColors.ActiveCaption;
                pnlProjectsSub.BackColor = SystemColors.ActiveCaption;
                pnlHelpSub.BackColor = SystemColors.ActiveCaption;
                pnlMembersSub.BackColor = SystemColors.ActiveCaption;
                pnlChildForm.BackColor = SystemColors.ActiveCaption;
                //panel1.BackColor = SystemColors.ActiveCaption;
            }

            if (TechGenics.Properties.Settings.Default.Theme == "BlueC")
            {


                pnlSideMenu.BackColor = SystemColors.Highlight;
                btnInitiation.BackColor = SystemColors.Highlight;
                btnPlanning.BackColor = SystemColors.Highlight;
                btnExecution.BackColor = SystemColors.Highlight;
                btnCloseOut.BackColor = SystemColors.Highlight;
                btnNewProj.BackColor = SystemColors.Highlight;
                btnNewMem.BackColor = SystemColors.Highlight;
                btnGoogle.BackColor = SystemColors.Highlight;
                btnManualA.BackColor = SystemColors.Highlight;
                btnHelp.BackColor = SystemColors.Highlight;
                btnFull.BackColor = SystemColors.Highlight;
                btnMin.BackColor = SystemColors.Highlight;
                btnMax.BackColor = SystemColors.Highlight;


                btnPhases.BackColor = SystemColors.Highlight;


                btnProjects.BackColor = SystemColors.Highlight;


                btnMembers.BackColor = SystemColors.Highlight;


                btnSettings.BackColor = SystemColors.Highlight;


                btnLogout.BackColor = SystemColors.Highlight;


                btnClose.BackColor = SystemColors.Highlight;


                this.BackColor = SystemColors.Highlight;
                btnExpand.BackColor = SystemColors.Highlight;

                pnlHide.BackColor = SystemColors.Highlight;

                pnlPhasesSub.BackColor = SystemColors.Highlight;
                pnlProjectsSub.BackColor = SystemColors.Highlight;
                pnlHelpSub.BackColor = SystemColors.Highlight;
                pnlMembersSub.BackColor = SystemColors.Highlight;
                pnlChildForm.BackColor = SystemColors.Highlight;
                //panel1.BackColor = SystemColors.Highlight;
            }

            if (TechGenics.Properties.Settings.Default.Theme == "DBlueC")
            {


                pnlSideMenu.BackColor = SystemColors.Info;
                btnInitiation.BackColor = SystemColors.Info;
                btnPlanning.BackColor = SystemColors.Info;
                btnExecution.BackColor = SystemColors.Info;
                btnCloseOut.BackColor = SystemColors.Info;
                btnNewProj.BackColor = SystemColors.Info;
                btnNewMem.BackColor = SystemColors.Info;
                btnGoogle.BackColor = SystemColors.Info;
                btnManualA.BackColor = SystemColors.Info;
                btnHelp.BackColor = SystemColors.Info;
                btnFull.BackColor = SystemColors.Info;
                btnMin.BackColor = SystemColors.Info;
                btnMax.BackColor = SystemColors.Info;


                btnPhases.BackColor = SystemColors.Info;


                btnProjects.BackColor = SystemColors.Info;


                btnMembers.BackColor = SystemColors.Info;


                btnSettings.BackColor = SystemColors.Info;


                btnLogout.BackColor = SystemColors.Info;


                btnClose.BackColor = SystemColors.Info;


                this.BackColor = SystemColors.Info;
                btnExpand.BackColor = SystemColors.Info;

                pnlHide.BackColor = SystemColors.Info;

                pnlPhasesSub.BackColor = SystemColors.Info;
                pnlProjectsSub.BackColor = SystemColors.Info;
                pnlHelpSub.BackColor = SystemColors.Info;
                pnlMembersSub.BackColor = SystemColors.Info;
                pnlChildForm.BackColor = SystemColors.Info;
                //panel1.BackColor = SystemColors.Info;
            }

            if (TechGenics.Properties.Settings.Default.Theme == "LGreyC")
            {


                pnlSideMenu.BackColor = SystemColors.ControlDark;
                btnInitiation.BackColor = SystemColors.ControlDark;
                btnPlanning.BackColor = SystemColors.ControlDark;
                btnExecution.BackColor = SystemColors.ControlDark;
                btnCloseOut.BackColor = SystemColors.ControlDark;
                btnNewProj.BackColor = SystemColors.ControlDark;
                btnNewMem.BackColor = SystemColors.ControlDark;
                btnGoogle.BackColor = SystemColors.ControlDark;
                btnManualA.BackColor = SystemColors.ControlDark;
                btnHelp.BackColor = SystemColors.ControlDark;
                btnFull.BackColor = SystemColors.ControlDark;
                btnMin.BackColor = SystemColors.ControlDark;
                btnMax.BackColor = SystemColors.ControlDark;


                btnPhases.BackColor = SystemColors.ControlDark;


                btnProjects.BackColor = SystemColors.ControlDark;


                btnMembers.BackColor = SystemColors.ControlDark;


                btnSettings.BackColor = SystemColors.ControlDark;


                btnLogout.BackColor = SystemColors.ControlDark;


                btnClose.BackColor = SystemColors.ControlDark;


                this.BackColor = SystemColors.ControlDark;
                btnExpand.BackColor = SystemColors.ControlDark;

                pnlHide.BackColor = SystemColors.ControlDark;

                pnlPhasesSub.BackColor = SystemColors.ControlDark;
                pnlProjectsSub.BackColor = SystemColors.ControlDark;
                pnlHelpSub.BackColor = SystemColors.ControlDark;
                pnlMembersSub.BackColor = SystemColors.ControlDark;
                pnlChildForm.BackColor = SystemColors.ControlDark;
                //panel1.BackColor = SystemColors.ControlDark;
            }

            if (TechGenics.Properties.Settings.Default.Theme == "DGreyC")
            {

                pnlSideMenu.BackColor = SystemColors.ControlDarkDark;
                btnInitiation.BackColor = SystemColors.ControlDarkDark;
                btnPlanning.BackColor = SystemColors.ControlDarkDark;
                btnExecution.BackColor = SystemColors.ControlDarkDark;
                btnCloseOut.BackColor = SystemColors.ControlDarkDark; 
                btnNewProj.BackColor = SystemColors.ControlDarkDark;
                btnNewMem.BackColor = SystemColors.ControlDarkDark;
                btnGoogle.BackColor = SystemColors.ControlDarkDark;
                btnManualA.BackColor = SystemColors.ControlDarkDark;
                btnHelp.BackColor = SystemColors.ControlDarkDark;
                btnFull.BackColor = SystemColors.ControlDarkDark;
                btnMin.BackColor = SystemColors.ControlDarkDark;
                btnMax.BackColor = SystemColors.ControlDarkDark;


                btnPhases.BackColor = SystemColors.ControlDarkDark;


                btnProjects.BackColor = SystemColors.ControlDarkDark;


                btnMembers.BackColor = SystemColors.ControlDarkDark;


                btnSettings.BackColor = SystemColors.ControlDarkDark;


                btnLogout.BackColor = SystemColors.ControlDarkDark;


                btnClose.BackColor = SystemColors.ControlDarkDark;


                this.BackColor = SystemColors.ControlDarkDark;
                btnExpand.BackColor = SystemColors.ControlDarkDark;

                pnlHide.BackColor = SystemColors.ControlDarkDark;

                pnlPhasesSub.BackColor = SystemColors.ControlDarkDark;
                pnlProjectsSub.BackColor = SystemColors.ControlDarkDark;
                pnlHelpSub.BackColor = SystemColors.ControlDarkDark;
                pnlMembersSub.BackColor = SystemColors.ControlDarkDark;
                pnlChildForm.BackColor = SystemColors.ControlDarkDark;
                //panel1.BackColor = SystemColors.ControlDarkDark;
            }

            if (TechGenics.Properties.Settings.Default.Theme == "BlackC")
            {


                pnlSideMenu.BackColor = SystemColors.Desktop;
                btnInitiation.BackColor = SystemColors.Desktop;
                btnPlanning.BackColor = SystemColors.Desktop;
                btnExecution.BackColor = SystemColors.Desktop;
                btnCloseOut.BackColor = SystemColors.Desktop;
                btnNewProj.BackColor = SystemColors.Desktop;
                btnNewMem.BackColor = SystemColors.Desktop;
                btnGoogle.BackColor = SystemColors.Desktop;
                btnManualA.BackColor = SystemColors.Desktop;
                btnHelp.BackColor = SystemColors.Desktop;
                btnFull.BackColor = SystemColors.Desktop;
                btnMin.BackColor = SystemColors.Desktop;
                btnMax.BackColor = SystemColors.Desktop;


                btnPhases.BackColor = SystemColors.Desktop;


                btnProjects.BackColor = SystemColors.Desktop;


                btnMembers.BackColor = SystemColors.Desktop;


                btnSettings.BackColor = SystemColors.Desktop;


                btnLogout.BackColor = SystemColors.Desktop;


                btnClose.BackColor = SystemColors.Desktop;


                this.BackColor = SystemColors.Desktop;
                btnExpand.BackColor = SystemColors.Desktop;

                pnlHide.BackColor = SystemColors.Desktop;

                pnlPhasesSub.BackColor = SystemColors.Desktop;
                pnlProjectsSub.BackColor = SystemColors.Desktop;
                pnlHelpSub.BackColor = SystemColors.Desktop;
                pnlMembersSub.BackColor = SystemColors.Desktop;
                pnlChildForm.BackColor = SystemColors.Desktop;
                //panel1.BackColor = SystemColors.Desktop;
            }

            if (TechGenics.Properties.Settings.Default.Theme == "WhiteC")
            {

                pnlSideMenu.BackColor = SystemColors.Window;
                btnInitiation.BackColor = SystemColors.Window;
                btnPlanning.BackColor = SystemColors.Window;
                btnExecution.BackColor = SystemColors.Window;
                btnCloseOut.BackColor = SystemColors.Window;
                btnNewProj.BackColor = SystemColors.Window;
                btnNewMem.BackColor = SystemColors.Window;
                btnGoogle.BackColor = SystemColors.Window;
                btnManualA.BackColor = SystemColors.Window;
                btnHelp.BackColor = SystemColors.Window;
                btnFull.BackColor = SystemColors.Window;
                btnMin.BackColor = SystemColors.Window;
                btnMax.BackColor = SystemColors.Window;


                btnPhases.BackColor = SystemColors.Window;


                btnProjects.BackColor = SystemColors.Window;


                btnMembers.BackColor = SystemColors.Window;


                btnSettings.BackColor = SystemColors.Window;


                btnLogout.BackColor = SystemColors.Window;


                btnClose.BackColor = SystemColors.Window;


                this.BackColor = SystemColors.Window;
                btnExpand.BackColor = SystemColors.Window;

                pnlHide.BackColor = SystemColors.Window;

                pnlPhasesSub.BackColor = SystemColors.Window;
                pnlProjectsSub.BackColor = SystemColors.Window;
                pnlHelpSub.BackColor = SystemColors.Window;
                pnlMembersSub.BackColor = SystemColors.Window;
                pnlChildForm.BackColor = SystemColors.Window;
                //panel1.BackColor = SystemColors.Window;
            }

            if (TechGenics.Properties.Settings.Default.Theme == "LBlueC2")
            {
                

                btnHelp.ForeColor = SystemColors.ActiveCaption;

                btnPhases.ForeColor = SystemColors.ActiveCaption;

                btnProjects.ForeColor = SystemColors.ActiveCaption;

                btnMembers.ForeColor = SystemColors.ActiveCaption;

                btnSettings.ForeColor = SystemColors.ActiveCaption;

                btnLogout.ForeColor = SystemColors.ActiveCaption;

                btnClose.ForeColor = SystemColors.ActiveCaption;

            }

            if (TechGenics.Properties.Settings.Default.Theme == "BlueC2")
            {


                btnHelp.ForeColor = SystemColors.Highlight;

                btnPhases.ForeColor = SystemColors.Highlight;

                btnProjects.ForeColor = SystemColors.Highlight;

                btnMembers.ForeColor = SystemColors.Highlight;

                btnSettings.ForeColor = SystemColors.Highlight;

                btnLogout.ForeColor = SystemColors.Highlight;

                btnClose.ForeColor = SystemColors.Highlight;

            }

            if (TechGenics.Properties.Settings.Default.Theme == "DBlueC2")
            {

                btnHelp.ForeColor = SystemColors.Info;

                btnPhases.ForeColor = SystemColors.Info;

                btnProjects.ForeColor = SystemColors.Info;

                btnMembers.ForeColor = SystemColors.Info;

                btnSettings.ForeColor = SystemColors.Info;

                btnLogout.ForeColor = SystemColors.Info;

                btnClose.ForeColor = SystemColors.Info;

            }

            if (TechGenics.Properties.Settings.Default.Theme == "LGreyC2")
            {


                btnHelp.ForeColor = SystemColors.ControlDark;

                btnPhases.ForeColor = SystemColors.ControlDark;

                btnProjects.ForeColor = SystemColors.ControlDark;

                btnMembers.ForeColor = SystemColors.ControlDark;

                btnSettings.ForeColor = SystemColors.ControlDark;

                btnLogout.ForeColor = SystemColors.ControlDark;

                btnClose.ForeColor = SystemColors.ControlDark;

            }

            if (TechGenics.Properties.Settings.Default.Theme == "DGreyC2")
            {


                btnHelp.ForeColor = SystemColors.ControlDarkDark;

                btnPhases.ForeColor = SystemColors.ControlDarkDark;

                btnProjects.ForeColor = SystemColors.ControlDarkDark;

                btnMembers.ForeColor = SystemColors.ControlDarkDark;

                btnSettings.ForeColor = SystemColors.ControlDarkDark;

                btnLogout.ForeColor = SystemColors.ControlDarkDark;

                btnClose.ForeColor = SystemColors.ControlDarkDark;

            }

            if (TechGenics.Properties.Settings.Default.Theme == "BlackC2")
            {


                btnHelp.ForeColor = SystemColors.Desktop;

                btnPhases.ForeColor = SystemColors.Desktop;

                btnProjects.ForeColor = SystemColors.Desktop;

                btnMembers.ForeColor = SystemColors.Desktop;

                btnSettings.ForeColor = SystemColors.Desktop;

                btnLogout.ForeColor = SystemColors.Desktop;

                btnClose.ForeColor = SystemColors.Desktop;

            }

            if (TechGenics.Properties.Settings.Default.Theme == "WhiteC2")
            {
                btnHelp.ForeColor = SystemColors.Window;

                btnPhases.ForeColor = SystemColors.Window;

                btnProjects.ForeColor = SystemColors.Window;

                btnMembers.ForeColor = SystemColors.Window;

                btnSettings.ForeColor = SystemColors.Window;

                btnLogout.ForeColor = SystemColors.Window;

                btnClose.ForeColor = SystemColors.Window;

            }
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            SettingsConstructor settings = new SettingsConstructor();
            settings.CurrentUser = "";
            lblCurrentUser.Text = "";

            login_signup login = new login_signup();
            login.Show();
            this.Dispose();
        }

        public void refreshProjects()
        {
            for (int i = 0; i < numberOfProjectsToRemove; i++)
            {
                foreach (Control item in pnlProjectsSub.Controls.OfType<Button>())
                {
                    if (item.Name != "btnNewProj" && item.Name != "btnRemoveProject")
                    {
                        pnlProjectsSub.Controls.Remove(item);
                    }
                }
            }

            generateProjects();
        }

        private void generateProjects()
        {
            SettingsConstructor settings = new SettingsConstructor();
            bool byPassLogin = settings.ByPassLogin;
            if (byPassLogin == true)
            { }
            else if(byPassLogin == false)
            {
                int locationStartX = 4;
                int locationStartY = 38;
                int projPanelSizeX = 201;
                int projPanelSizeY = 65;

                if (isAdmin == true)
                {
                    btnNewProj.Visible = true;
                    locationStartY += 90;
                    projPanelSizeY += 90;

                    DataAccess db = new DataAccess();
                    _ProjectsAndTasks = new List<ProjectsAndTasksByUserPhase>(); 
                    _ProjectsAndTasks = db.GetProjectAndTaskInfo(null, true, true, true, true); //Change to read from db
                    DataSet dsProjectsAndTasks = new DataSet();
                    dsProjectsAndTasks = ListToDataSet.ToDataSet(_ProjectsAndTasks);

                    DataView view = new DataView(dsProjectsAndTasks.Tables[0]);
                    DataTable distinctProjects = view.ToTable(true, "ProjectId", "ProjectName", "ProjectPhase", "ProjectStatus", "DocumentLocation");
                    DataRow[] projectByPhase;
                    DataTable dtProjectByPhase;
                    if (cboPhases.Text == "--All Phases--")
                    {
                        dtProjectByPhase = distinctProjects;
                    }
                    else
                    {
                        projectByPhase = distinctProjects.Select("ProjectPhase = '" + cboPhases.Text + "'");
                        dtProjectByPhase = distinctProjects.Clone();
                        foreach (DataRow row in projectByPhase)
                        {
                            dtProjectByPhase.ImportRow(row);
                        }
                    }

                    foreach (DataRow row in dtProjectByPhase.Rows)
                    {
                        numberOfProjectsToRemove++;
                        ctrl = btnNewProj.Clone();
                        ctrl.Name = row.Field<String>("ProjectName");
                        ctrl.Text = row.Field<String>("ProjectName");
                        ctrl.Tag = row.Field<Int32>("ProjectId");
                        ctrl.Location = new Point(locationStartX, locationStartY);
                        ctrl.Visible = true;
                        ctrl.Click += project_Click;

                        locationStartY += 30;
                        pnlProjectsSub.Size = new Size(projPanelSizeX, projPanelSizeY);
                        projPanelSizeY += 30;
                        pnlProjectsSub.Controls.Add(ctrl);
                    }
                }
                else if (isAdmin == false)
                {
                    btnNewProj.Visible = false;
                    locationStartY += 30;
                    projPanelSizeY += 30;

                    List<User> _users = new List<User>();
                    DataAccess db = new DataAccess();
                    _users = db.GetUser(currentUser);
                    DataSet dsUser = new DataSet();
                    dsUser = ListToDataSet.ToDataSet(_users);
                    bool initiation = (bool)dsUser.Tables[0].Rows[0]["Initiation"];
                    bool planning = (bool)dsUser.Tables[0].Rows[0]["Planning"];
                    bool execution = (bool)dsUser.Tables[0].Rows[0]["Execution"];
                    bool closeOut = (bool)dsUser.Tables[0].Rows[0]["CloseOut"];                 

                    _ProjectsAndTasks = db.GetProjectAndTaskInfo(currentUser, initiation, planning, execution, closeOut); 
                    DataSet dsProjectsAndTasks = new DataSet();
                    dsProjectsAndTasks = ListToDataSet.ToDataSet(_ProjectsAndTasks);

                    DataView view = new DataView(dsProjectsAndTasks.Tables[0]);
                    DataTable distinctProjects = view.ToTable(true, "ProjectId", "ProjectName", "ProjectPhase", "ProjectStatus", "DocumentLocation");
                    DataRow[] projectByPhase;
                    DataTable dtProjectByPhase;
                    if (cboPhases.Text == "--All Phases--")
                    {
                        dtProjectByPhase = distinctProjects;
                    }
                    else
                    {
                        projectByPhase = distinctProjects.Select("ProjectPhase = '" + cboPhases.Text + "'");
                        dtProjectByPhase = distinctProjects.Clone();
                        foreach (DataRow row in projectByPhase)
                        {
                            dtProjectByPhase.ImportRow(row);
                        }
                    }

                    foreach (DataRow row in dtProjectByPhase.Rows)
                    {
                        numberOfProjectsToRemove++;
                        ctrl = btnNewProj.Clone();
                        ctrl.Name = row.Field<String>("ProjectName");
                        ctrl.Text = row.Field<String>("ProjectName");
                        ctrl.Tag = row.Field<Int32>("ProjectId");
                        ctrl.Location = new Point(locationStartX, locationStartY);
                        ctrl.Visible = true;
                        ctrl.Click += project_Click;

                        locationStartY += 30;
                        pnlProjectsSub.Size = new Size(projPanelSizeX, projPanelSizeY);
                        projPanelSizeY += 30;
                        pnlProjectsSub.Controls.Add(ctrl);
                    }
                }              
            }     
        }

        private void project_Click(object sender, EventArgs e)
        {          
            var button = (Button)sender;
            buttonTag = button.Tag.ToString();
            lblTasksHeading.Text = button.Name.ToUpper();

            for (int i = 0; i < numberOfTasksToRemove; i++)
            {
                foreach (Control item in pnlBacklog.Controls.OfType<Button>())
                {
                    if (item.Name != "btnPtoB" 
                        && item.Name != "btnBtoP" 
                        && item.Name != "btnCtoP"
                        && item.Name != "btnPtoC"
                        && item.Name != "btnRtoC"
                        && item.Name != "btnCtoR"
                        && item.Name != "btnDividerLeft"
                        && item.Name != "btnDividerMid"
                        && item.Name != "btnDividerRight")
                    {
                        pnlBacklog.Controls.Remove(item);
                    }
                }
            }

            backlogLocationStartX = 18;
            progressLocationStartX = 221;
            completedLocationStartX = 447;
            removedLocationStartX = 662;
            backlogLocationStartY = 13;
            progressLocationStartY = 13;
            completedLocationStartY = 13;
            removedLocationStartY = 13;

            lastBacklogLocationX = 0;
            lastBacklogLocationY = 0;
            lastProgressLocationX = 0;
            lastProgressLocationY = 0;
            lastCompletedLocationX = 0;
            lastCompletedLocationY = 0;
            lastRemovedLocationX = 0;
            lastRemovedLocationY = 0;

            generateTasks(buttonTag);
            pnlTasks.Visible = true;
        }
        private void generateTasks(string buttonTag)
        {
            if (isAdmin == true)
            {              
                DataAccess db = new DataAccess();

                _GeneratedTasks = new List<ProjectsAndTasksByUserPhase>();
                _GeneratedTasks = db.GetProjectAndTaskInfo(null, true, true, true, true); 
                DataSet dsGeneratedTasks = new DataSet();
                dsGeneratedTasks = ListToDataSet.ToDataSet(_GeneratedTasks);
                DataView view = new DataView(dsGeneratedTasks.Tables[0]);
                DataTable dtGeneratedTasks = view.ToTable();/*dsGeneratedTasks.Tables[0].Select("ProjectPhase = '" + cboPhases.Text + "'");*/

                DataRow[] dtGeneratedTasksFilterRow = dtGeneratedTasks.Select("ProjectId = '" + buttonTag + "'");
                dtGeneratedTasksFilter = dtGeneratedTasks.Clone();

                foreach (DataRow row in dtGeneratedTasksFilterRow)
                {
                    dtGeneratedTasksFilter.ImportRow(row);
                }

                foreach (DataRow row in dtGeneratedTasksFilter.Rows)
                {
                    numberOfTasksToRemove++;
                    ctrlTask = btnBackLogEx.Clone();
                    ctrlTask.Name = row.Field<String>("TaskName");
                    ctrlTask.Text = row.Field<String>("TaskName");
                    ctrlTask.Tag = row.Field<Int32>("TaskId");

                    if (row.Field<String>("TaskStatus") == "Backlog")
                    {
                        ctrlTask.Location = new Point(backlogLocationStartX, backlogLocationStartY);
                        backlogLocationStartY += 90;
                        lastBacklogLocationY = backlogLocationStartY;
                    }
                    else if (row.Field<String>("TaskStatus") == "Progress")
                    {
                        ctrlTask.Location = new Point(progressLocationStartX, progressLocationStartY);
                        progressLocationStartY += 90;
                        lastProgressLocationY = progressLocationStartY;
                    }
                    else if (row.Field<String>("TaskStatus") == "Completed")
                    {
                        ctrlTask.Location = new Point(completedLocationStartX, completedLocationStartY);
                        completedLocationStartY += 90;
                        lastCompletedLocationY = completedLocationStartY;
                    }
                    else if (row.Field<String>("TaskStatus") == "Removed")
                    {
                        ctrlTask.Location = new Point(removedLocationStartX, removedLocationStartY);
                        removedLocationStartY += 90;
                        lastRemovedLocationY = removedLocationStartY;
                    }

                    ctrlTask.Visible = true;
                    ctrlTask.Click += task_Click;
                    ctrlTask.MouseDown += task_MouseDown;

                    pnlBacklog.Controls.Add(ctrlTask);
                }
            }
            else if (isAdmin == false)
            {
                List<User> _users = new List<User>();
                DataAccess db = new DataAccess();
                _users = db.GetUser(currentUser);
                DataSet dsUser = new DataSet();
                dsUser = ListToDataSet.ToDataSet(_users);
                bool initiation = (bool)dsUser.Tables[0].Rows[0]["Initiation"];
                bool planning = (bool)dsUser.Tables[0].Rows[0]["Planning"];
                bool execution = (bool)dsUser.Tables[0].Rows[0]["Execution"];
                bool closeOut = (bool)dsUser.Tables[0].Rows[0]["CloseOut"];

                _GeneratedTasks = new List<ProjectsAndTasksByUserPhase>();
                _GeneratedTasks = db.GetProjectAndTaskInfo(currentUser, initiation, planning, execution, closeOut); //Change to read from db
                DataSet dsGeneratedTasks = new DataSet();
                dsGeneratedTasks = ListToDataSet.ToDataSet(_GeneratedTasks);
                DataView view = new DataView(dsGeneratedTasks.Tables[0]);
                DataTable dtGeneratedTasks = view.ToTable();/*dsGeneratedTasks.Tables[0].Select("ProjectPhase = '" + cboPhases.Text + "'");*/

                DataRow[] dtGeneratedTasksFilterRow = dtGeneratedTasks.Select("ProjectId = '" + buttonTag + "'");
                dtGeneratedTasksFilter = dtGeneratedTasks.Clone();

                foreach (DataRow row in dtGeneratedTasksFilterRow)
                {
                    dtGeneratedTasksFilter.ImportRow(row);
                }

                foreach (DataRow row in dtGeneratedTasksFilter.Rows)
                {
                    numberOfTasksToRemove++;
                    ctrlTask = btnBackLogEx.Clone();
                    ctrlTask.Name = row.Field<String>("TaskName");
                    ctrlTask.Text = row.Field<String>("TaskName");
                    ctrlTask.Tag = row.Field<Int32>("TaskId");

                    if (row.Field<String>("TaskStatus") == "Backlog")
                    {
                        ctrlTask.Location = new Point(backlogLocationStartX, backlogLocationStartY);
                        backlogLocationStartY += 90;
                        lastBacklogLocationY = backlogLocationStartY;
                    }
                    else if (row.Field<String>("TaskStatus") == "Progress")
                    {
                        ctrlTask.Location = new Point(progressLocationStartX, progressLocationStartY);
                        progressLocationStartY += 90;
                        lastProgressLocationY = progressLocationStartY;
                    }
                    else if (row.Field<String>("TaskStatus") == "Completed")
                    {
                        ctrlTask.Location = new Point(completedLocationStartX, completedLocationStartY);
                        completedLocationStartY += 90;
                        lastCompletedLocationY = completedLocationStartY;
                    }
                    else if (row.Field<String>("TaskStatus") == "Removed")
                    {
                        ctrlTask.Location = new Point(removedLocationStartX, removedLocationStartY);
                        removedLocationStartY += 90;
                        lastRemovedLocationY = removedLocationStartY;
                    }

                    ctrlTask.Visible = true;
                    ctrlTask.Click += task_Click;
                    ctrlTask.MouseDown += task_MouseDown;

                    pnlBacklog.Controls.Add(ctrlTask);
                }
            }          
        }

        private void task_Click(object sender, EventArgs e)
        {
            string taskTag;
            var button = (Button)sender;
            taskTag = button.Tag.ToString();
            taskToMoveId = taskTag;
            ctrlTaskToMove = button;
        }

        private void task_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Clicks == 2)
            {
                string taskTag;
                var button = (Button)sender;
                taskTag = button.Tag.ToString();

                DataAccess db = new DataAccess();
                List<ProjectTasks> _tasks = new List<ProjectTasks>();
                _tasks = db.GetTask(Int32.Parse(taskTag));
                DataSet dsTask = new DataSet();
                dsTask = ListToDataSet.ToDataSet(_tasks);

                string taskDesc = dsTask.Tables[0].Rows[0]["TaskDescription"].ToString();
                string taskAssigned = dsTask.Tables[0].Rows[0]["TaskAssignedTo"].ToString();
                string taskProgress = dsTask.Tables[0].Rows[0]["TaskProgress"].ToString();
                string taskStatus = dsTask.Tables[0].Rows[0]["TaskStatus"].ToString();
                string projectName = dsTask.Tables[0].Rows[0]["ProjectName"].ToString();

                rtbTaskDesc.Text = taskDesc;
                txtTaskAssignedTo.Text = taskAssigned;
                txtTaskProgress.Text = taskProgress;
                txtTaskStatus.Text = taskStatus;
                txtProjectName.Text = projectName;

                pnlBacklog.Visible = false;
                lblTaskName.Text = button.Name.ToUpper();
                pnlViewTask.Visible = true;
            }     
        }

        private void removeTasks()
        {
            for (int i = 0; i < numberOfTasksToRemove; i++)
            {
                foreach (Control item in pnlBacklog.Controls.OfType<Button>())
                {
                    if (item.Name != "btnPtoB"
                        && item.Name != "btnBtoP"
                        && item.Name != "btnCtoP"
                        && item.Name != "btnPtoC"
                        && item.Name != "btnRtoC"
                        && item.Name != "btnCtoR"
                        && item.Name != "btnDividerLeft"
                        && item.Name != "btnDividerMid"
                        && item.Name != "btnDividerRight")
                    {
                        pnlBacklog.Controls.Remove(item);
                    }
                }
            }
        }

        private void resetPos()
        {
            backlogLocationStartX = 18;
            progressLocationStartX = 221;
            completedLocationStartX = 447;
            removedLocationStartX = 662;
            backlogLocationStartY = 13;
            progressLocationStartY = 13;
            completedLocationStartY = 13;
            removedLocationStartY = 13;

            lastBacklogLocationX = 0;
            lastBacklogLocationY = 0;
            lastProgressLocationX = 0;
            lastProgressLocationY = 0;
            lastCompletedLocationX = 0;
            lastCompletedLocationY = 0;
            lastRemovedLocationX = 0;
            lastRemovedLocationY = 0;
        }

        public void refreshTasks()
        {
            removeTasks();
            resetPos();
            generateTasks(buttonTag);
        }

        private void btnPtoB_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            ctrlTaskToMove.Location = new Point(backlogLocationStartX, lastBacklogLocationY + 90);
            lastBacklogLocationY += 90;
            db.UpdateTaskStatus(Int32.Parse(taskToMoveId), "Backlog");
            removeTasks();
            resetPos();
            generateTasks(buttonTag);
        }

        private void btnBtoP_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            ctrlTaskToMove.Location = new Point(progressLocationStartX, lastProgressLocationY + 90);
            lastProgressLocationY += 90;
            db.UpdateTaskStatus(Int32.Parse(taskToMoveId), "Progress");
            removeTasks();
            resetPos();
            generateTasks(buttonTag);
        }

        private void btnCtoP_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            ctrlTaskToMove.Location = new Point(progressLocationStartX, lastProgressLocationY + 90);
            lastProgressLocationY += 90;
            db.UpdateTaskStatus(Int32.Parse(taskToMoveId), "Progress");
            removeTasks();
            resetPos();
            generateTasks(buttonTag);
        }

        private void btnPtoC_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            ctrlTaskToMove.Location = new Point(completedLocationStartX, lastCompletedLocationY + 90);
            lastCompletedLocationY += 90;
            db.UpdateTaskStatus(Int32.Parse(taskToMoveId), "Completed");
            removeTasks();
            resetPos();
            generateTasks(buttonTag);
        }

        private void btnRtoC_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            ctrlTaskToMove.Location = new Point(completedLocationStartX, lastCompletedLocationY + 90);
            lastCompletedLocationY += 90;
            db.UpdateTaskStatus(Int32.Parse(taskToMoveId), "Completed");
            removeTasks();
            resetPos();
            generateTasks(buttonTag);
        }

        private void btnCtoR_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            ctrlTaskToMove.Location = new Point(removedLocationStartX, lastRemovedLocationY + 90);
            lastRemovedLocationY += 90;
            db.UpdateTaskStatus(Int32.Parse(taskToMoveId), "Removed");
            removeTasks();
            resetPos();
            generateTasks(buttonTag);
        }

        //private void btnInitiation_Click(object sender, EventArgs e)
        //{

        //    //pnlChildForm.Size = new Size(860, 656);
        //    ////pnlChildForm.BringToFront();
        //    //leftDock = true;
        //}
        //private void pnlChildForm_Paint(object sender, PaintEventArgs e)
        //{
        //    //ControlExtension.Draggable(btnTaskBacklog, true);
        //}
        //private void openInDualViewToolStripMenuItem_Click(object sender, EventArgs e)
        //{


        //    if (leftDock == true)
        //    {
        //        //dock panel right
        //        pnlChildForm.Dock = DockStyle.Right;
        //        pnlChildForm.Size = new System.Drawing.Size(pnlChildForm.Size.Width - 430, pnlChildForm.Size.Height);
        //    }
        //    else
        //    {
        //        pnlChildForm.Dock = DockStyle.Left;
        //        pnlChildForm.Size = new System.Drawing.Size(pnlChildForm.Size.Width - 430, pnlChildForm.Size.Height);
        //    }
        //}

        private void cboPhases_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < numberOfProjectsToRemove; i++)
            {
                foreach (Control item in pnlProjectsSub.Controls.OfType<Button>())
                {
                    if (item.Name != "btnNewProj" && item.Name != "btnRemoveProject")
                    {
                        pnlProjectsSub.Controls.Remove(item);
                    }  
                }
            }
                 
            generateProjects();
        }

        private void btnCloseTaskPanel_Click(object sender, EventArgs e)
        {
            pnlTasks.Visible = false;
        }

        private void btnBackTask_Click(object sender, EventArgs e)
        {
            pnlViewTask.Visible = false;
            pnlBacklog.Visible = true;
        }

        private void btnLogout_Click_2(object sender, EventArgs e)
        {
            SettingsConstructor settings = new SettingsConstructor();
            settings.CurrentUser = "";
            lblCurrentUser.Text = "";
            settings.ByPassLogin = false;

            login_signup login = new login_signup();
            login.Show();
            this.Dispose();
        }

        private void btnShowDocuments_Click(object sender, EventArgs e)
        {
            openChildForm(new Docs());
        }

        private void btnNewProj_Click(object sender, EventArgs e)
        {
            frmAddProject addProject = new frmAddProject();
            addProject.StartPosition = FormStartPosition.CenterParent;
            addProject.ShowDialog();
        }

        private void btnManualA_Click(object sender, EventArgs e)
        {

        }

        private void btnAddTasl_Click(object sender, EventArgs e)
        {
            frmAddTask addTask = new frmAddTask();
            addTask.StartPosition = FormStartPosition.CenterParent;
            addTask.ShowDialog();
        }

        private void btnNewMem_Click(object sender, EventArgs e)
        {
            frmAddUser addUser = new frmAddUser();
            addUser.StartPosition = FormStartPosition.CenterParent;
            addUser.ShowDialog();
        }

        private void btnViewTemplateDocs_Click(object sender, EventArgs e)
        {
            openChildForm(new Docs());
        }
    }
}
