using System.IO;
using Buzzer.Interface;

namespace Buzzer.Models
{
    public class AudioManager : IAudioManager
    {
        public void Play(Audio audio)
        {
            throw new System.NotImplementedException();
        }

        public Stream GetAudioStream(Audio audio)
        {
            throw new System.NotImplementedException();
        }
    }
}