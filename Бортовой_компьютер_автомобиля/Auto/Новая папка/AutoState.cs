using System.Collections.Generic;

namespace Auto.AutoSystems
{
    class AutoState
    {
        public double GetEngineHeat();
        public double GetBatteryCharge();
        public List<TTDData> GetCurrentState();
    }
}
