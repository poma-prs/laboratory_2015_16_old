using System.Collections.Generic;
using Buzzer.Models;

namespace Buzzer.Interface
{
    public interface ISensorManager
    {
        bool Registrate(Sensor sensor);
        void ScanPorts(IList<Sensor> sensors);
    }
}