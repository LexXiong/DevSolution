using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSolution.Caching
{
    /// <summary>
    /// 缓存接口
    /// </summary>
    /// <typeparam name="TKey">缓存键的类型</typeparam>
    /// <typeparam name="TResult">缓存值的类型</typeparam>
    public interface ICache<TKey, TResult>
    {
        /// <summary>
        /// 获取缓存
        /// </summary>
        /// <param name="key">缓存键</param>
        /// <param name="acquire"></param>
        /// <returns></returns>
        TResult Get(TKey key, Func<AcquireContext<TKey>, TResult> acquire);
    }
}
