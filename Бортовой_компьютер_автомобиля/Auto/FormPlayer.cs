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
    public partial class FormPlayer : Form
    {
        private Player player;

        public FormPlayer()
        {
            InitializeComponent();
            player = new Player();
        }

        private void buttonOn_Click(object sender, EventArgs e)
        {
            player.TurnOn();
        }

        private void buttonOff_Click(object sender, EventArgs e)
        {
            player.TurnOff();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            player.Play();
        }
    }
}
