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
    public partial class frmCloseOut : Form
    {
        public frmCloseOut()
        {
            InitializeComponent();
        }

        int first = 0;
        int second = 0;

        public void showInstructions()
        {
            pnlCloseOut.Visible = false;
            pnlInstr.Visible = true;
            pnlInstr.BringToFront();
        }

        public void closure()
        {
            first = 1;
            second = 1;

            btnFirst.Visible = true;
            btnSec.Visible = true;
            btnThird.Visible = true;

            btnFirst.Text = "Confirm Project Completion";
            btnSec.Text = "Identify Closure Actions";
            
            lstInstr.Items.Clear();
            lstInstr.Items.Add("Releasing final deliverables to the customer");
            lstInstr.Items.Add("Handling over all documentation to the business");
            lstInstr.Items.Add("Terminating supplier contracts");
            lstInstr.Items.Add("Releasing project resources");
            lstInstr.Items.Add("Communicating project close out to all stakeholders");

            btnViewClosure.Visible = true;
            btnViewCompletion.Visible = false;
        }

        public void completion()
        {
            first = 2;
            second = 2;

            btnFirst.Visible = true;
            btnSec.Visible = true;
            btnThird.Visible = false;

            btnFirst.Text = "Review Project Performance";
            btnSec.Text = "Review Project Conformance";

            lstInstr.Items.Clear();
            lstInstr.Items.Add("Involves:");
            lstInstr.Items.Add(" *Post implementation review (undertaken by independent person)");
            lstInstr.Items.Add(" *Determine level of success achieved");
            lstInstr.Items.Add(" *Note all lessons learned");

            btnViewClosure.Visible = false;
            btnViewCompletion.Visible = true;

        }

        private void btnClosure_MouseHover(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
            lstInfo.Items.Add("Project Closure involves undertaking a series of activities to wind up the project, including:");
            lstInfo.Items.Add(" *Assessing whether the project completion criteria have been met");
            lstInfo.Items.Add(" *Identifying any outstanding items (activities, risks or issues)");
            lstInfo.Items.Add(" *Producing a hand - over plan to transfer the deliverables to the customer environment");
            lstInfo.Items.Add(" *Listing the activities required to hand over documentation, cancel supplier contracts and release");
            lstInfo.Items.Add("   project resources to the business");
            lstInfo.Items.Add(" *Communicating closure to all stakeholders and interested parties.");
            lstInfo.Items.Add("");
            lstInfo.Items.Add("A Project Closure Report is submitted to the Customer and/or Project Sponsor for approval. The Project");
            lstInfo.Items.Add("Manager is then responsible for undertaking each of the activities identified within the Project Closure");
            lstInfo.Items.Add("Report on time and according to budget. The project is closed only when all activities identified in the");
            lstInfo.Items.Add("Project Closure Report have been completed.");
            lstInfo.Items.Add("Template: Project Closure Report");
        }

        private void btnClosure_MouseLeave(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
        }

        private void btnRev_MouseHover(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
            lstInfo.Items.Add("The final activity undertaken on any project is a review of its overall success by an independent resource");
            lstInfo.Items.Add("Success is determined by how well it performed against the defined objectives and conformed to the");
            lstInfo.Items.Add("management processes outlined in the planning phase. To determine performance, a number of");
            lstInfo.Items.Add("questions are posed. For example:");
            lstInfo.Items.Add(" *Did it result in the benefits defined in the Business Case?");
            lstInfo.Items.Add(" *Did it achieve the objectives outlined in the Project Charter?");
            lstInfo.Items.Add(" *Did it operate within the scope of the Project Charter?");
            lstInfo.Items.Add(" *Did the deliverables meet the criteria defined in the Quality Plan?");
            lstInfo.Items.Add(" *Was it delivered within the schedule outlined in the Project Plan?");
            lstInfo.Items.Add(" *Was it delivered within the budget outlined in the Financial Plan?");
            lstInfo.Items.Add("");
            lstInfo.Items.Add("To determine conformance, a review is undertaken of the level of conformity of the project activities to the");
            lstInfo.Items.Add("management processes outlined in the Quality Plan. The above results, key achievements and lessons");
            lstInfo.Items.Add("learnt are documented within a Post Implementation Review report and presented to the Project Sponsor");
            lstInfo.Items.Add("for approval.");
            lstInfo.Items.Add("Template: Post Implementation Review");
        }

        private void frmCloseOut_Load(object sender, EventArgs e)
        {

        }

        private void btnThird_Click(object sender, EventArgs e)
        {
            lstInstr.Items.Clear();
            lstInstr.Items.Add("Undertake closing actions");
            lstInstr.Items.Add("The Project Manager submits his Close Out plan for approval to the Project Board");
            lstInstr.Items.Add("The Project Board approves the plan");
            lstInstr.Items.Add("The Project Manager undertakes all close out actions");
           
        }

        private void btnClosure_Click(object sender, EventArgs e)
        {
            showInstructions();
            closure();
        }

        private void btnRev_Click(object sender, EventArgs e)
        {
            showInstructions();
            completion();
        }

        private void lblClosure_Click(object sender, EventArgs e)
        {
            closure();
        }

        private void lblCompletion_Click(object sender, EventArgs e)
        {
            completion();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            firstButton(first);
        }
        public void firstButton(int button)
        {
            //switch for first button

            switch (button)
            {
                //Confirm project completion
                case 1:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Review completion criteria");
                    lstInstr.Items.Add(" *Review Terms of Reference to determine that all completion criteria specified have been met");
                    lstInstr.Items.Add(" *Checklist:");
                    lstInstr.Items.Add("  -List the completion categories");
                    lstInstr.Items.Add("  -Objectives");
                    lstInstr.Items.Add("  -Benefits");
                    lstInstr.Items.Add("   -Deliverables");
                    lstInstr.Items.Add("   -List the completion criteria");
                    lstInstr.Items.Add("   -Vision has been achieved");
                    lstInstr.Items.Add("   -All objectives were met");
                    lstInstr.Items.Add("   -Stated benefits have been realised");
                    lstInstr.Items.Add("   -All deliverables have been produced");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Outstanding items");
                    lstInstr.Items.Add("List all activities that are incomplete as compared to the Project Plan");
                    lstInstr.Items.Add("Identify and list actions that are required to resolve outstanding items");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Checklist");
                    lstInstr.Items.Add(" *List the outstanding actions");
                    lstInstr.Items.Add(" *Outstanding actions");
                    lstInstr.Items.Add(" *Action required");
                    lstInstr.Items.Add(" *Targeted completion date");
                    break;
                //Review project performance
                case 2:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Benefits");
                    lstInstr.Items.Add("Objectives");
                    lstInstr.Items.Add("Checklist: Benefits");
                    lstInstr.Items.Add("Checklist: Objectives");
                    lstInstr.Items.Add("Checklist: Deliverables");
                    lstInstr.Items.Add("Checklist: Schedule");
                    lstInstr.Items.Add("Checklist: Expenses");
                    lstInstr.Items.Add("Checklist: Resources");
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
                //Identify closure actions
                case 1:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Deliverables:");
                    lstInstr.Items.Add(" *List actions required to hand over the deliverables (responsibility and accountability to the customer");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Checklist: Deliverable");
                    lstInstr.Items.Add(" *List the outstanding actions");
                    lstInstr.Items.Add(" *Deliverable");
                    lstInstr.Items.Add(" *Action required");
                    lstInstr.Items.Add(" *Targeted completion date");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Checklist: Documentation");
                    lstInstr.Items.Add(" *Itemise the project documentationaccording to the project phases:");
                    lstInstr.Items.Add(" *Initiation            *Planning");
                    lstInstr.Items.Add(" *Execution             *Close Out");
                    lstInstr.Items.Add(" *Action required");
                    lstInstr.Items.Add(" *Targeted completion date");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Checklist: Suppliers");
                    lstInstr.Items.Add(" *List the actions required to terminate all supplier contracts:");
                    lstInstr.Items.Add("  -Contract");
                    lstInstr.Items.Add("  -Action required");
                    lstInstr.Items.Add("  -Targeted conmpletion date");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Checklist: Resources");
                    lstInstr.Items.Add("List the actions required to release all project resources:");
                    lstInstr.Items.Add(" *Resource");
                    lstInstr.Items.Add(" *Action required");
                    lstInstr.Items.Add(" *Targeted completion date");
                    lstInstr.Items.Add(" *Actions may include:");
                    lstInstr.Items.Add("  -Closing down of Project Office");
                    lstInstr.Items.Add("  -Ceasing lease agreements");
                    lstInstr.Items.Add("  -Disseminating Project Office equipment");
                    lstInstr.Items.Add("  -Closing accounts");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Checklist: Communications");
                    lstInstr.Items.Add("List the actions required to Close Out communications to all stakeholders:");
                    lstInstr.Items.Add(" *Audience              *Message");
                    lstInstr.Items.Add(" *Method                *Date");
                    lstInstr.Items.Add("");
                    lstInstr.Items.Add("Undertake closing actions");
                    lstInstr.Items.Add("The Project Manager submits his Close Out plan for approval to the Project Board");
                    lstInstr.Items.Add(" *The Project Board approves the plan");
                    lstInstr.Items.Add(" *The Project Manager undertakes all close out actions");
                    break;
                //Review project conformance
                case 2:
                    lstInstr.Items.Clear();
                    lstInstr.Items.Add("Checklist: Time Management Process");
                    lstInstr.Items.Add("Checklist: Cost Management Process ");
                    lstInstr.Items.Add("Checklist: Quality Management Process");
                    lstInstr.Items.Add("Checklist: Change Management Process");
                    lstInstr.Items.Add("Checklist: Risk Management Process");
                    lstInstr.Items.Add("Checklist: Issue Management Process");
                    lstInstr.Items.Add("Checklist: Procurement Management Process");
                    lstInstr.Items.Add("Checklist: Communications Management Process");
                    lstInstr.Items.Add("Checklist: Acceptance Management Process");
                    lstInstr.Items.Add("Identify project achievements");
                    lstInstr.Items.Add("Identify project failures");
                    lstInstr.Items.Add("Identiy lessons learned");
                    break;
                default:
                    lstInstr.Items.Clear();
                    break;
            }
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            secondButton(second);
        }

        private void pnlInstr_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlCloseOut.Visible = true;
            pnlInstr.Visible = false;
            pnlCloseOut.BringToFront();

            lstInfo.Items.Clear();
            lstInfo.Items.Add("Project Closure involves releasing the final deliverables to the customer, handing over project documentation");
            lstInfo.Items.Add("terminating supplier contracts, releasing project resources and communicating the closure of the project to all");
            lstInfo.Items.Add("stakeholders.The last remaining step is to undertake a Post Implementation Review to quantify the overall");
            lstInfo.Items.Add("success of the project and list any lessons learnt for future projects.");

        }

        private void btnViewClosure_Click(object sender, EventArgs e)
        {
            string assemblyPath = Application.StartupPath;

            string filename = Application.StartupPath + "\\Info_Temps\\Project_Closure_Report.pdf";

            System.Diagnostics.Process.Start(filename);

        }

        private void btnViewCompletion_Click(object sender, EventArgs e)
        {
            string assemblyPath = Application.StartupPath;

            string filename = Application.StartupPath + "\\Info_Temps\\Post_Implementation_Review.pdf";

            System.Diagnostics.Process.Start(filename);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TechGenics.Properties.Settings.Default.Theme == "Light")
            {
                this.BackColor = SystemColors.AppWorkspace;
                pnlInstr.BackColor = SystemColors.AppWorkspace;
                pnlCloseOut.BackColor = SystemColors.AppWorkspace;

                btnViewCompletion.BackColor = SystemColors.AppWorkspace;
                btnViewClosure.BackColor = SystemColors.AppWorkspace;
                btnClose.BackColor = SystemColors.AppWorkspace;

                lblClosure.BackColor = SystemColors.AppWorkspace;
                lblClosure.ForeColor = SystemColors.Desktop;
                lblCompletion.BackColor = SystemColors.AppWorkspace;
                lblCompletion.ForeColor = SystemColors.Desktop;

                lstInstr.BackColor = SystemColors.AppWorkspace;
                lstInstr.ForeColor = SystemColors.Desktop;
                lstInfo.BackColor = SystemColors.AppWorkspace;
                lstInfo.ForeColor = SystemColors.Desktop;
                
            }
            if (TechGenics.Properties.Settings.Default.Theme == "Dark")
            {
                
                this.BackColor = SystemColors.Desktop;
                pnlInstr.BackColor = SystemColors.Desktop;
                pnlCloseOut.BackColor = SystemColors.Desktop;

                btnViewCompletion.BackColor = SystemColors.Desktop;
                btnViewClosure.BackColor = SystemColors.Desktop;
                btnClose.BackColor = SystemColors.Desktop;

                lblClosure.BackColor = SystemColors.Desktop;
                lblClosure.ForeColor = SystemColors.ActiveBorder;
                lblCompletion.BackColor = SystemColors.Desktop;
                lblCompletion.ForeColor = SystemColors.ActiveBorder;

                lstInstr.BackColor = SystemColors.Desktop;
                lstInstr.ForeColor = SystemColors.ActiveBorder; ;
                lstInfo.BackColor = SystemColors.Desktop;
                lstInfo.ForeColor = SystemColors.ActiveBorder;

            }

            //custom
            if (TechGenics.Properties.Settings.Default.Theme == "LBlueC")
            {
                this.BackColor = SystemColors.ActiveCaption;
                pnlInstr.BackColor = SystemColors.ActiveCaption;
                pnlCloseOut.BackColor = SystemColors.ActiveCaption;

                btnViewCompletion.BackColor = SystemColors.ActiveCaption;
                btnViewClosure.BackColor = SystemColors.ActiveCaption;
                btnClose.BackColor = SystemColors.ActiveCaption;

                lblClosure.BackColor = SystemColors.ActiveCaption;

                lblCompletion.BackColor = SystemColors.ActiveCaption;


                lstInstr.BackColor = SystemColors.ActiveCaption;

                lstInfo.BackColor = SystemColors.ActiveCaption;
            }

            if (TechGenics.Properties.Settings.Default.Theme == "BlueC")
            {
                this.BackColor = SystemColors.Highlight;
                pnlInstr.BackColor = SystemColors.Highlight;
                pnlCloseOut.BackColor = SystemColors.Highlight;

                btnViewCompletion.BackColor = SystemColors.Highlight;
                btnViewClosure.BackColor = SystemColors.Highlight;
                btnClose.BackColor = SystemColors.Highlight;

                lblClosure.BackColor = SystemColors.Highlight;

                lblCompletion.BackColor = SystemColors.Highlight;


                lstInstr.BackColor = SystemColors.Highlight;

                lstInfo.BackColor = SystemColors.Highlight;
            }

            if (TechGenics.Properties.Settings.Default.Theme == "DBlueC")
            {
                this.BackColor = SystemColors.Info;
                pnlInstr.BackColor = SystemColors.Info;
                pnlCloseOut.BackColor = SystemColors.Info;

                btnViewCompletion.BackColor = SystemColors.Info;
                btnViewClosure.BackColor = SystemColors.Info;
                btnClose.BackColor = SystemColors.Info;

                lblClosure.BackColor = SystemColors.Info;

                lblCompletion.BackColor = SystemColors.Info;


                lstInstr.BackColor = SystemColors.Info;

                lstInfo.BackColor = SystemColors.Info;
            }

            if (TechGenics.Properties.Settings.Default.Theme == "LGreyC")
            {
                this.BackColor = SystemColors.ControlDark;
                pnlInstr.BackColor = SystemColors.ControlDark;
                pnlCloseOut.BackColor = SystemColors.ControlDark;

                btnViewCompletion.BackColor = SystemColors.ControlDark;
                btnViewClosure.BackColor = SystemColors.ControlDark;
                btnClose.BackColor = SystemColors.ControlDark;

                lblClosure.BackColor = SystemColors.ControlDark;

                lblCompletion.BackColor = SystemColors.ControlDark;


                lstInstr.BackColor = SystemColors.ControlDark;

                lstInfo.BackColor = SystemColors.ControlDark;
            }

            if (TechGenics.Properties.Settings.Default.Theme == "DGreyC")
            {
                this.BackColor = SystemColors.ControlDarkDark;
                pnlInstr.BackColor = SystemColors.ControlDarkDark;
                pnlCloseOut.BackColor = SystemColors.ControlDarkDark;

                btnViewCompletion.BackColor = SystemColors.ControlDarkDark;
                btnViewClosure.BackColor = SystemColors.ControlDarkDark;
                btnClose.BackColor = SystemColors.ControlDarkDark;

                lblClosure.BackColor = SystemColors.ControlDarkDark;

                lblCompletion.BackColor = SystemColors.ControlDarkDark;


                lstInstr.BackColor = SystemColors.ControlDarkDark;

                lstInfo.BackColor = SystemColors.ControlDarkDark;
            }

            if (TechGenics.Properties.Settings.Default.Theme == "BlackC")
            {
                this.BackColor = SystemColors.Desktop;
                pnlInstr.BackColor = SystemColors.Desktop;
                pnlCloseOut.BackColor = SystemColors.Desktop;

                btnViewCompletion.BackColor = SystemColors.Desktop;
                btnViewClosure.BackColor = SystemColors.Desktop;
                btnClose.BackColor = SystemColors.Desktop;

                lblClosure.BackColor = SystemColors.Desktop;

                lblCompletion.BackColor = SystemColors.Desktop;


                lstInstr.BackColor = SystemColors.Desktop;

                lstInfo.BackColor = SystemColors.Desktop;
            }

            if (TechGenics.Properties.Settings.Default.Theme == "WhiteC")
            {
                this.BackColor = SystemColors.Window;
                pnlInstr.BackColor = SystemColors.Window;
                pnlCloseOut.BackColor = SystemColors.Window;

                btnViewCompletion.BackColor = SystemColors.Window;
                btnViewClosure.BackColor = SystemColors.Window;
                btnClose.BackColor = SystemColors.Window;

                lblClosure.BackColor = SystemColors.Window;

                lblCompletion.BackColor = SystemColors.Window;


                lstInstr.BackColor = SystemColors.Window;

                lstInfo.BackColor = SystemColors.Window;
            }

            if (TechGenics.Properties.Settings.Default.Theme == "LBlueC2")
            {

                lblClosure.ForeColor = SystemColors.ActiveCaption;

                lblCompletion.ForeColor = SystemColors.ActiveCaption;


                lstInstr.ForeColor = SystemColors.ActiveCaption;

                lstInfo.ForeColor = SystemColors.ActiveCaption;

            }

            if (TechGenics.Properties.Settings.Default.Theme == "BlueC2")
            {

                lblClosure.ForeColor = SystemColors.Highlight;

                lblCompletion.ForeColor = SystemColors.Highlight;


                lstInstr.ForeColor = SystemColors.Highlight;

                lstInfo.ForeColor = SystemColors.Highlight;

            }

            if (TechGenics.Properties.Settings.Default.Theme == "DBlueC2")
            {

                lblClosure.ForeColor = SystemColors.Info;

                lblCompletion.ForeColor = SystemColors.Info;


                lstInstr.ForeColor = SystemColors.Info;

                lstInfo.ForeColor = SystemColors.Info;

            }

            if (TechGenics.Properties.Settings.Default.Theme == "LGreyC2")
            {

                lblClosure.ForeColor = SystemColors.ControlDark;

                lblCompletion.ForeColor = SystemColors.ControlDark;


                lstInstr.ForeColor = SystemColors.ControlDark;

                lstInfo.ForeColor = SystemColors.ControlDark;

            }

            if (TechGenics.Properties.Settings.Default.Theme == "DGreyC2")
            {

                lblClosure.ForeColor = SystemColors.ControlDarkDark;

                lblCompletion.ForeColor = SystemColors.ControlDarkDark;


                lstInstr.ForeColor = SystemColors.ControlDarkDark;

                lstInfo.ForeColor = SystemColors.ControlDarkDark;

            }

            if (TechGenics.Properties.Settings.Default.Theme == "BlackC2")
            {

                lblClosure.ForeColor = SystemColors.Desktop;

                lblCompletion.ForeColor = SystemColors.Desktop;


                lstInstr.ForeColor = SystemColors.Desktop;

                lstInfo.ForeColor = SystemColors.Desktop;

            }

            if (TechGenics.Properties.Settings.Default.Theme == "WhiteC2")
            {

                lblClosure.ForeColor = SystemColors.Window;

                lblCompletion.ForeColor = SystemColors.Window;


                lstInstr.ForeColor = SystemColors.Window;

                lstInfo.ForeColor = SystemColors.Window;

            }
        }

        private void btnCClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
