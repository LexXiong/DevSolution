namespace Boying.Caching
{
    public interface ICacheContextAccessor
    {
        IAcquireContext Current { get; set; }
    }
}