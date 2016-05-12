using System;
using Boying.Events;
using Boying.Messaging.Models;

namespace Boying.Messaging.Events
{
    [Obsolete]
    public interface IMessageEventHandler : IEventHandler
    {
        void Sending(MessageContext context);

        void Sent(MessageContext context);
    }
}