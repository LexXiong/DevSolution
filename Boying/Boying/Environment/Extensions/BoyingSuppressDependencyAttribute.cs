using System;

namespace Boying.Environment.Extensions
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public class BoyingSuppressDependencyAttribute : Attribute
    {
        public BoyingSuppressDependencyAttribute(string fullName)
        {
            FullName = fullName;
        }

        public string FullName { get; set; }
    }
}