using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Auto.Navigator;
using Auto.AutoSystems;

namespace Auto
{
    public partial class FormMenu : Form, Igui
    {        
        private Option option;
        private FormNavigator formNavigator;
        private FormPlayer formPlayer;
        private FormRadio formRadio;
        private FormConditioner formConditioner;
        private FormTrip formTrip;
        private FormJournal formJournal;
        private FormParkingSensor formParking;
        private AutoState autoState;

        public FormMenu()
        {
            ShowMenu();
        }

        public void ShowMenu()
        {
            InitializeComponent();
        }

        public void ExecuteOption()
        {
            switch (option)
            {
                case Option.navigator:
                    formNavigator = new FormNavigator();
                    formNavigator.Show();
                    break;
                case Option.conditioner:
                    formConditioner = new FormConditioner();
                    formConditioner.Show();
                    break;
                case Option.journal:
                    formJournal = new FormJournal();
                    formJournal.Show();
                    break;
                case Option.parkingSensor:
                    formParking = new FormParkingSensor();
                    formParking.Show();
                    break;
                case Option.player:
                    formPlayer = new FormPlayer();
                    formPlayer.Show();
                    break;
                case Option.radio:
                    formRadio = new FormRadio();
                    formRadio.Show();
                    break;
                case Option.tripData:
                    formTrip = new FormTrip();
                    formTrip.Show();
                    break;
                default:
                    break;
            }
        }

        private void ShowState()
        {
            autoState.GetCurrentState();
            autoState.GetBatteryCharge();
            autoState.GetEngineHeat();
        }

        private void buttonNavigator_Click(object sender, EventArgs e)
        {
            option = Option.navigator;
            ExecuteOption();
        }

        private void buttonPlayer_Click(object sender, EventArgs e)
        {
            option = Option.player;
            ExecuteOption();
        }

        private void buttonRadio_Click(object sender, EventArgs e)
        {
            option = Option.radio;
            ExecuteOption();
        }

        private void buttonCurrentData_Click(object sender, EventArgs e)
        {
            option = Option.tripData;
            ExecuteOption();
        }

        private void buttonJournal_Click(object sender, EventArgs e)
        {
            option = Option.journal;
            ExecuteOption();
        }

        private void buttonConditioner_Click(object sender, EventArgs e)
        {
            option = Option.conditioner;
            ExecuteOption();
        }

        private void buttonParkingSensor_Click(object sender, EventArgs e)
        {
            option = Option.parkingSensor;
            ExecuteOption();
        }
    }
}
