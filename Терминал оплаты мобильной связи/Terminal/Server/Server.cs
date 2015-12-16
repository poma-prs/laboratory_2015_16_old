using System;
using System.Reflection;

namespace Server
{
    class Server : ServerBase
    {
        public Server(string host, string port)
            : base(host, port)
        { }

        public void Start()
        {
            while (listener.IsListening)
            {
                context = listener.GetContext();
                request = context.Request;
                response = context.Response;

                var rawUrl = request.RawUrl;
                var trimmedUrl = rawUrl.Trim(new char[] { '/' });
                var indexOf = trimmedUrl.IndexOf('?');
                var methodName = indexOf >= 0 ? trimmedUrl.Substring(0, indexOf) : trimmedUrl;

                MethodInfo info = typeof(Server).GetMethod(methodName);
                try
                {
                    info.Invoke(this, null);
                }
                catch
                {
                    WriteResponse(string.Empty);
                }
            }
        }

        public void Ping()
        {
            Console.WriteLine("Ping");
            WriteResponse("OK");
        }

        public void CheckOperator()
        {
            string[] data = GetRequestBody().Split(new char[] { ' ' });
            if (data.Length == 2)
            {
                Console.WriteLine("Check " + data[0] + " " + data[1]);
                WriteResponse("Correct");
            }
            else
            {
                Console.WriteLine("Check attempt. Wrong data.");
                WriteResponse("Incorrect");
            }
        }

        public void Lock()
        {
            Console.WriteLine("Terminal locked: " + GetRequestBody());
            Console.WriteLine("Type \"Unlock\" to unlock the terminal.");
            string input;
            while ((input = Console.ReadLine()) != "Unlock") ;
            WriteResponse(input);
        }

        public void Commit()
        {
            string[] data = GetRequestBody().Split(new char[] { ' ' });
            if (data.Length == 3)
            {
                Console.WriteLine("Commit " + data[0] + " " + data[1] + " " + data[2]);
                WriteResponse("Success");
            }
            else
            {
                Console.WriteLine("Commit attempt. Wrong data.");
                WriteResponse("Failure");
            }
        }

        public void Stop()
        {
            listener.Stop();
        }
    }
}