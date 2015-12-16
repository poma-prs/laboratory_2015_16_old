using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal
{
    public interface IHttpClient
    {
        ServerResponse Ping();
        ServerResponse CheckOperator(MobileOperator op, string number);
        ServerResponse SendLock(string info);
        ServerResponse SendTransaction(Transaction transaction);
    }
}
