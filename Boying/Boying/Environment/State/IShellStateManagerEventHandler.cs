using Boying.Events;

namespace Boying.Environment.State
{
    public interface IShellStateManagerEventHandler : IEventHandler
    {
        void ApplyChanges();
    }
}