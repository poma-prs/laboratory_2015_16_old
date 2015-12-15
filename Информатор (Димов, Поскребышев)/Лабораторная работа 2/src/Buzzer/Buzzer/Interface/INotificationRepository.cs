using System;
using System.Collections.Generic;

namespace Buzzer.Interface
{
    public interface INotificationRepository
    {
        bool Add(INotification notification);
        bool Update(INotification notification);
        bool Remove(long id);
        IList<INotification> GetRange(TimeSpan startTime, TimeSpan endTime);
    }
}