using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class UserManager
    {
        ApplicationDbContext context = new();
        public void Register(User user, string userPassword)
        {
            user.Password = PasswordHash(userPassword);
            context.Users.Add(user); 
            context.SaveChanges();
        }
        public User GetByEmail(string email)
        {
            return context.Users.FirstOrDefault(x => x.Email == email);
        }
        public string PasswordHash( string password)
        {
            using SHA256 sha256 = SHA256.Create();
            byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

            StringBuilder returnPassword = new();
            for(int i=0; i<hash.Length; i++)
            {
                returnPassword.Append(hash[i].ToString("x2"));
            }
            return returnPassword.ToString();
        }
    }
}
