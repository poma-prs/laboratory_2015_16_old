using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project6
{
    interface IorderHandler
    {
        string add_order(Order order);
        Order handle_order(int id_user, int[] id_goods);
    }
}
