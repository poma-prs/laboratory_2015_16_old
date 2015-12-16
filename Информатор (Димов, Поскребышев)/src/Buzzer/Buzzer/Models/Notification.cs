using System;

namespace Buzzer.Models
{
    public class Notification
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public TimeSpan Time { get; set; }
        public Audio Audio { get; set; }
    }
}