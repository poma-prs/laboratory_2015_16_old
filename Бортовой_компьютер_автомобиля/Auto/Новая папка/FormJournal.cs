using System;
using System.Windows.Forms;

namespace Auto
{
    public partial class FormJournal : Form
    {
        private FuelJournalData fuelJournal;
        private TripJournalData tripJournal;
        private DateTime date1, date2;

        public FormJournal()
        {
            InitializeComponent();
            fuelJournal = new FuelJournalData();
            tripJournal = new TripJournalData();
        }

        private void buttonTrip_Click(object sender, EventArgs e)
        {
            GetDates();
            tripJournal.Show(date1, date2);
        }

        private void GetDates()
        {
            throw new NotImplementedException();
        }

        private void buttonFuel_Click(object sender, EventArgs e)
        {
            fuelJournal.Show(date1, date2);
        }
    }
}
