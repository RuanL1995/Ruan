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
        public frmMainAdmin()
        {
            InitializeComponent();
            customDesign();
        }

        //set SubMenus to invisible
        private void customDesign()
        {
            pnlPhasesSub.Visible = false;
            //pnlDiagramsSub.Visible = false;
        }

        //hide SubMenus
        private void hideSubs()
        {
            if(pnlPhasesSub.Visible == true)
            {
                pnlPhasesSub.Visible = false;
            }

            /*if (pnlDiagramsSub.Visible == true)
            {
                pnlDiagramsSub.Visible = false;
            }*/

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

        private void btnPhases_Click(object sender, EventArgs e)
        {
            showSubs(pnlPhasesSub);
        }

        private void btnInitiation_Click(object sender, EventArgs e)
        {
            //openChildForm(new formName());

            hideSubs();
        }


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

        private void btnPlanning_Click(object sender, EventArgs e)
        {
            hideSubs();
        }

        private void btnExecution_Click(object sender, EventArgs e)
        {
            hideSubs();
        }

        private void btnCloseOut_Click(object sender, EventArgs e)
        {
            hideSubs();
        }

        private void btnDiagrams_Click(object sender, EventArgs e)
        {
            //showSubs(pnlDiagramsSub);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
