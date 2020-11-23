using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisioForge.Types;

namespace TechGenics
{
    public partial class frmPlanning : Form
    {
        public frmPlanning()
        {
            InitializeComponent();
        }

        private void frmPlanning_Load(object sender, EventArgs e)
        {
            pnlPlanning.BringToFront();
            pboTender.SendToBack();
        }

        /// <summary>
        /// Variables for switch
        /// </summary>
        #region Variables
        int first = 0;      //btnFirst
        int second = 0;     //btnSec
        int third = 0;      //btnThird
        int fourth = 0;     //btnFourth
        int fifth = 0;      //btnFifth
        int sixth = 0;      //btnSixth
        #endregion

        /// <summary>
        /// General Functions
        /// </summary>
        #region Functions

        public void projectPlan()
        {
            pnlPlanning.Visible = false;
            pnlInstr.Visible = true;
            pnlInstr.BringToFront();

            lstInstr.Items.Clear();

            //button visibility
            btnFirst.Visible = true;
            btnSec.Visible = true;
            btnThird.Visible = true;
            btnFourth.Visible = false;
            btnFifth.Visible = false;
            btnSixth.Visible = false;

            //button text
            btnFirst.Text = "Define the Work Breakdown Structure";
            btnSec.Text = "Identify Required Resources";
            btnThird.Text = "Construct a Project Schedule";

            first = 1;      
            second = 1;     
            third = 1;      
            fourth = 1;     
            fifth = 1;      
            sixth = 1;

            btnViewProjectPlan.Visible = true;
            btnViewResPlan.Visible = false;
            btnViewFinPlan.Visible = false;
            btnViewQPlan.Visible = false;
            btnViewComPlan.Visible = false;
            btnViewAPlan.Visible = false;
            btnViewRiskPlan.Visible = false;
            btnViewProcPlan.Visible = false;
            btnViewPhaseRev.Visible = false;
        }

        public void resourcePlan()
        {
            pnlPlanning.Visible = false;
            pnlInstr.Visible = true;
            pnlInstr.BringToFront();

            lstInstr.Items.Clear();

            //button visibility
            btnFirst.Visible = true;
            btnSec.Visible = true;
            btnThird.Visible = true;
            btnFourth.Visible = false;
            btnFifth.Visible = false;
            btnSixth.Visible = false;

            //button text
            btnFirst.Text = "List the Required Resources";
            btnSec.Text = "Quantify the Required Resources";
            btnThird.Text = "Create a Resource Schedule";

            first = 2;
            second = 2;
            third = 2;
            fourth = 2;
            fifth = 2;
            sixth = 2;

            btnViewProjectPlan.Visible = false;
            btnViewResPlan.Visible = true;
            btnViewFinPlan.Visible = false;
            btnViewQPlan.Visible = false;
            btnViewComPlan.Visible = false;
            btnViewAPlan.Visible = false;
            btnViewRiskPlan.Visible = false;
            btnViewProcPlan.Visible = false;
            btnViewPhaseRev.Visible = false;
        }

        public void financialPlan()
        {
            pnlPlanning.Visible = false;
            pnlInstr.Visible = true;
            pnlInstr.BringToFront();

            lstInstr.Items.Clear();

            //button visibility
            btnFirst.Visible = true;
            btnSec.Visible = true;
            btnThird.Visible = true;
            btnFourth.Visible = false;
            btnFifth.Visible = false;
            btnSixth.Visible = false;

            //button text
            btnFirst.Text = "List Financial Expenses";
            btnSec.Text = "Quantify the Financial Expenses";
            btnThird.Text = "Construct a Cashflow Schedule";

            first = 3;
            second = 3;
            third = 3;
            fourth = 3;
            fifth = 3;
            sixth = 3;

            btnViewProjectPlan.Visible = false;
            btnViewResPlan.Visible = false;
            btnViewFinPlan.Visible = true;
            btnViewQPlan.Visible = false;
            btnViewComPlan.Visible = false;
            btnViewAPlan.Visible = false;
            btnViewRiskPlan.Visible = false;
            btnViewProcPlan.Visible = false;
            btnViewPhaseRev.Visible = false;
        }

        public void qualityPlan()
        {
            pnlPlanning.Visible = false;
            pnlInstr.Visible = true;
            pnlInstr.BringToFront();

            lstInstr.Items.Clear();

            //button visibility
            btnFirst.Visible = true;
            btnSec.Visible = true;
            btnThird.Visible = true;
            btnFourth.Visible = true;
            btnFifth.Visible = false;
            btnSixth.Visible = false;

            //button text
            btnFirst.Text = "ID Appropriate Quality Standards to Employ";
            btnSec.Text = "Define Quality Targets";
            btnThird.Text = "Create a Quality assurance Plan";
            btnFourth.Text = "Create a Quality Control Plan";

            first = 4;
            second = 4;
            third = 4;
            fourth = 4;
            fifth = 4;
            sixth = 4;

            btnViewProjectPlan.Visible = false;
            btnViewResPlan.Visible = false;
            btnViewFinPlan.Visible = false;
            btnViewQPlan.Visible = true;
            btnViewComPlan.Visible = false;
            btnViewAPlan.Visible = false;
            btnViewRiskPlan.Visible = false;
            btnViewProcPlan.Visible = false;
            btnViewPhaseRev.Visible = false;
        }

        public void communicationsPlan()
        {
            pnlPlanning.Visible = false;
            pnlInstr.Visible = true;
            pnlInstr.BringToFront();

            lstInstr.Items.Clear();

            //button visibility
            btnFirst.Visible = true;
            btnSec.Visible = true;
            btnThird.Visible = true;
            btnFourth.Visible = false;
            btnFifth.Visible = false;
            btnSixth.Visible = false;

            //button text
            btnFirst.Text = "Identify the Communications Stakeholders";
            btnSec.Text = "Identify the Communications Requirements";
            btnThird.Text = "Construct a Communications Schedule";

            first = 5;
            second = 5;
            third = 5;
            fourth = 5;
            fifth = 5;
            sixth = 5;

            btnViewProjectPlan.Visible = false;
            btnViewResPlan.Visible = false;
            btnViewFinPlan.Visible = false;
            btnViewQPlan.Visible = false;
            btnViewComPlan.Visible = true;
            btnViewAPlan.Visible = false;
            btnViewRiskPlan.Visible = false;
            btnViewProcPlan.Visible = false;
            btnViewPhaseRev.Visible = false;
        }

