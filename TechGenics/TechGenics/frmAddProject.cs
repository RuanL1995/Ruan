using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechGenics.Models;

namespace TechGenics
{
    public partial class frmAddProject : Form
    {
        public frmAddProject()
        {
            InitializeComponent();
        }

        private void frmAddProject_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            List<Projects> _projects = new List<Projects>();
            DataAccess db = new DataAccess();
            _projects = db.GetProject();
            DataSet dsProjects = new DataSet();
            dsProjects = ListToDataSet.ToDataSet(_projects);

            DataView viewProjectNames = new DataView(dsProjects.Tables[0]);
            DataTable dtProjectNames = viewProjectNames.ToTable(true, "ProjectId", "ProjectName");

            cboProjectName.ValueMember = "ProjectId";
            cboProjectName.DisplayMember = "ProjectName";
            cboProjectName.DataSource = dtProjectNames;

            cboProjectPhase.SelectedIndex = 0;

            if (System.Windows.Forms.Application.OpenForms["frmMainAdmin"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["frmMainAdmin"] as frmMainAdmin).refreshProjects();
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            string projectName = cboProjectName.Text;
            string projectPhase = cboProjectPhase.Text;
            string projectStatus = txtProjectStatus.Text;

            bool validProjectName = false;
            bool validProjectPhase = false;
            bool validProjectStatus = false;


            if (!String.IsNullOrWhiteSpace(projectName))
            {
                validProjectName = true;
            }
            if (validProjectName == false)
            {
                MessageBox.Show("Please enter a project name.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!String.IsNullOrWhiteSpace(projectPhase))
            {
                validProjectPhase = true;
            }
            if (validProjectPhase == false)
            {
                MessageBox.Show("Please enter a project phase.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!String.IsNullOrWhiteSpace(projectStatus))
            {
                validProjectStatus = true;
            }
            if (validProjectStatus == false)
            {
                MessageBox.Show("Please enter a project status.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (validProjectName == true && validProjectPhase == true && validProjectStatus == true)
            {
                db.InsertProject(projectName, projectPhase, projectStatus);
                load();
                MessageBox.Show("The new project has been added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            int projectId = (int)cboProjectName.SelectedValue;
            string projectName = cboProjectName.Text;
            string projectPhase = cboProjectPhase.Text;
            string projectStatus = txtProjectStatus.Text;

            bool validProjectName = false;
            bool validProjectPhase = false;
            bool validProjectStatus = false;

            if (!String.IsNullOrWhiteSpace(projectName))
            {
                validProjectName = true;
            }
            if (validProjectName == false)
            {
                MessageBox.Show("Please enter a project name.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!String.IsNullOrWhiteSpace(projectPhase))
            {
                validProjectPhase = true;
            }
            if (validProjectPhase == false)
            {
                MessageBox.Show("Please enter a project phase.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!String.IsNullOrWhiteSpace(projectStatus))
            {
                validProjectStatus = true;
            }
            if (validProjectStatus == false)
            {
                MessageBox.Show("Please enter a project status.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (validProjectName == true && validProjectPhase == true && validProjectStatus == true)
            {
                db.UpdateProject(projectId, projectName, projectPhase, projectStatus);
                load();
                MessageBox.Show("The project has been updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            int projectId = (int)cboProjectName.SelectedValue;
            string projectName = cboProjectName.Text;

            bool validProjectName = false;

            if (!String.IsNullOrWhiteSpace(projectName))
            {
                validProjectName = true;
            }
            if (validProjectName == false)
            {
                MessageBox.Show("Please enter a project name.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (validProjectName == true)
            {
                db.DeleteProject(projectId);
                load();
                MessageBox.Show("The project has been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
