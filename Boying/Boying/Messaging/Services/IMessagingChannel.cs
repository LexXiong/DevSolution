using System;
using System.Collections.Generic;
using Boying.Messaging.Models;

namespace Boying.Messaging.Services
{
    [Obsolete]
    public interface IMessagingChannel : IDependency
    {
        /// <summary>
        /// Actually sends the message though this channel
        /// </summary>
        void SendMessage(MessageContext message);

        /// <summary>
        /// Provides all the handled services, the user can choose from when receving messages
        /// </summary>
        IEnumerable<string> GetAvailableServices();
    }
}