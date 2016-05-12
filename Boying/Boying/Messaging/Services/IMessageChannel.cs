using System.Collections.Generic;

namespace Boying.Messaging.Services
{
    public interface IMessageChannel : IDependency
    {
        void Process(IDictionary<string, object> parameters);
    }
}