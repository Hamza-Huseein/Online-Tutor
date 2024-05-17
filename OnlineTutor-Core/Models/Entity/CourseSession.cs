using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutor_Core.Models.Entity
{
    public class CourseSession
    {
        public int CourseSessionId { get; set; }
        public int SessionId { get; set; }
        public int CourseId { get; set; }
    }
}
