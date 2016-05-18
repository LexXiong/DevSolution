using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Boying.Security;

namespace Boying.Users.Events
{
    public class UserContext
    {
        public IUser User { get; set; }

        public bool Cancel { get; set; }

        public CreateUserParams UserParameters { get; set; }
    }
}