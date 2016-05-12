using System.Collections.Generic;
using Boying.Events;

namespace Boying.Messaging.Services
{
    public interface IMessageService : IEventHandler
    {
        void Send(string type, IDictionary<string, object> parameters);
    }
}