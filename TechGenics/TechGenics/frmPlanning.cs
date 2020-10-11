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
    public partial class frmPlanning : Form
    {
        public frmPlanning()
        {
            InitializeComponent();
        }

        private void btnProjectPlan_MouseHover(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
            lstInfo.Items.Add("The first step is to document the Project Plan. A ‘Work Breakdown Structure’ (WBS) is identified, which includes a hierarchical set of phases,");
            lstInfo.Items.Add("activities and tasks to be undertaken on the project. After the WBS has been agreed, an assessment of the effort required to undertake the ");
            lstInfo.Items.Add("activities and tasks is made. The activities and tasks are sequenced, resources are allocated and a detailed project schedule is formed.");
            lstInfo.Items.Add("This project schedule will become the primary tool for the Project Manager to assess the progress of the project.");
        }

        private void btnProjectPlan_MouseLeave(object sender, EventArgs e)
        {
            
            lstInfo.Items.Clear();
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

        private void btnResPlan_MouseLeave(object sender, EventArgs e)
        {
           
            lstInfo.Items.Clear();
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

        private void btnFinPlan_MouseLeave(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
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

        private void btnQualPlan_MouseLeave(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
        }

        private void btnComPlan_MouseHover(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
            lstInfo.Items.Add("Prior to the Execution phase, it is also necessary to identify how each of the stakeholders will be kept");
            lstInfo.Items.Add("informed of the progress of the project. The Communications Plan identifies the types of information to");
            lstInfo.Items.Add("be distributed, the methods of distributing information to stakeholders, the frequency of distribution and");
            lstInfo.Items.Add("responsibilities of each person in the project team for distributing information regularly to stakeholders.");
        }

        private void btnComPlan_MouseLeave(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
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

        private void btnAccPlan_MouseLeave(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
        }

        private void btnRiskPlan_MouseHover(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
            lstInfo.Items.Add("The foreseeable project risks are then documented within a Risk Plan and a set of actions to be taken");
            lstInfo.Items.Add("formulated to both prevent each risk from occurring and reduce the impact of the risk should it eventuate.");
            lstInfo.Items.Add("Developing a clear Risk Plan is an important activity within the planning phase as it is necessary to");
            lstInfo.Items.Add("mitigate all critical project risks prior to entering the Execution phase of the project.");
        }

        private void btnRiskPlan_MouseLeave(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
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

        private void btnProcPlan_MouseLeave(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
        }

        private void btnPRev_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
