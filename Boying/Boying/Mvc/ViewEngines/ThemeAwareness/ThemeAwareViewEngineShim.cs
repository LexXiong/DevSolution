using System;
using System.Linq;
using System.Web.Mvc;
using Boying.Environment;

namespace Boying.Mvc.ViewEngines.ThemeAwareness
{
    public class ThemeAwareViewEngineShim : IViewEngine, IShim
    {
        public ThemeAwareViewEngineShim()
        {
            BoyingHostContainerRegistry.RegisterShim(this);
        }

        public IBoyingHostContainer HostContainer { get; set; }

        public ViewEngineResult FindPartialView(ControllerContext controllerContext, string partialViewName, bool useCache)
        {
            return Forward(
                controllerContext,
                dve => dve.FindPartialView(controllerContext, partialViewName, useCache, false /*useDeepPaths*/),
                EmptyViewEngineResult);
        }

        public ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache)
        {
            return Forward(
                controllerContext,
                dve => dve.FindView(controllerContext, viewName, masterName, useCache, false /*useDeepPaths*/),
                EmptyViewEngineResult);
        }

        public void ReleaseView(ControllerContext controllerContext, IView view)
        {
            throw new NotImplementedException();
        }

        private static TResult Forward<TResult>(ControllerContext controllerContext, Func<IThemeAwareViewEngine, TResult> forwardAction, Func<TResult> defaultAction)
        {
            var workContext = controllerContext.GetWorkContext();
            if (workContext != null)
            {
                var displayViewEngine = workContext.Resolve<IThemeAwareViewEngine>();
                if (displayViewEngine != null)
                {
                    return forwardAction(displayViewEngine);
                }
            }
            return defaultAction();
        }

        private static ViewEngineResult EmptyViewEngineResult()
        {
            return new ViewEngineResult(Enumerable.Empty<string>());
        }
    }
}