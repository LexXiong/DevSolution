using System.Web.Security;

namespace Boying.Security.Providers
{
    public class DefaultSslSettingsProvider : ISslSettingsProvider
    {
        public bool RequireSSL { get; set; }

        public DefaultSslSettingsProvider()
        {
            RequireSSL = FormsAuthentication.RequireSSL;
        }

        public bool GetRequiresSSL()
        {
            return RequireSSL;
        }
    }
}