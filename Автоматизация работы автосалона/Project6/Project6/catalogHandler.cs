using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project6
{
    class CatalogHandler:IcatalogHandler
    {
        DiscountHandler _discountHandler { get; set; } 
        public int count_cars(int id_car)
        {
            var db = new db();
            return db.Cars.Count();
        }
        public static int i=0;
        public string add_car(string brand, string model, DateTime date, string color, string engine_performance, double price, string images_url)
        {
            Car car = new Car();
            car.brand = brand;
            car.carId = i;
            i++;
            car.color = color;
            car.date = date;
            car.engine_performance = engine_performance;
            car.images_url = images_url;
            car.model = model;
            car.price = price;
            var db = new db();
            db.Cars.Add(car);
            db.SaveChanges(); 
            return "Успех";
        }
    }
}
