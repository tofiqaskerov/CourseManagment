using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class TeacherManager
    {
        ApplicationDbContext context = new();


        public void AddTeacher(User user)
        {
            user.RoleId = 2;
            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}
