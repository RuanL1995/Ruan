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
    public partial class frmExecution : Form
    {
        public frmExecution()
        {
            InitializeComponent();
        }

        public void showInstructions()
        {
            pnlExecution.Visible = false;
            pnlInfo.Visible = true;
            pnlInfo.BringToFront();
        }

        /// <summary>
        /// Variables for switch
        /// </summary>
        #region Variables
        int first = 0;      //btnFirst
        int second = 0;     //btnSec
        int third = 0;      //btnThird
        #endregion
        private void btnTMan_MouseHover(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
            lstInfo.Items.Add("Time Management is the process within which time spent by staff undertaking project tasks is recorded");
            lstInfo.Items.Add("against the project. As time is a scarce resource on projects, it is important to record the time spent by");
            lstInfo.Items.Add("each member of the team on a Timesheet to enable the Project Manager to control the level of resource");
            lstInfo.Items.Add("allocated to a particular activity. A Timesheet Register provides a summary of the time currently spent on");
            lstInfo.Items.Add("the project and enables the Project Plan to be kept fully up to date");
            lstInfo.Items.Add("Templates: Time Management Process, Timesheet Form, Timesheet Register");
        }

        private void btnTMan_MouseLeave(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
        }

        private void btnCostMan_MouseHover(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
            lstInfo.Items.Add("Cost Management is the process by which costs (or expenses) incurred on the project are formally");
            lstInfo.Items.Add("identified, approved and paid. Expense Forms are completed for each set of related project expenses");
            lstInfo.Items.Add("such as labour, equipment and materials costs. Expense Forms are approved by the Project Manager and");
            lstInfo.Items.Add("recorded within an Expense Register for audit purposes.");
            lstInfo.Items.Add("Templates: Cost Management Process, Expense Form, Expense Register");
        }

        private void btnCostMan_MouseLeave(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
        }

        private void btnQualMan_MouseHover(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
            lstInfo.Items.Add("Quality is defined as “the level of conformance of the final deliverable to the customer’s requirements”.");
            lstInfo.Items.Add("Quality Management is the process by which the quality of the deliverables is assured and controlled for");
            lstInfo.Items.Add("the project, using Quality Assurance and Quality Control techniques. Quality reviews are frequently");
            lstInfo.Items.Add("undertaken and the results recorded within a Quality Register.");
            lstInfo.Items.Add("Templates: Quality Management Process, Quality Review Form, Deliverables Register");
        }

        private void btnQualMan_MouseLeave(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
        }

        private void btnCMan_MouseHover(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
            lstInfo.Items.Add("Change Management is the process by which changes to the project’s scope, deliverables, timescales or");
            lstInfo.Items.Add("resources are formally defined, evaluated and approved prior to implementation. A core aspect of the");
            lstInfo.Items.Add("Project Manager’s role is to manage change within the project successfully. This is achieved by");
            lstInfo.Items.Add("understanding the business and system drivers requiring the change, documenting the benefits and");
            lstInfo.Items.Add("costs of adopting the change and formulating a structured plan for implementing the change. To formally");
            lstInfo.Items.Add("request a change it is often necessary to complete a Change Form. The change request details may then");
            lstInfo.Items.Add("be recorded within a Change Register.");
            lstInfo.Items.Add("Templates: Change Management Process, Change Form, Change Register");
            
        }

        private void btnCMan_MouseLeave(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
        }

        private void btnRiskMan_MouseHover(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
            lstInfo.Items.Add("Risk Management is the process by which risks to the project (e.g. to the scope, deliverables, timescales");
            lstInfo.Items.Add("or resources) are formally identified, quantified and managed during the project. A project risk may be");
            lstInfo.Items.Add("identified at any stage of the project by completing a Risk Form and recording the relevant risk details");
            lstInfo.Items.Add("within the Risk Register");
            lstInfo.Items.Add("Templates: Risk Management Process, Risk Form, Risk Register");
        }

        private void btnRiskMan_MouseLeave(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
        }

        private void btnIssMan_MouseHover(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
            lstInfo.Items.Add("Issue Management is the method by which issues currently affecting the ability of the project to produce");
            lstInfo.Items.Add("the required deliverable are formally managed. After completion of an Issue Form (and logging the details");
            lstInfo.Items.Add("within the Issue Register), each issue is evaluated by the Project Manager and a set of actions undertaken");
            lstInfo.Items.Add("to resolve the issue at hand.");
            lstInfo.Items.Add("Templates: Issue Management Process, Issue Form, Issue Register");
        }

        private void btnIssMan_MouseLeave(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
        }

        private void btnProcMan_MouseHover(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
            lstInfo.Items.Add("Procurement Management is the process by which product is sourced from an external supplier. To");
            lstInfo.Items.Add("request the delivery of product from a supplier, a Purchase Order must be approved by the Project");
            lstInfo.Items.Add("Manager and sent to the supplier for confirmation. The status of the purchase is then tracked using a");
            lstInfo.Items.Add("Procurement Register until the product has been delivered and accepted by the project team.");
            lstInfo.Items.Add("Templates: Procurement Management Process, Purchase Order Form, Procurement Register");
        }

        private void btnProcMan_MouseLeave(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
        }

        private void btnAccMan_MouseHover(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
            lstInfo.Items.Add("Acceptance Management is the process by which deliverables produced by the project are reviewed and");
            lstInfo.Items.Add("accepted by the customer as meeting his/her specific requirements. To request the acceptance of a");
            lstInfo.Items.Add("deliverable by the customer, an Acceptance Form is completed. The Acceptance Form describes the");
            lstInfo.Items.Add("criteria from which the deliverable has been produced and the level of satisfaction of each criterion listed.");
            lstInfo.Items.Add("Templates: Acceptance Management Process, Acceptance Form, Acceptance Register");
        }

        private void btnAccMan_MouseLeave(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
        }

        private void btnComMan_MouseHover(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
            lstInfo.Items.Add("Communications Management is the process by which formal communications messages are identified,");
            lstInfo.Items.Add("created, reviewed and communicated within a project. The most common method of communicating the");
            lstInfo.Items.Add("status of the project is via a Project Status Report. Each communication item released to the project");
            lstInfo.Items.Add("stakeholders is captured within a Communications Register.");
            lstInfo.Items.Add("Templates: Communications Management Process, Project Status Report, Communications Register");
        }

        private void btnComMan_MouseLeave(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
        }

        private void btnCPhaseRev_MouseHover(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
            lstInfo.Items.Add("At the end of the Execution Phase, a Phase review is performed. This is basically a checkpoint to ensure");
            lstInfo.Items.Add("that the project has achieved its stated objectives as planned.");
            lstInfo.Items.Add("Template: Phase Review Form");
        }

        private void btnCPhaseRev_MouseLeave(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
        }

        public void communicationsManagement()
        {
            pnlExecution.Visible = false;
            pnlInfo.Visible = true;
            pnlInfo.BringToFront();

            lstInstr.Items.Clear();

            //button visibility
            btnFirst.Visible = true;
            btnSec.Visible = true;
            btnThird.Visible = true;
           

            //button text
            btnFirst.Text = "Perform Communications Management";
            btnSec.Text = "Communications Management Activities";
            btnThird.Text = "Communications Management Roles";

            first = 1;
            second = 1;
            third = 1;

           
        }

        public void issueManagement()
        {
            pnlExecution.Visible = false;
            pnlInfo.Visible = true;
            pnlInfo.BringToFront();

            lstInstr.Items.Clear();

            //button visibility
            btnFirst.Visible = true;
            btnSec.Visible = true;
            btnThird.Visible = true;


            //button text
            btnFirst.Text = "Perform Issue Management";
            btnSec.Text = "Issue Management Activities";
            btnThird.Text = "Issue Management Roles";

            first = 2;
            second = 2;
            third = 2;


        }

        public void riskManagement()
        {
            pnlExecution.Visible = false;
            pnlInfo.Visible = true;
            pnlInfo.BringToFront();

            lstInstr.Items.Clear();

            //button visibility
            btnFirst.Visible = true;
            btnSec.Visible = true;
            btnThird.Visible = true;


            //button text
            btnFirst.Text = "Perform Risk Management";
            btnSec.Text = "Risk Management Activities";
            btnThird.Text = "Risk Management Roles";

            first = 3;
            second = 3;
            third = 3;


        }

        public void qualityManagement()
        {
            pnlExecution.Visible = false;
            pnlInfo.Visible = true;
            pnlInfo.BringToFront();

            lstInstr.Items.Clear();

            //button visibility
            btnFirst.Visible = true;
            btnSec.Visible = true;
            btnThird.Visible = true;


            //button text
            btnFirst.Text = "Perform Quality Management";
            btnSec.Text = "Quality Management Activities";
            btnThird.Text = "Quality Management Roles";

            first = 4;
            second = 4;
            third = 4;


        }

        public void acceptanceManagement()
        {
            pnlExecution.Visible = false;
            pnlInfo.Visible = true;
            pnlInfo.BringToFront();

            lstInstr.Items.Clear();

            //button visibility
            btnFirst.Visible = true;
            btnSec.Visible = true;
            btnThird.Visible = true;


            //button text
            btnFirst.Text = "Perform Acceptance Management";
            btnSec.Text = "Quality Acceptance Activities";
            btnThird.Text = "Quality Acceptance Roles";

            first = 5;
            second = 5;
            third = 5;


        }

        public void procurementManagement()
        {
            pnlExecution.Visible = false;
            pnlInfo.Visible = true;
            pnlInfo.BringToFront();

            lstInstr.Items.Clear();

            //button visibility
            btnFirst.Visible = true;
            btnSec.Visible = true;
            btnThird.Visible = true;


            //button text
            btnFirst.Text = "Perform Procurement Management";
            btnSec.Text = "Quality Procurement Activities";
            btnThird.Text = "Quality Procurement Roles";

            first = 6;
            second = 6;
            third = 6;


        }

        public void changeManagement()
        {
            pnlExecution.Visible = false;
            pnlInfo.Visible = true;
            pnlInfo.BringToFront();

            lstInstr.Items.Clear();

            //button visibility
            btnFirst.Visible = true;
            btnSec.Visible = true;
            btnThird.Visible = true;


            //button text
            btnFirst.Text = "Perform Change Management";
            btnSec.Text = "Quality Change Activities";
            btnThird.Text = "Quality Change Roles";

            first = 7;
            second = 7;
            third = 7;

        }

        public void timeManagement()
        {
            pnlExecution.Visible = false;
            pnlInfo.Visible = true;
            pnlInfo.BringToFront();

            lstInstr.Items.Clear();

            //button visibility
            btnFirst.Visible = true;
            btnSec.Visible = true;
            btnThird.Visible = true;


            //button text
            btnFirst.Text = "Perform Time Management";
            btnSec.Text = "Time Change Activities";
            btnThird.Text = "Time Change Roles";

            first = 8;
            second = 8;
            third = 8;

        }

        public void costManagement()
        {
            pnlExecution.Visible = false;
            pnlInfo.Visible = true;
            pnlInfo.BringToFront();

            lstInstr.Items.Clear();

            //button visibility
            btnFirst.Visible = true;
            btnSec.Visible = true;
            btnThird.Visible = true;


            //button text
            btnFirst.Text = "Perform Cost Management";
            btnSec.Text = "Cost Change Activities";
            btnThird.Text = "Cost Change Roles";

            first = 9;
            second = 9;
            third = 9;

        }

        public void phaseReview()
        {
            pnlExecution.Visible = false;
            pnlInfo.Visible = true;
            pnlInfo.BringToFront();

            lstInstr.Items.Clear();

            //button visibility
            btnFirst.Visible = true;
            btnSec.Visible = true;
            btnThird.Visible = true;


            //button text
            btnFirst.Text = "Identify Phase Review Criteria";
            btnSec.Text = "Undertake Phase Review";
            btnThird.Text = "Seek Approval to Proceed";

            first = 10;
            second = 10;
            third = 10;
           

        }

        private void btnCommunications_Click(object sender, EventArgs e)
        {
            communicationsManagement();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            issueManagement();
        }

        private void btnRisk_Click(object sender, EventArgs e)
        {
            riskManagement();
        }

        private void btnQuality_Click(object sender, EventArgs e)
        {
            qualityManagement();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            acceptanceManagement();
        }

        private void btnProcurement_Click(object sender, EventArgs e)
        {
            procurementManagement();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            changeManagement();
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            timeManagement();
        }

        private void btnCost_Click(object sender, EventArgs e)
        {
            costManagement();
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            phaseReview();
        }

        public void firstButton(int button)
        {
            //switch for first button

            switch (button)
            {
                //Perform communications management
                case 1:
                    lstInstr.Items.Clear();
                    
                    break;
                //Perform issue management
                case 2:
                    lstInstr.Items.Clear();
                   
                    break;
                //...
                case 3:
                    lstInstr.Items.Clear();
                    
                    break;               
                default:
                    lstInstr.Items.Clear();
                    break;
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            firstButton(first);
        }

        private void frmExecution_Load(object sender, EventArgs e)
        {
            pnlExecution.Visible = true;
            pnlExecution.BringToFront();

            pnlInfo.Visible = false;
            pnlInfo.SendToBack();
        }

        private void btnIssMan_Click(object sender, EventArgs e)
        {
            showInstructions();
            issueManagement();
        }

        private void btnComMan_Click(object sender, EventArgs e)
        {
            showInstructions();
            communicationsManagement();
        }

        private void btnRiskMan_Click(object sender, EventArgs e)
        {
            showInstructions();
        }

        private void btnQualMan_Click(object sender, EventArgs e)
        {
            showInstructions();
        }

        private void btnAccMan_Click(object sender, EventArgs e)
        {
            showInstructions();
        }

        private void btnProcMan_Click(object sender, EventArgs e)
        {
            showInstructions();
        }

        private void btnCMan_Click(object sender, EventArgs e)
        {
            showInstructions();
        }

        private void btnTMan_Click(object sender, EventArgs e)
        {
            showInstructions();
        }

        private void btnCostMan_Click(object sender, EventArgs e)
        {
            showInstructions();
        }

        private void btnOperate_Click(object sender, EventArgs e)
        {
            showInstructions();
        }

        private void btnCPhaseRev_Click(object sender, EventArgs e)
        {
            showInstructions();
            phaseReview();
        }
    }
}
