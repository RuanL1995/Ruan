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
    }
}
