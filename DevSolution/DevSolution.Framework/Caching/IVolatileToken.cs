using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSolution.Caching
{
    /// <summary>
    /// 失效令牌
    /// </summary>
    public interface IVolatileToken
    {
        /// <summary>
        /// 是否有效
        /// </summary>
        bool IsCurrent { get; }
    }
}
