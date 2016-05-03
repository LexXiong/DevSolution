using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSolution.Logging
{
    internal class NullLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger(Type type)
        {
            return NullLogger.Instance;
        }
    }
}