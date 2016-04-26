using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSolution.Caching
{
    /// <summary>
    /// 实现默认的缓存持有者
    /// 缓存持有人负责存储缓存的实体的引用
    /// </summary>
    public class DefaultCacheHolder : ICacheHolder
    {
        private readonly ICacheContextAccessor _cacheContextAccessor;
        private readonly ConcurrentDictionary<CacheKey, object> _caches = new ConcurrentDictionary<CacheKey, object>();

        public DefaultCacheHolder(ICacheContextAccessor cacheContextAccessor)
        {
            _cacheContextAccessor = cacheContextAccessor;
        }

        private class CacheKey : Tuple<Type, Type, Type>
        {
            public CacheKey(Type component, Type key, Type result)
                : base(component, key, result)
            {
            }
        }

        /// <summary>
        /// 从缓存中获取一个缓存实例。
        /// 如果没有发现，则创建一个空实例并返回
        /// </summary>
        /// <typeparam name="TKey">The type of the key within the component.</typeparam>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="component">The component context.</param>
        /// <returns>An entry from the cache, or a new, empty one, if none is found.</returns>
        public ICache<TKey, TResult> GetCache<TKey, TResult>(Type component)
        {
            var cacheKey = new CacheKey(component, typeof(TKey), typeof(TResult));

            var result = _caches.GetOrAdd(cacheKey, k => new Cache<TKey, TResult>(_cacheContextAccessor));

            return (Cache<TKey, TResult>)result;
        }
    }
}