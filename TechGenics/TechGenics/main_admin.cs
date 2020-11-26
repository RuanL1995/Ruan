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
        private Control ctrl;

        //Projects and tasks model
        List<ProjectsAndTasksByUserPhase> _ProjectsAndTasks = new List<ProjectsAndTasksByUserPhase>();

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
            pnlDiagramsSub.Visible = false;
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

            if (pnlDiagramsSub.Visible == true)
            {
                pnlDiagramsSub.Visible = false;
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
            showSubs(pnlDiagramsSub);
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
            pnlChildForm.Controls.Add(docs);
            pnlChildForm.Tag = docs;
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

        

        private void btnLightMode_Click(object sender, EventArgs e)
        {
            lightMode();
        }

        public void lightMode()
        {
            lblTitle.BackColor = Color.DimGray;
            pnlSideMenu.BackColor = Color.DimGray;
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
                btnTemplate.BackColor = SystemColors.AppWorkspace;
                //btnNewProj.BackColor = SystemColors.AppWorkspace;
                btnNewMem.BackColor = SystemColors.AppWorkspace;
                btnGoogle.BackColor = SystemColors.AppWorkspace;
                btnManualA.BackColor = SystemColors.AppWorkspace;
                btnHelp.BackColor = SystemColors.AppWorkspace;
                btnFull.BackColor = SystemColors.AppWorkspace;
                btnMin.BackColor = SystemColors.AppWorkspace;
                btnMax.BackColor = SystemColors.AppWorkspace;
                btnHelp.ForeColor = SystemColors.Desktop;

                btnPhases.BackColor = SystemColors.AppWorkspace;
                btnPhases.ForeColor = SystemColors.Desktop;

                btnDocs.BackColor = SystemColors.AppWorkspace;
                btnDocs.ForeColor = SystemColors.Desktop;

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
                pnlDiagramsSub.BackColor = SystemColors.AppWorkspace;
                pnlProjectsSub.BackColor = SystemColors.AppWorkspace;
                pnlHelpSub.BackColor = SystemColors.AppWorkspace;
                pnlMembersSub.BackColor = SystemColors.AppWorkspace;
                pnlChildForm.BackColor = SystemColors.Desktop;
            }
            if (TechGenics.Properties.Settings.Default.Theme == "Dark")
            {
                btnDocs.BackColor = SystemColors.Desktop;
                btnDocs.ForeColor = SystemColors.ActiveBorder;

                pnlSideMenu.BackColor = SystemColors.Desktop;
                btnInitiation.BackColor = SystemColors.Desktop;
                btnPlanning.BackColor = SystemColors.Desktop;
                btnExecution.BackColor = SystemColors.Desktop;
                btnCloseOut.BackColor = SystemColors.Desktop;
                btnTemplate.BackColor = SystemColors.Desktop;
                btnNewProj.BackColor = SystemColors.Desktop;
                btnNewMem.BackColor = SystemColors.Desktop;
                btnGoogle.BackColor = SystemColors.Desktop;
                btnManualA.BackColor = SystemColors.Desktop;
                btnHelp.BackColor = SystemColors.Desktop;
                btnFull.BackColor = SystemColors.Desktop;
                btnMin.BackColor = SystemColors.Desktop;
                btnMax.BackColor = SystemColors.Desktop;
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
                pnlDiagramsSub.BackColor = SystemColors.Desktop;
                pnlProjectsSub.BackColor = SystemColors.Desktop;
                pnlHelpSub.BackColor = SystemColors.Desktop;
                pnlMembersSub.BackColor = SystemColors.Desktop;
                pnlChildForm.BackColor = SystemColors.Desktop;
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

        private void generateProjects()
        {
            DataAccess db = new DataAccess();
            _ProjectsAndTasks = db.GetProjectAndTaskInfo(currentUser,true,false,true,false); //Change to read from db
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

            int locationStartX = 4;
            int locationStartY = 38;
            int projPanelSizeX = 201;
            int projPanelSizeY = 65;           

            foreach (DataRow row in dtProjectByPhase.Rows)
            {
                ctrl = btnNewProj.Clone();
                ctrl.Name = row.Field<String>("ProjectName");
                ctrl.Text = Text = row.Field<String>("ProjectName");
                ctrl.Location = new Point(locationStartX, locationStartY);
                ctrl.Visible = true;

                locationStartY += 30;
                pnlProjectsSub.Size = new Size(projPanelSizeX, projPanelSizeY);
                projPanelSizeY += 30;
                pnlProjectsSub.Controls.Add(ctrl);
            }
        }
        private void generateTasks()
        {
            int XPos = -1;
            int YPos = -1;
            object inputB = "";

            inputB = Interaction.InputBox("New Project Creation", "Enter the name of the new project", "new project 1..", XPos, YPos);

            if (inputB != null)
            {
                pnlTasks.Visible = true;
                pnlTasks.BringToFront();

            }

            string actualHeading = Convert.ToString(inputB);
            lblTasksHeading.Text = ("Tasks for " + actualHeading).ToUpper();
        }

        private void btnInitiation_Click(object sender, EventArgs e)
        {

            //pnlChildForm.Size = new Size(860, 656);
            ////pnlChildForm.BringToFront();
            //leftDock = true;
        }
        private void pnlChildForm_Paint(object sender, PaintEventArgs e)
        {
            //ControlExtension.Draggable(btnTaskBacklog, true);
        }
        private void openInDualViewToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (leftDock == true)
            {
                //dock panel right
                pnlChildForm.Dock = DockStyle.Right;
                pnlChildForm.Size = new System.Drawing.Size(pnlChildForm.Size.Width - 430, pnlChildForm.Size.Height);
            }
            else
            {
                pnlChildForm.Dock = DockStyle.Left;
                pnlChildForm.Size = new System.Drawing.Size(pnlChildForm.Size.Width - 430, pnlChildForm.Size.Height);
            }
        }

        private void cboPhases_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control item in pnlProjectsSub.Controls.OfType<Button>())
            {
                pnlProjectsSub.Controls.Remove(item);
            }
            generateProjects();
        }
    }
}
