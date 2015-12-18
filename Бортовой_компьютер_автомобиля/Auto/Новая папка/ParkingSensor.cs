using System;

namespace Auto.AutoSystems.ParkingSensor
{
    class ParkingSensor : IAutoSystem, IParkingSensor
    {
        public void TurnOn()
        {
            throw new NotImplementedException();
        }

        public void TurnOff()
        {
            throw new NotImplementedException();
        }

        public void Bleep(double frequency);
    }
}
