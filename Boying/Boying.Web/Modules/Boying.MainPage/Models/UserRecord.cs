using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Boying.MainPage.Models
{
    public class UserRecord
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual int Age { get; set; }
    }
}