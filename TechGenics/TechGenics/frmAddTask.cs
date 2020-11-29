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
            try
            {
                List<ProjectTasks> _tasks = new List<ProjectTasks>();
                DataAccess db = new DataAccess();
                _tasks = db.GetAllTasks();
                DataSet dsTasks = new DataSet();
                dsTasks = ListToDataSet.ToDataSet(_tasks);

                if (dsTasks.Tables[0].Rows.Count > 0)
                {
                    DataView viewAssigned = new DataView(dsTasks.Tables[0]);
                    DataTable dtAssigened = viewAssigned.ToTable(true, "TaskId", "TaskName");

                    cboTaskName.ValueMember = "TaskId";
                    cboTaskName.DisplayMember = "TaskName";
                    cboTaskName.DataSource = dtAssigened;
                }


                List<User> _users = new List<User>();
                _users = db.GetUsers();
                DataSet dsUsers = new DataSet();
                dsUsers = ListToDataSet.ToDataSet(_users);

                if (dsUsers.Tables[0].Rows.Count > 0)
                {
                    DataView viewUsers = new DataView(dsUsers.Tables[0]);
                    DataTable dtUsers = viewUsers.ToTable(true, "UserId", "UserName");

                    cboTaskAssigned.ValueMember = "UserId";
                    cboTaskAssigned.DisplayMember = "UserName";
                    cboTaskAssigned.DataSource = dtUsers;
                }


                List<Projects> _projects = new List<Projects>();
                _projects = db.GetProject();
                DataSet dsProjects = new DataSet();
                dsProjects = ListToDataSet.ToDataSet(_projects);

                if (dsProjects.Tables[0].Rows.Count > 0)
                {
                    DataView viewProjectName = new DataView(dsProjects.Tables[0]);
                    DataTable dtProjectName = viewProjectName.ToTable(true, "ProjectId", "ProjectName");

                    cboProjectName.ValueMember = "ProjectId";
                    cboProjectName.DisplayMember = "ProjectName";
                    cboProjectName.DataSource = dtProjectName;
                }



                cboTaskStatus.SelectedIndex = 0;

                if (System.Windows.Forms.Application.OpenForms["frmMainAdmin"] != null)
                {
                    (System.Windows.Forms.Application.OpenForms["frmMainAdmin"] as frmMainAdmin).refreshProjects();
                }

                if (System.Windows.Forms.Application.OpenForms["frmMainAdmin"] != null)
                {
                    (System.Windows.Forms.Application.OpenForms["frmMainAdmin"] as frmMainAdmin).refreshTasks();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool validateTaskName = false;
                bool validateTaskDesc = false;
                bool validateTaskProg = false;
                bool validateTaskAssigned = false;
                bool validateProjectName = false;
                bool validateProjectStatus = false;

                string taskName = cboTaskName.Text;
                string taskDesc = txtTaskDesc.Text;
                string taskProg = txtProg.Text;
                string taskAssigned = cboTaskAssigned.Text;
                string projectName = cboProjectName.Text;
                int userId = (int)cboTaskAssigned.SelectedValue;
                int projectId = (int)cboProjectName.SelectedValue;
                string taskStatus = cboTaskStatus.Text;

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

                if (!String.IsNullOrWhiteSpace(taskAssigned))
                {
                    validateTaskAssigned = true;
                }
                if (validateTaskAssigned == false)
                {
                    MessageBox.Show("Please enter a task assigned to.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (!String.IsNullOrWhiteSpace(projectName))
                {
                    validateProjectName = true;
                }
                if (validateProjectName == false)
                {
                    MessageBox.Show("Please enter a project name.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (!String.IsNullOrWhiteSpace(taskStatus))
                {
                    validateProjectStatus = true;
                }
                if (validateProjectStatus == false)
                {
                    MessageBox.Show("Please enter a project status.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                DataAccess db = new DataAccess();

                if (validateTaskName == true && validateTaskDesc == true && validateTaskProg == true && validateTaskAssigned == true && validateProjectName && validateProjectStatus == true)
                {
                    db.InsertTask(taskName, taskDesc, taskProg, taskAssigned, projectName, userId, projectId, taskStatus);
                    load();
                    MessageBox.Show("The new task has been added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                int taskId = (int)cboTaskName.SelectedValue;
                string taskName = cboTaskName.Text;
                string taskDesc = txtTaskDesc.Text;
                string taskProg = txtProg.Text;
                string taskAssigned = cboTaskAssigned.Text;
                string projectName = cboProjectName.Text;
                int userId = (int)cboTaskAssigned.SelectedValue;
                int projectId = (int)cboProjectName.SelectedValue;
                string taskStatus = cboTaskStatus.Text;

                bool validateTaskName = false;
                bool validateTaskDesc = false;
                bool validateTaskProg = false;
                bool validateTaskAssigned = false;
                bool validateProjectName = false;
                bool validateProjectStatus = false;

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

                if (!String.IsNullOrWhiteSpace(taskAssigned))
                {
                    validateTaskAssigned = true;
                }
                if (validateTaskAssigned == false)
                {
                    MessageBox.Show("Please enter a task assigned to.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (!String.IsNullOrWhiteSpace(projectName))
                {
                    validateProjectName = true;
                }
                if (validateProjectName == false)
                {
                    MessageBox.Show("Please enter a project name.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (!String.IsNullOrWhiteSpace(taskStatus))
                {
                    validateProjectStatus = true;
                }
                if (validateProjectStatus == false)
                {
                    MessageBox.Show("Please enter a project status.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                DataAccess db = new DataAccess();

                if (validateTaskName == true && validateTaskDesc == true && validateTaskProg == true && validateTaskAssigned == true && validateProjectName && validateProjectStatus == true)
                {
                    db.UpdateTask(taskId, taskName, taskDesc, taskProg, taskAssigned, projectName, userId, projectId, taskStatus);
                    load();
                    MessageBox.Show("The task has been updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            try
            {
                int taskId = (int)cboTaskName.SelectedValue;
                string taskName = cboTaskName.Text;

                bool validateTaskName = false;

                if (!String.IsNullOrWhiteSpace(taskName))
                {
                    validateTaskName = true;
                }
                if (validateTaskName == false)
                {
                    MessageBox.Show("Please enter a task name.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                DataAccess db = new DataAccess();

                if (validateTaskName == true)
                {
                    db.DeleteTask(taskId);
                    load();
                    MessageBox.Show("The task has been deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }
    }
}
