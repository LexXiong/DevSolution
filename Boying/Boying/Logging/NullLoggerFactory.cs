using System;

namespace Boying.Logging
{
    internal class NullLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger(Type type)
        {
            return NullLogger.Instance;
        }
    }
}