using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Opsumering
{
    public class Registry
    {
        public List<User> Users { get; private set; } = new List<User>();
        public List<Admin> Admins { get; private set; } = new List<Admin>();

        public void AddNewUser(User user)
        {
            Users.Add(user);
            Console.WriteLine("{0} added to list of users", user.Login);
        }

        public bool Login(string login, string password)
        {
            var userWithLoginAndPassword = Users
                .Where(u => u.Login == login)
                .Where(u => u.Password == password)
                .FirstOrDefault();

            return (userWithLoginAndPassword != null) ? true : false;
        }
    }
}
