using System.Collections.Generic;
using Boying.UI.Notify;

namespace Boying.UI.Admin.Notification
{
    public interface INotificationManager : IDependency
    {
        /// <summary>
        /// Returns all notifications to display per zone
        /// </summary>
        IEnumerable<NotifyEntry> GetNotifications();
    }
}