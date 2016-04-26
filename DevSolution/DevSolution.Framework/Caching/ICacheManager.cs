using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSolution.Caching
{
    /// <summary>
    /// 缓存管理器
    /// </summary>
    public interface ICacheManager
    {
        /// <summary>
        /// 获取缓存对象
        /// </summary>
        /// <typeparam name="TKey">用于获取缓存项的键值类型</typeparam>
        /// <typeparam name="TResult">从缓存中获取的缓存项类型</typeparam>
        /// <param name="key">缓存键</param>
        /// <param name="acquire">处理缓存的方式</param>
        /// <returns></returns>
        TResult Get<TKey, TResult>(TKey key, Func<AcquireContext<TKey>, TResult> acquire);

        /// <summary>
        /// 获取缓存
        /// </summary>
        /// <typeparam name="TKey">用于获取缓存项的键值类型</typeparam>
        /// <typeparam name="TResult">从缓存中获取的缓存项类型</typeparam>
        /// <returns></returns>
        ICache<TKey, TResult> GetCache<TKey, TResult>();
    }

    /// <summary>
    /// 缓存管理扩展
    /// </summary>
    public static class CacheManagerExtensions
    {
        /// <summary>
        /// 获取缓存对象
        /// </summary>
        /// <typeparam name="TKey">用于获取缓存项的键值类型</typeparam>
        /// <typeparam name="TResult">从缓存中获取的缓存项类型</typeparam>
        /// <param name="cacheManager">缓存管理器</param>
        /// <param name="key">缓存键</param>
        /// <param name="preventConcurrentCalls">防止并发调用</param>
        /// <param name="acquire">处理缓存的方式</param>
        /// <returns></returns>
        public static TResult Get<TKey, TResult>(this ICacheManager cacheManager, TKey key, bool preventConcurrentCalls, Func<AcquireContext<TKey>, TResult> acquire)
        {
            if (preventConcurrentCalls)
            {
                lock (key)
                {
                    return cacheManager.Get(key, acquire);
                }
            }
            else
            {
                return cacheManager.Get(key, acquire);
            }
        }
    }

}
