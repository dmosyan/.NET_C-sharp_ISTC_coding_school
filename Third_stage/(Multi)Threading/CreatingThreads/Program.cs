using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CreatingThreads
{
    // Threads are created by extending the Thread class. 
    // The extended Thread class then calls the Start() method to 
    // begin the child thread execution.

    class Program
    {
        public static void CallToChildThread()
        {
            Console.WriteLine("Starting child thread");
        }

        static void Main(string[] args)
        {
            ThreadStart childReferance = new ThreadStart(CallToChildThread);
            Console.WriteLine("In Main creating the Child Thread");
            Thread childThread = new Thread(childReferance);
            childThread.Start();
        }
    }
}
