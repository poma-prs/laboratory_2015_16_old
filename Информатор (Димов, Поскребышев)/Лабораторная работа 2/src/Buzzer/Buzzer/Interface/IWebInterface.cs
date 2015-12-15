using System.Collections.Generic;

namespace Buzzer.Interface
{
    public interface IWebInterface
    {
        INotification ViewAddNotificationPage();
        void ViewUpdateNotificationPage(INotification notification);
        void ViewRemoveNotificationPage(INotification notification);
        void ViewNotificationListPage(IList<INotification> notifications);
    }
}