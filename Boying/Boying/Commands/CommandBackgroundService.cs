using Boying.Tasks;

namespace Boying.Commands
{
    /// <summary>
    /// Command line specific "no-op" background service implementation.
    /// Note that we make this class "internal" so that it's not auto-registered
    /// by the Boying Framework (it is registered explicitly by the command
    /// line host).
    /// </summary>
    internal class CommandBackgroundService : IBackgroundService
    {
        public void Sweep()
        {
            // Don't run any background service in command line
        }
    }
}