using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class PaymentManager
    {
        ApplicationDbContext context = new();
        public void AddPayment (int studentId , double price)
        {
            PaymentList payment = new()
            {
                StudentId = studentId,
                Price = price,
                PayDate = DateTime.Now
            };
            context.PaymentLists.Add(payment);
            context.SaveChanges();
        }
        public PaymentList GetPaymentListById(int studentId)
        {
            return context.PaymentLists.FirstOrDefault(x =>x.StudentId == studentId);
        }
    }
}
