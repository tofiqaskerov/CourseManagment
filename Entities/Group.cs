using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Group : Base
    { 
        public string Name { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int ShiftTimeId { get; set; }
        public ShiftTime ShiftTime { get; set; }
       
    }
}
