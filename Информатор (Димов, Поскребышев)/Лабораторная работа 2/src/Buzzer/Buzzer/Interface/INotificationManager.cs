namespace Buzzer.Interface
{
    public interface INotificationManager
    {
        INotification GetNextNotification();
        void AddToPool(INotification notification);
    }
}