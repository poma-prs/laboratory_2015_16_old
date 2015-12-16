using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto.Navigator
{
    class MyNavigator : INavigator
    {
        public List<Coordinate> SetRoute(Coordinate begin, Coordinate end)
        {
            throw new NotImplementedException();
        }

        public void ShowMap(Map map)
        {
            throw new NotImplementedException();
        }

        public Coordinate GetCurrentLocation()
        {
            throw new NotImplementedException();
        }

        public bool ConnectGps()
        {
            throw new NotImplementedException();
        }

        public Map DownloadMap()
        {
            throw new NotImplementedException();
        }

        public List<Coordinate> GetTrafficJam()
        {
            throw new NotImplementedException();
        }

        public void UpdateMap(List<Coordinate> coordinates)
        {
 	        throw new NotImplementedException();
        }

        public Map GetSavedMap()
        {
            throw new NotImplementedException();
        }
    }
}
