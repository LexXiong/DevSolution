using System.Web.Routing;
using Boying.Environment.Extensions.Models;

namespace Boying.Themes
{
    public interface IThemeManager : IDependency
    {
        ExtensionDescriptor GetRequestTheme(RequestContext requestContext);
    }
}