using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Auto.AutoSystems.Conditioner;

namespace Auto
{
    public partial class FormConditioner : Form
    {
        private Conditioner conditioner;

        public FormConditioner()
        {
            InitializeComponent();
            conditioner = new Conditioner();
        }

        private void buttonOn_Click(object sender, EventArgs e)
        {
            conditioner.TurnOn();
        }

        private void buttonOff_Click(object sender, EventArgs e)
        {
            conditioner.TurnOff();
        }

        private void buttonTemp_Click(object sender, EventArgs e)
        {
            double temp = GetTemp();
            conditioner.SetTemperature(temp);
        }

        private double GetTemp();

        private void buttonPower_Click(object sender, EventArgs e)
        {
            double power = GetPower();
            conditioner.SetPower(power);
        }

        private double GetPower();

    }
}
