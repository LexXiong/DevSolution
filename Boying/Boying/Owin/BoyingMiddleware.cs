using System;
using System.Threading.Tasks;
using Owin;

namespace Boying.Owin
{
    /// <summary>
    /// A special Owin middleware that is executed last in the Owin pipeline and runs the non-Owin part of the request.
    /// </summary>
    public static class BoyingMiddleware
    {
        public static IAppBuilder UseBoying(this IAppBuilder app)
        {
            app.Use(async (context, next) =>
            {
                var handler = context.Environment["Boying.Handler"] as Func<Task>;

                if (handler == null)
                {
                    throw new ArgumentException("Boying.Handler can't be null");
                }
                await handler();
            });

            return app;
        }
    }
}