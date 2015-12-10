using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project6
{
    interface Igui
    {
        string get_catalog(int id_catalog);
        string get_user_page(string auth_id);
    }
}
