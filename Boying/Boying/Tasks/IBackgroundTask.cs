namespace Boying.Tasks
{
    public interface IBackgroundTask : IDependency
    {
        void Sweep();
    }
}