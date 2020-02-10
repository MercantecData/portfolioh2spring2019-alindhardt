using System;
using System.Collections.Generic;
using System.Text;

namespace Opsumering
{
    /// <summary>
    /// List of valid Admins. Ex: () => registry.Admins;
    /// </summary>
    /// <returns></returns>
    public delegate List<Admin> ListOfValidAdminsDelegate();
    public class User
    {
        protected string password;
        ListOfValidAdminsDelegate validAdminsDelegate;

        /// <summary>
        /// Create new user, with a pointer to a list of valid admins.
        /// </summary>
        /// <param name="login">User's login</param>
        /// <param name="password">User's password</param>
        /// <param name="job">Type of job, the user has. Can be null</param>
        /// <param name="validAdminsDelegate">Pointer to a list of valid admins. Used for authorizing password change.</param>
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

        /// <summary>
        /// Validate password of user.
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool CheckPassword(string password)
        {
            return this.password == password ? true : false;
        }

        /// <summary>
        /// Checks if admin is valid, then changes password.
        /// </summary>
        /// <param name="admin">Admin who is changing the password.</param>
        /// <param name="adminPassword">The password of the admin, who is changing the password.</param>
        /// <param name="newPassword">The new password of the user.</param>
        /// <returns>true if password is changed.</returns>
        public bool ChangePassword(Admin admin, string adminPassword, string newPassword)
        {
            //Check if admin is part of the list in pointer to valid admins
            if (validAdminsDelegate().Contains(admin))
            {
                //Check if admins password matches
                if (admin.CheckPassword(adminPassword))
                {
                    //Change password
                    password = newPassword;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Change password.
        /// </summary>
        /// <param name="oldPassword">The current password.</param>
        /// <param name="newPassword">The new password.</param>
        /// <returns></returns>
        public bool ChangePassword(string oldPassword, string newPassword)
        {
            if (password != oldPassword) return false;

            password = newPassword;
            return true;
        }
    }
}
