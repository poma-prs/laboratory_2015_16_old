using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Terminal
{
    public class BillAnalyzer: IBillAnalyzer
    {
        List<RubleBill> currentTransactionBills = new List<RubleBill>();
        public int CurrentSum { get; private set; }

        public bool AnalyzeBill(object source)
        {
            string sourceValue = ((Button)source).Text;
            string value = sourceValue.Substring(0, sourceValue.IndexOf(' '));
            int denomination;
            bool analyzingStatus = Int32.TryParse(value, out denomination);
            if (!analyzingStatus)
            {
                MessageBox.Show("Не удается определить номинал купюры.");
                return false;
            }
            Random rnd = new Random();
            RubleBill bill = new RubleBill()
            {
                Denomination = denomination,
                Serial = rnd.Next().ToString()
            };
            currentTransactionBills.Add(bill);
            CurrentSum += bill.Denomination;
            return true;
        }

        public void ReturnBills()
        {
            foreach (var bill in currentTransactionBills)
            {
                MessageBox.Show("Возврат купюры " + bill.Denomination.ToString() + " рублей.");
            }
            currentTransactionBills.Clear();
            CurrentSum = 0;
        }

        public void StoreBills()
        {
            currentTransactionBills.Clear();
            CurrentSum = 0;
        }
    }
}