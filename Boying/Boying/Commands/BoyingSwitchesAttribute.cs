using System;
using System.Collections.Generic;
using System.Linq;

namespace Boying.Commands
{
    [AttributeUsage(AttributeTargets.Method)]
    public class BoyingSwitchesAttribute : Attribute
    {
        private readonly string _switches;

        public BoyingSwitchesAttribute(string switches)
        {
            _switches = switches;
        }

        public IEnumerable<string> Switches
        {
            get
            {
                return (_switches ?? "").Trim().Split(',').Select(s => s.Trim());
            }
        }
    }
}