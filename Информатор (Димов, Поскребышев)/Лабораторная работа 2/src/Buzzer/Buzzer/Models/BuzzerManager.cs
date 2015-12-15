using Buzzer.Interface;

namespace Buzzer.Models
{
    public class BuzzerManager : IBuzzerManager
    {
        private readonly NotificationManager _notificationManager;
        private readonly AudioManager _audioManager;

        public BuzzerManager(
            NotificationManager notificationManager, 
            AudioManager audioManager)
        {
            _notificationManager = notificationManager;
            _audioManager = audioManager;
        }

        public void Start()
        {
            throw new System.NotImplementedException();
        }

        public void Stop()
        {
            throw new System.NotImplementedException();
        }
    }
}