using NHibernate.Cfg.Loquacious;

namespace Boying.Data
{
    public class DefaultDatabaseCacheConfiguration : IDatabaseCacheConfiguration
    {
        public void Configure(ICacheConfigurationProperties cache)
        {
            cache.UseQueryCache = false;
        }
    }
}