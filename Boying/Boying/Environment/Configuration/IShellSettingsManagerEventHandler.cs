using Boying.Events;

namespace Boying.Environment.Configuration
{
    public interface IShellSettingsManagerEventHandler : IEventHandler
    {
        void Saved(ShellSettings settings);
    }
}