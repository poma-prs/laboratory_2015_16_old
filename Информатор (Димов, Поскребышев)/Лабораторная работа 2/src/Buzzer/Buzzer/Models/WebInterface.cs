using System.Collections.Generic;
using Buzzer.Interface;

namespace Buzzer.Models
{
    public class WebInterface : IWebInterface
    {
        private readonly NotificationManager _notificationManager;
        private readonly NotificationRepository _notificationRepository;

        public WebInterface(
            NotificationManager notificationManager, 
            NotificationRepository notificationRepository)
        {
            _notificationManager = notificationManager;
            _notificationRepository = notificationRepository;
        }

        public Notification ViewAddNotificationPage()
        {
            throw new System.NotImplementedException();
        }

        public void ViewUpdateNotificationPage(Notification notification)
        {
            throw new System.NotImplementedException();
        }

        public void ViewRemoveNotificationPage(Notification notification)
        {
            throw new System.NotImplementedException();
        }

        public void ViewNotificationListPage(IList<Notification> notifications)
        {
            throw new System.NotImplementedException();
        }
    }
}