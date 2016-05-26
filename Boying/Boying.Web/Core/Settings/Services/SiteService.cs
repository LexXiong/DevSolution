using System.Linq;
using Boying.Caching;
using Boying.Core.Settings.Models;
using Boying.Settings;

namespace Boying.Core.Settings.Services
{
    public class SiteService : ISiteService
    {
        private readonly ICacheManager _cacheManager;

        public SiteService(
            ICacheManager cacheManager)
        {
            _cacheManager = cacheManager;
        }

        public ISite GetSiteSettings()
        {
            return new SiteSettingsPart
            {
                HomePage = "/",
                BaseUrl = "",
                PageSize = 10,
                PageTitleSeparator = " - ",
                ResourceDebugMode = ResourceDebugMode.FromAppSetting,
                SiteCalendar = "",
                SiteCulture = "zh-CN",
                SiteName = "分期保",
                SiteSalt = "",
                SiteTimeZone = "China Standard Time",
                SuperUser = "boying",
                UseCdn = false
            };
        }
    }
}