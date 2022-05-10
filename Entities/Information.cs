using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Information : Base
    {
        public string Fullname { get; set; }
        public string Notice { get; set; }
        public int EducationPlanId { get; set; }
        public EducationPlan EducationPlan { get; set; }
    }
}
