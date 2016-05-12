using System.IO;

namespace Boying.Environment.Extensions.Compilers
{
    public interface IProjectFileParser
    {
        ProjectFileDescriptor Parse(string virtualPath);

        ProjectFileDescriptor Parse(Stream stream);
    }
}