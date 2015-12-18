using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Auto.AutoSystems.MediaPlayer;

namespace Auto
{
    public partial class FormRadio : Form
    {
        private Radio radio;

        public FormRadio()
        {
            InitializeComponent();
            radio = new Radio();
        }

        private void buttonOn_Click(object sender, EventArgs e)
        {
            radio.TurnOn();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            radio.Play();
        }

        private void buttonOff_Click(object sender, EventArgs e)
        {
            radio.TurnOff();
        }

        private void buttonFreq_Click(object sender, EventArgs e)
        {
            radio.SetFrequency();
        }
    }
}
