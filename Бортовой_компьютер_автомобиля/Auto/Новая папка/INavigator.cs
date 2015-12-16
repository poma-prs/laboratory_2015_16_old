using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    interface INavigator
    {
        List<Coordinate> SetRoute(Coordinate begin, Coordinate end);
        void ShowMap(Map map);
        Coordinate GetCurrentLocation();
        bool ConnectGps();
        Map DownloadMap();
        List<Coordinate> GetTrafficJam();
        void UpdateMap(List<Coordinate> coordinates);
        Map GetSavedMap();
    }
}
