using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto.AutoSystems.Conditioner
{
    interface IConditioner
    {
        void SetTemperature(double temp);
        void SetPower(double power);
    }
}
