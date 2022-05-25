using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ShiftManager
    {
        ApplicationDbContext context = new();
        public List<ShiftTime> GetShiftTimes()
        {
            return context.ShiftTimes.ToList();
        }
        public ShiftTime GetShiftByName(string name) //bu formadada yazmaq olar => context.ShiftTimes.FirstOrDefault(x => x.Name == name); 
        {
           return context.ShiftTimes.FirstOrDefault(x => x.Name == name); 
        }

        public void addShift(string shift)
        {
            ShiftTime newShiftTime = new();
            newShiftTime.Name = shift;
            context.ShiftTimes.Add(newShiftTime);
            context.SaveChanges();
        }
        
    }
}
