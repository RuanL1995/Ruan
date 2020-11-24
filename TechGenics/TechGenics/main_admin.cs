﻿using System;
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

        int tab = 1;

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
        private void btnLogout_Click(object sender, EventArgs e)
        {
            //go to login 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

            if (tab == 6)
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
            pnlChildForm2.SendToBack();
            pnlChildForm3.Visible = false;
            pnlChildForm3.SendToBack();
            pnlChildForm4.Visible = false;
            pnlChildForm4.SendToBack();
            pnlChildForm5.Visible = false;
            pnlChildForm5.SendToBack();
            //pnlTasks.Visible = false;
            //pnlTasks.SendToBack();
        }

        private void btnTab2_Click(object sender, EventArgs e)
        {
            pnlChildForm2.Visible = true;
            pnlChildForm2.BringToFront();

            pnlChildForm.Visible = false;
            pnlChildForm2.SendToBack();
            pnlChildForm3.Visible = false;
            pnlChildForm3.SendToBack();
            pnlChildForm4.Visible = false;
            pnlChildForm4.SendToBack();
            pnlChildForm5.Visible = false;
            pnlChildForm5.SendToBack();

        }

        private void btnTab3_Click(object sender, EventArgs e)
        {
            pnlChildForm3.Visible = true;
            pnlChildForm3.BringToFront();

            pnlChildForm2.Visible = false;
            pnlChildForm2.SendToBack();
            pnlChildForm.Visible = false;
            pnlChildForm.SendToBack();
            pnlChildForm4.Visible = false;
            pnlChildForm4.SendToBack();
            pnlChildForm5.Visible = false;
            pnlChildForm5.SendToBack();
        }

        private void btnTab4_Click(object sender, EventArgs e)
        {
            pnlChildForm4.Visible = true;
            pnlChildForm4.BringToFront();

            pnlChildForm2.Visible = false;
            pnlChildForm2.SendToBack();
            pnlChildForm3.Visible = false;
            pnlChildForm3.SendToBack();
            pnlChildForm.Visible = false;
            pnlChildForm.SendToBack();
            pnlChildForm5.Visible = false;
            pnlChildForm5.SendToBack();
        }

        private void btnTab5_Click(object sender, EventArgs e)
        {
            pnlChildForm5.Visible = true;
            pnlChildForm5.BringToFront();

            pnlChildForm2.Visible = false;
            pnlChildForm2.SendToBack();
            pnlChildForm3.Visible = false;
            pnlChildForm3.SendToBack();
            pnlChildForm4.Visible = false;
            pnlChildForm4.SendToBack();
            pnlChildForm.Visible = false;
            pnlChildForm.SendToBack();
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
                   
                }
                else if (tab == 3)
                {
                    openChildForm3(new frmInitiation());
                    pnlChildForm3.BringToFront();
                    pnlChildForm3.Visible = true;
                    
                }
                else if (tab == 4)
                {
                    openChildForm4(new frmInitiation());
                    pnlChildForm4.BringToFront();
                    pnlChildForm4.Visible = true;
                    
                }
                else if (tab == 5)
                {
                    openChildForm5(new frmInitiation());
                    pnlChildForm5.BringToFront();
                    pnlChildForm5.Visible = true;
                    
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
                
            }
            else if (tab == 3)
            {
                openChildForm3(new frmPlanning());
                pnlChildForm3.BringToFront();
                pnlChildForm3.Visible = true;
                
            }
            else if (tab == 4)
            {
                openChildForm4(new frmPlanning());
                pnlChildForm4.BringToFront();
                pnlChildForm4.Visible = true;
                
            }
            else if (tab == 5)
            {
                openChildForm5(new frmPlanning());
                pnlChildForm5.BringToFront();
                pnlChildForm5.Visible = true;
                
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
                
            }
            else if (tab == 3)
            {
                openChildForm3(new frmExecution());
                pnlChildForm3.BringToFront();
                pnlChildForm3.Visible = true;
                
            }
            else if (tab == 4)
            {
                openChildForm4(new frmExecution());
                pnlChildForm4.BringToFront();
                pnlChildForm4.Visible = true;
                
            }
            else if (tab == 5)
            {
                openChildForm5(new frmExecution());
                pnlChildForm5.BringToFront();
                pnlChildForm5.Visible = true;
                
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
                
            }
            else if (tab == 3)
            {
                openChildForm3(new frmCloseOut());
                pnlChildForm3.BringToFront();
                pnlChildForm3.Visible = true;
                
            }
            else if (tab == 4)
            {
                openChildForm4(new frmCloseOut());
                pnlChildForm4.BringToFront();
                pnlChildForm4.Visible = true;
               
            }
            else if (tab == 5)
            {
                openChildForm5(new frmCloseOut());
                pnlChildForm5.BringToFront();
                pnlChildForm5.Visible = true;
                
            }
        }

        private void btnInitiation_Click(object sender, EventArgs e)
        {

        }

        private void btnPlanning_Click(object sender, EventArgs e)
        {

        }

        private void pnlTasks_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
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

        private void btnManualA_Click(object sender, EventArgs e)
        {

        }

        private void btnForward_Click(object sender, EventArgs e)
        {

        }

        private void pnlChildForm_Paint(object sender, PaintEventArgs e)
        {
            ControlExtension.Draggable(btnTask1, true);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings frmSettings = new frmSettings();
            frmSettings.ShowDialog();
        }
    }
}
