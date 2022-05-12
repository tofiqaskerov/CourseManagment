using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class RoleManager
    {
        ApplicationDbContext context = new();


        public void AddRole(string role) 
        {
            Role newRole = new();
            newRole.Name = role;
            context.Roles.Add(newRole);
            context.SaveChanges();
        }
    }
}
