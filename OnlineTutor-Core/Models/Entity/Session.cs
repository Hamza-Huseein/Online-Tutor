using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutor_Core.Models.Entity
{
    public class Session 
    {
        public int SessionId { get; set; }
        public DateTime DateTime { get; set; }
        public int Capacity { get; set; }
        public string Topics { get; set; }
        public int ? CourseId { get; set; }
    }
}
