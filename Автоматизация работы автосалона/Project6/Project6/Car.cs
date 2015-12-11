using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project6
{
    [Table("Cars")]
    class Car
    {
        [Key]
        public int carId { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public DateTime date { get; set; }
        public string color { get; set; }
        public string engine_performance { get; set; }
        public double price { get; set; }
        public string images_url { get; set; }
    }
}