        public void acceptancePlan()
        {
            pnlPlanning.Visible = false;
            pnlInstr.Visible = true;
            pnlInstr.BringToFront();

            lstInstr.Items.Clear();

            //button visibility
            btnFirst.Visible = true;
            btnSec.Visible = true;
            btnThird.Visible = false;
            btnFourth.Visible = false;
            btnFifth.Visible = false;
            btnSixth.Visible = false;

            //button text
            btnFirst.Text = "List the Acceptance Criteria";
            btnSec.Text = "Create an Acceptance Schedule";

            first = 6;
            second = 6;
            third = 6;
            fourth = 6;
            fifth = 6;
            sixth = 6;

            btnViewProjectPlan.Visible = false;
            btnViewResPlan.Visible = false;
            btnViewFinPlan.Visible = false;
            btnViewQPlan.Visible = false;
            btnViewComPlan.Visible = false;
            btnViewAPlan.Visible = true;
            btnViewRiskPlan.Visible = false;
            btnViewProcPlan.Visible = false;
            btnViewPhaseRev.Visible = false;
        }

        public void riskPlan()
        {
            pnlPlanning.Visible = false;
            pnlInstr.Visible = true;
            pnlInstr.BringToFront();

            lstInstr.Items.Clear();

            //button visibility
            btnFirst.Visible = true;
            btnSec.Visible = true;
            btnThird.Visible = true;
            btnFourth.Visible = false;
            btnFifth.Visible = false;
            btnSixth.Visible = false;

            //button text
            btnFirst.Text = "Identify the Risks";
            btnSec.Text = "Quantify the Risks";
            btnThird.Text = "Construct a Risk Schedule";

            first = 7;
            second = 7;
            third = 7;
            fourth = 7;
            fifth = 7;
            sixth = 7;

            btnViewProjectPlan.Visible = false;
            btnViewResPlan.Visible = false;
            btnViewFinPlan.Visible = false;
            btnViewQPlan.Visible = false;
            btnViewComPlan.Visible = false;
            btnViewAPlan.Visible = false;
            btnViewRiskPlan.Visible = true;
            btnViewProcPlan.Visible = false;
            btnViewPhaseRev.Visible = false;
        }

        public void procurementPlan()
        {
            pnlPlanning.Visible = false;
            pnlInstr.Visible = true;
            pnlInstr.BringToFront();

            lstInstr.Items.Clear();

            //button visibility
            btnFirst.Visible = true;
            btnSec.Visible = true;
            btnThird.Visible = true;
            btnFourth.Visible = true;
            btnFifth.Visible = true;
            btnSixth.Visible = true;

            //button text
            btnFirst.Text = "identify Procurement Requirements";
            btnSec.Text = "Research Market Offerings";
            btnThird.Text = "Create a Procurement Schedule";
            btnFourth.Text = "Define Procurement Roles";
            btnFifth.Text = "Define the Tendering Process";
            btnSixth.Text = "Contract with the Supplier";

            first = 8;
            second = 8;
            third = 8;
            fourth = 8;
            fifth = 8;
            sixth = 8;

            btnViewProjectPlan.Visible = false;
            btnViewResPlan.Visible = false;
            btnViewFinPlan.Visible = false;
            btnViewQPlan.Visible = false;
            btnViewComPlan.Visible = false;
            btnViewAPlan.Visible = false;
            btnViewRiskPlan.Visible = false;
            btnViewProcPlan.Visible = true;
            btnViewPhaseRev.Visible = false;
        }

        public void phaseReview()
        {
            pnlPlanning.Visible = false;
            pnlInstr.Visible = true;
            pnlInstr.BringToFront();

            lstInstr.Items.Clear();

            //button visibility
            btnFirst.Visible = true;
            btnSec.Visible = true;
            btnThird.Visible = true;
            btnFourth.Visible = false;
            btnFifth.Visible = false;
            btnSixth.Visible = false;

            //button text
            btnFirst.Text = "Identify Phase Review Criteria";
            btnSec.Text = "Undertake Phase Review";
            btnThird.Text = "Seek Approval to Proceed";

            first = 9;
            second = 9;
            third = 9;
            fourth = 9;
            fifth = 9;
            sixth = 9;

            btnViewProjectPlan.Visible = false;
            btnViewResPlan.Visible = false;
            btnViewFinPlan.Visible = false;
            btnViewQPlan.Visible = false;
            btnViewComPlan.Visible = false;
            btnViewAPlan.Visible = false;
            btnViewRiskPlan.Visible = false;
            btnViewProcPlan.Visible = false;
            btnViewPhaseRev.Visible = true;
        }

        public void showInstructions()
        {
            pnlPlanning.Visible = false;
            pnlInstr.Visible = true;
            pnlInstr.BringToFront();
        }

