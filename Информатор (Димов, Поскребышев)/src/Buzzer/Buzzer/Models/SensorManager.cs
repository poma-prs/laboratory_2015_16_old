using System.Collections.Generic;
using Buzzer.Interface;

namespace Buzzer.Models
{
    public class SensorManager : ISensorManager
    {
        private readonly NotificationManager _notificationManager;

        public SensorManager(NotificationManager notificationManager)
        {
            _notificationManager = notificationManager;
        }

        public bool Registrate(Sensor sensor)
        {
            throw new System.NotImplementedException();
        }

        public void ScanPorts(IList<Sensor> sensors)
        {
            throw new System.NotImplementedException();
        }
    }
}