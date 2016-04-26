using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSolution.Caching
{
    /// <summary>
    /// 异步标识缓存提供器
    /// </summary>
    public interface IAsyncTokenProvider
    {
        /// <summary>
        /// 获取不稳定标识的缓存
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        IVolatileToken GetToken(Action<Action<IVolatileToken>> task);
    }
}
