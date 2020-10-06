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
        public List<User> GetUsers(string userName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TGDB")))
            {
                return connection.Query<User>("dbo.spUserR1 @UserName", new { UserName = userName }).ToList();
            }
        }
    }
}
