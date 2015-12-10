using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project6
{
    interface IuserHandler
    {
        string get_auth(string user_name, string password);

    }
}
