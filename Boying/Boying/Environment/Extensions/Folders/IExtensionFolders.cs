using System.Collections.Generic;
using Boying.Environment.Extensions.Models;

namespace Boying.Environment.Extensions.Folders
{
    public interface IExtensionFolders
    {
        IEnumerable<ExtensionDescriptor> AvailableExtensions();
    }
}