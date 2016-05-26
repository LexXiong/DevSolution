using System.Collections.Generic;
using System.Web.Routing;
using Boying.Environment.Extensions.Models;
using Boying.Events;

namespace Boying.Themes.Events
{
    public interface IExtensionDisplayEventHandler : IEventHandler
    {
        /// <summary>
        /// Called before an extension is displayed
        /// </summary>
        IEnumerable<string> Displaying(ExtensionDescriptor extensionDescriptor, RequestContext requestContext);
    }
}