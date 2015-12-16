using Buzzer.Models;

namespace Buzzer.Interface
{
    public interface INotificationManager
    {
        Notification GetNextNotification();
        void AddToPool(Notification notification);
    }
}