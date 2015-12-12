using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;

namespace Terminal
{
    public class HttpClient
    {
        string prefix = "http://127.0.0.1:10000";

        private string Post(string method, string data, int timeout)
        {
            var request = (HttpWebRequest)WebRequest.Create(string.Format("{0}/{1}/", prefix, method));
            request.Method = "POST";
            request.Timeout = timeout;
            byte[] bytes = Encoding.UTF8.GetBytes(data);
            if (data != null)
                request.GetRequestStream().Write(bytes, 0, bytes.Length);
            List<byte> responseBytes = new List<byte>();
            using (var stream = request.GetResponse().GetResponseStream())
            {
                while (true)
                {
                    var b = stream.ReadByte();
                    if (b == -1)
                        break;
                    responseBytes.Add((byte)b);
                }
            }
            return Encoding.UTF8.GetString(responseBytes.ToArray());
        }

        public bool Ping()
        {
            return Post("Ping", string.Empty, 2000) == "OK";
        }

        public bool CheckOperator(MobileOperator op, string number)
        {
            return Post("CheckOperator", op.ToString() + " " + number.Replace(" ", ""), 5000) == "Correct";
        }

        public bool SendLock(string info)
        {
            return Post("Lock", info, Timeout.Infinite) == "Unlock";
        }

        public bool SendTransaction(Transaction transaction)
        {
            return Post("Commit", transaction.Operator.ToString() + " " +
                transaction.PhoneNumber.Replace(" ", "") + " " + 
                transaction.Sum.ToString(), 10000) == "Success";
        }
    }
}