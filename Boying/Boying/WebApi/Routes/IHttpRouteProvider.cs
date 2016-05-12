using System.Collections.Generic;
using Boying.Mvc.Routes;

namespace Boying.WebApi.Routes
{
    public interface IHttpRouteProvider : IDependency
    {
        IEnumerable<RouteDescriptor> GetRoutes();

        void GetRoutes(ICollection<RouteDescriptor> routes);
    }
}