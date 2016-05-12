using System;

namespace Boying.Logging
{
    public interface ILoggerFactory
    {
        ILogger CreateLogger(Type type);
    }
}