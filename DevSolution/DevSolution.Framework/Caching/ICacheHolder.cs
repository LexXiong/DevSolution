using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSolution.Caching
{
    /// <summary>
    /// 缓存存储方式
    /// </summary>
    public interface ICacheHolder : ISingletonDependency
    {
        /// <summary>
        /// 获取缓存
        /// </summary>
        /// <typeparam name="TKey">缓存键的类型</typeparam>
        /// <typeparam name="TResult">缓存值得类型</typeparam>
        /// <param name="component">组件</param>
        /// <returns></returns>
        ICache<TKey, TResult> GetCache<TKey, TResult>(Type component);
    }
}