        #endregion

   
        /// <summary>
        /// Switch statements
        /// </summary>
        #region Switch
        public void firstButton(int button)
        {
            //switch for first button

            switch (button)
            {
                //Develop the Work Breakdown Structure
                case 1:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Define the following");
                    lstInstr.Items.Add(" *Work packages");
                    lstInstr.Items.Add(" *Activities");
                    lstInstr.Items.Add(" *Product packages");
                    lstInstr.Items.Add(" *Tasks");
                    lstInstr.Items.Add(" *WBS Numbering code & Structure");
                    pboTender.Visible = false;
                    break;
                //List the resources required
                case 2:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("List Required Resources");
                    lstInstr.Items.Add(" *Labour");
                    lstInstr.Items.Add(" *Equipment");
                    lstInstr.Items.Add(" *Materials List the Phases");
                    lstInstr.Items.Add(" *List the Activities (WBS)");            
                    lstInstr.Items.Add(" *List the Tasks (WBS)");
                    lstInstr.Items.Add(" *Use a Scheduling Programme i.e. MS Projects, Primavera etc.");
                    pboTender.Visible = false;
                    break;
                //List financial expenses
                case 3:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Categories Expenses as:");
                    lstInstr.Items.Add(" *Purchases");
                    lstInstr.Items.Add(" *Rent");
                    lstInstr.Items.Add(" *Labour");
                    lstInstr.Items.Add(" *Leasing");
                    lstInstr.Items.Add(" *Contracts");
                    lstInstr.Items.Add(" *Procurements from External Sources");
                    lstInstr.Items.Add(" *Office Environment Establishment");
                    lstInstr.Items.Add(" *Project Administation");
                    pboTender.Visible = false;
                    break;
                //ID appropriate quality standards to employ
                case 4:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Identify Quality Standards and frameworks to Employ i.e.:");
                    lstInstr.Items.Add(" *ISO");
                    lstInstr.Items.Add(" *BOK Standards");
                    lstInstr.Items.Add(" *Audit Standards");
                    pboTender.Visible = false;
                    break;
                //Identify the communications stakeholders
                case 5:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("List the Communications Stakeholders");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("NOTE: Message, Medium, Frequency, ETC");
                    lstInstr.Items.Add(" *Project Sponsor/Customer      *Project Board");
                    lstInstr.Items.Add(" *Project Manager               *Project Leader");
                    lstInstr.Items.Add(" *Team Member                   *Quality Manager");
                    lstInstr.Items.Add(" *Procurement Manager           *Communications Manager");
                    lstInstr.Items.Add(" *Project Office Manager        *Business Representatives");
                    lstInstr.Items.Add(" *External Organisations");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Stakeholders according to:");
                    lstInstr.Items.Add(" *PESTEL Analysis");
                    pboTender.Visible = false;
                    break;
                //List the acceptance criteria
                case 6:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Identify Acceptance Criteria");
                    lstInstr.Items.Add("Deliverables");
                    lstInstr.Items.Add("Acceptance Criteria");
                    lstInstr.Items.Add("Acceptance Standard");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Note:");
                    lstInstr.Items.Add("It may be useful to use:");
                    lstInstr.Items.Add(" *Time");
                    lstInstr.Items.Add(" *Cost");
                    lstInstr.Items.Add(" *Quality");
                    lstInstr.Items.Add("as acceptance criteria");
                    pboTender.Visible = false;
                    break;
                //Identify the risks
                case 7:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Run risk workshop with:");
                    lstInstr.Items.Add(" *Project Sponsor               *Project Manager");
                    lstInstr.Items.Add(" *Team Members                  *Suppliers");
                    lstInstr.Items.Add(" *Customers");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("List the risk categories:");
                    lstInstr.Items.Add(" *Requirements                  *Benefits");
                    lstInstr.Items.Add(" *Schedule                      *Budget");
                    lstInstr.Items.Add(" *Deliverables                  *Scope");
                    lstInstr.Items.Add(" *Issues                        *Suppliers");
                    lstInstr.Items.Add(" *Acceptance                    *Communication");
                    lstInstr.Items.Add(" *Resources");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("List the risks");
                    lstInstr.Items.Add(" *Risk Category                 *Risk Description");
                    lstInstr.Items.Add(" *Risk ID                       *Relation to WBS elements if possible");
                    pboTender.Visible = false;
                    break;
                //Identify procurement requirements
                case 8:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Note Buy VS Make Decision");
                    lstInstr.Items.Add("Identify Procurement Requirements");
                    lstInstr.Items.Add(" *Create an Outsourcing/Procurement List i.e.:");
                    lstInstr.Items.Add("   -Products                    -Services");
                    lstInstr.Items.Add("   -Results");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Research market offerings");
                    lstInstr.Items.Add("Create a procurement schedule to manage the following");
                    lstInstr.Items.Add(" *Selection of suppliers");
                    lstInstr.Items.Add(" *Procurement of items (Timing & Price");
                    lstInstr.Items.Add(" *Managing supplier performance");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Define Procurement Needs i.e. What is it that needs to be procured?");
                    lstInstr.Items.Add("List & describe each procurement item:");
                    lstInstr.Items.Add(" *Item                          *Description");
                    lstInstr.Items.Add(" *Justification?                *Quantities?");
                    lstInstr.Items.Add(" *Budgeted for?");
                    pboTender.Visible = false;
                    break;
                //Identify phase review criteria
                case 9:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Activities");
                    lstInstr.Items.Add("Definition of WBS");
                    lstInstr.Items.Add("Clearly stated Milestones identified?");
                    lstInstr.Items.Add("Detailed Project Schedule Produced?");
                    lstInstr.Items.Add("Dependencies Identified and stated?");
                    lstInstr.Items.Add("Required Resources Identified?");
                    lstInstr.Items.Add("Quantities of Resources Identified?");
                    lstInstr.Items.Add("Detailed Resource Schedule Produced?");
                    lstInstr.Items.Add("Types of Financial Expenses Listed?");
                    lstInstr.Items.Add("Unit Costs of Resources Identified?");
                    lstInstr.Items.Add("Expense Schedule/Cashflow statement drawn up?");
                    lstInstr.Items.Add("Financial Process Defined?");
                    lstInstr.Items.Add("Quality Targets Defined?");
                    lstInstr.Items.Add("Quality Assurance Plan Drawn up?");
                    lstInstr.Items.Add("Quality Control Plan Drawn Up?");
                    lstInstr.Items.Add("Quality Management Process Defined?");
                    lstInstr.Items.Add("Risks Identified?");
                    lstInstr.Items.Add("Risks Quantified?");
                    lstInstr.Items.Add("Risks Prioritised?");
                    lstInstr.Items.Add("Risk Schedule Produced?");
                    lstInstr.Items.Add("Risk Management Process Defined?");
                    lstInstr.Items.Add("Identification of Acceptance Criteria?");
                    lstInstr.Items.Add("Acceptance Schedule Produced?");
                    lstInstr.Items.Add("Acceptance Management Process Defined?");
                    lstInstr.Items.Add("Stakeholders Identified?");
                    lstInstr.Items.Add("Communications Requirements Listed?");
                    lstInstr.Items.Add("Communications Schedule Produced?");
                    lstInstr.Items.Add("Communications Management Process Defined?");
                    lstInstr.Items.Add("Procurement Requirements Determined?");
                    lstInstr.Items.Add("Market Research into Offerings Conducted? (Buy VS Make Decision)");
                    lstInstr.Items.Add("Procurement Schedule Produced?");
                    lstInstr.Items.Add("Procurement Management Process Defined?");
                    pboTender.Visible = false;
                    break;
                default:
                    lstInstr.Items.Clear();
                    break;
            }
        }

