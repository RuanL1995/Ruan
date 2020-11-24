using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechGenics.Models
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        public string AdminPassword { get; set; }
        public string AdminFirstName { get; set; }
        public string AdminSurName { get; set; }
        public string AdminEmail { get; set; }

        //Combines Admin properties into one combo property
        public string FullInfoUser
        {
            get
            {
                return $"{AdminName} {AdminPassword}";
            }
        }

        public string FullInfoIdentity
        {
            get
            {
                return $"{AdminFirstName} {AdminSurName} {AdminEmail}";
            }
        }
    }
}
