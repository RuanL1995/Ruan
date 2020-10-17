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
    public partial class frmMainAdmin : Form
    {
        int slider;
        bool hide;

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
               //MessageBox.Show("Right");

            }
            else//left or middle click
            {
                hideSubs();
                openChildForm(new frmInitiation());
            }
        }

        private void btnPlanning_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //MessageBox.Show("Right");

            }
            else//left or middle click
            {
                hideSubs();
                openChildForm(new frmPlanning());
            }
        }

        private void btnExecution_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Right");

            }
            else//left or middle click
            {
                hideSubs();
                openChildForm(new frmExecution());
            }
        }

        private void btnCloseOut_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Right");

            }
            else//left or middle click
            {
                hideSubs();
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

        /// <summary>
        /// New tab and dual view
        /// </summary>
        #region Right click
        private void openInNewTabToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openInDualViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmInitiation());
            //dock = true;
        }

        #endregion

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
    }
}
