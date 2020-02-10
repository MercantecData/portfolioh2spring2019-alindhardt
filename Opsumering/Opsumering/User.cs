using System;
using System.Collections.Generic;
using System.Text;

namespace Opsumering
{
    public delegate List<Admin> ListOfValidAdminsDelegate();
    public class User
    {
        string password;
        ListOfValidAdminsDelegate validAdminsDelegate;
        public User(string login, string password, Job job, ListOfValidAdminsDelegate validAdminsDelegate)
        {
            Login = login;
            this.password = password;
            Job = job;
            this.validAdminsDelegate = validAdminsDelegate;
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
