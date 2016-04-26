using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSolution.Caching
{
    /// <summary>
    /// 挥发性令牌
    /// </summary>
    public interface IVolatileToken
    {
        bool IsCurrent { get; }
    }
}
