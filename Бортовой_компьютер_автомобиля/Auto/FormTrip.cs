using System;
using System.Windows.Forms;

namespace Auto
{
    public partial class FormTrip : Form
    {
        private CurrentTripData curTripData;
        private CurrentFuelData curFuelData;

        public FormTrip()
        {
            InitializeComponent();
            curFuelData = new CurrentFuelData();
            curTripData = new CurrentTripData();
        }

        private void buttonCurrentTrip_Click(object sender, EventArgs e)
        {
            curTripData.Show();
        }

        private void buttonCurrentFuel_Click(object sender, EventArgs e)
        {
            curFuelData.Show();
        }
    }
}
