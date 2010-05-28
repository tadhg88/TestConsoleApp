using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestConsoleApp
{
    public class ThreadTimer
    {
        public static void WaitForTimer(int waitMilliSeconds)
        {
            System.Threading.Thread.Sleep(waitMilliSeconds);
        }
    }
}
