using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project6
{
    class UserHandler:IuserHandler
    {
        public string get_auth(string user_name, string password) {
            Dictionary<string, string> user_table = new Dictionary<string,string>();
            user_table.Add("user", "123");
            user_table.Add("user1", "321");
            user_table.Add("user2", "0000");
            string[] sellers = new string[] {"user2"};

            if (user_table.ContainsKey(user_name) && user_table[user_name]==password)
            {
                if (sellers.Contains(user_name)) {
                    return "s-" + user_name;
                }
                return "u-" + user_name;
            }
            else {
                return "unauth";
            }               
        }
    }
}
