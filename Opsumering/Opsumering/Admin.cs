using System;
using System.Collections.Generic;
using System.Text;

namespace Opsumering
{
    public class Admin : User
    {
        public Admin(string login, string password, Job job, ListOfValidAdminsDelegate validAdminsDelegate) : base(login, password, job, validAdminsDelegate)
        {

        }

        public void ChangePassword(User user, string password)
        {
            Console.WriteLine("{0} please change password to {1}", user.Login, password);
        }
    }
}
