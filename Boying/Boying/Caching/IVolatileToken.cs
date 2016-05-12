namespace Boying.Caching
{
    public interface IVolatileToken
    {
        bool IsCurrent { get; }
    }
}