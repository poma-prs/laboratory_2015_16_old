using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terminal
{
    public partial class TerminalForm : Form
    {
        bool SwitchingTabAllowed;
        int InsertedMoney = 0;
        Transaction transaction;
        static Printer printer;
        static BillAnalizer analizer;
        Locker locker;

        public TerminalForm()
        {
            InitializeComponent();
            this.tabControl.Selecting += tabControl_Selecting;
            this.PhoneNumberMaskedTextBox.TextChanged += PhoneNumberMaskedTextBox_TextChanged;
            this.Button10Rubles.Click += InsertingBill;
            this.Button50Rubles.Click += InsertingBill;
            this.Button100Rubles.Click += InsertingBill;
            this.Button500Rubles.Click += InsertingBill;
            this.Button1000Rubles.Click += InsertingBill;
            this.Button5000Rubles.Click += InsertingBill;
            this.TransactionCommitingTabPage.Enter += tabPage4_Enter;
            this.ButtonCancel1.Click += CancelTransaction;
            this.ButtonCancel2.Click += CancelTransaction;
            SwitchingTabAllowed = false;
            transaction = new Transaction();
            printer = new Printer();
            analizer = new BillAnalizer();
            locker = new Locker();
            ResetInterface();
        }

        private void ResetInterface()
        {
            transaction = new Transaction();
            SwitchingTabAllowed = true;
            this.tabControl.SelectedIndex = 0;
            this.MTSRadioButton.Checked = false;
            this.BeelineRadioButton.Checked = false;
            this.MegaphoneRadioButton.Checked = false;
            this.ButtonNext1.Enabled = false;
            this.PhoneNumberMaskedTextBox.Text = string.Empty;
            this.ButtonNext2.Enabled = false;
            this.InsertedMoneyTextBox.Text = string.Empty;
            this.ButtonNext3.Enabled = false;
            this.PhoneNumberLabel.Text = string.Empty;
            this.InsertedMoneyLabel.Text = string.Empty;
        }

        private void tabControl_Selecting(object sender, System.Windows.Forms.TabControlCancelEventArgs e)
        {
            e.Cancel = !SwitchingTabAllowed;
            SwitchingTabAllowed = false;
        }

        private void SwitchTab(bool next)
        {
            SwitchingTabAllowed = true;
            if (next)
                tabControl.SelectedIndex++;
            else
                tabControl.SelectedIndex--;
        }

        private void ButtonNext1_Click(object sender, EventArgs e)
        {
            if (MTSRadioButton.Checked)
                transaction.Operator = MobileOperator.MTS;
            else if (BeelineRadioButton.Checked)
                transaction.Operator = MobileOperator.Beeline;
            else if (MegaphoneRadioButton.Checked)
                transaction.Operator = MobileOperator.Megaphone;
            else
                throw new Exception("Не выбран оператор мобильной связи.");
            SwitchTab(true);
        }

        private void ButtonNext2_Click(object sender, EventArgs e)
        {
            if (PhoneNumberMaskedTextBox.MaskFull)
                transaction.PhoneNumber = PhoneNumberMaskedTextBox.Text;
            else
                throw new Exception("Не указан номер мобильного телефона.");
            SwitchTab(true);
        }

        private void ButtonNext3_Click(object sender, EventArgs e)
        {
            transaction.Sum = InsertedMoney;
            SwitchTab(true);
        }

        private void ButtonBack1_Click(object sender, EventArgs e)
        {
            SwitchTab(false);
        }

        private void ButtonBack2_Click(object sender, EventArgs e)
        {
            SwitchTab(false);
        }

        private void MTSRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ButtonNext1.Enabled = true;
        }

        private void BeelineRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ButtonNext1.Enabled = true;
        }

        private void MegaphoneRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ButtonNext1.Enabled = true;
        }

        private void PhoneNumberMaskedTextBox_TextChanged(object sender, System.EventArgs e)
        {
            if (PhoneNumberMaskedTextBox.MaskFull)
                ButtonNext2.Enabled = true;
            else
                ButtonNext2.Enabled = false;
        }

        private void InsertingBill(object sender, EventArgs e)
        {
            //////////////////////////////////
            var buttonText = ((Button)sender).Text;
            var valueText = buttonText.Substring(0, buttonText.IndexOf(' '));
            var value = Int32.Parse(valueText);
            //////////////////////////////////
            InsertedMoney += value;
            InsertedMoneyTextBox.Text = InsertedMoney.ToString();
        }

        private void RecievedMoneyTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(InsertedMoneyTextBox.Text) >= 50)
                    ButtonNext3.Enabled = true;
            }
            catch { }
        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {
            PhoneNumberLabel.Text = transaction.PhoneNumber;
            InsertedMoneyLabel.Text = transaction.Sum.ToString();
        }

        private void CancelTransaction(object sender, EventArgs e)
        {
            ///////////////////////////////////////

            ResetInterface();
            //////////////////////////////////////
        }

        private void CommitTransaction(Transaction transaction)
        {

        }

        private void ButtonCommitTransaction_Click(object sender, EventArgs e)
        {
            //////////////////////////////////////

            printer.Print(transaction);
            ResetInterface();
            //////////////////////////////////////
        }
    }
}