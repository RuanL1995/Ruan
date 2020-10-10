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
    public partial class frmInitiation : Form
    {
        public frmInitiation()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Hover functionality
        /// </summary>
        #region Mouse hover

        private void btnPhaseReview_MouseHover(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
            lstInfo.Items.Add("hi there");
            lstInfo.Items.Add("Howzit");
            lstInfo.Visible = true;
        }

        private void btnSetupPOfiice_MouseHover(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
            lstInfo.Items.Add("4545");
            lstInfo.Visible = true;
        }

        private void btnEstPCharter_MouseHover(object sender, EventArgs e)
        {

            lstInfo.Visible = true;
        }

        private void btnUndertakeFStudy_MouseHover(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
            lstInfo.Items.Add("At any stage during (or after) the development of a Business Case, a formal Feasibility");
            lstInfo.Items.Add("Study may be commissioned. The purpose is to assess the likelihood of a particular");
            lstInfo.Items.Add("solution option’s achieving the benefits outlined in the Business Case.");
            lstInfo.Items.Add("The Feasibility Study will also investigate whether the forecast costs");
            lstInfo.Items.Add("are reasonable, the solution is achievable, the risks are acceptable");
            lstInfo.Items.Add("and/or any likely issues are avoidable.");
            lstInfo.Visible = true;
        }

        private void btnDevBCase_MouseHover(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
            lstInfo.Items.Add("Once a business problem or opportunity has been identified, a Business Case is prepared.");
            lstInfo.Items.Add("This includes: A detailed definition of the problem or opportunity");
            lstInfo.Items.Add("An analysis of the potential solution options available.");
            lstInfo.Items.Add("For each option, the potential benefits, costs, risks & issues");
            lstInfo.Items.Add("are documented.");
            lstInfo.Items.Add("A formal feasibility study may be commissioned if the feasibility of any particular solution option is not clear");
            lstInfo.Items.Add("The Business Case is approved by the Project Sponsor & the required funding is allocated to proceed with the project.");
            lstInfo.Visible = true;
        }

        #endregion

        /// <summary>
        /// Functionality when mouse no longer hovering
        /// </summary>
        #region Mouse leave

        private void btnPhaseReview_MouseLeave(object sender, EventArgs e)
        {
            lstInfo.Visible = false;
            lstInfo.Items.Clear();
        }

       

        private void btnSetupPOfiice_MouseLeave(object sender, EventArgs e)
        {
            lstInfo.Visible = false;
            lstInfo.Items.Clear();
        }

        

        private void btnDevBCase_MouseLeave(object sender, EventArgs e)
        {
            lstInfo.Visible = false;
            lstInfo.Items.Clear();
        }

        

        private void btnUndertakeFStudy_MouseLeave(object sender, EventArgs e)
        {
            lstInfo.Visible = false;
            lstInfo.Items.Clear();
        }

        #endregion

        /// <summary>
        /// Mehtods used for general purpose
        /// </summary>
        #region Dual view

        #endregion
    }
}
