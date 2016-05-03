using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevSolution.Caching;

namespace DevSolution.FileSystems.VirtualPath
{
    /// <summary>
    /// Enable monitoring changes over virtual path
    /// </summary>
    public interface IVirtualPathMonitor : IVolatileProvider
    {
        IVolatileToken WhenPathChanges(string virtualPath);
    }
}
