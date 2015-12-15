using System.Collections.Generic;
using Buzzer.Models;

namespace Buzzer.Interface
{
    public interface IWebInterface
    {
        Notification ViewAddNotificationPage();
        void ViewUpdateNotificationPage(Notification notification);
        void ViewRemoveNotificationPage(Notification notification);
        void ViewNotificationListPage(IList<Notification> notifications);
    }
}