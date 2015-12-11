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
    public partial class ChequeForm : Form
    {
        public ChequeForm()
        {
            InitializeComponent();
        }

        public void SetContent(Transaction data) {
            OperatorLabel.Text = data.Operator.ToString();
            PhoneNumberLabel.Text = data.PhoneNumber;
            SumLabel.Text = data.Sum.ToString();
        }
    }
}