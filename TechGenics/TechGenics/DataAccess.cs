using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechGenics.Models;
using Dapper;
using System.Data;

namespace TechGenics
{
    public class DataAccess
    {
        /// <summary>
        /// Data Access for tblUser
        /// </summary>
        #region tblUser
        /// <summary>
        /// All data read operations for tblUser
        /// </summary>
        #region Data Read
        /// <summary>
        /// Gets the user filtered by txtUserName in order to login
        /// </summary>
        public List<User> GetUser(string userName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TGDB")))
            {
                return connection.Query<User>("dbo.spUserR1 @UserName", new { UserName = userName }).ToList();
            }
        }

        /// <summary>
        /// Gets all users
        /// </summary>
        /// <returns></returns>
        public List<User> GetUsers()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TGDB")))
            {
                return connection.Query<User>("dbo.spUserR2").ToList();
            }
        }
        #endregion
        /// <summary>
        /// All data write operations for tblUser
        /// </summary>
        #region Data Write
        /// <summary>
        /// Inserts a new user when btnRegister is clicked
        /// </summary>
        internal void InsertUser(string userName, string userPassword, string firstName, string surName, string email)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TGDB")))
            {
                User newUser = new User();
                newUser.UserName = userName;
                newUser.UserPassword = userPassword;
                newUser.FirstName = firstName;
                newUser.SurName = surName;
                newUser.Email = email;

                List<User> user = new List<User>();
                user.Add(newUser);

                connection.Execute("dbo.spUserC1 @UserName, @UserPassword, @FirstName, @SurName, @Email", user);
            }
        }
        /// <summary>
        /// Inserts a new user by admin
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="userPassword"></param>
        /// <param name="firstName"></param>
        /// <param name="surName"></param>
        /// <param name="email"></param>
        /// <param name="initiation"></param>
        /// <param name="planning"></param>
        /// <param name="execution"></param>
        /// <param name="closeOut"></param>
        internal void InsertUserByAdmin(string userName, string userPassword, string firstName, string surName, string email, bool initiation, bool planning, bool execution, bool closeOut)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TGDB")))
            {
                User newUser = new User();
                newUser.UserName = userName;
                newUser.UserPassword = userPassword;
                newUser.FirstName = firstName;
                newUser.SurName = surName;
                newUser.Email = email;
                newUser.Initiation = initiation;
                newUser.Planning = planning;
                newUser.Execution = execution;
                newUser.CloseOut = closeOut;

                List<User> user = new List<User>();
                user.Add(newUser);

                connection.Execute("dbo.spUserC2 @UserName, @UserPassword, @FirstName, @SurName, @Email, @Initiation, @Planning, @Execution, @CloseOut", user);
            }
        }
        /// <summary>
        /// Updates a user
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userName"></param>
        /// <param name="userPassword"></param>
        /// <param name="firstName"></param>
        /// <param name="surName"></param>
        /// <param name="email"></param>
        /// <param name="initiation"></param>
        /// <param name="planning"></param>
        /// <param name="execution"></param>
        /// <param name="closeOut"></param>
        internal void UpdateUser(int userId, string userName, string userPassword, string firstName, string surName, string email, bool initiation, bool planning, bool execution, bool closeOut)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TGDB")))
            {
                User newUser = new User();
                newUser.UserId = userId;
                newUser.UserName = userName;
                newUser.UserPassword = userPassword;
                newUser.FirstName = firstName;
                newUser.SurName = surName;
                newUser.Email = email;
                newUser.Initiation = initiation;
                newUser.Planning = planning;
                newUser.Execution = execution;
                newUser.CloseOut = closeOut;

                List<User> user = new List<User>();
                user.Add(newUser);

                connection.Execute("dbo.spUserU2 @UserId, @UserName, @UserPassword, @FirstName, @SurName, @Email, @Initiation, @Planning, @Execution, @CloseOut", user);
            }
        }
        /// <summary>
        /// Deletes a user
        /// </summary>
        /// <param name="userId"></param>
        internal void DeleteUser(int userId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TGDB")))
            {
                User newUser = new User();
                newUser.UserId = userId;

                List<User> user = new List<User>();
                user.Add(newUser);

                connection.Execute("dbo.spUserD2 @UserId", user);
            }
        }
        #endregion
        #endregion

        /// <summary>
        /// Data Access for tblAdmin
        /// </summary>
        #region tblAdmin
        /// <summary>
        /// All data read operations for tblAdmin
        /// </summary>
        #region Data Read
        /// <summary>
        /// Gets the user filtered by txtUserName in order to login
        /// </summary>
        public List<Admin> GetAdmin(string adminName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TGDB")))
            {
                return connection.Query<Admin>("dbo.spAdminR1 @AdminName", new { AdminName = adminName }).ToList();
            }
        }
        #endregion
        /// <summary>
        /// All data write operations for tblAdmin
        /// </summary>
        #region Data Write
        /// <summary>
        /// Inserts a new admin when btnRegister is clicked
        /// </summary>
        internal void InsertAdmin(string adminName, string adminPassword, string adminFirstName, string adminSurName, string adminEmail)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TGDB")))
            {
                Admin newAdmin = new Admin();
                newAdmin.AdminName = adminName;
                newAdmin.AdminPassword = adminPassword;
                newAdmin.AdminFirstName = adminFirstName;
                newAdmin.AdminSurName = adminSurName;
                newAdmin.AdminEmail = adminEmail;

                List<Admin> admin = new List<Admin>();
                admin.Add(newAdmin);

                connection.Execute("dbo.spAdminC1 @AdminName, @AdminPassword, @AdminFirstName, @AdminSurName, @AdminEmail", admin);
            }
        }
        #endregion
        #endregion    

        /// <summary>
        /// Data Access for tblProject
        /// </summary>
        #region tblProject
        /// <summary>
        /// All data read operations for tblProject
        /// </summary>
        #region Data Read
        /// <summary>
        /// Gets all information on all projects
        /// </summary>
        public List<Projects> GetProject()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TGDB")))
            {
                return connection.Query<Projects>("dbo.spProjectR1").ToList();
            }
        }
        /// <summary>
        /// Gets all information all projects and tasks assigend to a user by phase
        /// </summary>
        public List<ProjectsAndTasksByUserPhase> GetProjectAndTaskInfo(string currentUser, bool initiation, bool planning, bool execution, bool closeOut)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TGDB")))
            {
                return connection.Query<ProjectsAndTasksByUserPhase>("dbo.spProjectR2 @CurrentUser, @Initiation, @Planning, @Execution, @closeOut",
                    new { 
                            CurrentUser = currentUser,
                            Initiation = initiation, 
                            Planning = planning, 
                            Execution = execution, 
                            CloseOut = closeOut
                        }
                    ).ToList();
            }
        }
        #endregion
        /// <summary>
        /// All data write operations for tblProject
        /// </summary>
        #region Data Write
        /// <summary>
        /// Inserts a new project into tblProject
        /// </summary>
        internal void InsertProject(string projectName, string projectType, string projectPhase)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TGDB")))
            {
                Projects newProject = new Projects();
                newProject.ProjectName = projectName;
                newProject.ProjectType = projectType;
                newProject.ProjectPhase = projectPhase;

                List<Projects> project = new List<Projects>();
                project.Add(newProject);

                connection.Execute("dbo.spProjectC1 @ProjectName, @ProjectType, @ProjectPhase", project);
            }
        }
        /// <summary>
        /// Updates a project
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
        /// <param name="projectType"></param>
        /// <param name="projectPhase"></param>
        internal void UpdateProject(int projectId, string projectName, string projectType, string projectPhase)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TGDB")))
            {
                Projects newProject = new Projects();
                newProject.ProjectId = projectId;
                newProject.ProjectName = projectName;
                newProject.ProjectType = projectType;
                newProject.ProjectPhase = projectPhase;

                List<Projects> project = new List<Projects>();
                project.Add(newProject);

                connection.Execute("dbo.spUpdateProjectRecord @ProjectId, @ProjectName, @ProjectType, @ProjectPhase", project);
            }
        }
        /// <summary>
        /// Deletes a project
        /// </summary>
        /// <param name="projectId"></param>
        internal void DeleteProject(int projectId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TGDB")))
            {
                Projects newProject = new Projects();
                newProject.ProjectId = projectId;

                List<Projects> project = new List<Projects>();
                project.Add(newProject);

                connection.Execute("dbo.spDeleteProjectRecord @ProjectId", project);
            }
        }
        internal void insertDocumentLocation(string path, string projectName, string projectPhase)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TGDB")))
            {
                Projects doc = new Projects();

                string updateDocQuery = @"UPDATE tblProject SET documentation = " + path + " WHERE ProjectName = " + projectName + " AND ProjectPhase = " + projectPhase;

                var result = connection.Execute(updateDocQuery, new
                {
                    doc.DocumentLocation,
                    doc.ProjectName,
                    doc.ProjectPhase
                });
            }
        }
        #endregion
        #endregion

        /// <summary>
        /// Data Access for tblTask
        /// </summary>
        #region tblTask
        /// <summary>
        /// All data read operations for tblTask
        /// </summary>
        #region Data Read
        public List<ProjectTasks> GetAllTasks()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TGDB")))
            {
                return connection.Query<ProjectTasks>("dbo.spTaskR1").ToList();
            }
        }
        #endregion
        /// <summary>
        /// All data write operations for tblProject
        /// </summary>
        #region Data Write
        /// <summary>
        /// Inserts a new project into tblTask
        /// </summary>
        internal void UpdateTaskStatus(int taskId, string taskStatus)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TGDB")))
            {
                ProjectTasks newTask = new ProjectTasks();
                newTask.TaskId = taskId;
                newTask.TaskStatus = taskStatus;

                List<ProjectTasks> task = new List<ProjectTasks>();
                task.Add(newTask);

                connection.Execute("dbo.spTaskU1 @TaskId, @TaskStatus", task);
            }
        }
        /// <summary>
        /// Inserts a new task
        /// </summary>
        /// <param name="taskName"></param>
        /// <param name="taskDescription"></param>
        /// <param name="taskProgress"></param>
        /// <param name="taskAssignedTo"></param>
        /// <param name="projectName"></param>
        /// <param name="userId"></param>
        /// <param name="projectId"></param>
        /// <param name="taskStatus"></param>
        internal void InsertTask(string taskName, string taskDescription, string taskProgress, string taskAssignedTo, string projectName, int userId, int projectId, string taskStatus)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TGDB")))
            {
                ProjectTasks newTask = new ProjectTasks();
                newTask.TaskName = taskName;
                newTask.TaskDescription = taskDescription;
                newTask.TaskProgress = taskProgress;
                newTask.TaskAssignedTo = taskAssignedTo;
                newTask.ProjectName = projectName;
                newTask.UserId = userId;
                newTask.ProjectId = projectId;
                newTask.TaskStatus = taskStatus;

                List<ProjectTasks> task = new List<ProjectTasks>();
                task.Add(newTask);

                connection.Execute("dbo.spTaskC1 @TaskName, @TaskDescription, @TaskProgress, @TaskAssignedTo, @ProjectName, @UserId, @ProjectId, @TaskStatus", task);
            }
        }
        /// <summary>
        /// Updates a task
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="taskName"></param>
        /// <param name="taskDescription"></param>
        /// <param name="taskProgress"></param>
        /// <param name="taskAssignedTo"></param>
        /// <param name="projectName"></param>
        /// <param name="userId"></param>
        /// <param name="projectId"></param>
        /// <param name="taskStatus"></param>
        internal void UpdateTask(int taskId, string taskName, string taskDescription, string taskProgress, string taskAssignedTo, string projectName, int userId, int projectId, string taskStatus)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TGDB")))
            {
                ProjectTasks newTask = new ProjectTasks();
                newTask.TaskId = taskId;
                newTask.TaskName = taskName;
                newTask.TaskDescription = taskDescription;
                newTask.TaskProgress = taskProgress;
                newTask.TaskAssignedTo = taskAssignedTo;
                newTask.ProjectName = projectName;
                newTask.UserId = userId;
                newTask.ProjectId = projectId;
                newTask.TaskStatus = taskStatus;

                List<ProjectTasks> task = new List<ProjectTasks>();
                task.Add(newTask);

                connection.Execute("dbo.spTaskU2 @TaskId, @TaskName, @TaskDescription, @TaskProgress, @TaskAssignedTo, @ProjectName, @UserId, @ProjectId, @TaskStatus", task);
            }
        }
        /// <summary>
        /// Deletes a task
        /// </summary>
        /// <param name="taskId"></param>
        internal void DeleteTask(int taskId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TGDB")))
            {
                ProjectTasks newTask = new ProjectTasks();
                newTask.TaskId = taskId;             

                List<ProjectTasks> task = new List<ProjectTasks>();
                task.Add(newTask);

                connection.Execute("dbo.spDeleteTaskRecord @TaskId", task);
            }
        }
        #endregion
        #endregion
    }
}
