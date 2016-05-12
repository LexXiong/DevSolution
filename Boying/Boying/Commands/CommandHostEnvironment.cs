using Boying.Environment;
using Boying.Localization;

namespace Boying.Commands
{
    internal class CommandHostEnvironment : HostEnvironment
    {
        public CommandHostEnvironment()
        {
            T = NullLocalizer.Instance;
        }

        public Localizer T { get; set; }

        public override void RestartAppDomain()
        {
            throw new BoyingCommandHostRetryException(T("A change of configuration requires the session to be restarted."));
        }
    }
}