        public void secButton(int button)
        {
            //switch for sec button

            switch (button)
            {
                //Identify required resources
                case 1:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Define the following");
                    lstInstr.Items.Add(" *resources required for the execution of the task");
                    lstInstr.Items.Add(" *Requirements of the resource identified to execute the task");
                    lstInstr.Items.Add(" *Level of effort required from the resource");
                    pboTender.Visible = false;
                    break;
                //Quantify the resources required
                case 2:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Labour");
                    lstInstr.Items.Add(" *Role                 *Number");
                    lstInstr.Items.Add(" *Responsibilities     *Skills");
                    lstInstr.Items.Add(" *Start Date           *End Date");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Equipment");
                    lstInstr.Items.Add(" *Item                 *Amount");
                    lstInstr.Items.Add(" *Purpose              *Specification");
                    lstInstr.Items.Add(" *Start Date           *End Date");
                    pboTender.Visible = false;
                    break;
                //Quantify the financial expenses
                case 3:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Forecast Unit Costs of Expenses as categorised i.e:");
                    lstInstr.Items.Add(" *Labour rate per hour");
                    lstInstr.Items.Add(" *Rental Cost per period");
                    lstInstr.Items.Add(" *Materials per Quantity");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Note:");
                    lstInstr.Items.Add("This can also be called Estimating or in more technical projects Cost Engineering");
                    pboTender.Visible = false;
                    break;
                //Define quality targets
                case 4:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Set Clear Quality Targets to be Achieved in the Project:");
                    lstInstr.Items.Add(" *Requirements         *Deliverables");
                    lstInstr.Items.Add(" *Quality Criteria     *Quality Standards");
                    pboTender.Visible = false;
                    break;
                //Identify the communications requirements
                case 5:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Identify Communications Requirements according to:");
                    lstInstr.Items.Add(" *Stakeholder Name           *Stakeholder Role");
                    lstInstr.Items.Add(" *Stakeholder Organisation   *Information Requirement");
                    lstInstr.Items.Add(" *Message Content            *Medium of Communication");
                    pboTender.Visible = false;
                    break;
                //Create an acceptance schedule
                case 6:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Schedule Acceptance Tests");
                    lstInstr.Items.Add(" *Deliverable");
                    lstInstr.Items.Add(" *Completion Date");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Acceptance Test");
                    lstInstr.Items.Add("Acceptance Test Method");
                    lstInstr.Items.Add("Testers");
                    lstInstr.Items.Add("Test Date");
                    pboTender.Visible = false;
                    break;
                //Quantify the risks
                case 7:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Quantify Likelihood");
                    lstInstr.Items.Add(" *Title                     *Score");
                    lstInstr.Items.Add(" *Description               *Assess cross impacts");
                    lstInstr.Items.Add(" *Rate the likelihood of occurrence");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Assign a priority");
                    lstInstr.Items.Add(" *Risk ID                   *Likelihood Score");
                    lstInstr.Items.Add(" *Impact Score              *Priority Score");
                    lstInstr.Items.Add(" *Priority Rating");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Quantify Impact");
                    lstInstr.Items.Add(" *Title                     *Score");
                    lstInstr.Items.Add(" *Description");
                    pboTender.Visible = false;
                    break;
                //Research market offerings 
                case 8:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Research the market segment");
                    lstInstr.Items.Add("What is the size of the relevant market segment?");
                    lstInstr.Items.Add("How many suppliers operate within this segment?");
                    lstInstr.Items.Add("Which suppliers have the largest market segment?");
                    lstInstr.Items.Add("Which suppliers have the largest market share?");
                    lstInstr.Items.Add("How many suppliers offer the required items?");
                    lstInstr.Items.Add("Timeliness & availability within the project schedule?");
                    lstInstr.Items.Add("Risk Associated with a particular supplier?");
                    pboTender.Visible = false;
                    break;
                //Undertake phase review
                case 9:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Approved Project Plan");
                    lstInstr.Items.Add("Approved Resources Plan");
                    lstInstr.Items.Add("Approved Financial Plan");
                    lstInstr.Items.Add("Approved Quality Plan");
                    lstInstr.Items.Add("Approved Risk Plan");
                    lstInstr.Items.Add("Approved Acceptance Plan");
                    lstInstr.Items.Add("Approved Communications Plan");
                    lstInstr.Items.Add("Approved Tendering Process");
                    lstInstr.Items.Add("Approved Statement  of Work Documentation (SOW)");
                    lstInstr.Items.Add("Approved Request for Information Documentation (RFI)");
                    lstInstr.Items.Add("Approved Request for Proposal Documentation (RFP)");
                    lstInstr.Items.Add("Approved Contracting Types (FIDIC or NEC)");
                    lstInstr.Items.Add("Contracts placed on Suppliers");
                    lstInstr.Items.Add("Summary");
                    lstInstr.Items.Add("Is the Project Currently on Schedule?");
                    lstInstr.Items.Add("Is the Project Currently within Budget?");
                    lstInstr.Items.Add("Any Critical Project Risks");
                    lstInstr.Items.Add("Any High Priority Issues");
                    lstInstr.Items.Add("Substantial Changes?");
                    pboTender.Visible = false;
                    break;
                default:
                    lstInstr.Items.Clear();
                    break;
            }
        }

