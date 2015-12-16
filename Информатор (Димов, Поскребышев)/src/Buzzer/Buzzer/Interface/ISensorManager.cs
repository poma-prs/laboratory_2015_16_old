using System.Collections.Generic;

namespace Buzzer.Interface
{
    public interface ISensorManager
    {
        bool Registrate(int port);
        void ScanPorts(IList<int> ports);
    }
}