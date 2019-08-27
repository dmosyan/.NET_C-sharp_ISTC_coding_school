using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DestroyingThreads
{
    class Program
    {
        public static void CallToChildThread()
        {
            int sleepTime = 5000;
            try
            {
                Console.WriteLine("Starting Child Thread");
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(sleepTime);
                    Console.WriteLine(i);
                }
                Console.WriteLine("Child Thread Completed");
            }
            catch (ThreadAbortException exception)
            {
                Console.WriteLine("Thread Abort Exception"); ;
            }
            finally { Console.WriteLine("Couldn't cath the tread exception"); }
        }

        static void Main(string[] args)
        {
            ThreadStart childReference = new ThreadStart(CallToChildThread);
            Console.WriteLine("Creating Child Thread in Main");
            Thread childThread = new Thread(childReference);
            childThread.Start();
            //Stoping Main Thread
            Thread.Sleep(2000);
            //Aborting the Child Thread
            Console.WriteLine("Aborting Child Thread in Main");
            childThread.Abort();
        }
    }
}
