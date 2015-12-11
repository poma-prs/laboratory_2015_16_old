using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project6
{
    interface IcatalogHandler
    {
        int count_cars(int id_car);
        string add_car(string brand, string model, DateTime date, string color, string engine_performance, double price, string images_url);
    }
}
