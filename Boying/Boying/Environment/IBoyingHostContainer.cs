namespace Boying.Environment
{
    public interface IBoyingHostContainer
    {
        T Resolve<T>();
    }
}