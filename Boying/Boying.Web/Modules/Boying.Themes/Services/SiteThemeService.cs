using Boying.Caching;
using Boying.ContentManagement;
using Boying.Environment.Extensions;
using Boying.Environment.Extensions.Models;
using Boying.Themes.Models;

namespace Boying.Themes.Services
{
    public interface ISiteThemeService : IDependency
    {
        ExtensionDescriptor GetSiteTheme();

        void SetSiteTheme(string themeName);

        string GetCurrentThemeName();
    }

    public class SiteThemeService : ISiteThemeService
    {
        public const string CurrentThemeSignal = "SiteCurrentTheme";

        private readonly IExtensionManager _extensionManager;
        private readonly ICacheManager _cacheManager;
        private readonly ISignals _signals;
        private readonly IBoyingServices _BoyingServices;

        public SiteThemeService(
            IBoyingServices BoyingServices,
            IExtensionManager extensionManager,
            ICacheManager cacheManager,
            ISignals signals)
        {
            _BoyingServices = BoyingServices;
            _extensionManager = extensionManager;
            _cacheManager = cacheManager;
            _signals = signals;
        }

        public ExtensionDescriptor GetSiteTheme()
        {
            string currentThemeName = GetCurrentThemeName();
            return string.IsNullOrEmpty(currentThemeName) ? null : _extensionManager.GetExtension(GetCurrentThemeName());
        }

        public void SetSiteTheme(string themeName)
        {
            //var site = _BoyingServices.WorkContext.CurrentSite;
            //site.As<ThemeSiteSettingsPart>().CurrentThemeName = themeName;

            _signals.Trigger(CurrentThemeSignal);
        }

        public string GetCurrentThemeName()
        {
            return _cacheManager.Get("CurrentThemeName", ctx =>
            {
                ctx.Monitor(_signals.When(CurrentThemeSignal));
                //return _BoyingServices.WorkContext.CurrentSite.As<ThemeSiteSettingsPart>().CurrentThemeName;
                return "TheThemeMachine";
            });
        }
    }
}