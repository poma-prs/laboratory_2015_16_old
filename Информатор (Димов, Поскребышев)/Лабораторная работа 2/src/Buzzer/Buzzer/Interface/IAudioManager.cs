using System.IO;
using Buzzer.Models;

namespace Buzzer.Interface
{
    public interface IAudioManager
    {
        void Play(Audio audio);
        Stream GetAudioStream(Audio audio);
    }
}