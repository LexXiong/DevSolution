using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevSolution.Caching
{
    /// <summary>
    /// 缓存失效信号
    /// </summary>
    public interface ISignals : IVolatileProvider
    {
        /// <summary>
        /// 触发缓存失效
        /// </summary>
        /// <typeparam name="T">表示触发失效的信号的类型</typeparam>
        /// <param name="signal">触发失效的信号</param>
        void Trigger<T>(T signal);

        /// <summary>
        /// 埋下一个失效的令牌，以便程序可以通过<see cref="ISignals.Trigger{T}(T)"/>进行通知触发
        /// </summary>
        /// <typeparam name="T">表示触发失效的信号的类型</typeparam>
        /// <param name="signal">触发失效的信号</param>
        /// <returns></returns>
        IVolatileToken When<T>(T signal);
    }

    public class Signals : ISignals
    {
        private readonly IDictionary<object, Token> _tokens = new Dictionary<object, Token>();

        public void Trigger<T>(T signal)
        {
            lock (_tokens)
            {
                Token token;
                if (_tokens.TryGetValue(signal, out token))
                {
                    _tokens.Remove(signal);
                    token.Trigger();
                }
            }
        }

        public IVolatileToken When<T>(T signal)
        {
            lock (_tokens)
            {
                Token token;
                if (!_tokens.TryGetValue(signal, out token))
                {
                    token = new Token();
                    _tokens[signal] = token;
                }
                return token;
            }
        }

        private class Token : IVolatileToken
        {
            public Token()
            {
                IsCurrent = true;
            }

            public bool IsCurrent { get; private set; }

            public void Trigger()
            {
                IsCurrent = false;
            }
        }
    }
}