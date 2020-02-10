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

        /// <summary>
        /// Change Password of a user.
        /// </summary>
        /// <param name="user">The user to change password on.</param>
        /// <param name="password">The new password.</param>
        public void ChangePassword(User user, string password)
        {
            //attempt password change.
            if(user.ChangePassword(this, this.password, password))
            {
                Console.WriteLine("Successfully changed password.");
            }
            else
            {
                Console.WriteLine("Failed to change password.");
            }
        }
    }
}
