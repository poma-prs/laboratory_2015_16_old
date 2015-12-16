using System;
using System.Collections.Generic;
using Buzzer.Interface;

namespace Buzzer.Models
{
    public class NotificationRepository : INotificationRepository
    {
        public bool Add(Notification notification)
        {
            throw new NotImplementedException();
        }

        public bool Update(Notification notification)
        {
            throw new NotImplementedException();
        }

        public bool Remove(long id)
        {
            throw new NotImplementedException();
        }

        public IList<Notification> GetRange(TimeSpan startTime, TimeSpan endTime)
        {
            throw new NotImplementedException();
        }
    }
}