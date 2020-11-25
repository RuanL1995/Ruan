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

        //tab control
        int tab = 1;
        
        bool initiation1 = false;
        bool initiation2 = false;
        bool initiation3 = false;
        bool initiation4 = false;
        bool initiation5 = false;

        bool planning1 = false;
        bool planning2 = false;
        bool planning3 = false;
        bool planning4 = false;
        bool planning5= false;

        bool execution1 = false;
        bool execution2 = false;
        bool execution3 = false;
        bool execution4 = false;
        bool execution5 = false;

        bool closeOut1 = false;
        bool closeOut2 = false;
        bool closeOut3 = false;
        bool closeOut4 = false;
        bool closeOut5 = false;

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

        private void openChildForm2(Form frmChild)
        {
            if (frmActive != null)
            {
                frmActive.Close();
            }

            frmActive = frmChild;
            frmChild.TopLevel = false;
            frmChild.FormBorderStyle = FormBorderStyle.None;
            frmChild.Dock = DockStyle.Fill;
            pnlChildForm2.Controls.Add(frmChild);
            pnlChildForm2.Tag = frmChild;
            frmChild.BringToFront();
            frmChild.Show();
        }

        private void openChildForm3(Form frmChild)
        {
            if (frmActive != null)
            {
                frmActive.Close();
            }

            frmActive = frmChild;
            frmChild.TopLevel = false;
            frmChild.FormBorderStyle = FormBorderStyle.None;
            frmChild.Dock = DockStyle.Fill;
            pnlChildForm3.Controls.Add(frmChild);
            pnlChildForm3.Tag = frmChild;
            frmChild.BringToFront();
            frmChild.Show();
        }

        private void openChildForm4(Form frmChild)
        {
            if (frmActive != null)
            {
                frmActive.Close();
            }

            frmActive = frmChild;
            frmChild.TopLevel = false;
            frmChild.FormBorderStyle = FormBorderStyle.None;
            frmChild.Dock = DockStyle.Fill;
            pnlChildForm4.Controls.Add(frmChild);
            pnlChildForm4.Tag = frmChild;
            frmChild.BringToFront();
            frmChild.Show();
        }

        private void openChildForm5(Form frmChild)
        {
            if (frmActive != null)
            {
                frmActive.Close();
            }

            frmActive = frmChild;
            frmChild.TopLevel = false;
            frmChild.FormBorderStyle = FormBorderStyle.None;
            frmChild.Dock = DockStyle.Fill;
            pnlChildForm5.Controls.Add(frmChild);
            pnlChildForm5.Tag = frmChild;
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
                

                if(tab == 0)
                {
                    tab = 1;
                }
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
                

                if (tab == 0)
                {
                    tab = 1;
                }
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
                

                if (tab == 0)
                {
                    tab = 1;
                }
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
                

                if (tab == 0)
                {
                    tab = 1;
                }
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

        
        private void button4_Click(object sender, EventArgs e)
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
                
        public void showTabs()
        {
            if (tab == 3)
            {
                btnTab3.Visible = true;
            }

            if (tab == 4)
            {
                btnTab4.Visible = true;
            }

            if (tab == 5)
            {
                btnTab5.Visible = true;
            }

            if (tab >= 6)
            {
                MessageBox.Show("Tab bar full!");
            }
        }
              

        private void btnPnewTab_Click(object sender, EventArgs e)
        {
            btnTab1.Visible = true;
            btnTab2.Visible = true;
            tab++;
            showTabs();
            
        }
             
       
        private void btnTab1_Click(object sender, EventArgs e)
        {
            pnlChildForm.Visible = true;
            pnlChildForm.BringToFront();

            pnlChildForm2.Visible = false;
            //pnlChildForm2.SendToBack();
            pnlChildForm3.Visible = false;
            //pnlChildForm3.SendToBack();
            pnlChildForm4.Visible = false;
            //pnlChildForm4.SendToBack();
            pnlChildForm5.Visible = false;
            //pnlChildForm5.SendToBack();
            //pnlTasks.Visible = false;
            //pnlTasks.SendToBack();

            tabControl();
        }

        private void btnTab2_Click(object sender, EventArgs e)
        {
            pnlChildForm2.Visible = true;
            pnlChildForm2.BringToFront();

            pnlChildForm.Visible = false;
            //pnlChildForm2.SendToBack();
            pnlChildForm3.Visible = false;
            //pnlChildForm3.SendToBack();
            pnlChildForm4.Visible = false;
            //pnlChildForm4.SendToBack();
            pnlChildForm5.Visible = false;
            //pnlChildForm5.SendToBack();

            tabControl();

        }

        private void btnTab3_Click(object sender, EventArgs e)
        {
            pnlChildForm3.Visible = true;
            pnlChildForm3.BringToFront();

            pnlChildForm2.Visible = false;
            //pnlChildForm2.SendToBack();
            pnlChildForm.Visible = false;
            //pnlChildForm.SendToBack();
            pnlChildForm4.Visible = false;
            //pnlChildForm4.SendToBack();
            pnlChildForm5.Visible = false;
            //pnlChildForm5.SendToBack();

            tabControl();
        }

        private void btnTab4_Click(object sender, EventArgs e)
        {
            pnlChildForm4.Visible = true;
            pnlChildForm4.BringToFront();

            pnlChildForm2.Visible = false;
            //pnlChildForm2.SendToBack();
            pnlChildForm3.Visible = false;
            //pnlChildForm3.SendToBack();
            pnlChildForm.Visible = false;
            //pnlChildForm.SendToBack();
            pnlChildForm5.Visible = false;
            //pnlChildForm5.SendToBack();

            tabControl();
        }

        private void btnTab5_Click(object sender, EventArgs e)
        {
            pnlChildForm5.Visible = true;
            pnlChildForm5.BringToFront();

            pnlChildForm2.Visible = false;
            //pnlChildForm2.SendToBack();
            pnlChildForm3.Visible = false;
            //pnlChildForm3.SendToBack();
            pnlChildForm4.Visible = false;
            //pnlChildForm4.SendToBack();
            pnlChildForm.Visible = false;
            //pnlChildForm.SendToBack();

            tabControl();
        }

        private void openInNewTabToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
            btnTab1.Visible = true;
            btnTab2.Visible = true;
            tab++;
            showTabs();
                

            if (tab == 2)
            {
                openChildForm2(new frmInitiation());
                pnlChildForm2.BringToFront();
                pnlChildForm2.Visible = true;

                initiation2 = true;
                //planning2 = false;
                //execution2 = false;
                //closeOut2 = false;
            }
            else if (tab == 3)
            {
                openChildForm3(new frmInitiation());
                pnlChildForm3.BringToFront();
                pnlChildForm3.Visible = true;

                initiation3 = true;
                //planning3 = false;
                //execution3 = false;
                //closeOut3 = false;
            }
            else if (tab == 4)
            {
                openChildForm4(new frmInitiation());
                pnlChildForm4.BringToFront();
                pnlChildForm4.Visible = true;

                initiation4 = true;
                //planning4 = false;
                //execution4 = false;
                //closeOut4 = false;
            }
            else if (tab == 5)
            {
                openChildForm5(new frmInitiation());
                pnlChildForm5.BringToFront();
                pnlChildForm5.Visible = true;

                initiation5 = true;
                //planning5 = false;
                //execution5 = false;
                //closeOut5 = false;

            }
                       
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnTab1.Visible = true;
            btnTab2.Visible = true;
            tab++;
            showTabs();
           

            if (tab == 2)
            {
                openChildForm2(new frmPlanning());
                pnlChildForm2.BringToFront();
                pnlChildForm2.Visible = true;

                //initiation2 = false;
                planning2 = true;
                //execution2 = false;
                //closeOut2 = false;
            }
            else if (tab == 3)
            {
                openChildForm3(new frmPlanning());
                pnlChildForm3.BringToFront();
                pnlChildForm3.Visible = true;

                //initiation3 = false;
                planning3 = true;
                //execution3 = false;
                //closeOut3 = false;
            }
            else if (tab == 4)
            {
                openChildForm4(new frmPlanning());
                pnlChildForm4.BringToFront();
                pnlChildForm4.Visible = true;

                //initiation4 = false;
                planning4 = true;
                //execution4 = false;
                //closeOut4 = false;
            }
            else if (tab == 5)
            {
                openChildForm5(new frmPlanning());
                pnlChildForm5.BringToFront();
                pnlChildForm5.Visible = true;

                //initiation5 = false;
                planning5 = true;
                //execution5 = false;
                //closeOut5 = false;
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

            btnTab1.Visible = true;
            btnTab2.Visible = true;
            tab++;
            showTabs();
           

            if (tab == 2)
            {
                openChildForm2(new frmExecution());
                pnlChildForm2.BringToFront();
                pnlChildForm2.Visible = true;

                //initiation2 = false;
                //planning2 = false;
                execution2 = true;
                //closeOut2 = false;
            }
            else if (tab == 3)
            {
                openChildForm3(new frmExecution());
                pnlChildForm3.BringToFront();
                pnlChildForm3.Visible = true;

                //initiation3 = false;
                //planning3 = false;
                execution3 = true;
                //closeOut3 = false;

            }
            else if (tab == 4)
            {
                openChildForm4(new frmExecution());
                pnlChildForm4.BringToFront();
                pnlChildForm4.Visible = true;

                //initiation4 = false;
                //planning4 = false;
                execution4 = true;
                //closeOut4 = false;

            }
            else if (tab == 5)
            {
                openChildForm5(new frmExecution());
                pnlChildForm5.BringToFront();
                pnlChildForm5.Visible = true;

                //initiation5 = false;
                //planning5 = false;
                execution5 = true;
                //closeOut5 = false;

            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            btnTab1.Visible = true;
            btnTab2.Visible = true;
            tab++;
            showTabs();
           

            if (tab == 2)
            {
                openChildForm2(new frmCloseOut());
                pnlChildForm2.BringToFront();
                pnlChildForm2.Visible = true;

                //initiation2 = false;
                //planning2 = false;
                //execution2 = false;
                closeOut2 = true;

            }
            else if (tab == 3)
            {
                openChildForm3(new frmCloseOut());
                pnlChildForm3.BringToFront();
                pnlChildForm3.Visible = true;

                //initiation3 = false;
                //planning3 = false;
                //execution3 = false;
                closeOut3 = true;
            }
            else if (tab == 4)
            {
                openChildForm4(new frmCloseOut());
                pnlChildForm4.BringToFront();
                pnlChildForm4.Visible = true;

                //initiation4 = false;
                //planning4 = false;
                //execution4 = false;
                closeOut4 = true;
            }
            else if (tab == 5)
            {
                openChildForm5(new frmCloseOut());
                pnlChildForm5.BringToFront();
                pnlChildForm5.Visible = true;

                //initiation5 = false;
                //planning5 = false;
                //execution5 = false;
                closeOut5 = true;
            }
        }

        private void btnInitiation_Click(object sender, EventArgs e)
        {
            initiation1 = true;
        }

        private void btnPlanning_Click(object sender, EventArgs e)
        {
            planning1 = true;
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
            execution1 = true;
        }

        private void btnCloseOut_Click(object sender, EventArgs e)
        {
            closeOut1 = true;
        }
        
        private void pnlChildForm_Paint(object sender, PaintEventArgs e)
        {
            ControlExtension.Draggable(btnTask1, true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        //set child form to panel
        public void tabControl()
        {
            if(initiation1 == true)
            {
                openChildForm(new frmInitiation());
                pnlChildForm.BringToFront();
                pnlChildForm.Visible = true;
            }
            else if(initiation2 == true)
            {
                openChildForm2(new frmInitiation());
                pnlChildForm2.BringToFront();
                pnlChildForm2.Visible = true;
            }
            else if (initiation3 == true)
            {
                openChildForm3(new frmInitiation());
                pnlChildForm3.BringToFront();
                pnlChildForm3.Visible = true;
            }
            else if (initiation4 == true)
            {
                openChildForm4(new frmInitiation());
                pnlChildForm4.BringToFront();
                pnlChildForm4.Visible = true;
            }
            else if (initiation5 == true)
            {
                openChildForm5(new frmInitiation());
                pnlChildForm5.BringToFront();
                pnlChildForm5.Visible = true;
            }

            if (planning1 == true)
            {
                openChildForm(new frmPlanning());
                pnlChildForm.BringToFront();
                pnlChildForm.Visible = true;
            }
            else if (planning2 == true)
            {
                openChildForm2(new frmPlanning());
                pnlChildForm2.BringToFront();
                pnlChildForm2.Visible = true;
            }
            else if (planning3 == true)
            {
                openChildForm3(new frmPlanning());
                pnlChildForm3.BringToFront();
                pnlChildForm3.Visible = true;
            }
            else if (planning4 == true)
            {
                openChildForm4(new frmPlanning());
                pnlChildForm4.BringToFront();
                pnlChildForm4.Visible = true;
            }
            else if (planning5 == true)
            {
                openChildForm5(new frmPlanning());
                pnlChildForm5.BringToFront();
                pnlChildForm5.Visible = true;
            }

            if (execution1 == true)
            {
                openChildForm(new frmExecution());
                pnlChildForm.BringToFront();
                pnlChildForm.Visible = true;
            }
            else if (execution2 == true)
            {
                openChildForm2(new frmExecution());
                pnlChildForm2.BringToFront();
                pnlChildForm2.Visible = true;
            }
            else if (execution3 == true)
            {
                openChildForm3(new frmExecution());
                pnlChildForm3.BringToFront();
                pnlChildForm3.Visible = true;
            }
            else if (execution4 == true)
            {
                openChildForm4(new frmExecution());
                pnlChildForm4.BringToFront();
                pnlChildForm4.Visible = true;
            }
            else if (execution5 == true)
            {
                openChildForm(new frmExecution());
                pnlChildForm5.BringToFront();
                pnlChildForm5.Visible = true;
            }

            if (closeOut1 == true)
            {
                openChildForm(new frmCloseOut());
                pnlChildForm.BringToFront();
                pnlChildForm.Visible = true;
            }
            else if (closeOut2 == true)
            {
                openChildForm2(new frmCloseOut());
                pnlChildForm2.BringToFront();
                pnlChildForm2.Visible = true;
            }
            else if (closeOut3 == true)
            {
                openChildForm3(new frmCloseOut());
                pnlChildForm3.BringToFront();
                pnlChildForm3.Visible = true;
            }
            else if (closeOut4 == true)
            {
                openChildForm4(new frmCloseOut());
                pnlChildForm4.BringToFront();
                pnlChildForm4.Visible = true;
            }
            else if (closeOut5 == true)
            {
                openChildForm5(new frmCloseOut());
                pnlChildForm5.BringToFront();
                pnlChildForm5.Visible = true;
            }
        }
    }
}
