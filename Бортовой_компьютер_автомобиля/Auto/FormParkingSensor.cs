using System;
using System.Windows.Forms;
using Auto.AutoSystems.ParkingSensor;

namespace Auto
{
    public partial class FormParkingSensor : Form
    {
        private ParkingSensor parkingSensor;

        public FormParkingSensor()
        {
            InitializeComponent();
            parkingSensor = new ParkingSensor();
        }

        private void buttonOn_Click(object sender, EventArgs e)
        {
            parkingSensor.TurnOn();
        }

        private void buttonOff_Click(object sender, EventArgs e)
        {
            parkingSensor.TurnOff();
        }
    }
}
