using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechGenics.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }

        //Combines User properties into one combo property
        public string FullInfo
        {
            get 
            {
                return $"{UserName} {UserPassword}";
            }
        }
    }
}
