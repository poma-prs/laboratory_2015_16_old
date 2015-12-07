using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terminal
{
    class Printer : IPrinter
    {
        const int minPaintVolume = 20;
        const int ChequeLength = 7;
        ChequeForm form;
        int paintVolume;
        int paperLength;
        bool turnedOn;
        bool paperStucked;

        private int GetCurrentPaintVolume()
        {
            return 80;
        }

        private int GetCurrentPaperLength()
        {
            return 28;
        }

        private bool CheckForPaperStuck()
        {
            return false;
        }

        public Printer()
        {
            form = new ChequeForm();
            turnedOn = true;
            paintVolume = GetCurrentPaintVolume();
            paperLength = GetCurrentPaperLength();
            paperStucked = CheckForPaperStuck();
        }

        public PrinterState GetState()
        {
            if (!turnedOn)
                return PrinterState.TurnedOff;
            if (paperStucked)
                return PrinterState.PaperStuck;
            if (paperLength < ChequeLength)
                return PrinterState.OutOfPaper;
            if (paintVolume < minPaintVolume)
                return PrinterState.OutOfPaint;
            return PrinterState.Ready;
        }

        private int GetPaintExpenses(Transaction data)
        {
            return  data.Operator.ToString().Length 
                    + data.PhoneNumber.Length
                    + data.Sum.ToString().Length;
        }

        public void Print(Transaction data)
        {
            if (GetState() == PrinterState.Ready)
            {
                int paintExpenses = GetPaintExpenses(data);
                if (paintExpenses > paintVolume)
                    return;
                form.SetContent(data);
                form.ShowDialog();
                DialogResult result = form.DialogResult;
                if (result != DialogResult.Cancel)
                    paperStucked = true;
                else
                {
                    paintVolume -= paintExpenses;
                    paperLength -= ChequeLength;
                }
            }
        }

        ~Printer()
        {
            turnedOn = false;
        }
    }
}