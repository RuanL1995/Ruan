using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechGenics.Models
{
    public class Project
    {
        public int ProjecId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectType { get; set; }
        public string ProjectStatus { get; set; }
        public string ProjectLocation { get; set; }
    }
}
