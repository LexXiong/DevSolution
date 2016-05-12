using System.Web;

namespace Boying.Mvc
{
    public interface IHttpContextAccessor
    {
        HttpContextBase Current();

        void Set(HttpContextBase httpContext);
    }
}