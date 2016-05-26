using Boying.Caching;
using Boying.ContentManagement;
using Boying.Data;
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
        private readonly IRepository<ThemeSiteSettingsRecord> _themeSiteSettingRepository;

        public SiteThemeService(
            IBoyingServices BoyingServices,
            IExtensionManager extensionManager,
            ICacheManager cacheManager,
            ISignals signals,
            IRepository<ThemeSiteSettingsRecord> themeSiteSettingRepository)
        {
            _BoyingServices = BoyingServices;
            _extensionManager = extensionManager;
            _cacheManager = cacheManager;
            _signals = signals;
            _themeSiteSettingRepository = themeSiteSettingRepository;
        }

        public ExtensionDescriptor GetSiteTheme()
        {
            string currentThemeName = GetCurrentThemeName();
            return string.IsNullOrEmpty(currentThemeName) ? null : _extensionManager.GetExtension(GetCurrentThemeName());
        }

        public void SetSiteTheme(string themeName)
        {
            var site = _BoyingServices.WorkContext.CurrentSite as ThemeSiteSettingsRecord;

            site.CurrentThemeName = themeName;

            _themeSiteSettingRepository.Update(site);

            _signals.Trigger(CurrentThemeSignal);
        }

        public string GetCurrentThemeName()
        {
            return _cacheManager.Get("CurrentThemeName", ctx =>
            {
                ctx.Monitor(_signals.When(CurrentThemeSignal));

                var themeSite = _themeSiteSettingRepository.Get(c => c != null);

                return (themeSite ?? new ThemeSiteSettingsRecord { CurrentThemeName = "TheThemeMachine" }).CurrentThemeName;
            });
        }
    }
}