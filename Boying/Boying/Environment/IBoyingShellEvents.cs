using Boying.Events;

namespace Boying.Environment
{
    public interface IBoyingShellEvents : IEventHandler
    {
        void Activated();

        void Terminating();
    }
}