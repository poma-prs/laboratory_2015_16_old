using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto.AutoSystems.MediaPlayer
{
    class Radio : IAutoSystem, IMedia
    {
        public void TurnOn()
        {
            throw new NotImplementedException();
        }

        public void TurnOff()
        {
            throw new NotImplementedException();
        }

        public void SetFrequency();

        public void Play()
        {
            throw new NotImplementedException();
        }
    }
}
