using System.Collections.Generic;

namespace Buzzer.Interface
{
    public interface INotificationRepository
    {
        void Add(INotification notification);
        INotification Update(long id);
        void Remove(long id);
        IList<INotification> GetAll();
    }
}