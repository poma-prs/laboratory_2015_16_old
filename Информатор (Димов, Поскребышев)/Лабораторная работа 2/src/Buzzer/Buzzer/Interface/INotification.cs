using System;

namespace Buzzer.Interface
{
    public interface INotification
    {
        long Id { get; set; }
        string Title { get; set; }
        TimeSpan Time { get; set; }
        IAudio Audio { get; set; }
    }
}