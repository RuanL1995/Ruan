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
    public partial class frmAddTask : Form
    {
        public frmAddTask()
        {
            InitializeComponent();
        }

        private void frmAddTask_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            List<ProjectTasks> _tasks = new List<ProjectTasks>();
            DataAccess db = new DataAccess();
            _tasks = db.GetAllTasks();
            DataSet dsTasks = new DataSet();
            dsTasks = ListToDataSet.ToDataSet(_tasks);

            DataView viewAssigned = new DataView(dsTasks.Tables[0]);
            DataTable dtAssigened = viewAssigned.ToTable(true, "UserId", "TaskAssignedTo");

            cboTaskAssigned.ValueMember = "UserId";
            cboTaskAssigned.DisplayMember = "TaskAssignedTo";
            cboTaskAssigned.DataSource = dtAssigened;

            DataView viewProjectName = new DataView(dsTasks.Tables[0]);
            DataTable dtProjectName = viewProjectName.ToTable(true, "ProjectId", "ProjectName");

            cboProjectName.ValueMember = "ProjectId";
            cboProjectName.DisplayMember = "ProjectName";
            cboProjectName.DataSource = dtProjectName;
            cboProjectName.SelectedIndex = 0;

            frmMainAdmin mainAdmin = new frmMainAdmin();
            if (System.Windows.Forms.Application.OpenForms["frmMainAdmin"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["frmMainAdmin"] as frmMainAdmin).refreshTasks();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string taskName = txtTaskName.Text;
            string taskDesc = txtTaskDesc.Text;
            string taskProg = txtProg.Text;
            string taskAssigned = cboTaskAssigned.Text;
            string projectName = cboProjectName.Text;
            int userId = (int)cboTaskAssigned.SelectedValue;
            int projectId = (int)cboProjectName.SelectedValue;
            string taskStatus = cboTaskStatus.Text;

            List<ProjectTasks> _tasks = new List<ProjectTasks>();
            DataAccess db = new DataAccess();
            
            _tasks = db.GetAllTasks();
            DataSet dsTasks = new DataSet();
            dsTasks = ListToDataSet.ToDataSet(_tasks);

            bool validateSuccessUser = false;
            bool validateSuccessProject = false;
            DataView viewAssigned = new DataView(dsTasks.Tables[0]);
            DataTable dtAssigened = viewAssigned.ToTable(true, "UserId", "TaskAssignedTo");

            DataView viewProjectName = new DataView(dsTasks.Tables[0]);
            DataTable dtProjectName = viewProjectName.ToTable(true, "ProjectId", "ProjectName");

            foreach (DataRow row in dtAssigened.Rows)
            {
                if (userId == (int)row["UserId"])
                {
                    validateSuccessUser = true;
                    break;
                }
            }
            if (validateSuccessUser == false)
            {
                MessageBox.Show("That user does not exist.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validateSuccessUser = false;
            }

            foreach (DataRow row in dtProjectName.Rows)
            {
                if (projectId == (int)row["ProjectId"])
                {
                    validateSuccessProject = true;
                    break;
                }
            }
            if (validateSuccessProject == false)
            {
                MessageBox.Show("That project does not exist.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validateSuccessProject = false;
            }

            if (validateSuccessUser == true && validateSuccessProject == true)
            {
                db.InsertTask(taskName, taskDesc, taskProg, taskAssigned, projectName, userId, projectId, taskStatus);
                load();
                MessageBox.Show("The new task has been added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int taskId = 0;
            string taskName = txtTaskName.Text;
            string taskDesc = txtTaskDesc.Text;
            string taskProg = txtProg.Text;
            string taskAssigned = cboTaskAssigned.Text;
            string projectName = cboProjectName.Text;
            int userId = (int)cboTaskAssigned.SelectedValue;
            int projectId = (int)cboProjectName.SelectedValue;
            string taskStatus = cboTaskStatus.Text;

            List<ProjectTasks> _tasks = new List<ProjectTasks>();
            DataAccess db = new DataAccess();

            _tasks = db.GetAllTasks();
            DataSet dsTasks = new DataSet();
            dsTasks = ListToDataSet.ToDataSet(_tasks);

            bool validateTask = false;
            bool validateTaskName = false;
            bool validateTaskDesc = false;
            bool validateTaskProg = false;
            bool validateSuccessUser = false;
            bool validateSuccessProject = false;
            DataView viewAssigned = new DataView(dsTasks.Tables[0]);
            DataTable dtAssigened = viewAssigned.ToTable(true, "UserId", "TaskAssignedTo");

            DataView viewProjectName = new DataView(dsTasks.Tables[0]);
            DataTable dtProjectName = viewProjectName.ToTable(true, "ProjectId", "ProjectName");

            foreach (DataRow row in dsTasks.Tables[0].Rows)
            {
                if (row["TaskName"].ToString() == taskName)
                {
                    taskId = (int)row["TaskID"];
                    validateTask = true;
                    break;
                }
            }
            if (validateTask == false)
            {
                MessageBox.Show("That task does not exist.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!String.IsNullOrWhiteSpace(taskName))
            {
                validateTaskName = true;
            }
            if (validateTaskName == false)
            {
                MessageBox.Show("Please enter a task name.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!String.IsNullOrWhiteSpace(taskDesc))
            {
                validateTaskDesc = true;
            }
            if (validateTaskDesc == false)
            {
                MessageBox.Show("Please enter a task desc.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!String.IsNullOrWhiteSpace(taskProg))
            {
                validateTaskProg = true;
            }
            if (validateTaskProg == false)
            {
                MessageBox.Show("Please enter a task progress.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (DataRow row in dtAssigened.Rows)
            {
                if (userId == (int)row["UserId"])
                {
                    validateSuccessUser = true;
                    break;
                }
            }
            if (validateSuccessUser == false)
            {
                MessageBox.Show("That user does not exist.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validateSuccessUser = false;
            }

            foreach (DataRow row in dtProjectName.Rows)
            {
                if (projectId == (int)row["ProjectId"])
                {
                    validateSuccessProject = true;
                    break;
                }
            }
            if (validateSuccessProject == false)
            {
                MessageBox.Show("That project does not exist.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validateSuccessProject = false;
            }

            if (validateTask == true && validateTaskName == true && validateTaskDesc == true && validateTaskProg == true && validateSuccessUser == true && validateSuccessProject == true)
            {
                db.UpdateTask(taskId, taskName, taskDesc, taskProg, taskAssigned, projectName, userId, projectId, taskStatus);
                load();
                MessageBox.Show("The task has been updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int taskId = 0;
            string taskName = txtTaskName.Text;          

            List<ProjectTasks> _tasks = new List<ProjectTasks>();
            DataAccess db = new DataAccess();

            _tasks = db.GetAllTasks();
            DataSet dsTasks = new DataSet();
            dsTasks = ListToDataSet.ToDataSet(_tasks);

            bool validateTask = false;
            bool validateTaskName = false;                 

            foreach (DataRow row in dsTasks.Tables[0].Rows)
            {
                if (row["TaskName"].ToString() == taskName)
                {
                    taskId = (int)row["TaskID"];
                    validateTask = true;
                    break;
                }
            }
            if (validateTask == false)
            {
                MessageBox.Show("That task does not exist.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!String.IsNullOrWhiteSpace(taskName))
            {
                validateTaskName = true;
            }
            if (validateTaskName == false)
            {
                MessageBox.Show("Please enter a task name.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                       

            if (validateTask == true && validateTaskName == true)
            {
                db.DeleteTask(taskId);
                load();
                MessageBox.Show("The task has been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
