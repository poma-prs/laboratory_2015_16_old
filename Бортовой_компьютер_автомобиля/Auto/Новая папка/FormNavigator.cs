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

namespace Auto
{
    public partial class FormNavigator : Form
    {
        private MyNavigator navigator;
        private Map map;

        public FormNavigator()
        {
            InitializeComponent();
            navigator = new MyNavigator();
            map = navigator.GetSavedMap();
        }

        private void buttonShowMap_Click(object sender, EventArgs e)
        {
            navigator.ShowMap(map);
        }

        private void buttonLocation_Click(object sender, EventArgs e)
        {
            if (navigator.ConnectGps())
            {
                Coordinate coord = navigator.GetCurrentLocation();
                navigator.UpdateMap(new List<Coordinate> { coord });
            }
        }

        private void buttonSetRoute_Click(object sender, EventArgs e)
        {
            Coordinate begin = new Coordinate();
            Coordinate end = new Coordinate();
            var coordList = navigator.SetRoute(begin, end);
            navigator.UpdateMap(coordList);
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            map = navigator.DownloadMap();
        }

        private void buttonTrafficJam_Click(object sender, EventArgs e)
        {
            List<Coordinate> trafficList = navigator.GetTrafficJam();
            navigator.UpdateMap(trafficList);
        }
    }
}
