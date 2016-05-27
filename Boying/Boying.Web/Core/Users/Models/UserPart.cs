using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using Boying.Security;

namespace Boying.Core.Users.Models
{
    public class UserPart : UserRecord, IUser
    {
        public const string EmailPattern =
          @"^(?![\.@])(""([^""\r\\]|\\[""\r\\])*""|([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
          + @"@([a-z0-9][\w-]*\.)+[a-z]{2,}$";

        public const string MobilePattern = @"^1[3578]\d{9}$";
        public const int MaxUserNameLength = 255;
        public const int MaxEmailLength = 255;
    }
}