        public void thirdButton(int button)
        {
            //switch for third button

            switch (button)
            {
                //Construct a project schedule
                case 1:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("-List the Phases");
                    lstInstr.Items.Add("-List the Activities");
                    lstInstr.Items.Add("Use a Scheduling Programme i.e. MS Projects, Primavera etc.");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Determinedependencies of Tasks");
                    lstInstr.Items.Add(" *Finish to Start               *Finish to Finish");
                    lstInstr.Items.Add(" *Start to Start                *Start to Finish");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("List Assumptions Made During Planning i.e.:");
                    lstInstr.Items.Add(" *Resources are available       *Changes in Scope");
                    lstInstr.Items.Add(" *Funding is available          *Etc.");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("List Constraints During Planning i.e.:");
                    lstInstr.Items.Add(" *Time                          *Costs/Budget");
                    lstInstr.Items.Add(" *Resource Availability         *Etc. ");
                    pboTender.Visible = false;
                    break;
                //Construct a resource schedule
                case 2:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Schedule the resources according to when they are needed");
                    lstInstr.Items.Add("List Assumptions Made During Planning i.e.:");
                    lstInstr.Items.Add(" *Resources are available       *Changes in Scope");
                    lstInstr.Items.Add(" *Funding is available          *Etc.");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Materials");
                    lstInstr.Items.Add(" *Item                          *Amount");
                    lstInstr.Items.Add(" *Purpose                       *Specification");
                    lstInstr.Items.Add(" *Start Date                    *End Date");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("List Constraints During Planning i.e.:");
                    lstInstr.Items.Add(" *Time                          *Costs/Budget");
                    lstInstr.Items.Add(" *Resource Availability         *Etc.");
                    pboTender.Visible = false;
                    break;
                //Construct a cashflow schedule
                case 3:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Schedule the flow of Funds in Accordance with the required payment times as well as time frame during which required");
                    lstInstr.Items.Add("List Constraints During Planning i.e.:");
                    lstInstr.Items.Add(" *Time                          *Costs/Budget");
                    lstInstr.Items.Add(" *Resource Availability         *Etc.");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("List Assumptions Made During Planning i.e.:");
                    lstInstr.Items.Add(" *Resources are available       *Changes in Scope");
                    lstInstr.Items.Add(" *Funding is available          *Etc.");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Define the Financial Management Process");
                    lstInstr.Items.Add(" *Purpose of the Process");
                    lstInstr.Items.Add(" *Steps Involved in Undertaking the Process");
                    lstInstr.Items.Add(" *Roles & Responsibilities involved  in Undertaking the Process");
                    lstInstr.Items.Add(" *Templates used to support the process");
                    lstInstr.Items.Add(" *Tools Used in Executing the Process");
                    pboTender.Visible = false;
                    break;
                //Create a quality assurance plan
                case 4:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Identify Quality Assurance Techniques i.e.:");
                    lstInstr.Items.Add(" *Quality Reviews");
                    lstInstr.Items.Add("*Review by External Resources");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Determine Overall Project Performance");
                    lstInstr.Items.Add("Determine Overall Project Conformance");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Identify Methodologies");
                    lstInstr.Items.Add(" *Techniques");
                    lstInstr.Items.Add(" *Frequencies");
                    lstInstr.Items.Add(" *Descriptions");
                    pboTender.Visible = false;
                    break;
                //Construct a communications schedule
                case 5:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Construct the Communication Schedule according to:");
                    lstInstr.Items.Add(" *Stakeholder Name              *Stakeholder Role");
                    lstInstr.Items.Add(" *Stakeholder Organisation      *Information Requirement");
                    lstInstr.Items.Add(" *Message Content               *Medium of Communication");
                    lstInstr.Items.Add(" *Frequency of Communications need");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Define the Communication Process");
                    lstInstr.Items.Add("Purpose of the Process");
                    lstInstr.Items.Add("Steps Involved in Undertaking the Process");
                    lstInstr.Items.Add("Roles & Responsibility Involved in Undertaking the Process");
                    lstInstr.Items.Add("Templates used to support the process");
                    lstInstr.Items.Add("Tools used in executing the process");
                    pboTender.Visible = false;
                    break;
                //Create a risk schedule
                case 7:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Risk Management Schedule        Risk Rating");
                    lstInstr.Items.Add("Risk ID                         Preventative Actions");
                    lstInstr.Items.Add("Resources to take action        Action Date");
                    lstInstr.Items.Add("Contingent Actions              Resources to take action");
                    lstInstr.Items.Add("Action Date");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Define the Risk Management Process");
                    lstInstr.Items.Add("Purpose of the Process");
                    lstInstr.Items.Add("Steps involved in undertaking the process");
                    lstInstr.Items.Add("Roles & responsibilities involved in undertaking the process");
                    lstInstr.Items.Add("Templates used to support the process");
                    lstInstr.Items.Add("Tools used in executing the process");
                    pboTender.Visible = false;
                    break;
                //Create a procurement schedule
                case 8:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Produce a Tender/Tendering Process");
                    lstInstr.Items.Add("Issue RFI");
                    lstInstr.Items.Add("Document Statement of Work (SOW)");
                    lstInstr.Items.Add("Document Request for Information (RFI)");
                    lstInstr.Items.Add("Release Tender Documents");
                    lstInstr.Items.Add("Receive & Evaluate Tender Documents");
                    lstInstr.Items.Add("Rank & Select Tenderers & Shortlist");
                    lstInstr.Items.Add("Notify All Participants in Tendering Process");
                    lstInstr.Items.Add("Issue RFP");
                    lstInstr.Items.Add("Update SOW");
                    lstInstr.Items.Add("Document request for Proposal (RFP)");
                    lstInstr.Items.Add("Release Tender Documents (RFP & SOW)");
                    lstInstr.Items.Add("Receive & Evaluate Tender Responses");
                    lstInstr.Items.Add("Select Preferred Tenderer");
                    lstInstr.Items.Add("Notify All Participants in Tendering Process");
                    lstInstr.Items.Add("Issue Contract in Accordance with Selected Contracting Strategy & Types");
                    pboTender.Visible = false;
                    break;
                //Seek approval to proceed
                case 9:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Complete Phase Review Form");
                    lstInstr.Items.Add(" *Initiation");
                    lstInstr.Items.Add(" *Planning");
                    lstInstr.Items.Add(" *Execution");
                    lstInstr.Items.Add(" *Closure");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Project Board");
                    lstInstr.Items.Add(" *Approve Project to Proceed");
                    lstInstr.Items.Add(" *Request additional information or activities undertaken");
                    lstInstr.Items.Add(" *Delay, Transfer or Cancel the Project");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Project Manager");
                    lstInstr.Items.Add(" *Present Phase Review Form");
                    lstInstr.Items.Add(" *Discuss current status");
                    lstInstr.Items.Add(" *Present Vision, Objectives, Scope & Deliverables");
                    lstInstr.Items.Add(" *Deliverables completed to date");
                    lstInstr.Items.Add(" *Schedule Progress");
                    lstInstr.Items.Add(" *Deviation From:");
                    lstInstr.Items.Add("   -Time         -Scope");
                    lstInstr.Items.Add("   -Cost         -Quality");
                    lstInstr.Items.Add("   -Key Issues   -Key Risks");
                    pboTender.Visible = false;
                    break;
                default:
                    lstInstr.Items.Clear();
                    break;
            }

        }

