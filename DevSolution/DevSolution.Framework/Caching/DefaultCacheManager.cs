using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSolution.Caching
{
    /// <summary>
    /// 缓存管理器提供的默认实现。
    /// 缓存的缓存管理器提供了一个抽象持有人便于交换和隔离在一个组件上下文。
    /// </summary>
    public class DefaultCacheManager : ICacheManager
    {
        private readonly Type _component;
        private readonly ICacheHolder _cacheHolder;

        /// <summary>
        /// 构造一个新的缓存管理器为给定组件类型和特定的缓存实现。
        /// </summary>
        /// <param name="component">应用缓存的组件(上下文context).</param>
        /// <param name="cacheHolder">缓存持有者包含的实体缓存.</param>
        public DefaultCacheManager(Type component, ICacheHolder cacheHolder)
        {
            _component = component;
            _cacheHolder = cacheHolder;
        }

        /// <summary>
        /// 从缓存持有者中获取缓存
        /// </summary>
        /// <typeparam name="TKey">用于获取缓存项的键值类型</typeparam>
        /// <typeparam name="TResult">从缓存中获取的缓存项类型</typeparam>
        /// <returns></returns>
        public ICache<TKey, TResult> GetCache<TKey, TResult>()
        {
            return _cacheHolder.GetCache<TKey, TResult>(_component);
        }

        /// <summary>
        /// 从缓存持有者中获取缓存结果
        /// </summary>
        /// <typeparam name="TKey">用于获取缓存项的键值类型</typeparam>
        /// <typeparam name="TResult">从缓存中获取的缓存项类型</typeparam>
        /// <param name="key"></param>
        /// <param name="acquire"></param>
        /// <returns></returns>
        public TResult Get<TKey, TResult>(TKey key, Func<AcquireContext<TKey>, TResult> acquire)
        {
            return GetCache<TKey, TResult>().Get(key, acquire);
        }
    }
}
