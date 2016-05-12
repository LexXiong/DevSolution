using System;
using Boying.Caching;

namespace Boying.Environment.Extensions
{
    public interface IExtensionMonitoringCoordinator
    {
        void MonitorExtensions(Action<IVolatileToken> monitor);
    }
}