using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSolution.Caching
{
    /// <summary>
    /// 失效适配器
    /// 主要用于扩展缓存失效的策略
    /// </summary>
    public interface IVolatileProvider : IDependency
    {
    }
}