        public void fourthButton(int button)
        {
            //switch for fourth button

            switch (button)
            {
                //Create a quality control plan
                case 4:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Identify Quality Control Techniques i.e.:");
                    lstInstr.Items.Add(" *Peer Reviews");
                    lstInstr.Items.Add(" *Deliverable Reviews");
                    lstInstr.Items.Add(" *Documentation Reviews");
                    lstInstr.Items.Add(" *Phase Reviews");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Define the Quality Management Process");
                    lstInstr.Items.Add(" *Purpose of the Process");
                    lstInstr.Items.Add(" *Steps Involved in Undertaking the Process");
                    lstInstr.Items.Add(" *Roles & Responsibilities Involved in Undertaking the Process");
                    lstInstr.Items.Add(" *Templates Used to Support the Process");
                    lstInstr.Items.Add(" *Tools Used in Executing the Process");
                    pboTender.Visible = false;
                    break;
                //Define procurement roles
                case 8:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Product Manager:");
                    lstInstr.Items.Add(" *Approving the SOW");
                    lstInstr.Items.Add(" *Monitors & Evaluates Processes");
                    lstInstr.Items.Add(" *Selects Preffered Supplier");
                    lstInstr.Items.Add(" *Resolves Contractual Issues & Authorises Final Supplier Contract");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Procurement Manager:");
                    lstInstr.Items.Add(" *Creating the SOW, RFI, RFP");
                    lstInstr.Items.Add(" *Obtaining Approval for Pre-Tender Document Release");
                    lstInstr.Items.Add(" *Collating Responses");
                    lstInstr.Items.Add(" *Organising Tender Evaluation Process");
                    lstInstr.Items.Add(" *Co-Select Preferred Suppliers");
                    lstInstr.Items.Add(" *Notify Unsuccessful Applicants");
                    lstInstr.Items.Add(" *Documenting Supplier Contracts");
                    lstInstr.Items.Add(" *Leading Supplier Negotiations");
                    lstInstr.Items.Add(" *Maintaining the Tender Register");
                    pboTender.Visible = false;
                    break;
                default:
                    lstInstr.Items.Clear();
                    break;

            }
        }

        public void fifthButton(int button)
        {
            //switch for fifth button

            switch (button)
            {
                //Define the tendering process
                case 8:
                    lstInstr.Items.Clear();
                    
                    pboTender.Visible = true;
                    break;
            }
        }

        public void sixthButton(int button)
        {
            //switch for sixth button

            switch (button)
            {
                //Contract with the supplier
                case 8:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Negotiate the Supplier Contract");
                    lstInstr.Items.Add(" *Get agreement on mutually accepted terms");
                    lstInstr.Items.Add("Document the Supplier Contract");
                    lstInstr.Items.Add(" *Draft agreement & present to supplier");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Contract is the Basis for:");
                    lstInstr.Items.Add(" *Relationship between Supplier & Project Team");
                    lstInstr.Items.Add(" *Performance Measurement");
                    lstInstr.Items.Add(" *Dispute Resolution");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Specifies:");
                    lstInstr.Items.Add(" *Deliverables");
                    lstInstr.Items.Add(" *Responsibilities");
                    lstInstr.Items.Add(" *Terms & Conditions of Procurement");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Sign the Supplier Contract");
                    lstInstr.Items.Add(" *The contract gets signed as a sign of mutual agreement between the parties");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Administer & Follow up on Supplier Contracts");
                    lstInstr.Items.Add(" *Performs contract administration in accordance with type of control selected as well as milestones, deliverable and performance criteria");
                    pboTender.Visible = false;
                    break;
            }
        }

        #endregion

        /// <summary>
        /// Planning panel - all phases showcased
        /// </summary>
        #region Planning

