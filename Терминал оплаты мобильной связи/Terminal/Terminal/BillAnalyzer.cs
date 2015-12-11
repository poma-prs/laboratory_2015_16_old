using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terminal
{
    public class BillAnalyzer
    {
        public static RubleBill AnalyzeBill(object source)
        {
            string sourceValue = ((Button)source).Text;
            string value = sourceValue.Substring(0, sourceValue.IndexOf(' '));
            int denomination;
            bool analyzingStatus = Int32.TryParse(value, out denomination);
            if (!analyzingStatus)
                throw new Exception("");
            Random rnd = new Random();
            RubleBill bill = new RubleBill()
            {
                Denomination = denomination,
                Serial = rnd.Next().ToString()
            };
            return bill;
        }
    }
}