using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSolution.Caching
{
    /// <summary>
    /// 缓存上下文
    /// </summary>
    public interface IAcquireContext
    {
        /// <summary>
        /// 用于获取缓存失效方式
        /// </summary>
        Action<IVolatileToken> Monitor { get; }
    }

    /// <summary>
    /// 获取上下文对象
    /// </summary>
    /// <typeparam name="TKey">上下文对象</typeparam>
    public class AcquireContext<TKey> : IAcquireContext
    {
        public AcquireContext(TKey key, Action<IVolatileToken> monitor)
        {
            Key = key;
            Monitor = monitor;
        }

        public TKey Key { get; private set; }

        public Action<IVolatileToken> Monitor { get; private set; }
    }

    /// <summary>
    /// 简单的实现的"IAcquireContext" given a lamdba
    /// </summary>
    public class SimpleAcquireContext : IAcquireContext
    {
        private readonly Action<IVolatileToken> _monitor;

        public SimpleAcquireContext(Action<IVolatileToken> monitor)
        {
            _monitor = monitor;
        }

        public Action<IVolatileToken> Monitor
        {
            get { return _monitor; }
        }
    }

}