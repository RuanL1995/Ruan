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
        /// Data Access for tblPhase
        /// </summary>
        #region tblPhase
        /// <summary>
        /// All data read operations for tblPhase
        /// </summary>
        #region Data Read
        /// <summary>
        /// Gets all the phase information
        /// </summary>
        public List<Phase> GetPhase()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TGDB")))
            {
                return connection.Query<Phase>("dbo.spPhaseR1").ToList();
            }
        }
        #endregion
        /// <summary>
        /// All data write operations for tblPhase
        /// </summary>
        #region Data Write
        /// <summary>
        /// Inserts a new phase into tblPhase
        /// </summary>
        internal void InsertPhase(string phaseName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TGDB")))
            {
                Phase newPhase = new Phase();
                newPhase.PhaseName = phaseName;

                List<Phase> phase = new List<Phase>();
                phase.Add(newPhase);

                connection.Execute("dbo.spPhaseC1 @PhaseName", phase);
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
        public List<Project> GetProject()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TGDB")))
            {
                return connection.Query<Project>("dbo.spProjectR1").ToList();
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
        internal void InsertProject(string projectName, string projectType, string projectStatus, string projectLocation)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TGDB")))
            {
                Project newProject = new Project();
                newProject.ProjectName = projectName;
                newProject.ProjectType = projectType;
                newProject.ProjectStatus = projectStatus;
                newProject.ProjectLocation = projectLocation;

                List<Project> project = new List<Project>();
                project.Add(newProject);

                connection.Execute("dbo.spProjectC1 @ProjectName, @ProjectType, @ProjectStatus, @ProjectLocation", project);
            }
        }
        #endregion
        #endregion

        /// <summary>
        /// Data Access for tblProjectPhase
        /// </summary>
        #region tblProjectPhase
        /// <summary>
        /// All data read operations for tblProjectPhase
        /// </summary>
        #region Data Read
        /// <summary>
        /// Gets all information from tblProjectPhase
        /// </summary>
        public List<ProjectPhase> GetProjectPhase()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TGDB")))
            {
                return connection.Query<ProjectPhase>("dbo.spProjectPhaseR1").ToList();
            }
        }
        #endregion
        #endregion

        /// <summary>
        /// Data Access for tblUserProject
        /// </summary>
        #region tblUserProject
        /// <summary>
        /// All data read operations for tblUserProject
        /// </summary>
        #region Data Read
        /// <summary>
        /// Gets all information on tblUserProject
        /// </summary>
        public List<UserProject> GetUserProject()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TGDB")))
            {
                return connection.Query<UserProject>("dbo.spUserProjectR1").ToList();
            }
        }
        #endregion
        #endregion
    }
}
