using System.Linq;
using Orchard.Caching;
using Orchard.Core.Settings.Models;
using Orchard.Settings;

namespace Orchard.Core.Settings.Services
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
            };
        }
    }
}