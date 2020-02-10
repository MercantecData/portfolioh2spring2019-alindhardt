using System;
using System.Linq;

namespace OpsumeringTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var registry = new Opsumering.Registry();
            registry.Users.AddRange(new Opsumering.User[] 
            {
                new Opsumering.User("User1", "Password1", null, () => registry.Admins),
                new Opsumering.User("User2", "Password1", null, () => registry.Admins),
                new Opsumering.User("User3", "Password1", null, () => registry.Admins),
                new Opsumering.User("User4", "Password1", null, () => registry.Admins),
                new Opsumering.User("User5", "Password1", null, () => registry.Admins)
            });

            var admin = new Opsumering.Admin("Admin1", "Password1", null, () => registry.Admins);
            registry.Admins.Add(admin);

            admin.ChangePassword(registry.Users.Single(x => x.Login == "User1"), "Password2");
        }
    }
}
