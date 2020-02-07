using System;
using System.Collections.Generic;
using System.Text;

namespace Opsumering
{
    public class User
    {
        public User(string login, string password, Job job)
        {
            Login = login;
            Password = password;
            Job = job;
        }

        public string Login { get; private set; }
        public string Password { get; private set; }
        public Job Job { get; private set; }

        public bool IsAdmin()
        {
            if(this is Admin)
            {
                return true;
            }
            return false;
        }
    }
}
