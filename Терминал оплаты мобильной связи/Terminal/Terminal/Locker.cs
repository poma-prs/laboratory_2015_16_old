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
    public partial class Locker : Form
    {
        bool allowClosing;

        public Locker()
        {
            InitializeComponent();
            allowClosing = false;
        }

        public void Lock(string cause)
        {
            CauseOfLockLabel.Text = cause;
            this.ShowDialog();
            DialogResult result = DialogResult;
        }

        public void Unlock()
        {
            allowClosing = true;
            this.Close();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = !allowClosing;
            base.OnClosing(e);
        }
    }
}