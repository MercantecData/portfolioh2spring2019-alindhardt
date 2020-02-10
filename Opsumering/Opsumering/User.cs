using System;
using System.Collections.Generic;
using System.Text;

namespace Opsumering
{
    public class User
    {
        string password;
        public User(string login, string password, Job job)
        {
            Login = login;
            this.password = password;
            Job = job;
        }

        public string Login { get; private set; }
        public Job Job { get; private set; }

        public bool IsAdmin()
        {
            if(this is Admin)
            {
                return true;
            }
            return false;
        }
        public bool CheckPassword(string password)
        {
            return this.password == password ? true : false;
        }
    }
}
