using System;
using System.Collections.Generic;
using Buzzer.Models;

namespace Buzzer.Interface
{
    public interface INotificationRepository
    {
        bool Add(Notification notification);
        bool Update(Notification notification);
        bool Remove(long id);
        IList<Notification> GetRange(TimeSpan startTime, TimeSpan endTime);
    }
}