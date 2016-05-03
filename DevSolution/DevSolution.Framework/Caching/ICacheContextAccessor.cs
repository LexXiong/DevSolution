using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSolution.Caching
{
    /// <summary>
    /// 保存缓存上下文。
    /// 当有多个缓存上下文时，保证缓存同时失效。
    /// </summary>
    public interface ICacheContextAccessor
    {
        /// <summary>
        /// 缓存上下文
        /// </summary>
        IAcquireContext Current { get; set; }
    }
}
