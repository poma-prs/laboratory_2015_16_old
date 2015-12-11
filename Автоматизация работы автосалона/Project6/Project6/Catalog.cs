using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project6
{
    class Catalog
    {
        [Key]
        public int catalogId { get; set; }
        public Car[] cars { get; set; }
        public Discount discount { get; set; }
    }
}
