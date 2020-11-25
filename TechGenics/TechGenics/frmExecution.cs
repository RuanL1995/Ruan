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


        /// <summary>
        /// Variables for switch
        /// </summary>
        #region Variables
        int first = 0;      //btnFirst
        int second = 0;     //btnSec
        int third = 0;      //btnThird
        #endregion

        /// <summary>
        /// Hover effects
        /// </summary>
        #region Hover
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

        #endregion

        /// <summary>
        /// Buttons for instruction panel
        /// </summary>
        #region Instructions
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

        #endregion

        public void showInstructions()
        {
            pnlExecution.Visible = false;
            pnlInfo.Visible = true;
            pnlInfo.BringToFront();
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

            btnViewIssueMan.Visible = false;
            btnViewRiskMan.Visible = false;
            btnViewQualityMan.Visible = false;
            btnViewChangeMan.Visible = false;
            btnViewComMan.Visible = true;
            btnViewTimeMan1.Visible = false;
            btnViewCostMan.Visible = false;
            btnViewProcMan.Visible = false;
            btnViewAccMan.Visible = false;
            btnViewPRev.Visible = false;
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

            btnViewIssueMan.Visible = true;
            btnViewRiskMan.Visible = false;
            btnViewQualityMan.Visible = false;
            btnViewChangeMan.Visible = false;
            btnViewComMan.Visible = false;
            btnViewTimeMan1.Visible = false;
            btnViewCostMan.Visible = false;
            btnViewProcMan.Visible = false;
            btnViewAccMan.Visible = false;
            btnViewPRev.Visible = false;

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

            btnViewIssueMan.Visible = false;
            btnViewRiskMan.Visible = true;
            btnViewQualityMan.Visible = false;
            btnViewChangeMan.Visible = false;
            btnViewComMan.Visible = false;
            btnViewTimeMan1.Visible = false;
            btnViewCostMan.Visible = false;
            btnViewProcMan.Visible = false;
            btnViewAccMan.Visible = false;
            btnViewPRev.Visible = false;

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

            btnViewIssueMan.Visible = false;
            btnViewRiskMan.Visible = false;
            btnViewQualityMan.Visible = true;
            btnViewChangeMan.Visible = false;
            btnViewComMan.Visible = false;
            btnViewTimeMan1.Visible = false;
            btnViewCostMan.Visible = false;
            btnViewProcMan.Visible = false;
            btnViewAccMan.Visible = false;
            btnViewPRev.Visible = false;


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

            btnViewIssueMan.Visible = false;
            btnViewRiskMan.Visible = false;
            btnViewQualityMan.Visible = false;
            btnViewChangeMan.Visible = false;
            btnViewComMan.Visible = false;
            btnViewTimeMan1.Visible = false;
            btnViewCostMan.Visible = false;
            btnViewProcMan.Visible = false;
            btnViewAccMan.Visible = true;
            btnViewPRev.Visible = false;
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

            btnViewIssueMan.Visible = false;
            btnViewRiskMan.Visible = false;
            btnViewQualityMan.Visible = false;
            btnViewChangeMan.Visible = false;
            btnViewComMan.Visible = false;
            btnViewTimeMan1.Visible = false;
            btnViewCostMan.Visible = false;
            btnViewProcMan.Visible = true;
            btnViewAccMan.Visible = false;
            btnViewPRev.Visible = false;

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

            btnViewIssueMan.Visible = false;
            btnViewRiskMan.Visible = false;
            btnViewQualityMan.Visible = false;
            btnViewChangeMan.Visible = true;
            btnViewComMan.Visible = false;
            btnViewTimeMan1.Visible = false;
            btnViewCostMan.Visible = false;
            btnViewProcMan.Visible = false;
            btnViewAccMan.Visible = false;
            btnViewPRev.Visible = false;
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

            btnViewIssueMan.Visible = false;
            btnViewRiskMan.Visible = false;
            btnViewQualityMan.Visible = false;
            btnViewChangeMan.Visible = false;
            btnViewComMan.Visible = false;
            btnViewTimeMan1.Visible = true;
            btnViewCostMan.Visible = false;
            btnViewProcMan.Visible = false;
            btnViewAccMan.Visible = false;
            btnViewPRev.Visible = false;


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

            btnViewIssueMan.Visible = false;
            btnViewRiskMan.Visible = false;
            btnViewQualityMan.Visible = false;
            btnViewChangeMan.Visible = false;
            btnViewComMan.Visible = false;
            btnViewTimeMan1.Visible = false;
            btnViewCostMan.Visible = true;
            btnViewProcMan.Visible = false;
            btnViewAccMan.Visible = false;
            btnViewPRev.Visible = false;

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

            btnViewIssueMan.Visible = false;
            btnViewRiskMan.Visible = false;
            btnViewQualityMan.Visible = false;
            btnViewChangeMan.Visible = false;
            btnViewComMan.Visible = false;
            btnViewTimeMan1.Visible = false;
            btnViewCostMan.Visible = false;
            btnViewProcMan.Visible = false;
            btnViewAccMan.Visible = false;
            btnViewPRev.Visible = true;
        }

        public void operateProject()
        {
            pnlExecution.Visible = false;
            pnlInfo.Visible = true;
            pnlInfo.BringToFront();

            lstInstr.Items.Clear();
            lstInstr.Items.Add("Databases:");
            lstInstr.Items.Add(" *Change register");
            lstInstr.Items.Add(" *Risk register");
            lstInstr.Items.Add(" *Issue register");
            lstInstr.Items.Add(" *Expense register");
            lstInstr.Items.Add(" *Procurement register");
            lstInstr.Items.Add(" *Communications register");
            lstInstr.Items.Add(" *Quality register");
            lstInstr.Items.Add(" *Acceptance register");
            lstInstr.Items.Add(" *Tender register");
            lstInstr.Items.Add(" *Timesheet register");
            lstInstr.Items.Add("");
            lstInstr.Items.Add("Templates & management processes");
            lstInstr.Items.Add(" *Time management");
            lstInstr.Items.Add(" *Cost management");
            lstInstr.Items.Add(" *Quality management");
            lstInstr.Items.Add(" *Change management");
            lstInstr.Items.Add(" *Risk management");
            lstInstr.Items.Add(" *Issue management");
            lstInstr.Items.Add(" *Procurement management");
            lstInstr.Items.Add(" *Communication management");
            lstInstr.Items.Add(" *Acceptance management");
        }

        public void firstButton(int button)
        {
            //switch for first button

            switch (button)
            {
                //Perform communications management
                case 1:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Aim:");
                    lstInstr.Items.Add(" Monitoring & controlling messagesthat get sent to and from the project team");
                    lstInstr.Items.Add(" Ensure that stakeholders get informed regularly");
                    lstInstr.Items.Add(" Control the release of critical project information");
                    lstInstr.Items.Add(" Avoid communication issues and risks");
                    lstInstr.Items.Add(" Communications management ensures that a method:");
                    lstInstr.Items.Add("  *Identifies the need for formal communications form the project");
                    lstInstr.Items.Add("  *Identifies formal messages");
                    lstInstr.Items.Add("  *Creates messages");
                    lstInstr.Items.Add("  *Reviews message content");
                    lstInstr.Items.Add("  *Disseminates project information");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add(" Select communications medium:");
                    lstInstr.Items.Add("  *Press releases");
                    lstInstr.Items.Add("  *Internal newsletters");
                    lstInstr.Items.Add("  *Project status reports");
                    lstInstr.Items.Add("  *Presentation materials");
                    lstInstr.Items.Add("  *Website news releases");
                    lstInstr.Items.Add("  *Internal project memo's");
                    lstInstr.Items.Add("  *Review and obtain feedback form the communications messages sent out");
                    break;
                //Perform issue management
                case 2:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Aim:");
                    lstInstr.Items.Add(" Tracking of issues that arise as and how the project gets executed");
                    lstInstr.Items.Add(" Issues are instances of occurence that can hamper the delivery of the project's product");
                    lstInstr.Items.Add(" Manage and resolve issues according to a structured approach");
                    lstInstr.Items.Add(" Limit the effect of unforseen events on the project");
                    lstInstr.Items.Add(" Reduce time spent in administering project issues");
                    lstInstr.Items.Add(" Improve chances of project success in terms of:");
                    lstInstr.Items.Add("  *Performance       *Cost");
                    lstInstr.Items.Add("  *Time              *Scope");
                    lstInstr.Items.Add("  *Parameters");
                    break;
                //Perform risk management
                case 3:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Aim:");
                    lstInstr.Items.Add(" Risks are identified as any event likely to adversely affect the project's ability to achieve");
                    lstInstr.Items.Add("  the desired objectives it involves:");
                    lstInstr.Items.Add("  *Identifying risks");
                    lstInstr.Items.Add("  *Quantifying risks");
                    lstInstr.Items.Add("  *Qualifying risks");
                    lstInstr.Items.Add("  *Ranking risks");
                    lstInstr.Items.Add("  *Developing mitigation strategies & plans");
                    lstInstr.Items.Add("  *Monitoring evolvement of risk during project course");
                    lstInstr.Items.Add("  *Helps to:");
                    lstInstr.Items.Add("   -Improve the accuracy of budgets and estimates");
                    lstInstr.Items.Add("   -Increase confidence level for completion of project within parameters");
                    break;
                //Perform quality management 
                case 4:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Aim:");
                    lstInstr.Items.Add(" Ensure project deliverables are within the customer's specification");
                    lstInstr.Items.Add(" Employ a formal quality management process");
                    lstInstr.Items.Add(" Involves:");
                    lstInstr.Items.Add("  *Quality assurance");
                    lstInstr.Items.Add("  *Quality control");
                    lstInstr.Items.Add("  *Manage level of quality of product delivery");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add(" Identify:");
                    lstInstr.Items.Add("  *Tasks needed to complete activities/deliverables");
                    lstInstr.Items.Add("  *Effort needed to complete tasks in accordance with quality targets");
                    lstInstr.Items.Add("  *Inspire the customer confidence that objectives will be met");
                    lstInstr.Items.Add("  *Constant re-assessment of quality targets as set out in the Quality plan");
                    lstInstr.Items.Add("  *Implementation of quality control reviews to monitor and control the actual quality of the overall project");
                    lstInstr.Items.Add("  *Implementation of quality control reviews to monitor and control the actual quality of deliverables produced");
                    lstInstr.Items.Add("  *Identifying deviations from quality targets");
                    lstInstr.Items.Add("  *Developing and implementing corrective actions to implement");
                    break;
                //Perform acceptance management
                case 5:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Aim:");
                    lstInstr.Items.Add(" *Conducting acceptance reviews");
                    lstInstr.Items.Add(" *Delivery & sign off of acceptance of deliverables by the customer");
                    lstInstr.Items.Add(" *Implementing & performing acceptance testing");
                    lstInstr.Items.Add(" *Commissioning the product");
                    lstInstr.Items.Add(" *Identify customer acceptance issues early on");
                    lstInstr.Items.Add(" *Improve deliverables to meet the customers' expectations");
                    lstInstr.Items.Add(" *Maximise customers' confidence in the project deliverables");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Reviewing deliverables in terms of:");
                    lstInstr.Items.Add(" *Performance");
                    lstInstr.Items.Add(" *Cost");
                    lstInstr.Items.Add(" *Time");
                    lstInstr.Items.Add(" *Scope");
                    lstInstr.Items.Add(" *Parameters");
                    lstInstr.Items.Add(" *Customers can be involved in the acceptance process");
                    lstInstr.Items.Add(" *Customers might dictate acceptance testing & methods");
                    break;
                //Perform procurement management
                case 6:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Aim:");
                    lstInstr.Items.Add(" *Acquisition of goods and services from external suppliers");
                    lstInstr.Items.Add(" *Management of a suppliers' scope of work within a project it involves:");
                    lstInstr.Items.Add("  -Identifying procurement items");
                    lstInstr.Items.Add("  -Ensuring procurement items are delivered in accordance with the contract");
                    lstInstr.Items.Add("  -Identifying & resolving supplier issues");
                    lstInstr.Items.Add("  -Maximising the supplier relationship");
                    break;
                //Perform change management
                case 7:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Aim:");
                    lstInstr.Items.Add(" *Monitoring & controlling changes within the project to:");
                    lstInstr.Items.Add("  -Reduce impact of changes on the project");
                    lstInstr.Items.Add("  -Identify new issues and risks brought about by the changes");
                    lstInstr.Items.Add("  -Ensure that chnages do not effect the project's ability to achieve its desired outcomes");
                    lstInstr.Items.Add("  -Control the costs of changes within the project");
                    lstInstr.Items.Add("  -Ensure project deliverables are wihtin customer's specifications");
                    break;
                //Perform time management
                case 8:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Aim:");
                    lstInstr.Items.Add(" *The process of monitoring and controlling time spent by staff on the project");
                    lstInstr.Items.Add(" *Timesheets are used to track and record time spent");
                    lstInstr.Items.Add(" *Timesheets are used to track conformance of level of effort tothe schedule");
                    lstInstr.Items.Add(" *Calculate planned vs actual time spent and variances if they occur");
                    lstInstr.Items.Add(" *Calculate the total time spent undertaking tasks");
                    lstInstr.Items.Add(" *Identify total staff costs in undertaking tasks");
                    lstInstr.Items.Add(" *Control the level of resources allocated to a task");
                    lstInstr.Items.Add(" *Monitor the percentage completed on time driven tasks");
                    lstInstr.Items.Add(" *Identify required effort and time to complete a task");
                    break;
                //Perform cost management
                case 9:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Aim:");
                    lstInstr.Items.Add(" *Ensure expenses are incurred as and how planned");
                    lstInstr.Items.Add(" *Ensure expenses are wihtin budget");
                    lstInstr.Items.Add(" *Record consumption rate of project budget");
                    lstInstr.Items.Add(" *Calculate the total cost of undertaking each project task");
                    lstInstr.Items.Add(" *Determine the total costs of staff allocated to the project");
                    lstInstr.Items.Add(" *Monitor total expenditure as opposed to projected expenditure");
                    lstInstr.Items.Add(" *Identify current and potential cost overruns");
                    lstInstr.Items.Add(" *Monitor the consumption rate of the project budget");
                    lstInstr.Items.Add(" *Monitor cash flow");
                    break;
                //Identify phase review criteria
                case 10:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Activities:");
                    lstInstr.Items.Add(" *Was the formal Time management process executed?");
                    lstInstr.Items.Add(" *Was a formal Cost management process executed?");
                    lstInstr.Items.Add(" *Was a formal Quality management rocess executed");
                    lstInstr.Items.Add(" *Was the formal Change management process executed?");
                    lstInstr.Items.Add(" *Was a formal Risk management process executed?");
                    lstInstr.Items.Add(" *Was a formal Issue management rocess executed");
                    lstInstr.Items.Add(" *Was the formal Procurement management process executed?");
                    lstInstr.Items.Add(" *Was a formal Acceptance management process executed?");
                    lstInstr.Items.Add(" *Was a formal Communications management rocess executed");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Deliverables:");
                    lstInstr.Items.Add(" *Were all project deliverables executed within the scheduled time frame?");
                    lstInstr.Items.Add(" *Were all project deliverables produced within the approved budget?");
                    lstInstr.Items.Add(" *Did all project deliverables meet the determined quality standards");
                    lstInstr.Items.Add(" *Were all project project change requests reviewed, approved, scheduled and implemented?");
                    lstInstr.Items.Add(" *Were all project risks quantified and mitigated effectively?");
                    lstInstr.Items.Add(" *Were all project issues raised and resolved effectively?");
                    lstInstr.Items.Add(" *Were all procurement items accepted by the project?");
                    lstInstr.Items.Add(" *Were all deliverables produced by the project accepted by the client?");
                    lstInstr.Items.Add(" *Were all project stakeholders furnished with the right information at the right time?");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Summary:");
                    lstInstr.Items.Add(" *Is the project currently on schedule?");
                    lstInstr.Items.Add(" *Is the project currently within budget?");
                    lstInstr.Items.Add(" *Any critical project risks?");
                    lstInstr.Items.Add(" *Any high priority issues?");
                    lstInstr.Items.Add(" *Substantial changes?");
                    break;
                default:
                    lstInstr.Items.Clear();
                    break;
            }
        }

        public void secondButton(int button)
        {
            //switch for first button

            switch (button)
            {
                //Communciations management activities
                case 1:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Activities");
                    lstInstr.Items.Add("Draft communications plan");
                    lstInstr.Items.Add("Identify communication needs:");
                    lstInstr.Items.Add(" *Identify the need for communication within the project context");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Create the message:");
                    lstInstr.Items.Add(" *Identify message content");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Plan the types and content of messages in accordance with the overall project plan");
                    lstInstr.Items.Add("Identify what needs to be sent to whom, when and how");
                    lstInstr.Items.Add("Determine the content of the message");
                    lstInstr.Items.Add("Determine the source of the message content");
                    lstInstr.Items.Add("Identify message audience");
                    lstInstr.Items.Add("Specific needs of specific recipients needs to be planned for:");
                    lstInstr.Items.Add(" *Internal stakeholders");
                    lstInstr.Items.Add(" *External stakeholders");
                    lstInstr.Items.Add(" *Specific avenues of delivery in accordance with the audience");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Identify message timing");
                    lstInstr.Items.Add("Determine when the message needs to be disseminated");
                    lstInstr.Items.Add("Determine schedule (frequency & timing) for regular communication");
                    lstInstr.Items.Add("The PM needs to ensure that for each message type the timing and regularity is appropriate");
                    lstInstr.Items.Add("Identify message format & delivery channels");
                    lstInstr.Items.Add("Oral presentations");
                    lstInstr.Items.Add("Written documentation");
                    lstInstr.Items.Add("Memo's");
                    lstInstr.Items.Add("Emails");
                    lstInstr.Items.Add("etc.");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Create message");
                    lstInstr.Items.Add("The communications team drafts the first version of the message");
                    lstInstr.Items.Add("Submits to PM for approval");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Communicate the message");
                    lstInstr.Items.Add("PM reviews details of the message and approves for dissemination");
                    lstInstr.Items.Add("PM approves the message content or seeks approval from the project board for approval");
                    lstInstr.Items.Add("Message gets disseminated or delivered");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Update communications register");
                    lstInstr.Items.Add("Monitor feedback and effectiveness of the communication process");
                    break;
                //Issue management activities
                case 2:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Activities:");
                    lstInstr.Items.Add(" *Identify issues:");
                    lstInstr.Items.Add("  -Document possible issues");
                    lstInstr.Items.Add("  -Describe issue in detail");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Completes issue identifiation document:");
                    lstInstr.Items.Add(" *Any team member can identify a new issue");
                    lstInstr.Items.Add(" *Completes the issue identification document");
                    lstInstr.Items.Add(" *Submit it for review to the PM");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("PM to review issues");
                    lstInstr.Items.Add(" *PM reviews issue and determines:");
                    lstInstr.Items.Add("  -Impact on and considers:");
                    lstInstr.Items.Add("    >Deliverables likely to be impacted (Terms of reference)");
                    lstInstr.Items.Add("    >Quality targets likely to be impacted(Quality plan");
                    lstInstr.Items.Add("    >Schedule impacts (Overall project plan");
                    lstInstr.Items.Add("    >Resource to be adversely affected (resource plan)");
                    lstInstr.Items.Add("    >Financial impact(Financial plan)");
                    lstInstr.Items.Add("    >Escalate issues where needed to board level");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Assign issue management actions");
                    lstInstr.Items.Add(" *After issue consideration, the PM decides to:");
                    lstInstr.Items.Add("  -Ignore the issue");
                    lstInstr.Items.Add("  -Validate the issue & request further information");
                    lstInstr.Items.Add("  -Decide on suite of actions to:");
                    lstInstr.Items.Add("   >Resolve");
                    lstInstr.Items.Add("   >Lessen the impact");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Update the Project plan");
                    lstInstr.Items.Add(" *The Project plan gets updated with the issue management plan");
                    lstInstr.Items.Add(" *Implementation actions gets scheduled");
                    lstInstr.Items.Add(" *The effect of implemented actions gets reviewed");
                    lstInstr.Items.Add(" *The issues get monitored continually");
                    lstInstr.Items.Add(" *Maintains an issue register");
                    break;
                //Risk management activities
                case 3:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Activities");
                    lstInstr.Items.Add(" *Identify risks;");
                    lstInstr.Items.Add("  -Document risks");
                    lstInstr.Items.Add("  -Describe risks in detail");
                    lstInstr.Items.Add("  -Conduct risk rating");
                    lstInstr.Items.Add("  -Describe and quantify likelihood");
                    lstInstr.Items.Add("  -Describe and quantify impact rating");
                    lstInstr.Items.Add("  -Decide on preventative and contingent actions");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add(" *Formulate risk management strategy:");
                    lstInstr.Items.Add("  -Mitigation");
                    lstInstr.Items.Add("  -Acceptance");
                    lstInstr.Items.Add("  -Transference");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Complete risk identification document:");
                    lstInstr.Items.Add(" *Any team member can identify a new risk");
                    lstInstr.Items.Add(" *Completes the risk identification document");
                    lstInstr.Items.Add(" *Submit it for review to the PM");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("PM to review risks");
                    lstInstr.Items.Add(" *PM review risk and determine:");
                    lstInstr.Items.Add("  -Overall priority based on likelihood and impact, considers:");
                    lstInstr.Items.Add("   >Delieverables likely to be impacted (Terms of reference)");
                    lstInstr.Items.Add("   >Quality targets likely to be impacted (Quality plan)");
                    lstInstr.Items.Add("   >Schedule impacts (Overall project plan)");
                    lstInstr.Items.Add("   >Resource to be adversely affected (Resource plan)");
                    lstInstr.Items.Add("   >Financial impact (Financial plan)");
                    lstInstr.Items.Add("   >Escalate risks where needed to board level");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Assign risk actions");
                    lstInstr.Items.Add(" *After risk consideration, the PM decides to:");
                    lstInstr.Items.Add("  -Ignore risk");
                    lstInstr.Items.Add("  -Validate risk & request further information");
                    lstInstr.Items.Add("  -Decide on suite of actions to:");
                    lstInstr.Items.Add("   >Mitigate");
                    lstInstr.Items.Add("   >Transfer");
                    lstInstr.Items.Add("   >Avoid");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Update project plan");
                    lstInstr.Items.Add(" *The project plan gets updated with the risk plan");
                    lstInstr.Items.Add(" *Implementation actions get shceduled");
                    lstInstr.Items.Add(" *The effect of implemented actions get reviewed");
                    lstInstr.Items.Add(" *The risk gets monitored continually");
                    lstInstr.Items.Add(" *Maintains a risk register");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Complete phases review form");
                    lstInstr.Items.Add(" *Initiation");
                    lstInstr.Items.Add(" *Planning");
                    lstInstr.Items.Add(" *Execution");
                    lstInstr.Items.Add(" *Closure");
                    break;
                //Quality management activities 
                case 4:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Activities");
                    lstInstr.Items.Add(" *Measure quality achieved:");
                    lstInstr.Items.Add("  -Identify items for review");
                    lstInstr.Items.Add("  -Implement actions as designed in the quality plan");
                    lstInstr.Items.Add("  -Quality assurance reviews");
                    lstInstr.Items.Add("  -Quality control reveiws");
                    lstInstr.Items.Add("  -Analyse quality measurement results");
                    lstInstr.Items.Add("  -Design intervention actions");
                    lstInstr.Items.Add("  -Implement intervention actions");
                    lstInstr.Items.Add("  -Submit a change request where quality deviations require re-design, re-manufacture ");
                    lstInstr.Items.Add("  -etc.");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("The project administrator updates the Project plan by entering information:");
                    lstInstr.Items.Add(" *Update expense register");
                    lstInstr.Items.Add(" *Update Project plan - cost per activity");
                    lstInstr.Items.Add(" *Identifying");
                    lstInstr.Items.Add(" *Identify total cost per resource or activity");
                    lstInstr.Items.Add(" *Calculating the actual vs projected expenses");
                    lstInstr.Items.Add(" *Identify instances of over or under spending");
                    lstInstr.Items.Add(" *Conduct an EVA analysis");
                    lstInstr.Items.Add(" *Tasks that have exceeded their estimated level of budget");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Report to the project manager:");
                    lstInstr.Items.Add(" *The project manager decides on actions to follow such as:");
                    lstInstr.Items.Add("  -Changing the amount of team members assigned to the tasks");
                    lstInstr.Items.Add("  -Allocating additional funding to the task");
                    lstInstr.Items.Add("  -Changing the team member assigned to the task");
                    lstInstr.Items.Add("  -Requesting external advice and assistance");
                    break;
                //Acceptance management activities
                case 5:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Activities");
                    lstInstr.Items.Add(" *Complete deliverable:");
                    lstInstr.Items.Add("  -Identify completed deliverable");
                    lstInstr.Items.Add("  -Document that deliverable is ready for acceptance testing");
                    lstInstr.Items.Add("  -Submit to PM to schedule acceptance testing");
                    lstInstr.Items.Add("  -Maintains an acceptance register");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Perform acceptance test:");
                    lstInstr.Items.Add(" *Review delievrables to affrim that it meets set criteria");
                    lstInstr.Items.Add(" *Types of acceptance testing:");
                    lstInstr.Items.Add("  -Physical inspection");
                    lstInstr.Items.Add("  -Third party audits");
                    lstInstr.Items.Add("  -Process analysis");
                    lstInstr.Items.Add("  -Demonstrations");
                    lstInstr.Items.Add("  -Reviews against:");
                    lstInstr.Items.Add("   >Project plan & time spent");
                    lstInstr.Items.Add("   >Financial Plan & estimated costs");
                    lstInstr.Items.Add("   >Quality plan");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Accept deliverable:");
                    lstInstr.Items.Add(" *Extra work to be completed gets commissioned");
                    lstInstr.Items.Add(" *Re-testing is scheduled & completed");
                    lstInstr.Items.Add(" *When the PM is satisfied the acceptance Documentation is completed stating:");
                    lstInstr.Items.Add("  -Acceptance criteria");
                    lstInstr.Items.Add("  -Overall results of acceptance tests");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Customer conducts review of acceptance test with the following actions:");
                    lstInstr.Items.Add(" *Commission own acceptance tests");
                    lstInstr.Items.Add(" *Request further information on the acceptance tests and results");
                    lstInstr.Items.Add(" *Does not accept the deliverable and raise a formal issue with the PM");
                    lstInstr.Items.Add(" *Approve the deliverable as 100% complete and signs the acceptance form");
                    break;
                //Procurement management activities
                case 6:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Issue a purchase order:");
                    lstInstr.Items.Add(" *Identify procurement items");
                    lstInstr.Items.Add(" *Products");
                    lstInstr.Items.Add(" *Services");
                    lstInstr.Items.Add(" *Results");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Document purchase order");
                    lstInstr.Items.Add(" *Describe:");
                    lstInstr.Items.Add("  -Order item");
                    lstInstr.Items.Add("  -Delivery details");
                    lstInstr.Items.Add("  -Payment details");
                    lstInstr.Items.Add("  -Terms & conditions for supply");
                    lstInstr.Items.Add("  -Time frame of expected delivery");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Approve a purchase order:");
                    lstInstr.Items.Add(" *The PO is forwarded to the PM to be approved after considering the following:");
                    lstInstr.Items.Add("  -Are the stated procurement items listed in the Procurement plam?");
                    lstInstr.Items.Add("  -Are the procurement items stated in the Supplier Contract");
                    lstInstr.Items.Add("  -Is there sufficient time for the supplier to produce the procurement item");
                    lstInstr.Items.Add("  -Is there a contract in place with the supplier");
                    lstInstr.Items.Add("  -Is it in phase with the projected cashflow of the project");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Issue purchase order:");
                    lstInstr.Items.Add(" *The PM approves & signs purchase order");
                    lstInstr.Items.Add(" *If needed the PM requests further information");
                    lstInstr.Items.Add(" *The PO gets delivered on the supplier");
                    lstInstr.Items.Add(" *Confirm delivery timeframes");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Complete the purchase order:");
                    lstInstr.Items.Add(" *Recieve procurement items");
                    lstInstr.Items.Add(" *Items or services are accepted at contracted place of delivery");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Review procurement items");
                    lstInstr.Items.Add(" *Compare invoice with PO to determine:");
                    lstInstr.Items.Add("  -Items delivered are what was ordered");
                    lstInstr.Items.Add("  -Delivered items conformto agreed quality");
                    lstInstr.Items.Add("  -Deliveries conform to agreed schedule and time frame");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Resolve delivery issues:");
                    lstInstr.Items.Add(" *Handle discrepancies in terms of order and physical deliveries:");
                    lstInstr.Items.Add("  -Quality");
                    lstInstr.Items.Add("  -Quantity");
                    lstInstr.Items.Add("  -Timing");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Accept procurement items");
                    lstInstr.Items.Add(" *The PM issues a receipt voucher");
                    lstInstr.Items.Add(" *Compiles payment documentation");
                    lstInstr.Items.Add(" *Submit documentation for payment approval");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Request & approve payment");
                    lstInstr.Items.Add(" *Payment is made to the supplier");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Manage supplier contract:");
                    lstInstr.Items.Add(" *Performance milestones reached");
                    lstInstr.Items.Add(" *Identify performance milestones");
                    lstInstr.Items.Add(" *Identify events triggering performance review milestones");
                    lstInstr.Items.Add(" *Initiate formal performance review");
                    lstInstr.Items.Add(" *Assess supplier performance");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Procurement manager reviews:");
                    lstInstr.Items.Add(" *Procurement items recieved to date ");
                    lstInstr.Items.Add(" *Scope of work");
                    lstInstr.Items.Add(" *Review terms & conditions of the contract");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Identify performance issues:");
                    lstInstr.Items.Add(" *Serious deviations are raised as an issue with the PM");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Resolve performance issues:");
                    lstInstr.Items.Add(" *Performance issues get resolved in accordance with the agreed process as per the contract");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Restitution actions:");
                    lstInstr.Items.Add(" *Withholding payment");
                    lstInstr.Items.Add(" *Raising a formal dispute in terms of the contract");
                    lstInstr.Items.Add(" *Cancellation of the supplier contract");
                    lstInstr.Items.Add(" *Communicate review outcomes");
                    lstInstr.Items.Add(" *Relevant stakeholders are informed about the outcome of the performance review");
                    break;
                //Change management activities
                case 7:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Activities");
                    lstInstr.Items.Add(" *Identify need for change:");
                    lstInstr.Items.Add("  -Identify the need for a change in Process, Design, Manufacturing etc.");
                    lstInstr.Items.Add("  -Completing the Change Request Form (CRF)");
                    lstInstr.Items.Add("  -Forwards the CRF to the Project Manager");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Review the proposed change:");
                    lstInstr.Items.Add(" *PM investigate to identify reason and impact");
                    lstInstr.Items.Add(" *Decide on criticality of change as well as impact on the project");
                    lstInstr.Items.Add(" *Assess change in terms of scope creep possibilities");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Approve the desired change");
                    lstInstr.Items.Add("PM reviews details of the CRF");
                    lstInstr.Items.Add("PM approves the change request or seeks approval from the project board for approval");
                    lstInstr.Items.Add("Update Project Plan");
                    lstInstr.Items.Add("Schedule & implement changes");
                    lstInstr.Items.Add("Reviews effects of changes");
                    lstInstr.Items.Add("Update change register");
                    break;
                //Time management activities
                case 8:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Document time sheet");
                    lstInstr.Items.Add(" *Capture time spent in completing project activities");
                    lstInstr.Items.Add(" *Complete time sheets as and how each task is completed");
                    lstInstr.Items.Add(" *Forward timesheets to project manager for approval");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Approve time sheet");
                    lstInstr.Items.Add(" *The project manager review recieved timesheets");
                    lstInstr.Items.Add(" *Identify:");
                    lstInstr.Items.Add("  -Total time spent per project activity");
                    lstInstr.Items.Add("  -Confirm allocation of the resource to the task");
                    lstInstr.Items.Add("  -Determine reasonableness of time spent to complete the task");
                    lstInstr.Items.Add("  -Identify whether sufficient progress has been made in completing the deliverable");
                    lstInstr.Items.Add("  -Identify any issues regarding the time spent and progress with the deliverable");
                    lstInstr.Items.Add("  -Approves, rejects or defers time sheets");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Update Project plan");
                    lstInstr.Items.Add(" *The project administration update the Project plan by entering information:");
                    lstInstr.Items.Add("  -This allows for identification of:");
                    lstInstr.Items.Add("   >Total time spent per project activity");
                    lstInstr.Items.Add("   >Calculates the percentage complete of each activity");
                    lstInstr.Items.Add("   >Evaluates the total delivery status against the schedule");
                    lstInstr.Items.Add("   >Tasks that are past their estimated completion date");
                    lstInstr.Items.Add("   >Conduct an EVA analysis");
                    lstInstr.Items.Add("   >Tasks that have exceeded their estimated level of effort");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Report to the Project Manager:");
                    lstInstr.Items.Add(" *The project manager decides on actions to follow such as:");
                    lstInstr.Items.Add("  -Changing the team member assigned to the task");
                    lstInstr.Items.Add("  -Allocating additional team members to the task");
                    lstInstr.Items.Add("  -Providing additional time for completion of the task");
                    lstInstr.Items.Add("  -Requesting external advice and assistance");
                    break;
                //Cost management activities
                case 9:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Activities");
                    lstInstr.Items.Add(" *Control the costs");
                    lstInstr.Items.Add(" *Labour costs");
                    lstInstr.Items.Add(" *Equipment costs");
                    lstInstr.Items.Add(" *Materials cost");
                    lstInstr.Items.Add(" *Administrative costs");
                    lstInstr.Items.Add(" *Other costs");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Document expense sheet:");
                    lstInstr.Items.Add(" *Capture date on which the expense occurred");
                    lstInstr.Items.Add("  -Activities and tasks against which the expense was incurred (WBS number)");
                    lstInstr.Items.Add("  -Type and categorisation of the expense");
                    lstInstr.Items.Add("  -Amount of the expense and payee");
                    lstInstr.Items.Add("  -Invoice number relating to the expense");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Approve time sheet");
                    lstInstr.Items.Add(" *Expense forms forwarded to the Project Manager to approve expense and payment");
                    lstInstr.Items.Add(" *The Project Manager reviews received timesheets and identifies:");
                    lstInstr.Items.Add("  -The Validity of expense against the WBS and schedule");
                    lstInstr.Items.Add("  -Validity as expense per approved budget item");
                    lstInstr.Items.Add("  -Validity as per Cash Flow Statement");
                    lstInstr.Items.Add("  -If unbudgeted, is it fair, reasonable and affordable");
                    lstInstr.Items.Add("  -Identify any issues regarding the cost incurred and progress with the deliverable");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Update Project Plan");
                    lstInstr.Items.Add(" *The project administrator updates the Project Plan by entering information:");
                    lstInstr.Items.Add("  -Update expense register");
                    lstInstr.Items.Add("  -Update Project Plan - Cost per activity");
                    lstInstr.Items.Add("  -Identifying");
                    lstInstr.Items.Add("  -Identify total cost per resource or activity");
                    lstInstr.Items.Add("  -Calculate the actual vs projected expenses");
                    lstInstr.Items.Add("  -Identify instances of over or under spending");
                    lstInstr.Items.Add("  -Conduct an EVA analysis");
                    lstInstr.Items.Add("  -Tasks that have exceeded their estimated level of budget");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Report to the project Manager:");
                    lstInstr.Items.Add(" *The project manager decides on actions to follow such as:");
                    lstInstr.Items.Add("  -Changing the amount of team members assigned to the task");
                    lstInstr.Items.Add("  -Allocating additional funding to the task");
                    lstInstr.Items.Add("  -Changing the team member assigned to the task");
                    lstInstr.Items.Add("  -Requesting external advice and assistance");
                    break;
                //Identify phase review criteria
                case 10:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Project Manager");
                    lstInstr.Items.Add(" *Present phase review form");
                    lstInstr.Items.Add(" *Discuss current status");
                    lstInstr.Items.Add(" *Present vision, objectives, scope and deliverables");
                    lstInstr.Items.Add(" *Deliverables completed to date");
                    lstInstr.Items.Add(" *Schedule progress");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Deviations form:");
                    lstInstr.Items.Add(" *Time ");
                    lstInstr.Items.Add(" *Scope");
                    lstInstr.Items.Add(" *Cost");
                    lstInstr.Items.Add(" *Quality");
                    lstInstr.Items.Add(" *Key issues");
                    lstInstr.Items.Add(" *Key risks");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Project board");
                    lstInstr.Items.Add(" *Approves project to proceed");
                    lstInstr.Items.Add(" *request additional information or activities undertaken");
                    lstInstr.Items.Add(" *Delay, transfer or cancel the project");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Complete phase review form");
                    lstInstr.Items.Add(" *Build/Construct phase review form");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Seek approval to proceed");
                    break;
                default:
                    lstInstr.Items.Clear();
                    break;
            }
        }
        public void thirdButton(int button)
        {
            //switch for first button

            switch (button)
            {
                //Communciations management roles
                case 1:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Communications team member");
                    lstInstr.Items.Add(" *Identifying communications events as identified in the plan");
                    lstInstr.Items.Add(" *Defining the message content, audience, timing and format");
                    lstInstr.Items.Add(" *Drafting the messages for approval by the PM");
                    lstInstr.Items.Add(" *Obtaining feedback and monitoring the effectiveness of the communications process");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Project Manger");
                    lstInstr.Items.Add(" *Approving all communications messages within the project");
                    lstInstr.Items.Add(" *Requesting special approvals from the project board as how the need arises");
                    lstInstr.Items.Add(" *Distributing all the communications messages within the project");
                    lstInstr.Items.Add(" *Identifying and resolving all communications issues as and when they arise");
                    break;
                //Issue management roles
                case 2:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Team Member ");
                    lstInstr.Items.Add(" *Identify issues within the project");
                    lstInstr.Items.Add(" *Completing an issue form for each identified issue");
                    lstInstr.Items.Add(" *Submitting issue forms for review");
                    lstInstr.Items.Add(" *Completing & implementing issue management actions as identified by the Project Manager");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Project Manager");
                    lstInstr.Items.Add(" *Review all issues to determine their priority");
                    lstInstr.Items.Add(" *Implementing issue management actions for low and medium priority issues");
                    lstInstr.Items.Add(" *Escalating issues where needed");
                    lstInstr.Items.Add(" *Implementing issue management actions as identified by the Project Board");
                    lstInstr.Items.Add(" *Reviewing the effectiveness of issue management actions after implementation");
                    lstInstr.Items.Add(" *Maintain a risk register");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Project Board");
                    lstInstr.Items.Add(" *Conducts a review of high priority issues as identified by the Project Manager");
                    lstInstr.Items.Add(" *Identify actions to take to:");
                    lstInstr.Items.Add("  -Resolve");
                    lstInstr.Items.Add("  -Lessen the impact");
                    lstInstr.Items.Add("  -Supports the Project Manager with implementation of all risk actions");
                    break;
                //Risk management roles
                case 3:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Team Member ");
                    lstInstr.Items.Add(" *Identify risks within the project");
                    lstInstr.Items.Add(" *Completing a risk form for each identified risk");
                    lstInstr.Items.Add(" *Submitting risk forms for review");
                    lstInstr.Items.Add(" *Completing & implementing risk actions as identified by the Project Manager");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Project Manager");
                    lstInstr.Items.Add(" *Review all risks to determine their priority");
                    lstInstr.Items.Add(" *Implementing risk actions for low and medium priority risks");
                    lstInstr.Items.Add(" *Escalating risks where needed");
                    lstInstr.Items.Add(" *Implementing risk actions as identified by the Project Board");
                    lstInstr.Items.Add(" *Reviewing the effectiveness of risk actions after implementation");
                    lstInstr.Items.Add(" *Maintain a risk register");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Project Board");
                    lstInstr.Items.Add(" *Conducts a review of high priority risks as identified by the Project Manager");
                    lstInstr.Items.Add(" *Identify actions to take to:");
                    lstInstr.Items.Add("  -Mitigate");
                    lstInstr.Items.Add("  -Transfer");
                    lstInstr.Items.Add("  -Avoid");
                    lstInstr.Items.Add("  -Supports the Project Manager with implementation of all risk actions");
                    break;
                //Quality management roles 
                case 4:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("The Quality Manager");
                    lstInstr.Items.Add(" *Review quality targets to ensure they are still relevant and achievable");
                    lstInstr.Items.Add(" *Ensure that quality management is executed as defined in the Quality Plan");
                    lstInstr.Items.Add(" *Review the results of implemented QA & QC actions");
                    lstInstr.Items.Add(" *Identifies deviations from form quality targets");
                    lstInstr.Items.Add(" *Lists corrective actions to take when quality deviations occur");
                    lstInstr.Items.Add(" *Raises change requests as and when required when quality deviances occur");
                    lstInstr.Items.Add(" *Oversees the implementation of corrective actions");
                    lstInstr.Items.Add(" *Updates the quality regsiter for quality actions implemented");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Project Manager");
                    lstInstr.Items.Add(" *Reviews and approves all corrective actions as raised by the Quality Manager");
                    lstInstr.Items.Add(" *Approves or seeks board approval for change requests raised");
                    break;
                //Acceptance management roles
                case 5:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Team Member ");
                    lstInstr.Items.Add(" *Produces the deliverable as stated in the terms of Reference");
                    lstInstr.Items.Add(" *Completes documentation & infomrs the Project Manager that a deliverable is complete and ready for signoff");
                    lstInstr.Items.Add(" *Completes any additional/remedial actions required to gain signoff");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Project Manager");
                    lstInstr.Items.Add(" *Organises and schedules accpetance tests to review deliverable comlpetion");
                    lstInstr.Items.Add(" *Ensures acceptance tests are:");
                    lstInstr.Items.Add("  -Comprehensive");
                    lstInstr.Items.Add("  -Effective");
                    lstInstr.Items.Add("  -Review the results of acceptance tests and ensures remedial actions are identified and implemented");
                    lstInstr.Items.Add("  -Involves the customer where possible in acceptance testing");
                    lstInstr.Items.Add("  -Complete an acceptance form for signoff by the customer");
                    lstInstr.Items.Add("  -Communicates the status of acceptance to the various Project Stakeholders");
                    lstInstr.Items.Add("  -Ensures that the acceptance register is kept up to date");
                    lstInstr.Items.Add("  -Resolves issues");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Customer");
                    lstInstr.Items.Add(" *Takes part in the acceptance tests");
                    lstInstr.Items.Add(" *Authorises the acceptance form for release from the Project");
                    lstInstr.Items.Add(" *Takes custody of the deliverable for integration into its own business");
                    break;
                //Procurement management roles
                case 6:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Procurement Manager");
                    lstInstr.Items.Add(" *Manages day to day procurement activities of the project");
                    lstInstr.Items.Add(" *Identifies the procurement items as per the Procurement Plan");
                    lstInstr.Items.Add(" *Completes purchase orders");
                    lstInstr.Items.Add(" *Obtains approval of purchase orders");
                    lstInstr.Items.Add(" *Issues purchase orders and obtains estinmated deloievry dates");
                    lstInstr.Items.Add(" *Accepts procurement items");
                    lstInstr.Items.Add(" *Conducts supplier performance reviews");
                    lstInstr.Items.Add(" *Identifies deviations from the contract");
                    lstInstr.Items.Add(" *Raises supplier issues");
                    lstInstr.Items.Add(" *Assists in resolving supplier issues");
                    lstInstr.Items.Add(" *Maintains a purchase register");
                    lstInstr.Items.Add(" *Submits & requets payment of suppliers");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Project Manager");
                    lstInstr.Items.Add(" *Approves purchase orders as submitted");
                    lstInstr.Items.Add(" *Approves supplier payments");
                    lstInstr.Items.Add(" *Resolves issues");
                    break;
                //Change management roles
                case 7:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Team Member");
                    lstInstr.Items.Add(" *Recognising the need for a change in the project");
                    lstInstr.Items.Add(" *Completing the CRF with a detailed description of the change required");
                    lstInstr.Items.Add(" *Forwarding the CRF to the Project Manager");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Project Manager");
                    lstInstr.Items.Add(" *Investigating the CRF to determine the criticality of the proposed change");
                    lstInstr.Items.Add(" *Requesting approval for each CRF from the Project Board");
                    lstInstr.Items.Add(" *Conducts a review of formally approved changes and closes out the change requests");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Project Board");
                    lstInstr.Items.Add(" *Conducts a review of each CRF to determine need and impact");
                    lstInstr.Items.Add(" *Decide upon merit to implement changes or not");
                    lstInstr.Items.Add(" *Identify the specific actions required to implement the change");
                    lstInstr.Items.Add(" *Approve changes as necessary to:");
                    lstInstr.Items.Add("  -Budgets");
                    lstInstr.Items.Add("  -Schedule");
                    lstInstr.Items.Add("  -Resource requirements");
                    break;
                //Time management roles
                case 8:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Team Member");
                    lstInstr.Items.Add(" *Undertakes each delegated task to the best of their ability");
                    lstInstr.Items.Add(" *Completes regular timesheets to the level of detail required");
                    lstInstr.Items.Add(" *Submits timesheets timeously");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Project Manager");
                    lstInstr.Items.Add(" *Informing all staffabout the time management process");
                    lstInstr.Items.Add(" *Ensure timeously completion of timesheets throughout the duration of the project");
                    lstInstr.Items.Add(" *Reviewing and approving all timesheets");
                    lstInstr.Items.Add(" *Recommending and implementing corrective actions");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Project Administration");
                    lstInstr.Items.Add(" *Manages day to day timesheet processes");
                    lstInstr.Items.Add(" *Provides all staff with basic timesheet templates");
                    lstInstr.Items.Add(" *Ensures level of detail completion of timesheets");
                    lstInstr.Items.Add(" *Ensures all timesheets have been signed off by the Project Manager");
                    lstInstr.Items.Add(" *Keeping the timesheet register up to date");
                    break;
                //Cost management roles
                case 9:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Team Member");
                    lstInstr.Items.Add(" *Complete regualr expense forms to the level of detail required");
                    lstInstr.Items.Add(" *Submit expense forms timeously");
                    lstInstr.Items.Add(" *Provide additional information regarding time spent when required");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Project Manager");
                    lstInstr.Items.Add(" *Informing all staff about the Cost Management process");
                    lstInstr.Items.Add(" *Ensuring timeously completion of expense forms throughout the duration of the project");
                    lstInstr.Items.Add(" *Reviewing and approving all expense forms");
                    lstInstr.Items.Add(" *Recommending and implementing corrcetive actions");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Project Administrator");
                    lstInstr.Items.Add(" *Manages day to day expense process");
                    lstInstr.Items.Add(" *Provides all staff with basic expense form templates");
                    lstInstr.Items.Add(" *Ensures level of detail completion of expense forms");
                    lstInstr.Items.Add(" *Ensures all expense forms have been signed off by the Project Manager");
                    lstInstr.Items.Add(" *Keeps the expense register up to date");
                    lstInstr.Items.Add(" *Updates the Project Plan and identifying deviations");
                    lstInstr.Items.Add(" *Arranges payment for approved expenses");
                    break;
                //Seek approval to proceed
                case 10:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Project  Manager");
                    lstInstr.Items.Add(" *Present Phase Review Form");
                    lstInstr.Items.Add(" *Discuss current state");
                    lstInstr.Items.Add(" *Present vision, objectives scope and deliverables");
                    lstInstr.Items.Add(" *Deliverable completed to date");
                    lstInstr.Items.Add(" *Schedule progress");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Deviations from:");
                    lstInstr.Items.Add(" *Time");
                    lstInstr.Items.Add(" *Scope");
                    lstInstr.Items.Add(" *Cost");
                    lstInstr.Items.Add(" *Quality");
                    lstInstr.Items.Add(" *Key issues");
                    lstInstr.Items.Add(" *key risks");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Project Board");
                    lstInstr.Items.Add(" *Approves project to proceed");
                    lstInstr.Items.Add(" *Request additional information or activities undertaken");
                    lstInstr.Items.Add(" *Delay, transfer or cancel the project");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Complete Phase review Form");
                    lstInstr.Items.Add(" *Build/Construct Phase Review Form");
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

      
        private void btnSec_Click(object sender, EventArgs e)
        {
            secondButton(second);
        }

        private void btnThird_Click(object sender, EventArgs e)
        {
            thirdButton(third);
        }

        private void btnOperate_Click_1(object sender, EventArgs e)
        {
            showInstructions();
            operateProject();
        }

        private void btnComMan_Click_1(object sender, EventArgs e)
        {
            showInstructions();
            communicationsManagement();
        }

        private void btnIssMan_Click_1(object sender, EventArgs e)
        {
            showInstructions();
            issueManagement();
        }

        private void btnRiskMan_Click_1(object sender, EventArgs e)
        {
            showInstructions();
            riskManagement();
        }

        private void btnQualMan_Click_1(object sender, EventArgs e)
        {
            showInstructions();
            qualityManagement();
        }

        private void btnAccMan_Click_1(object sender, EventArgs e)
        {
            showInstructions();
            acceptanceManagement();
        }

        private void btnProcMan_Click_1(object sender, EventArgs e)
        {
            showInstructions();
            procurementManagement();
        }

        private void btnCMan_Click_1(object sender, EventArgs e)
        {
            showInstructions();
            changeManagement();
        }

        private void btnTMan_Click_1(object sender, EventArgs e)
        {
            showInstructions();
            timeManagement();
        }

        private void btnCostMan_Click_1(object sender, EventArgs e)
        {
            showInstructions();
            costManagement();
        }

        private void btnCPhaseRev_Click_1(object sender, EventArgs e)
        {
            showInstructions();
            phaseReview();
        }

        private void btnViewTimeMan_Click(object sender, EventArgs e)
        {
            string filename = "Time_Management_Process.pdf";
            string filename2 = "Timesheet_Form.pdf";
            string filename3 = "Timesheet_Register.pdf";

            System.Diagnostics.Process.Start(filename);
            System.Diagnostics.Process.Start(filename2);
            System.Diagnostics.Process.Start(filename3);
        }

        private void btnViewCostMan_Click(object sender, EventArgs e)
        {
            string filename = "Cost_Management_Process.pdf";
            string filename2 = "Expense_Form.pdf";
            string filename3 = "Expense_Register.pdf";

            System.Diagnostics.Process.Start(filename);
            System.Diagnostics.Process.Start(filename2);
            System.Diagnostics.Process.Start(filename3);
        }

        private void btnViewQualityMan_Click(object sender, EventArgs e)
        {
            string filename = "Quality_Management_Process.pdf";
            string filename2 = "Quality_Review_Form.pdf";
            string filename3 = "Quality_Register.pdf";

            System.Diagnostics.Process.Start(filename);
            System.Diagnostics.Process.Start(filename2);
            System.Diagnostics.Process.Start(filename3);
        }

        private void btnViewChangeMan_Click(object sender, EventArgs e)
        {
            string filename = "Change_Management_Process.pdf";
            string filename2 = "Change_Request_Form.pdf";
            string filename3 = "Change_Register.pdf";

            System.Diagnostics.Process.Start(filename);
            System.Diagnostics.Process.Start(filename2);
            System.Diagnostics.Process.Start(filename3);
        }

        private void btnViewRiskMan_Click(object sender, EventArgs e)
        {
            string filename = "Risk_Management_Process.pdf";
            string filename2 = "Risk_Form.pdf";
            string filename3 = "Risk_Register.pdf";

            System.Diagnostics.Process.Start(filename);
            System.Diagnostics.Process.Start(filename2);
            System.Diagnostics.Process.Start(filename3);
        }

        private void btnViewIssueMan_Click(object sender, EventArgs e)
        {
            string filename = "Issue_Management_Process.pdf";
            string filename2 = "Issue_Form.pdf";
            string filename3 = "Issue_Register.pdf";

            System.Diagnostics.Process.Start(filename);
            System.Diagnostics.Process.Start(filename2);
            System.Diagnostics.Process.Start(filename3);
        }

        private void btnViewProcMan_Click(object sender, EventArgs e)
        {
            string filename = "Procurement_Management_Process.pdf";
            string filename2 = "Purchase_Order_Form.pdf";
            string filename3 = "Procurement_Register.pdf";

            System.Diagnostics.Process.Start(filename);
            System.Diagnostics.Process.Start(filename2);
            System.Diagnostics.Process.Start(filename3);
        }

        private void btnViewAccMan_Click(object sender, EventArgs e)
        {
            string filename = "Acceptance_Management_Process.pdf";
            string filename2 = "Acceptance_Form.pdf";
            string filename3 = "Acceptance_Register.pdf";

            System.Diagnostics.Process.Start(filename);
            System.Diagnostics.Process.Start(filename2);
            System.Diagnostics.Process.Start(filename3);
        }

        private void btnViewComMan_Click(object sender, EventArgs e)
        {
            string filename = "Communication_Management_Process.pdf";
            string filename2 = "Project_Status_Report.pdf";
            string filename3 = "Communications_Register.pdf";

            System.Diagnostics.Process.Start(filename);
            System.Diagnostics.Process.Start(filename2);
            System.Diagnostics.Process.Start(filename3);
        }

        

        private void btnViewPRev_Click(object sender, EventArgs e)
        {
            string filename = "Phase_Review_Form_Execution.pdf";
            
            

            System.Diagnostics.Process.Start(filename);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TechGenics.Properties.Settings.Default.Theme == "Light")
            {
                this.BackColor = SystemColors.AppWorkspace;
                
                lstInstr.BackColor = SystemColors.AppWorkspace;
                lstInstr.ForeColor = SystemColors.Desktop;
                lstInfo.BackColor = SystemColors.AppWorkspace;
                lstInfo.ForeColor = SystemColors.Desktop;
                pnlInfo.BackColor = SystemColors.AppWorkspace;
                pnlExecution.BackColor = SystemColors.AppWorkspace;
                pnlTopMenu.BackColor = SystemColors.AppWorkspace;

                btnViewIssueMan.BackColor = SystemColors.AppWorkspace;
                btnViewRiskMan.BackColor = SystemColors.AppWorkspace;
                btnViewQualityMan.BackColor = SystemColors.AppWorkspace;
                btnViewChangeMan.BackColor = SystemColors.AppWorkspace;
                btnViewComMan.BackColor = SystemColors.AppWorkspace;
                btnViewTimeMan1.BackColor = SystemColors.AppWorkspace;
                btnViewCostMan.BackColor = SystemColors.AppWorkspace;
                btnViewProcMan.BackColor = SystemColors.AppWorkspace;
                btnViewAccMan.BackColor = SystemColors.AppWorkspace;
                btnViewPRev.BackColor = SystemColors.AppWorkspace;

                btnCommunications.BackColor = SystemColors.AppWorkspace;
                btnIssue.BackColor = SystemColors.AppWorkspace;
                btnRisk.BackColor = SystemColors.AppWorkspace;
                btnQuality.BackColor = SystemColors.AppWorkspace;
                btnAccept.BackColor = SystemColors.AppWorkspace;
                btnProcurement.BackColor = SystemColors.AppWorkspace;
                btnChange.BackColor = SystemColors.AppWorkspace;
                btnTime.BackColor = SystemColors.AppWorkspace;
                btnCost.BackColor = SystemColors.AppWorkspace;
                btnReview.BackColor = SystemColors.AppWorkspace;

                btnCommunications.ForeColor = SystemColors.Desktop;
                btnIssue.ForeColor = SystemColors.Desktop;
                btnRisk.ForeColor = SystemColors.Desktop;
                btnQuality.ForeColor = SystemColors.Desktop;
                btnAccept.ForeColor = SystemColors.Desktop;
                btnProcurement.ForeColor = SystemColors.Desktop;
                btnChange.ForeColor = SystemColors.Desktop;
                btnTime.ForeColor = SystemColors.Desktop;
                btnCost.ForeColor = SystemColors.Desktop;
                btnReview.ForeColor = SystemColors.Desktop;
            }
            if (TechGenics.Properties.Settings.Default.Theme == "Dark")
            {

                this.BackColor = SystemColors.Desktop;

                pnlInfo.BackColor = SystemColors.Desktop;
                pnlTopMenu.BackColor = SystemColors.Desktop;
                pnlExecution.BackColor = SystemColors.Desktop;
                lstInstr.BackColor = SystemColors.Desktop;
                lstInstr.ForeColor = SystemColors.ActiveBorder; 
                lstInfo.BackColor = SystemColors.Desktop;
                lstInfo.ForeColor = SystemColors.ActiveBorder;

                btnViewIssueMan.BackColor = SystemColors.Desktop;
                btnViewRiskMan.BackColor = SystemColors.Desktop;
                btnViewQualityMan.BackColor = SystemColors.Desktop;
                btnViewChangeMan.BackColor = SystemColors.Desktop;
                btnViewComMan.BackColor = SystemColors.Desktop;
                btnViewTimeMan1.BackColor = SystemColors.Desktop;
                btnViewCostMan.BackColor = SystemColors.Desktop;
                btnViewProcMan.BackColor = SystemColors.Desktop;
                btnViewAccMan.BackColor = SystemColors.Desktop;
                btnViewPRev.BackColor = SystemColors.Desktop;

                btnCommunications.BackColor = SystemColors.Desktop;
                btnIssue.BackColor = SystemColors.Desktop;
                btnRisk.BackColor = SystemColors.Desktop;
                btnQuality.BackColor = SystemColors.Desktop;
                btnAccept.BackColor = SystemColors.Desktop;
                btnProcurement.BackColor = SystemColors.Desktop;
                btnChange.BackColor = SystemColors.Desktop;
                btnTime.BackColor = SystemColors.Desktop;
                btnCost.BackColor = SystemColors.Desktop;
                btnReview.BackColor = SystemColors.Desktop;

                btnCommunications.ForeColor = SystemColors.ActiveBorder;
                btnIssue.ForeColor = SystemColors.ActiveBorder;
                btnRisk.ForeColor = SystemColors.ActiveBorder;
                btnQuality.ForeColor = SystemColors.ActiveBorder;
                btnAccept.ForeColor = SystemColors.ActiveBorder;
                btnProcurement.ForeColor = SystemColors.ActiveBorder;
                btnChange.ForeColor = SystemColors.ActiveBorder;
                btnTime.ForeColor = SystemColors.ActiveBorder;
                btnCost.ForeColor = SystemColors.ActiveBorder;
                btnReview.ForeColor = SystemColors.ActiveBorder;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlInfo.Hide();
            pnlExecution.Visible = true;

            lstInfo.Items.Clear();
            lstInfo.Items.Add("This phase involves the execution of each activity and task listed in the Project Plan.While the activities and tasks");
            lstInfo.Items.Add("are being executed, a series of management processes are undertaken to monitor and control the deliverables");
            lstInfo.Items.Add("being output by the project.This includes the identification of changes, risks and issues, the review of deliverable");
            lstInfo.Items.Add("quality and the measurement of each deliverable being produced against the acceptance criteria. Once all of the");
            lstInfo.Items.Add("deliverables have been produced and the customer has accepted the final solution, the project is ready for closure");

        }
    }
}