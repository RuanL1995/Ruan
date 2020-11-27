using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechGenics.Models
{
    public class ProjectTasks
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public string TaskProgress { get; set; }
        public string TaskAssignedTo { get; set; }
        public string TaskStatus { get; set; }
    }
}
