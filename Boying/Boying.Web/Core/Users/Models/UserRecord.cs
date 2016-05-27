using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using Boying.Data;

namespace Boying.Core.Users.Models
{
    public class UserRecord : ContentRecord
    {
        [Encrypted]
        public virtual string Mobile { get; set; }

        public virtual string Email { get; set; }

        public virtual string NickName { get; set; }

        public virtual string Password { get; set; }

        public virtual MembershipPasswordFormat PasswordFormat { get; set; }

        public virtual string HashAlgorithm { get; set; }

        public virtual string PasswordSalt { get; set; }

        public virtual UserStatus RegistrationStatus { get; set; }

        public virtual UserStatus EmailStatus { get; set; }

        public virtual string EmailChallengeToken { get; set; }

        public virtual DateTime? CreatedUtc { get; set; }

        public virtual DateTime? LastLoginUtc { get; set; }

        public virtual DateTime? LastLogoutUtc { get; set; }
    }
}