using System.Web;

namespace Boying.Time
{
    public interface ITimeZoneSelector : IDependency
    {
        TimeZoneSelectorResult GetTimeZone(HttpContextBase context);
    }
}