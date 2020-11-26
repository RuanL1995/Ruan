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
        internal void InsertProject(string projectName, string projectType, string projectPhase, string documentLocation)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TGDB")))
            {
                Projects newProject = new Projects();
                newProject.ProjectName = projectName;
                newProject.ProjectType = projectType;
                newProject.ProjectPhase = projectPhase;
                newProject.DocumentLocation = documentLocation;

                List<Projects> project = new List<Projects>();
                project.Add(newProject);

                connection.Execute("dbo.spProjectC1 @ProjectName, @ProjectType, @ProjectPhase, @DocumentLocation", project);
            }
        }
        #endregion
        #endregion
    }
}
