using NHibernate.Cfg.Loquacious;

namespace Boying.Data
{
    public interface IDatabaseCacheConfiguration : IDependency
    {
        void Configure(ICacheConfigurationProperties cache);
    }
}