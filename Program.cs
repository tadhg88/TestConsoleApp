using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (OtherClass.GoForIt())
            {
                Console.WriteLine("before hello world");
                Console.ReadKey(true);
            }

            if (MasterClass.GoForIt())
            {
                Console.WriteLine("hello world");
                Console.ReadKey(true);

                Console.WriteLine("after hello world");
                Console.ReadKey(true);
            }

            Console.WriteLine("1st before exit");
            Console.ReadKey(true);

            if (MasterClass.GoForIt())
            {
                Console.WriteLine("before exit");
                Console.ReadKey(true);

                Console.WriteLine("last before exit");
                Console.ReadKey(true);

                Console.WriteLine("exit");
            }
            
			Console.WriteLine("change message from timtest");
            Console.ReadKey(true);

            ThreadTimer.WaitForTimer();
        }
    }
}
