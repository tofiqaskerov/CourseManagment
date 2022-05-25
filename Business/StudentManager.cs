using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class StudentManager
    {
        ApplicationDbContext context = new();
        public Student AddStudent(Student student)
        {
            
            context.Students.Add(student);
            context.SaveChanges();
            return student;
        }
        public IQueryable<Student> GetAllStudents()
        {
            return context.Students;
        } // =>  -- return demekdir
        
        public Student GetStudentById(int studentId)
        {
            return context.Students.Include(x => x.Groups).FirstOrDefault(x =>x.Id == studentId);
        }
        public void UpdateStudent(Student student, PaymentList payment)
        {
;            context.Students.Update(student);
             context.PaymentLists.Update(payment);
             context.SaveChanges();
        }
        public void DeleteGroup(int studentId)
        {
            var student = context.Students.FirstOrDefault(x => x.Id == studentId);
            context.Students.Remove(student);
            context.SaveChanges();
        }
        

       

    }
}
