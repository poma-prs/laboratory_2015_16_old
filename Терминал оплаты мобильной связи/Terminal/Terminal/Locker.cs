using System.Timers;
using System.Windows.Forms;

namespace Terminal
{
    public partial class Locker : Form
    {
        TerminalForm form;
        HttpClient client;

        public Locker(TerminalForm form, ref HttpClient client)
        {
            InitializeComponent();
            this.form = form;
            this.client = client;
        }

        public void Lock(string cause)
        {
            form.Enabled = false;
            CauseOfLockLabel.Text = cause;
            if (client.Ping() != ServerResponse.Positive)
            {
                this.Show();
                while (client.Ping() != ServerResponse.Positive) ;
            }
            Unlock();
        }

        public void Unlock()
        {
            this.Hide();
            form.Enabled = true;
        }
    }
}