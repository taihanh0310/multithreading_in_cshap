using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _01.CreatingThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(MethodA));
            t.Start();
            MethodB();
        }

        static void MethodA()
        {
            for (int i = 0; i < 100; i++)
                Console.Write("0");
        }
        static void MethodB()
        {
            for (int i = 0; i < 100; i++)
                Console.Write("1");
        }
    }
}
