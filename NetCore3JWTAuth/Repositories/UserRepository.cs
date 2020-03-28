using ShopAPIJWT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAPIJWT.Repositories
{
    public static class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>();
            users.Add(new User { Id = 1, Username = "Batman", Password = "123456", Role = "manager"});
            users.Add(new User { Id = 2, Username = "robin", Password = "123456", Role = "employee"});

            return users
                .Where(u => u.Username.ToLower() == username.ToLower() && u.Password == password)
                .FirstOrDefault() ;
        }
    }
}
