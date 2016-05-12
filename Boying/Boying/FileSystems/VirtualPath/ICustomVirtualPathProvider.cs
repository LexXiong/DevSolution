using System.Web.Hosting;

namespace Boying.FileSystems.VirtualPath
{
    public interface ICustomVirtualPathProvider
    {
        VirtualPathProvider Instance { get; }
    }
}