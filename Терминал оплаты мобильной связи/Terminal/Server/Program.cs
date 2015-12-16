namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server("http://127.0.0.1", "10000");
            server.Start();
        }
    }
}