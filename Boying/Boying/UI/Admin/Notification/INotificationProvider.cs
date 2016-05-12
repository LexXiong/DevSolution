using System.Collections.Generic;
using Boying.UI.Notify;

namespace Boying.UI.Admin.Notification
{
    public interface INotificationProvider : IDependency
    {
        /// <summary>
        /// Returns all notifications to display per zone
        /// </summary>
        IEnumerable<NotifyEntry> GetNotifications();
    }
}