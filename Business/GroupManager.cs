﻿using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class GroupManager
    {
        ApplicationDbContext context = new();

        public void AddGroup(Group group)
        {
            context.Groups.Add(group);
            context.SaveChanges();
        }

        public IQueryable<Group> GetAllGroups()
        {
            return context.Groups.Include(x => x.User).Include(x =>x.ShiftTime);
        }
        public Group GetGroupByName(string name)
        {
            var group = context.Groups.FirstOrDefault(x => x.Name == name);
            return group;
            
        }
        public void UpdateGroup(Group group)
        {
            context.Groups.Update(group);
            context.SaveChanges();
        }
        public Group GetGroupById(int id)
        {
           return context.Groups.Include(x =>x.User).Include(x=>x.ShiftTime).FirstOrDefault(x => x.Id == id);
        }
        public void DeleteGroup(int id)
        {
            var group = context.Groups.FirstOrDefault(x => x.Id == id); 
            context.Groups.Remove(group);
            context.SaveChanges();
        }

    }
}
