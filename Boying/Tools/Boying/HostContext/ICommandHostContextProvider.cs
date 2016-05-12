namespace Boying.HostContext
{
    public interface ICommandHostContextProvider
    {
        CommandHostContext CreateContext();

        void Shutdown(CommandHostContext context);
    }
}