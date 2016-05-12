using System.Web.Routing;

namespace Boying.Mvc
{
    public interface IHasRequestContext
    {
        RequestContext RequestContext { get; }
    }
}