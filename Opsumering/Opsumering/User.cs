using System;
using System.Collections.Generic;
using System.Text;

namespace Opsumering
{
    public class User
    {
        public string Login { get; private set; }
        public string Password { get; private set; }
        public Job Job { get; private set; }

        public bool IsAdmin()
        {
            return false;
        }
    }
}
