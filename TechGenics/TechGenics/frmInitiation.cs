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

         private void frmInitiation_Load(object sender, EventArgs e)
        {
            pnlInitiation.BringToFront();
        }

        /// <summary>
        /// Functions to display info
        /// </summary>
        #region Functions

        public void businessCase()
        {
            //button visibility
            btnFirst.Visible = true;
            btnSec.Visible = true;
            btnThird.Visible = true;
            btnFourth.Visible = false;
            btnFifth.Visible = false;

            //button text
            btnFirst.Text = "Identify the business problem";
            btnSec.Text = "Solution development";
            btnThird.Text = "Implementation approach";

            first = 1;
            second = 1;
            third = 1;

            lstInstr.Items.Clear();

            btnViewBusCase.Visible = true;
            btnViewFeasStudy.Visible = false;
            btnViewCharter.Visible = false;
            btnViewTeam.Visible = false;
            btnViewOffice.Visible = false;
            btnViewPhase.Visible = false;
        }

        public void feasibilityStudy()
        {
            //button visibility
            btnFirst.Visible = true;
            btnSec.Visible = true;
            btnThird.Visible = true;
            btnFourth.Visible = true;
            btnFifth.Visible = true;

            //button text
            btnFirst.Text = "Research the business problem";
            btnSec.Text = "Identify requirements";
            btnThird.Text = "Feasibility of alternative solutions";
            btnFourth.Text = "Rank feasibility results";
            btnFifth.Text = "Identify best alternative";

            first = 2;
            second = 2;
            third = 2;

            lstInstr.Items.Clear();

            btnPrev.Visible = false;
            btnNext.Visible = false;

            btnViewBusCase.Visible = false;
            btnViewFeasStudy.Visible = true;
            btnViewCharter.Visible = false;
            btnViewTeam.Visible = false;
            btnViewOffice.Visible = false;
            btnViewPhase.Visible = false;
        }

        public void projectCharter()
        {
            //button visibility
            btnFirst.Visible = true;
            btnSec.Visible = true;
            btnThird.Visible = true;
            btnFourth.Visible = false;
            btnFifth.Visible = false;

            //button text
            btnFirst.Text = "Identify the project vision";
            btnSec.Text = "Describe the Project Organization";
            btnThird.Text = "{Plan the approach to implementation";

            first = 3;
            second = 3;
            third = 3;

            lstInstr.Items.Clear();

            btnPrev.Visible = false;
            btnNext.Visible = false;

            btnViewBusCase.Visible = false;
            btnViewFeasStudy.Visible = false;
            btnViewCharter.Visible = true;
            btnViewTeam.Visible = false;
            btnViewOffice.Visible = false;
            btnViewPhase.Visible = false;
        }

        public void projectTeam()
        {
            //button visibility
            btnFirst.Visible = true;
            btnSec.Visible = true;
            btnThird.Visible = true;
            btnFourth.Visible = false;
            btnFifth.Visible = false;

            //button text
            btnFirst.Text = "List the Project Roles";
            btnSec.Text = "Define Roles and Responsibilities";
            btnThird.Text = "Identify the Recruitment Process";

            first = 4;
            second = 4;
            third = 4;

            lstInstr.Items.Clear();

            btnPrev.Visible = false;
            btnNext.Visible = false;

            btnViewBusCase.Visible = false;
            btnViewFeasStudy.Visible = false;
            btnViewCharter.Visible = false;
            btnViewTeam.Visible = true;
            btnViewOffice.Visible = false;
            btnViewPhase.Visible = false;
        }

        public void projectOffice()
        {
            //button visibility
            btnFirst.Visible = true;
            btnSec.Visible = true;
            btnThird.Visible = true;
            btnFourth.Visible = false;
            btnFifth.Visible = false;

            //button text
            btnFirst.Text = "Define the role of the Project Office";
            btnSec.Text = "Resource & Locate the Project Office";
            btnThird.Text = "Create the tools to run the Project Office";

            first = 5;
            second = 5;
            third = 5;

            lstInstr.Items.Clear();

            btnPrev.Visible = false;
            btnNext.Visible = false;

            btnViewBusCase.Visible = false;
            btnViewFeasStudy.Visible = false;
            btnViewCharter.Visible = false;
            btnViewTeam.Visible = false;
            btnViewOffice.Visible = true;
            btnViewPhase.Visible = false;
        }

        public void phaseReview()
        {
            //button visibility
            btnFirst.Visible = true;
            btnSec.Visible = true;
            btnThird.Visible = false;
            btnFourth.Visible = false;
            btnFifth.Visible = false;

            //button text
            btnFirst.Text = "Identify Phase Review Criteria";
            btnSec.Text = "Undertake Phase Review";

            first = 6;
            second = 6;

            lstInstr.Items.Clear();

            btnViewBusCase.Visible = false;
            btnViewFeasStudy.Visible = false;
            btnViewCharter.Visible = false;
            btnViewTeam.Visible = false;
            btnViewOffice.Visible = false;
            btnViewPhase.Visible = true;
        }

        public void showInstructions()
        {
            pnlInitiation.Visible = false;
            pnlInstr.Visible = true;
            pnlInstr.BringToFront();
        }

        #endregion

        /// <summary>
        /// Variables for switch
        /// </summary>
        #region Variables
        int first = 0;      //btnFirst
        int second = 0;     //btnSec
        int third = 0;      //btnThird
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
                case 1:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Identify The Root Cause for the need for the project as changes to:");
                    lstInstr.Items.Add(" *Business Vision, Strategy, Objetives");
                    lstInstr.Items.Add(" *Newly identified competing products or processes");
                    lstInstr.Items.Add(" *Opportunities resulting from newly introduced technologies");
                    lstInstr.Items.Add(" *Commercial and operational trends that are driving business changes");
                    lstInstr.Items.Add(" *Changes to statutory, legislative or other environmental requirements");
                    break;
                case 2:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Research the Problem");
                    lstInstr.Items.Add(" *Data Collection");
                    lstInstr.Items.Add(" *Data Analysis");
                    lstInstr.Items.Add(" *Identify Contributing Factors");
                    lstInstr.Items.Add(" *Identify the Root Cause");
                    break;
                case 3:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Develop Project Objectives \n *SMART");
                    lstInstr.Items.Add("Identify Deliverables \n *Identify/Define Milestones");
                    lstInstr.Items.Add("Develop Project Scope");
                    break;
                case 4:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add(" *Project Sponsor           *Project Board");
                    lstInstr.Items.Add(" *Project Administrator     *Quality Manager");
                    lstInstr.Items.Add(" *Procurement Manager       *Communications Manager");
                    lstInstr.Items.Add(" *Project Office Manager    *Team Member");
                    break;
                case 5:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add(" *Time management           *Cost Management");
                    lstInstr.Items.Add(" *Change Management         *Risk Management");
                    lstInstr.Items.Add(" *Issue Management          *Procurement Management");
                    lstInstr.Items.Add(" *Acceptance Management     *Communications Management");
                    lstInstr.Items.Add(" *Phase Reviews");
                    lstInstr.Items.Add("Auditing & Compliance");
                    lstInstr.Items.Add("Supporting Staff");
                    lstInstr.Items.Add("Providing Tools");
                    lstInstr.Items.Add("Documentation Management");
                    lstInstr.Items.Add("General Administration");
                    lstInstr.Items.Add("Undertake Closure Reviews");
                    lstInstr.Items.Add(" *Time Management");
                    break;
                case 6:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Activities:");
                    lstInstr.Items.Add(" *Business Vision, Strategy, Objectives");
                    lstInstr.Items.Add(" *Newly Identified Competing Products or processes");
                    lstInstr.Items.Add(" *Opportunities resulting form newly introduced technologies");
                    lstInstr.Items.Add(" *Commercial and operational trends that are driving business changes");
                    lstInstr.Items.Add(" *Changes to statutory, legislative or other environmental requirements");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Deliverables:");
                    lstInstr.Items.Add(" *Quantify Benefits");
                    lstInstr.Items.Add(" *Assess Feasibility");
                    lstInstr.Items.Add(" *Forecast Associated costs");
                    lstInstr.Items.Add(" *Identify Associated Risks");
                    lstInstr.Items.Add(" *Document Possible Issues");
                    lstInstr.Items.Add(" *List Assumptions");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Summary");
                    lstInstr.Items.Add("Rate the alternative solutions");
                    lstInstr.Items.Add("Identify the Recommended Solution");
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
                case 1:
                    btnNext.Visible = false;

                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Develop list of alternatives");
                    lstInstr.Items.Add(" *Quantify Benefits");
                    lstInstr.Items.Add(" *Assess Feasibility");
                    lstInstr.Items.Add(" *Forecast Associated costs");
                    lstInstr.Items.Add(" *Identify Associated Risks");
                    lstInstr.Items.Add(" *Document Possible Issues");
                    lstInstr.Items.Add(" *List Assumptions");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Recommend Possible  Preferred Solutions");
                    lstInstr.Items.Add(" *Rate the alternative solutions");
                    lstInstr.Items.Add(" *Identify the Recommended Possible Solutions");
                    break;
                case 2:
                    btnNext.Visible = false;

                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("List the key business drivers");
                    lstInstr.Items.Add(" *Changes in PESTE");
                    lstInstr.Items.Add(" *A Competitive Advantage");
                    lstInstr.Items.Add("*A Business Plan Milestone");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Define the Business Requirements");
                    lstInstr.Items.Add(" *New Technology Development");
                    lstInstr.Items.Add(" *New Processes/Procedures");
                    lstInstr.Items.Add(" *New Products or Services");
                    break;
                case 3:
                    btnNext.Visible = false;

                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Customers");
                    lstInstr.Items.Add("Identify Roles and Responsibilities");
                    lstInstr.Items.Add(" *Draft PARICS Chart");
                    lstInstr.Items.Add(" *Define Who does What When");
                    lstInstr.Items.Add("Stakeholders");
                    lstInstr.Items.Add("Identify Responsibilities");
                    lstInstr.Items.Add("Develop Project Organizational Structure");
                    break;
                case 4:
                    btnNext.Visible = false;

                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Project Sponsor");
                    lstInstr.Items.Add("Project Board");
                    lstInstr.Items.Add("Project Manager");
                    lstInstr.Items.Add("Team Member");
                    lstInstr.Items.Add("Etc?");
                    lstInstr.Items.Add("List the following:");
                    lstInstr.Items.Add(" *General purpose of the role");
                    lstInstr.Items.Add(" *Detailed responsibilities");
                    lstInstr.Items.Add(" *Relationships to other roles in the organisation structure");
                    lstInstr.Items.Add(" *Skills, Experience and Qualifications");
                    lstInstr.Items.Add(" *Performance criteria");
                    lstInstr.Items.Add(" *General Work Environment");
                    lstInstr.Items.Add(" *Remunerations");
                    break;
                case 5:
                    btnNext.Visible = false;

                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Resource the Project Office");
                    lstInstr.Items.Add(" *Project Administrator");
                    lstInstr.Items.Add(" *Quality Manager");
                    lstInstr.Items.Add(" *Risk Manager");
                    lstInstr.Items.Add(" *Change Manager");
                    lstInstr.Items.Add(" *Procurement Manager");
                    lstInstr.Items.Add(" *Communications Manager");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Locate the Project Office");
                    lstInstr.Items.Add(" *Plan Physical Location and Acquire Office Space");
                    lstInstr.Items.Add(" *Create list of Office requirements");
                    lstInstr.Items.Add(" *Draft & Submit Office Budget");
                    lstInstr.Items.Add(" *Identify Physical Space Requirements & Premises");
                    lstInstr.Items.Add(" *Furniture Fitment");
                    lstInstr.Items.Add(" *Telecoms Fitment");
                    lstInstr.Items.Add(" *IT Infrastructure");
                    lstInstr.Items.Add(" *Access Control");
                    break;
                case 6:
                    btnNext.Visible = true;
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Project Manager");
                    lstInstr.Items.Add(" *Present Phase Review Form");
                    lstInstr.Items.Add(" *Discuss current status");
                    lstInstr.Items.Add(" *Present Vision, Objectives, Scope and deliverables");
                    lstInstr.Items.Add(" *Deliverables completed to date");
                    lstInstr.Items.Add(" *Schedule Progress");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Deviations form:");
                    lstInstr.Items.Add(" *Time      *Scope");
                    lstInstr.Items.Add(" *Cost      *Quality");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Key Issues");
                    lstInstr.Items.Add("Key risks");
                    break;
                default:
                    lstInstr.Items.Clear();
                    break;
            }
        }

        public void thirdButton(int button)
        {
            //switch for sec button

            switch (button)
            {
                case 1:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Project Phased Approach");
                    lstInstr.Items.Add(" *Initiation        *Planning");
                    lstInstr.Items.Add(" *Execution         *Closure");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Management Processes");
                    lstInstr.Items.Add(" *Time Management           *Cost Management");
                    lstInstr.Items.Add(" *Quality Management        *Change Management");
                    lstInstr.Items.Add(" *Risk Management           *Issue Management");
                    lstInstr.Items.Add(" *Procurement Management    *Communications Management");
                    lstInstr.Items.Add("Acceptance Management");
                    break;
                case 2:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Identify the potential Solutions");
                    lstInstr.Items.Add("Undertake the Assessment");
                    lstInstr.Items.Add(" *Score results         *Identify Risks");
                    lstInstr.Items.Add(" *Identify Issues       *List Any Assumptions");
                    break;
                case 3:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Approach");
                    lstInstr.Items.Add(" *Initiation    *Planning");
                    lstInstr.Items.Add(" *Execution     *Closure");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Develop Framework for the Implementation Plan");
                    lstInstr.Items.Add(" *Mile Stones                     *Dependencies");
                    lstInstr.Items.Add(" *Resource Plan                   *Financial Plan");
                    lstInstr.Items.Add(" *Quality Plan                    *Risk Management Plan");
                    lstInstr.Items.Add(" *Acceptance Plan                 *Communications Plan");
                    lstInstr.Items.Add(" *Stakeholder management plan     *Procurement Plan");
                    lstInstr.Items.Add(" *Issue Management Plan           *Planning Assumptions");
                    lstInstr.Items.Add(" *Planning Constraints");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Develop Framework for control & Assurance");
                    lstInstr.Items.Add(" *Define the Key Performance Areas");
                    lstInstr.Items.Add(" *Define the Key performance Indicators");
                    lstInstr.Items.Add("Define the standard alarm parameters");
                    lstInstr.Items.Add("Identify the relevant standards against which the project deliverables will be measured");
                    break;
                case 4:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Conduct a Job Analysis");
                    lstInstr.Items.Add("Draft Job Descriptions");
                    lstInstr.Items.Add("Recruit Project Staff");
                    lstInstr.Items.Add(" *Review Organisation Structure & Job Description");
                    lstInstr.Items.Add(" *Decide on Recruitment Method");
                    lstInstr.Items.Add(" *Place Advertisements");
                    lstInstr.Items.Add(" *Review Applicants");
                    lstInstr.Items.Add(" *Interviews");
                    lstInstr.Items.Add(" *Appointments");
                    btnPrev.Visible = false;
                    btnNext.Visible = false;
                    break;
                case 5:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Identify necessary standards, methods & tools");
                    lstInstr.Items.Add(" *Standards                 *Methodologies");
                    lstInstr.Items.Add(" *Project Planning tools    *Resource Planning tools");
                    lstInstr.Items.Add(" *Financial  Planning tools");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Identify & Createtemplates for:");
                    lstInstr.Items.Add(" *Time Management           *Cost Management");
                    lstInstr.Items.Add(" *Quality Management        *Change Management");
                    lstInstr.Items.Add(" *Risk Management           *Issue Management");
                    lstInstr.Items.Add(" *Procurement Management    *Communications Management");
                    lstInstr.Items.Add(" *acceptance Management");
                    break;
                default:
                    lstInstr.Items.Clear();
                    break;
            }
        }

        #endregion

        /// <summary>
        /// Initiation panel - all phases showcased
        /// </summary>
        #region Initiation panel

        /// <summary>
        /// Hover functionality
        /// </summary>
        #region Mouse hover

        private void btnPhaseReview_MouseHover(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
            lstInfo.Items.Add("At the end of the Initiation Phase, a Phase review is performed.");
            lstInfo.Items.Add("This is basically a checkpoint to ensure that the project has achieved its stated objectives as planned.");
            lstInfo.Visible = true;
        }

        private void btnSetupPOffice_MouseHover(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
            lstInfo.Items.Add("The Project Office is the physical environment within which the team will be based.");
            lstInfo.Items.Add("Although it is usual to have one central project office, it is possible to have a");
            lstInfo.Items.Add("‘virtual project office’ environment, with project team members in various locations around the world.");
            lstInfo.Visible = true;
        }

        private void btnAppointPTeam_MouseHover(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
            lstInfo.Items.Add("At this point the scope of the project has been defined in detail and the project team are ready to be appointed.");
            lstInfo.Items.Add("Although a Project Manager can be appointed at any stage of the project, s/he will need to be appointed prior to the");
            lstInfo.Items.Add("establishment of the project team. The Project Manager documents a detailed Job Description for each project role and");
            lstInfo.Items.Add("appoints a human resource to each role based on his/her relevant skills and experience. Once the team are ‘fully");
            lstInfo.Items.Add("resourced’, the Project Office is ready to be set-up.");
            lstInfo.Visible = true;
        }

        private void btnEstPCharter_MouseHover(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
            lstInfo.Items.Add("After the solution has been agreed and funding allocated, a project is formed.");
            lstInfo.Items.Add("The Project Charter defines the vision, objectives, scope and deliverables for the project.");
            lstInfo.Items.Add(". It also provides the organization structure (roles and responsibilities) and a summarized plan of the activities,");
            lstInfo.Items.Add("resources and funding required to undertake the project.");
            lstInfo.Items.Add("Finally, any risks, issues, planning assumptions and constraints are listed.");
            lstInfo.Visible = true;
            
        }

        private void btnUndertakeFStudy_MouseHover(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
            lstInfo.Items.Add("At any stage during (or after) the development of a Business Case, a formal Feasibility");
            lstInfo.Items.Add("Study may be commissioned. The purpose is to assess the likelihood of a particular");
            lstInfo.Items.Add("solution option’s achieving the benefits outlined in the Business Case.");
            lstInfo.Items.Add("The Feasibility Study will also investigate whether the forecast costs.");
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

        private void btnSetupPOffice_MouseLeave(object sender, EventArgs e)
        {
            lstInfo.Visible = false;
            lstInfo.Items.Clear();
        }

        private void btnAppointPTeam_MouseLeave(object sender, EventArgs e)
        {
            lstInfo.Visible = false;
            lstInfo.Items.Clear();
        }

        private void btnEstPCharter_MouseLeave(object sender, EventArgs e)
        {
            lstInfo.Visible = false;
            lstInfo.Items.Clear();
        }

        private void btnUndertakeFStudy_MouseLeave(object sender, EventArgs e)
        {
            lstInfo.Visible = false;
            lstInfo.Items.Clear();
        }

        private void btnDevBCase_MouseLeave(object sender, EventArgs e)
        {
            lstInfo.Visible = false;
            lstInfo.Items.Clear();
        }



        #endregion

        /// <summary>
        /// Show instructions panel 
        /// </summary>
        #region Click events

        private void btnPhaseReview_Click(object sender, EventArgs e)
        {
            phaseReview();
            showInstructions();
        }

        private void btnSetupPOffice_Click(object sender, EventArgs e)
        {
            projectOffice();
            showInstructions();
        }

        private void btnAppointPTeam_Click(object sender, EventArgs e)
        {
            projectTeam();
            showInstructions();
        }

        private void btnEstPCharter_Click(object sender, EventArgs e)
        {
            projectCharter();
            showInstructions();
        }

        private void btnUndertakeFStudy_Click(object sender, EventArgs e)
        {
            feasibilityStudy();
            showInstructions();
        }

        private void btnDevBCase_Click(object sender, EventArgs e)
        {
            businessCase();
            showInstructions();
        }

        #endregion

        //end initiation phase
        #endregion

        /// <summary>
        /// All instructions for Initiation phase 
        /// </summary>
        #region Instructions panel

        /// <summary>
        /// Info displayed based on main button selection
        /// </summary>
        #region Heading buttons

        private void lblBusCase_Click(object sender, EventArgs e)
        {
            businessCase();
                        
        }

        private void lblFeasStudy_Click(object sender, EventArgs e)
        {
            feasibilityStudy();
        }

        private void lblProjCharter_Click(object sender, EventArgs e)
        {
            projectCharter();
        }

        private void lblProjTeam_Click(object sender, EventArgs e)
        {
            projectTeam();
        }

        private void lblProjOffice_Click(object sender, EventArgs e)
        {
            projectOffice();
        }

        private void lblPhaseRev_Click(object sender, EventArgs e)
        {
            phaseReview();
        }

        #endregion

        /// <summary>
        /// Info displayed based on side button selection
        /// </summary>
        #region Sidemenu buttons

        private void btnFirst_Click(object sender, EventArgs e)
        {
            firstButton(first);
            btnPrev.Visible = false;
            btnNext.Visible = false;
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
            lstInstr.Items.Clear();
            lstInstr.Items.Add("Rank the Feasibility Options");
            lstInstr.Items.Add(" *Matrix Decision Making tool");
        }

        private void btnFifth_Click(object sender, EventArgs e)
        {
            lstInstr.Items.Clear();
            lstInstr.Items.Add("Identify the most feasible outcome");
            lstInstr.Items.Add(" *Matrix Decision Making tool");

        }

        //Next/Prev/Close buttons
        private void btnPrev_Click(object sender, EventArgs e)
        {

            lstInstr.Items.Clear();
            lstInstr.Items.Add("Project Manager");
            lstInstr.Items.Add(" *Present Phase Review Form");
            lstInstr.Items.Add(" *Discuss current status");
            lstInstr.Items.Add(" *Present Vision, Objectives, Scope and deliverables");
            lstInstr.Items.Add(" *Deliverables completed to date");
            lstInstr.Items.Add(" *Schedule Progress");
            lstInstr.Items.Add("");
            lstInstr.Items.Add("Deviations form:");
            lstInstr.Items.Add(" *Time      *Scope");
            lstInstr.Items.Add(" *Cost      *Quality");
            lstInstr.Items.Add("");
            lstInstr.Items.Add("Key Issues");
            lstInstr.Items.Add("Key risks");
            btnPrev.Visible = false;
            btnNext.Visible = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            lstInstr.Items.Clear();
            lstInstr.Items.Add("Project board");
            lstInstr.Items.Add(" *Approves Project to proceed");
            lstInstr.Items.Add(" *Request additional information or activities undertaken");
            lstInstr.Items.Add(" *Delay, Transfer or cancel the Project");
            lstInstr.Items.Add("");
            lstInstr.Items.Add("Complete Phase Review Form");
            lstInstr.Items.Add(" *Initiation Phase Review Form");
            btnPrev.Visible = true;
            btnNext.Visible = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlInstr.Hide();
            pnlInitiation.Visible = true;

            lstInfo.Items.Clear();
            lstInfo.Items.Add("The Initiation Phase is the first phase in the project.");
            lstInfo.Items.Add("In this phase a business problem(or opportunity) is identified and a business case which provides various solution");
            lstInfo.Items.Add("options is defined.A feasibility study is then conducted to investigate the likelihood of each solution option");
            lstInfo.Items.Add("addressing the business problem and a final recommended solution is put forward.");
            lstInfo.Items.Add("");
            lstInfo.Items.Add("Once the recommended solution is approved, a project is initiated to deliver the approved solution.");
            lstInfo.Items.Add("A ‘Project Charter’ is completed, which outlines the objectives, scope and structure of the new project,");
            lstInfo.Items.Add("and a Project Manager is appointed.The Project Manager begins recruiting a project team and establishes");
            lstInfo.Items.Add("a Project Office environment. Approval is then sought to move into the detailed planning phase.");
            lstInfo.Visible = true;

        }


        #endregion

        #endregion

               

        private void btnViewBusCase_Click(object sender, EventArgs e)
        {
            string filename = "Business_Case.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void btnViewFeasStudy_Click(object sender, EventArgs e)
        {
            string filename = "Feasibility_Study.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void btnViewCharter_Click(object sender, EventArgs e)
        {
            string filename = "Project_Charter.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void btnViewTeam_Click(object sender, EventArgs e)
        {
            string filename = "Job_Description.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void btnViewOffice_Click(object sender, EventArgs e)
        {
            string filename = "Project_Office_Checklist.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void btnViewPhase_Click(object sender, EventArgs e)
        {
            string filename = "Phase_Review_Form_Initiation.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TechGenics.Properties.Settings.Default.Theme == "Light")
            {
                this.BackColor = SystemColors.AppWorkspace;
               
                pnlInitiation.BackColor = SystemColors.AppWorkspace;
                pnlInstr.BackColor = SystemColors.AppWorkspace;

                btnClose.BackColor = SystemColors.AppWorkspace;
                btnPrev.BackColor = SystemColors.AppWorkspace;
                btnNext.BackColor = SystemColors.AppWorkspace;

                lstInstr.BackColor = SystemColors.AppWorkspace;
                lstInstr.ForeColor = SystemColors.Desktop;
                lstInfo.BackColor = SystemColors.AppWorkspace;
                lstInfo.ForeColor = SystemColors.Desktop;

                lblBusCase.BackColor = SystemColors.AppWorkspace;
                lblBusCase.ForeColor = SystemColors.Desktop;
                lblFeasStudy.BackColor = SystemColors.AppWorkspace;
                lblFeasStudy.ForeColor = SystemColors.Desktop;
                lblProjCharter.BackColor = SystemColors.AppWorkspace;
                lblProjCharter.ForeColor = SystemColors.Desktop;
                lblProjTeam.BackColor = SystemColors.AppWorkspace;
                lblProjTeam.ForeColor = SystemColors.Desktop;
                lblProjOffice.BackColor = SystemColors.AppWorkspace;
                lblProjOffice.ForeColor = SystemColors.Desktop;
                lblPhaseRev.BackColor = SystemColors.AppWorkspace;
                lblPhaseRev.ForeColor = SystemColors.Desktop;

                btnViewBusCase.BackColor = SystemColors.AppWorkspace;
                btnViewFeasStudy.BackColor = SystemColors.AppWorkspace;
                btnViewCharter.BackColor = SystemColors.AppWorkspace;
                btnViewTeam.BackColor = SystemColors.AppWorkspace;
                btnViewOffice.BackColor = SystemColors.AppWorkspace;
                btnViewPhase.BackColor = SystemColors.AppWorkspace;

            }
            if (TechGenics.Properties.Settings.Default.Theme == "Dark")
            {

                this.BackColor = SystemColors.Desktop;
                pnlInstr.BackColor = SystemColors.Desktop;
                pnlInitiation.BackColor = SystemColors.Desktop;
                btnClose.BackColor = SystemColors.Desktop;

               

                lstInstr.BackColor = SystemColors.Desktop;
                lstInstr.ForeColor = SystemColors.ActiveBorder; 
                lstInfo.BackColor = SystemColors.Desktop;
                lstInfo.ForeColor = SystemColors.ActiveBorder;

                btnClose.BackColor = SystemColors.Desktop;
                btnPrev.BackColor = SystemColors.Desktop;
                btnNext.BackColor = SystemColors.Desktop;

                lblBusCase.BackColor = SystemColors.Desktop;
                lblBusCase.ForeColor = SystemColors.ActiveBorder;
                lblFeasStudy.BackColor = SystemColors.Desktop;
                lblFeasStudy.ForeColor = SystemColors.ActiveBorder;
                lblProjCharter.BackColor = SystemColors.Desktop;
                lblProjCharter.ForeColor = SystemColors.ActiveBorder;
                lblProjTeam.BackColor = SystemColors.Desktop;
                lblProjTeam.ForeColor = SystemColors.ActiveBorder;
                lblProjOffice.BackColor = SystemColors.Desktop;
                lblProjOffice.ForeColor = SystemColors.ActiveBorder;
                lblPhaseRev.BackColor = SystemColors.Desktop;
                lblPhaseRev.ForeColor = SystemColors.ActiveBorder;

                btnViewBusCase.BackColor = SystemColors.Desktop;
                btnViewFeasStudy.BackColor = SystemColors.Desktop;
                btnViewCharter.BackColor = SystemColors.Desktop;
                btnViewTeam.BackColor = SystemColors.Desktop;
                btnViewOffice.BackColor = SystemColors.Desktop;
                btnViewPhase.BackColor = SystemColors.Desktop;
            }

            if (TechGenics.Properties.Settings.Default.Theme == "LBlueC")
            {
                this.BackColor = SystemColors.ActiveCaption;

                pnlInitiation.BackColor = SystemColors.ActiveCaption;
                pnlInstr.BackColor = SystemColors.ActiveCaption;

                btnClose.BackColor = SystemColors.ActiveCaption;
                btnPrev.BackColor = SystemColors.ActiveCaption;
                btnNext.BackColor = SystemColors.ActiveCaption;

                lstInstr.BackColor = SystemColors.ActiveCaption;

                lstInfo.BackColor = SystemColors.ActiveCaption;


                lblBusCase.BackColor = SystemColors.ActiveCaption;

                lblFeasStudy.BackColor = SystemColors.ActiveCaption;

                lblProjCharter.BackColor = SystemColors.ActiveCaption;

                lblProjTeam.BackColor = SystemColors.ActiveCaption;

                lblProjOffice.BackColor = SystemColors.ActiveCaption;

                lblPhaseRev.BackColor = SystemColors.ActiveCaption;


                btnViewBusCase.BackColor = SystemColors.ActiveCaption;
                btnViewFeasStudy.BackColor = SystemColors.ActiveCaption;
                btnViewCharter.BackColor = SystemColors.ActiveCaption;
                btnViewTeam.BackColor = SystemColors.ActiveCaption;
                btnViewOffice.BackColor = SystemColors.ActiveCaption;
                btnViewPhase.BackColor = SystemColors.ActiveCaption;

            }

            if (TechGenics.Properties.Settings.Default.Theme == "BlueC")
            {
                this.BackColor = SystemColors.Highlight;

                pnlInitiation.BackColor = SystemColors.Highlight;
                pnlInstr.BackColor = SystemColors.Highlight;

                btnClose.BackColor = SystemColors.Highlight;
                btnPrev.BackColor = SystemColors.Highlight;
                btnNext.BackColor = SystemColors.Highlight;

                lstInstr.BackColor = SystemColors.Highlight;

                lstInfo.BackColor = SystemColors.Highlight;


                lblBusCase.BackColor = SystemColors.Highlight;

                lblFeasStudy.BackColor = SystemColors.Highlight;

                lblProjCharter.BackColor = SystemColors.Highlight;

                lblProjTeam.BackColor = SystemColors.Highlight;

                lblProjOffice.BackColor = SystemColors.Highlight;

                lblPhaseRev.BackColor = SystemColors.Highlight;


                btnViewBusCase.BackColor = SystemColors.Highlight;
                btnViewFeasStudy.BackColor = SystemColors.Highlight;
                btnViewCharter.BackColor = SystemColors.Highlight;
                btnViewTeam.BackColor = SystemColors.Highlight;
                btnViewOffice.BackColor = SystemColors.Highlight;
                btnViewPhase.BackColor = SystemColors.Highlight;

            }

            if (TechGenics.Properties.Settings.Default.Theme == "DBlueC")
            {
                this.BackColor = SystemColors.Info;

                pnlInitiation.BackColor = SystemColors.Info;
                pnlInstr.BackColor = SystemColors.Info;

                btnClose.BackColor = SystemColors.Info;
                btnPrev.BackColor = SystemColors.Info;
                btnNext.BackColor = SystemColors.Info;

                lstInstr.BackColor = SystemColors.Info;

                lstInfo.BackColor = SystemColors.Info;


                lblBusCase.BackColor = SystemColors.Info;

                lblFeasStudy.BackColor = SystemColors.Info;

                lblProjCharter.BackColor = SystemColors.Info;

                lblProjTeam.BackColor = SystemColors.Info;

                lblProjOffice.BackColor = SystemColors.Info;

                lblPhaseRev.BackColor = SystemColors.Info;


                btnViewBusCase.BackColor = SystemColors.Info;
                btnViewFeasStudy.BackColor = SystemColors.Info;
                btnViewCharter.BackColor = SystemColors.Info;
                btnViewTeam.BackColor = SystemColors.Info;
                btnViewOffice.BackColor = SystemColors.Info;
                btnViewPhase.BackColor = SystemColors.Info;

            }

            if (TechGenics.Properties.Settings.Default.Theme == "LGreyC")
            {
                this.BackColor = SystemColors.ControlDark;

                pnlInitiation.BackColor = SystemColors.ControlDark;
                pnlInstr.BackColor = SystemColors.ControlDark;

                btnClose.BackColor = SystemColors.ControlDark;
                btnPrev.BackColor = SystemColors.ControlDark;
                btnNext.BackColor = SystemColors.ControlDark;

                lstInstr.BackColor = SystemColors.ControlDark;

                lstInfo.BackColor = SystemColors.ControlDark;


                lblBusCase.BackColor = SystemColors.ControlDark;

                lblFeasStudy.BackColor = SystemColors.ControlDark;

                lblProjCharter.BackColor = SystemColors.ControlDark;

                lblProjTeam.BackColor = SystemColors.ControlDark;

                lblProjOffice.BackColor = SystemColors.ControlDark;

                lblPhaseRev.BackColor = SystemColors.ControlDark;


                btnViewBusCase.BackColor = SystemColors.ControlDark;
                btnViewFeasStudy.BackColor = SystemColors.ControlDark;
                btnViewCharter.BackColor = SystemColors.ControlDark;
                btnViewTeam.BackColor = SystemColors.ControlDark;
                btnViewOffice.BackColor = SystemColors.ControlDark;
                btnViewPhase.BackColor = SystemColors.ControlDark;

            }

            if (TechGenics.Properties.Settings.Default.Theme == "DGreyC")
            {
                this.BackColor = SystemColors.ControlDarkDark;

                pnlInitiation.BackColor = SystemColors.ControlDarkDark;
                pnlInstr.BackColor = SystemColors.ControlDarkDark;

                btnClose.BackColor = SystemColors.ControlDarkDark;
                btnPrev.BackColor = SystemColors.ControlDarkDark;
                btnNext.BackColor = SystemColors.ControlDarkDark;

                lstInstr.BackColor = SystemColors.ControlDarkDark;

                lstInfo.BackColor = SystemColors.ControlDarkDark;


                lblBusCase.BackColor = SystemColors.ControlDarkDark;

                lblFeasStudy.BackColor = SystemColors.ControlDarkDark;

                lblProjCharter.BackColor = SystemColors.ControlDarkDark;

                lblProjTeam.BackColor = SystemColors.ControlDarkDark;

                lblProjOffice.BackColor = SystemColors.ControlDarkDark;

                lblPhaseRev.BackColor = SystemColors.ControlDarkDark;


                btnViewBusCase.BackColor = SystemColors.ControlDarkDark;
                btnViewFeasStudy.BackColor = SystemColors.ControlDarkDark;
                btnViewCharter.BackColor = SystemColors.ControlDarkDark;
                btnViewTeam.BackColor = SystemColors.ControlDarkDark;
                btnViewOffice.BackColor = SystemColors.ControlDarkDark;
                btnViewPhase.BackColor = SystemColors.ControlDarkDark;

            }

            if (TechGenics.Properties.Settings.Default.Theme == "BlackC")
            {
                this.BackColor = SystemColors.Desktop;

                pnlInitiation.BackColor = SystemColors.Desktop;
                pnlInstr.BackColor = SystemColors.Desktop;

                btnClose.BackColor = SystemColors.Desktop;
                btnPrev.BackColor = SystemColors.Desktop;
                btnNext.BackColor = SystemColors.Desktop;

                lstInstr.BackColor = SystemColors.Desktop;

                lstInfo.BackColor = SystemColors.Desktop;


                lblBusCase.BackColor = SystemColors.Desktop;

                lblFeasStudy.BackColor = SystemColors.Desktop;

                lblProjCharter.BackColor = SystemColors.Desktop;

                lblProjTeam.BackColor = SystemColors.Desktop;

                lblProjOffice.BackColor = SystemColors.Desktop;

                lblPhaseRev.BackColor = SystemColors.Desktop;


                btnViewBusCase.BackColor = SystemColors.Desktop;
                btnViewFeasStudy.BackColor = SystemColors.Desktop;
                btnViewCharter.BackColor = SystemColors.Desktop;
                btnViewTeam.BackColor = SystemColors.Desktop;
                btnViewOffice.BackColor = SystemColors.Desktop;
                btnViewPhase.BackColor = SystemColors.Desktop;

            }

            if (TechGenics.Properties.Settings.Default.Theme == "WhiteC")
            {
                this.BackColor = SystemColors.Window;

                pnlInitiation.BackColor = SystemColors.Window;
                pnlInstr.BackColor = SystemColors.Window;

                btnClose.BackColor = SystemColors.Window;
                btnPrev.BackColor = SystemColors.Window;
                btnNext.BackColor = SystemColors.Window;

                lstInstr.BackColor = SystemColors.Window;

                lstInfo.BackColor = SystemColors.Window;


                lblBusCase.BackColor = SystemColors.Window;

                lblFeasStudy.BackColor = SystemColors.Window;

                lblProjCharter.BackColor = SystemColors.Window;

                lblProjTeam.BackColor = SystemColors.Window;

                lblProjOffice.BackColor = SystemColors.Window;

                lblPhaseRev.BackColor = SystemColors.Window;


                btnViewBusCase.BackColor = SystemColors.Window;
                btnViewFeasStudy.BackColor = SystemColors.Window;
                btnViewCharter.BackColor = SystemColors.Window;
                btnViewTeam.BackColor = SystemColors.Window;
                btnViewOffice.BackColor = SystemColors.Window;
                btnViewPhase.BackColor = SystemColors.Window;

            }

            if (TechGenics.Properties.Settings.Default.Theme == "LBlueC2")
            {

                lstInstr.ForeColor = SystemColors.ActiveCaption;

                lstInfo.ForeColor = SystemColors.ActiveCaption;

                lblBusCase.ForeColor = SystemColors.ActiveCaption;

                lblFeasStudy.ForeColor = SystemColors.ActiveCaption;

                lblProjCharter.ForeColor = SystemColors.ActiveCaption;

                lblProjTeam.ForeColor = SystemColors.ActiveCaption;

                lblProjOffice.ForeColor = SystemColors.ActiveCaption;

                lblPhaseRev.ForeColor = SystemColors.ActiveCaption;

            }

            if (TechGenics.Properties.Settings.Default.Theme == "BlueC2")
            {

                lstInstr.ForeColor = SystemColors.Highlight;

                lstInfo.ForeColor = SystemColors.Highlight;

                lblBusCase.ForeColor = SystemColors.Highlight;

                lblFeasStudy.ForeColor = SystemColors.Highlight;

                lblProjCharter.ForeColor = SystemColors.Highlight;

                lblProjTeam.ForeColor = SystemColors.Highlight;

                lblProjOffice.ForeColor = SystemColors.Highlight;

                lblPhaseRev.ForeColor = SystemColors.Highlight;

            }

            if (TechGenics.Properties.Settings.Default.Theme == "DBlueC2")
            {

                lstInstr.ForeColor = SystemColors.Info;

                lstInfo.ForeColor = SystemColors.Info;

                lblBusCase.ForeColor = SystemColors.Info;

                lblFeasStudy.ForeColor = SystemColors.Info;

                lblProjCharter.ForeColor = SystemColors.Info;

                lblProjTeam.ForeColor = SystemColors.Info;

                lblProjOffice.ForeColor = SystemColors.Info;

                lblPhaseRev.ForeColor = SystemColors.Info;

            }

            if (TechGenics.Properties.Settings.Default.Theme == "LGreyC2")
            {

                lstInstr.ForeColor = SystemColors.ControlDark;

                lstInfo.ForeColor = SystemColors.ControlDark;

                lblBusCase.ForeColor = SystemColors.ControlDark;

                lblFeasStudy.ForeColor = SystemColors.ControlDark;

                lblProjCharter.ForeColor = SystemColors.ControlDark;

                lblProjTeam.ForeColor = SystemColors.ControlDark;

                lblProjOffice.ForeColor = SystemColors.ControlDark;

                lblPhaseRev.ForeColor = SystemColors.ControlDark;

            }

            if (TechGenics.Properties.Settings.Default.Theme == "DGreyC2")
            {

                lstInstr.ForeColor = SystemColors.ControlDarkDark;

                lstInfo.ForeColor = SystemColors.ControlDarkDark;

                lblBusCase.ForeColor = SystemColors.ControlDarkDark;

                lblFeasStudy.ForeColor = SystemColors.ControlDarkDark;

                lblProjCharter.ForeColor = SystemColors.ControlDarkDark;

                lblProjTeam.ForeColor = SystemColors.ControlDarkDark;

                lblProjOffice.ForeColor = SystemColors.ControlDarkDark;

                lblPhaseRev.ForeColor = SystemColors.ControlDarkDark;

            }

            if (TechGenics.Properties.Settings.Default.Theme == "BlackC2")
            {

                lstInstr.ForeColor = SystemColors.Desktop;

                lstInfo.ForeColor = SystemColors.Desktop;

                lblBusCase.ForeColor = SystemColors.Desktop;

                lblFeasStudy.ForeColor = SystemColors.Desktop;

                lblProjCharter.ForeColor = SystemColors.Desktop;

                lblProjTeam.ForeColor = SystemColors.Desktop;

                lblProjOffice.ForeColor = SystemColors.Desktop;

                lblPhaseRev.ForeColor = SystemColors.Desktop;

            }

            if (TechGenics.Properties.Settings.Default.Theme == "WhiteC2")
            {

                lstInstr.ForeColor = SystemColors.Window;

                lstInfo.ForeColor = SystemColors.Window;

                lblBusCase.ForeColor = SystemColors.Window;

                lblFeasStudy.ForeColor = SystemColors.Window;

                lblProjCharter.ForeColor = SystemColors.Window;

                lblProjTeam.ForeColor = SystemColors.Window;

                lblProjOffice.ForeColor = SystemColors.Window;

                lblPhaseRev.ForeColor = SystemColors.Window;

            }
        }
    }
}
