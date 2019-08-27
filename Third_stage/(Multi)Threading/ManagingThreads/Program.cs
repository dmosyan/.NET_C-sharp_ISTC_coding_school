using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ManagingThreads
{
    // The following example demonstrates the use of
    // the sleep() method for making a thread pause for a specific period of time.

    class Program
    {
        static void CallToChildThread()
        {
            Console.WriteLine("Child Thread starts");
            int sleepTime = 5000;
            Console.WriteLine($"Pausing Child Thread for {sleepTime/1000} seconds");
            Thread.Sleep(sleepTime);
            Console.WriteLine("Chiled Thread resumed");
        }


        static void Main(string[] args)
        {
            ThreadStart childreferance = new ThreadStart(CallToChildThread);
            Console.WriteLine("Creating Child Thread in Main");
            Thread childThread = new Thread(childreferance);
            childThread.Start();
        }
    }
}
