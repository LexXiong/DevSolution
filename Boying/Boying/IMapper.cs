namespace Boying
{
    public interface IMapper<TSource, TTarget> : IDependency
    {
        TTarget Map(TSource source);
    }
}