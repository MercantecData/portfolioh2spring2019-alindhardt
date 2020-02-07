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
            var label = string.Empty;

            if(user.IsAdmin())
            {
                Admins.Add(user as Admin);
                label = "admins";
            }
            else
            {
                Users.Add(user);
                label = "users";
            }

            Console.WriteLine("{0} added to list of {1}", user.Login, label);
        }

        public bool Login(string login, string password)
        {
            //Check if Users has a match
            var userWithLoginAndPassword = Users
                .Where(u => u.Login == login)
                .Where(u => u.Password == password)
                .FirstOrDefault();

            //If no matches where found in Users, check Admins
            if (userWithLoginAndPassword == null)
            {
                userWithLoginAndPassword = Admins
                    .Where(u => u.Login == login)
                    .Where(u => u.Password == password)
                    .FirstOrDefault();
            }

            return (userWithLoginAndPassword != null) ? true : false;
        }
    }
}
