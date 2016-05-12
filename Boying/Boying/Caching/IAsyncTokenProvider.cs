using System;

namespace Boying.Caching
{
    public interface IAsyncTokenProvider
    {
        IVolatileToken GetToken(Action<Action<IVolatileToken>> task);
    }
}