        /// <summary>
        /// Descriptions with hover
        /// </summary>
        #region Hover

        private void btnProjectPlan_MouseHover(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
            lstInfo.Items.Add("The first step is to document the Project Plan. A ‘Work Breakdown Structure’ (WBS) is identified, which includes a hierarchical set of phases,");
            lstInfo.Items.Add("activities and tasks to be undertaken on the project. After the WBS has been agreed, an assessment of the effort required to undertake the ");
            lstInfo.Items.Add("activities and tasks is made. The activities and tasks are sequenced, resources are allocated and a detailed project schedule is formed.");
            lstInfo.Items.Add("This project schedule will become the primary tool for the Project Manager to assess the progress of the project.");
        }

        private void btnResPlan_MouseHover(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
            lstInfo.Items.Add("Immediately after the Project Plan is formed, it is necessary to allocate the resources required to undertake each of the activities");
            lstInfo.Items.Add("and tasks within the Project Plan. Although general groups of resources may have already been allocated to the Project Plan, a");
            lstInfo.Items.Add("detailed resource assessment is required to identify the:");
            lstInfo.Items.Add(" *Types of resources (labor, equipment and materials)");
            lstInfo.Items.Add(" *Total quantities of each resource type");
            lstInfo.Items.Add(" *Roles, responsibilities and skill-sets of all human resources");
            lstInfo.Items.Add(" *Items, purposes and specifications of all equipment resource");
            lstInfo.Items.Add(" *Items and quantities of material resource.");
            lstInfo.Items.Add(" *A schedule is assembled for each type of resource so that the Project Manager can assess the resource allocation at each stage in the project.");
        }

        private void btnFinPlan_MouseHover(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
            lstInfo.Items.Add("A Financial Plan is prepared to identify the quantity of money required for each stage in the project.");
            lstInfo.Items.Add("The total cost of labor, equipment and materials is quantified and an expense schedule is defined which provides the Project Manager");
            lstInfo.Items.Add("with an understanding of the forecast spending vs. the actual spending throughout the project. Preparing a detailed Financial Plan is");
            lstInfo.Items.Add("extremely important as the project’s success will depend on whether or not it is delivered within the ‘time, cost and quality’");
            lstInfo.Items.Add("estimates for this project.");
        }

        private void btnQualPlan_MouseHover(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
            lstInfo.Items.Add("*Defines what quality means in terms of this project");
            lstInfo.Items.Add("*Lists clear and unambiguous quality targets for each deliverable. Each quality target provides a set of criteria and standards which");
            lstInfo.Items.Add(" must be achieved to meet the expectations of the customer");
            lstInfo.Items.Add("*Outlines a plan of activities which will assure the customer that the quality targets will be met (i.e. a Quality Assurance Plan)");
            lstInfo.Items.Add("Identifies the techniques used to control the actual level of quality of each deliverable as it is built");
        }

        private void btnComPlan_MouseHover(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
            lstInfo.Items.Add("Prior to the Execution phase, it is also necessary to identify how each of the stakeholders will be kept");
            lstInfo.Items.Add("informed of the progress of the project. The Communications Plan identifies the types of information to");
            lstInfo.Items.Add("be distributed, the methods of distributing information to stakeholders, the frequency of distribution and");
            lstInfo.Items.Add("responsibilities of each person in the project team for distributing information regularly to stakeholders.");
        }

        private void btnAccPlan_MouseHover(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
            lstInfo.Items.Add("The key to a successful project is gaining acceptance from the customer that each deliverable produced");
            lstInfo.Items.Add("meets (or exceeds) his/her requirements. To clarify the criteria used to judge each deliverable for");
            lstInfo.Items.Add("customer acceptance, an Acceptance Plan is produced. The Acceptance Plan provides the criteria for");
            lstInfo.Items.Add("obtaining customer acceptance, a schedule of acceptance reviews within which customer acceptance will");
            lstInfo.Items.Add("be sought and a summary of the process used to gain acceptance of each deliverable from the customer.");
        }

        private void btnRiskPlan_MouseHover(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
            lstInfo.Items.Add("The foreseeable project risks are then documented within a Risk Plan and a set of actions to be taken");
            lstInfo.Items.Add("formulated to both prevent each risk from occurring and reduce the impact of the risk should it eventuate.");
            lstInfo.Items.Add("Developing a clear Risk Plan is an important activity within the planning phase as it is necessary to");
            lstInfo.Items.Add("mitigate all critical project risks prior to entering the Execution phase of the project.");
        }

        private void btnProcPlan_MouseHover(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
            lstInfo.Items.Add("The last planning activity within the Planning phase is to identify the elements of the Project which will be");
            lstInfo.Items.Add("acquired from external suppliers to the project. The Procurement Plan provides a detailed description of");
            lstInfo.Items.Add("the Products (i.e. goods and services) to be procured from suppliers, the justification for procuring each");
            lstInfo.Items.Add("product externally, as opposed to from within the business, and the schedule for procurement. It also");
            lstInfo.Items.Add("references the process for the selection of a preferred supplier (“Tender Process”) and the process for");
            lstInfo.Items.Add("the actual order and delivery of the procured products (“Procurement Process”).");
        }

        private void btnPRev_MouseHover(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
            lstInfo.Items.Add("At the end of the Initiation Phase, a Phase review is performed. This is basically a checkpoint to ensure");
            lstInfo.Items.Add("that the project has achieved its stated objectives as planned. ");
        }

        #endregion

        /// <summary>
        /// Descriptions hidden when mouse moves
        /// </summary>
        #region MouseLeave

        private void btnProjectPlan_MouseLeave(object sender, EventArgs e)
        {

            lstInfo.Items.Clear();
        }

        private void btnResPlan_MouseLeave(object sender, EventArgs e)
        {

            lstInfo.Items.Clear();
        }

        private void btnFinPlan_MouseLeave(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
        }

        private void btnQualPlan_MouseLeave(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
        }

