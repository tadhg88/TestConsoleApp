﻿using System;
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

            if (AnotherClass.HmmmmmmRandomMethod())
            {
                Console.WriteLine("hello world");
                Console.ReadKey(true);

                Console.WriteLine("after hello world");
            }

            Console.WriteLine("before exit");
            Console.ReadKey(true);
        }
    }
}
