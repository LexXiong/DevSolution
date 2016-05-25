using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Boying.ContentManagement;
using Boying.Security;

namespace Boying.Users.Models
{
    public class UserPart : ContentPart<UserPartRecord>, IUser
    {
        public string Mobile
        {
            get { return Record.Mobile; }
            set { Record.Mobile = value; }
        }

        public string UserName
        {
            get { return Record.UserName; }
            set { Record.UserName = value; }
        }
    }
}