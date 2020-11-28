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
            //List<ProjectTasks> _tasks = new List<ProjectTasks>();
            //DataAccess db = new DataAccess();
            //_tasks = db.GetAllTasks();
            //DataSet dsTasks = new DataSet();
            //dsTasks = ListToDataSet.ToDataSet(_tasks);

            //DataView viewAssigned = new DataView(dsTasks.Tables[0]);
            //DataTable dtAssigened = viewAssigned.ToTable(true, "UserId", "TaskAssignedTo");

            //cboTaskAssigned.ValueMember = "UserId";
            //cboTaskAssigned.DisplayMember = "TaskAssignedTo";
            //cboTaskAssigned.DataSource = dtAssigened;

            //DataView viewProjectName = new DataView(dsTasks.Tables[0]);
            //DataTable dtProjectName = viewProjectName.ToTable(true, "ProjectId", "ProjectName");

            List<User> _users = new List<User>();
            DataAccess db = new DataAccess();
            _users = db.GetUsers();
            DataSet dsUsers = new DataSet();
            dsUsers = ListToDataSet.ToDataSet(_users);

            DataView viewUsers = new DataView(dsUsers.Tables[0]);
            DataTable dtUsers = viewUsers.ToTable(true, "UserId", "UserName");

            cboTaskAssigned.ValueMember = "UserId";
            cboTaskAssigned.DisplayMember = "UserName";
            cboTaskAssigned.DataSource = dtUsers;

            List<Projects> _projects = new List<Projects>();
            _projects = db.GetProject();
            DataSet dsProjects = new DataSet();
            dsProjects = ListToDataSet.ToDataSet(_projects);

            DataView viewProjectName = new DataView(dsProjects.Tables[0]);
            DataTable dtProjectName = viewProjectName.ToTable(true, "ProjectId", "ProjectName");

            cboProjectName.ValueMember = "ProjectId";
            cboProjectName.DisplayMember = "ProjectName";
            cboProjectName.DataSource = dtProjectName;
            cboProjectName.SelectedIndex = 0;

            if (System.Windows.Forms.Application.OpenForms["frmMainAdmin"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["frmMainAdmin"] as frmMainAdmin).refreshProjects();
            }

            if (System.Windows.Forms.Application.OpenForms["frmMainAdmin"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["frmMainAdmin"] as frmMainAdmin).refreshTasks();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool validateSuccessUser = false;
            bool validateSuccessProject = false;

            string taskName = txtTaskName.Text;
            string taskDesc = txtTaskDesc.Text;
            string taskProg = txtProg.Text;
            string taskAssigned = cboTaskAssigned.Text;
            string projectName = cboProjectName.Text;
            int userId = (int)cboTaskAssigned.SelectedValue;
            int projectId = (int)cboProjectName.SelectedValue;
            string taskStatus = cboTaskStatus.Text;

            DataAccess db = new DataAccess();

            ////CHECK IF USER ID EXISTS IN USER TABLE OR TASK TABLE
            //List<User> _users = new List<User>();
            //_users = db.GetUsers(); //Change to read from db
            //DataSet dsUsers = new DataSet();
            //dsUsers = ListToDataSet.ToDataSet(_users);
            //DataView viewUsers = new DataView(dsUsers.Tables[0]);
            //DataTable dtUsers = viewUsers.ToTable();

            //DataRow[] dtUsersRow = dtUsers.Select("UserName = '" + taskAssigned + "'");
            //DataTable dtUsersFilter = dtUsers.Clone();

            //foreach (DataRow row in dtUsersRow)
            //{
            //    dtUsersFilter.ImportRow(row);
            //}

            //List<ProjectTasks> _tasksF = new List<ProjectTasks>();
            //_tasksF = db.GetAllTasks(); //Change to read from db
            //DataSet dsTasksF = new DataSet();
            //dsTasksF = ListToDataSet.ToDataSet(_tasksF);
            //DataView viewTasksF = new DataView(dsTasksF.Tables[0]);
            //DataTable dtTasksF = viewTasksF.ToTable();

            //DataRow[] dtTasksFRow = dtTasksF.Select("TaskAssignedTo = '" + taskAssigned + "'");
            //DataTable dtTasksFFilter = dtTasksF.Clone();

            //foreach (DataRow row in dtTasksFRow)
            //{
            //    dtTasksFFilter.ImportRow(row);
            //}

            //if (dtUsersFilter.Rows.Count > 0)
            //{
            //    userId = dtUsersFilter.Rows[0].Field<int>("UserId");
            //    validateSuccessUser = true;
            //    doneUser = true;
            //}
            //else if (dtTasksFFilter.Rows.Count > 0 && doneUser == false)
            //{
            //    userId = (int)cboTaskAssigned.SelectedValue;
            //    validateSuccessUser = true;
            //}

            ////CHECK IF PROJECT ID EXISTS IN USER TABLE OR TASK TABLE
            //List<Projects> _projects = new List<Projects>();
            //_projects = db.GetProject(); //Change to read from db
            //DataSet dsProjects = new DataSet();
            //dsProjects = ListToDataSet.ToDataSet(_projects);
            //DataView viewProjects = new DataView(dsProjects.Tables[0]);
            //DataTable dtProjects = viewProjects.ToTable();

            //DataRow[] dtProjectsRow = dtProjects.Select("ProjectName = '" + projectName + "'");
            //DataTable dtProjectsFilter = dtProjects.Clone();

            //foreach (DataRow row in dtProjectsRow)
            //{
            //    dtProjectsFilter.ImportRow(row);
            //}

            //List<ProjectTasks> _tasksF1 = new List<ProjectTasks>();
            //_tasksF1 = db.GetAllTasks(); //Change to read from db
            //DataSet dsTasksF1 = new DataSet();
            //dsTasksF1 = ListToDataSet.ToDataSet(_tasksF1);
            //DataView viewTasksF1 = new DataView(dsTasksF1.Tables[0]);
            //DataTable dtTasksF1 = viewTasksF1.ToTable();

            //DataRow[] dtTasksFRow1 = dtTasksF1.Select("TaskAssignedTo = '" + taskAssigned + "'");
            //DataTable dtTasksFFilter1 = dtTasksF1.Clone();

            //foreach (DataRow row in dtTasksFRow1)
            //{
            //    dtTasksFFilter1.ImportRow(row);
            //}

            //if (dtProjectsFilter.Rows.Count > 0)
            //{
            //    projectId = dtProjectsFilter.Rows[0].Field<int>("ProjectId");
            //    validateSuccessProject = true;
            //    doneProject = true;
            //}
            //else if (dtTasksFFilter1.Rows.Count > 0 && doneProject == false)
            //{
            //    projectId = (int)cboProjectName.SelectedValue;
            //    validateSuccessProject = true;
            //}

            //INSERTS THE TASK
            //List<ProjectTasks> _tasks = new List<ProjectTasks>();

            //_tasks = db.GetAllTasks();
            //DataSet dsTasks = new DataSet();
            //dsTasks = ListToDataSet.ToDataSet(_tasks);

            //DataView viewAssigned = new DataView(dsTasks.Tables[0]);
            //DataTable dtAssigened = viewAssigned.ToTable(true, "UserId", "TaskAssignedTo");

            //DataView viewProjectName = new DataView(dsTasks.Tables[0]);
            //DataTable dtProjectName = viewProjectName.ToTable(true, "ProjectId", "ProjectName");
            List<User> _users = new List<User>();
            _users = db.GetUsers();
            DataSet dsUsers = new DataSet();
            dsUsers = ListToDataSet.ToDataSet(_users);

            DataView viewUsers = new DataView(dsUsers.Tables[0]);
            DataTable dtUsers = viewUsers.ToTable(true, "UserId", "UserName");

            cboTaskAssigned.ValueMember = "UserId";
            cboTaskAssigned.DisplayMember = "UserName";
            cboTaskAssigned.DataSource = dtUsers;

            List<Projects> _projects = new List<Projects>();
            _projects = db.GetProject();
            DataSet dsProjects = new DataSet();
            dsProjects = ListToDataSet.ToDataSet(_projects);

            DataView viewProjectName = new DataView(dsProjects.Tables[0]);
            DataTable dtProjectName = viewProjectName.ToTable(true, "ProjectId", "ProjectName");

            foreach (DataRow row in dtUsers.Rows)
            {
                if (userId == row.Field<Int32>("UserId"))
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
                if (projectId == row.Field<Int32>("ProjectId"))
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
                    taskId = (int)row["TaskId"];
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
                    taskId = (int)row["TaskId"];
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
