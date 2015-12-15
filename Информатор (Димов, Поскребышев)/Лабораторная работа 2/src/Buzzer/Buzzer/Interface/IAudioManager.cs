using System.IO;

namespace Buzzer.Interface
{
    public interface IAudioManager
    {
        void Play(IAudio audio);
        Stream GetAudioStream(IAudio audio);
    }
}