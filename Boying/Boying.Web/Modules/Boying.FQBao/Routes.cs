using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using Boying.Mvc.Routes;

namespace Boying.FQBao
{
    public class Routes : IRouteProvider
    {
        public void GetRoutes(ICollection<RouteDescriptor> routes)
        {
            foreach (var routeDescriptor in GetRoutes())
                routes.Add(routeDescriptor);
        }

        public IEnumerable<RouteDescriptor> GetRoutes()
        {
            return new[] {
                new RouteDescriptor {
                    Route = new Route(
                        "",
                        new RouteValueDictionary {
                            { "area", "Boying.FQBao" },
                            { "controller", "Home" },
                            { "action", "Index" },
                        },
                        new RouteValueDictionary {
                            { "area", "Boying.FQBao" },
                            { "controller", "Home" },
                        },
                        new RouteValueDictionary {
                            { "area", "Boying.FQBao" },
                        },
                        new MvcRouteHandler()
                        ),
                },
            };
        }
    }
}