using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project6
{
    interface IdiscountHandler
    {
        string add_discount(string discount_type, double percent, int id_catalog);
        string edit_discount(int id_catalog, Discount edited_discount);
    }
}
