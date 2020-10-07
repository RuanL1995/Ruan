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
        public List<User> GetUsers(string userName)
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
    }
}
