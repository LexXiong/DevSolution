using System;
using System.Web.Mvc;

namespace Boying.Mvc.AntiForgery
{
    [AttributeUsage(AttributeTargets.Method)]
    public class ValidateAntiForgeryTokenBoyingAttribute : FilterAttribute
    {
        private readonly bool _enabled = true;

        public ValidateAntiForgeryTokenBoyingAttribute() : this(true)
        {
        }

        public ValidateAntiForgeryTokenBoyingAttribute(bool enabled)
        {
            _enabled = enabled;
        }

        public bool Enabled { get { return _enabled; } }
    }
}