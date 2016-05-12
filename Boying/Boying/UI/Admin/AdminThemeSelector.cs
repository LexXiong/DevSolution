using System.Web.Routing;
using Boying.Themes;

namespace Boying.UI.Admin
{
    public class AdminThemeSelector : IThemeSelector
    {
        public ThemeSelectorResult GetTheme(RequestContext context)
        {
            if (AdminFilter.IsApplied(context))
            {
                return new ThemeSelectorResult { Priority = 100, ThemeName = "TheAdmin" };
            }

            return null;
        }
    }
}