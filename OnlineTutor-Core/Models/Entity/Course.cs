using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutor_Core.Models.Entity
{
    public class Course 
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public float DisacountAmount { get; set; }
        public string DiscountType  { get; set; }
        public bool isHaveDiscount { get; set; }
    }
}
