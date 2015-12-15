using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal
{
    public interface IBillAnalyzer
    {
        bool AnalyzeBill(object source);
        void ReturnBills();
        void StoreBills();
    }
}
