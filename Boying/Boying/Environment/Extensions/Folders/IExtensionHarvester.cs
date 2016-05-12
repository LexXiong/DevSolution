using System.Collections.Generic;
using Boying.Environment.Extensions.Models;

namespace Boying.Environment.Extensions.Folders
{
    public interface IExtensionHarvester
    {
        IEnumerable<ExtensionDescriptor> HarvestExtensions(IEnumerable<string> paths, string extensionType, string manifestName, bool manifestIsOptional);
    }
}