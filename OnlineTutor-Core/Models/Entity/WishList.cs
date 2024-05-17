using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutor_Core.Models.Entity
{
    public class WishList 
    {
        public int WishListId { get; set; }
        public string ItemName { get; set; }
        public string ItemImage { get; set; }
        public int ? UserId { get; set; }
    }
}
