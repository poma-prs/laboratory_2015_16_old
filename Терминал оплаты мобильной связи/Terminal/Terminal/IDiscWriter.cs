using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal
{
    public interface IDiscWriter
    {
        void WriteToLog(Transaction transaction);
        void StoreQueue();
        void Close();
    }
}
