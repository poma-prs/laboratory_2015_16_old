using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project6
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(tt1));
            t1.Start();
            Console.Read();
        }
        static void tt1()
        {
            Application.Run(new Form1());
        }
    }
}
