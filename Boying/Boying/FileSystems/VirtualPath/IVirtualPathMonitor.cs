using Boying.Caching;

namespace Boying.FileSystems.VirtualPath
{
    /// <summary>
    /// Enable monitoring changes over virtual path
    /// </summary>
    public interface IVirtualPathMonitor : IVolatileProvider
    {
        IVolatileToken WhenPathChanges(string virtualPath);
    }
}