namespace Boying.Settings
{
    public interface ISiteService : IDependency
    {
        ISite GetSiteSettings();
    }
}