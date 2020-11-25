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
           //lblCurrentUser.Text = "Welcome " + settings.CurrentUser;
            
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
           
       

        private void btnInitiation_Click(object sender, EventArgs e)
        {
            
            pnlChildForm.Size = new Size(860, 656);
            //pnlChildForm.BringToFront();
            leftDock = true;
        }

        private void btnPlanning_Click(object sender, EventArgs e)
        {
            
        }
                
        private void btnNewProj_Click(object sender, EventArgs e)
        {

            int XPos = -1;
            int YPos = -1;
            object inputB = "";

            inputB = Interaction.InputBox("New Project Creation", "Enter the name of the new project","new project 1..", XPos, YPos);

            if(inputB != null)
            {
                pnlTasks.Visible = true;
                pnlTasks.BringToFront();

            }

            string actualHeading = Convert.ToString(inputB);
            lblTasksHeading.Text = ("Tasks for " +actualHeading).ToUpper();
            
        }

        private void btnExecution_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCloseOut_Click(object sender, EventArgs e)
        {
            
        }
        
        private void pnlChildForm_Paint(object sender, PaintEventArgs e)
        {
            ControlExtension.Draggable(btnTask1, true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
              
       
        private void openInDualViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            if(leftDock == true)
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
                btnNewProj.BackColor = SystemColors.AppWorkspace;
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

                pnlHide.BackColor = SystemColors.Desktop; 

                pnlPhasesSub.BackColor = SystemColors.AppWorkspace;
                pnlDiagramsSub.BackColor = SystemColors.AppWorkspace;
                pnlProjectsSub.BackColor = SystemColors.AppWorkspace;
                pnlHelpSub.BackColor = SystemColors.AppWorkspace;
                pnlMembersSub.BackColor = SystemColors.AppWorkspace;
                pnlChildForm.BackColor = SystemColors.Desktop;
                button8.BackColor = SystemColors.AppWorkspace;
            }
            if (TechGenics.Properties.Settings.Default.Theme == "Dark")
            {
                btnDocs.BackColor = SystemColors.Desktop;
                btnDocs.ForeColor = SystemColors.ActiveBorder;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