        private void btnComPlan_MouseLeave(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
        }

        private void btnAccPlan_MouseLeave(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
        }

        private void btnRiskPlan_MouseLeave(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
        }

        private void btnProcPlan_MouseLeave(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
        }

        private void btnPRev_MouseLeave(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
        }

        #endregion

        /// <summary>
        /// All button events
        /// </summary>
        #region onClick

        private void btnProjectPlan_Click(object sender, EventArgs e)
        {
            projectPlan();
            showInstructions();
        }

        private void btnResPlan_Click(object sender, EventArgs e)
        {
            resourcePlan();
            showInstructions();
        }

        private void btnFinPlan_Click(object sender, EventArgs e)
        {
            financialPlan();
            showInstructions();
        }

        private void btnQualPlan_Click(object sender, EventArgs e)
        {
            qualityPlan();
            showInstructions();
        }

        private void btnComPlan_Click(object sender, EventArgs e)
        {
            communicationsPlan();
            showInstructions();
        }

        private void btnAccPlan_Click(object sender, EventArgs e)
        {
            acceptancePlan();
            showInstructions();
        }

        private void btnRiskPlan_Click(object sender, EventArgs e)
        {
            riskPlan();
            showInstructions();
        }

        private void btnProcPlan_Click(object sender, EventArgs e)
        {
            procurementPlan();
            showInstructions();
        }

        private void btnPRev_Click(object sender, EventArgs e)
        {
            phaseReview();
            showInstructions();
        }

        #endregion

        #endregion

        /// <summary>
        /// On click for pnlInstr
        /// </summary>
        #region Instructions planning

        private void btnPPLan_Click(object sender, EventArgs e)
        {
            projectPlan();

        }

        private void btnRPlan_Click(object sender, EventArgs e)
        {
            resourcePlan();
        }

        private void btnFPlan_Click(object sender, EventArgs e)
        {
            financialPlan();        
        }

        private void btnQPlan_Click(object sender, EventArgs e)
        {
            qualityPlan();  
        }

        private void btnCPlan_Click(object sender, EventArgs e)
        {
            communicationsPlan();                   
        }

        private void btnAPlan_Click(object sender, EventArgs e)
        {
            acceptancePlan();
                       
        }

        private void btnRisk_Click(object sender, EventArgs e)
        {
            riskPlan();
                       
        }

        private void btnProc_Click(object sender, EventArgs e)
        {
            procurementPlan();
                        
        }

        private void btnPhase_Click(object sender, EventArgs e)
        {
            phaseReview();
                     
        }

        //back button
        private void btnHide_Click(object sender, EventArgs e)
        {
            pnlInstr.Hide();
            pnlPlanning.Visible = true;

            lstInfo.Items.Clear();
            lstInfo.Items.Add("Once the scope of the project has been defined in the Project Charter, the project enters the detailed");
            lstInfo.Items.Add("planning phase.This involves the creation of a:");
            lstInfo.Items.Add("");
            lstInfo.Items.Add("* Project Plan(outlining the activities, tasks, dependencies and timeframes)");
            lstInfo.Items.Add("* Resource Plan(listing the labour, equipment and materials required)");
            lstInfo.Items.Add("* Financial Plan(identifying the labour, equipment and materials costs)");
            lstInfo.Items.Add("* Quality Plan(providing quality targets, assurance and control measures)");
            lstInfo.Items.Add("* Risk Plan(highlighting potential risks and actions taken to mitigate them)");
            lstInfo.Items.Add("* Acceptance Plan(listing the criteria to be met to gain customer acceptance)");
            lstInfo.Items.Add("* Communications Plan(listing the information needed to inform stakeholders)");
            lstInfo.Items.Add("* Procurement Plan(identifying products to be sourced from external suppliers)");
            lstInfo.Visible = true;
            pboTender.Visible = false;

            btnViewProjectPlan.Visible = false;
            btnViewResPlan.Visible = false;
            btnViewFinPlan.Visible = false;
            btnViewQPlan.Visible = false;
            btnViewComPlan.Visible = false;
            btnViewAPlan.Visible = false;
            btnViewRiskPlan.Visible = false;
            btnViewProcPlan.Visible = false;
            btnViewPhaseRev.Visible = false;
        }

        //Side menu
        private void btnFirst_Click(object sender, EventArgs e)
        {
            firstButton(first);

            
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            secButton(second);
        }

        private void btnThird_Click(object sender, EventArgs e)
        {
            thirdButton(third);
        }

        private void btnFourth_Click(object sender, EventArgs e)
        {
            fourthButton(fourth);
        }

        private void btnFifth_Click(object sender, EventArgs e)
        {
            fifthButton(fifth);
        }

        private void btnSixth_Click(object sender, EventArgs e)
        {
            sixthButton(sixth);
        }


        #endregion

        private void btnViewProjectPlan_Click(object sender, EventArgs e)
        {
            string filename = "Project_Plan.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void btnViewResPlan_Click(object sender, EventArgs e)
        {
            string filename = "Resource_Plan.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void btnViewFinPlan_Click(object sender, EventArgs e)
        {
            string filename = "Financial_Plan.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void btnViewQPlan_Click(object sender, EventArgs e)
        {
            string filename = "Quality_Plan.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void btnViewComPlan_Click(object sender, EventArgs e)
        {
            string filename = "Communications_Plan.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void btnViewAPlan_Click(object sender, EventArgs e)
        {
            string filename = "Acceptance_Plan.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void btnViewRiskPlan_Click(object sender, EventArgs e)
        {
            string filename = "Risk_Form.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void btnViewPhaseRev_Click(object sender, EventArgs e)
        {
            string filename = "Phase_Review_Form_Planning.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void btnViewProcPlan_Click(object sender, EventArgs e)
        {
            string filename = "Procurement_Plan.pdf";
            System.Diagnostics.Process.Start(filename);
        }
    }
}