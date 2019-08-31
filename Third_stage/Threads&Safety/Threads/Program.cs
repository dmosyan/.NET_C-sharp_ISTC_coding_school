using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Main method start thread");
            Thread thread1 = new Thread(new ThreadStart(DoSmth));
            thread1.Start();

            Thread thread2 = new Thread(new ThreadStart(DoSmth));
            thread2.Start();

            Thread thread3 = new Thread(new ThreadStart(DoSmth));
            thread3.Start();

            Console.WriteLine("Main method end thread");
        }

        private static Random random = new Random();
        private static int total = 0;

        private static void DoSmth()
        {
            Thread.Sleep(random.Next(1, 1500));
            int myTotal = total;
            Thread.Sleep(random.Next(1, 1500));
            total = myTotal + 1;
            Console.WriteLine($"Thread ID: {Thread.CurrentThread.ManagedThreadId} says {total}");
        }

        //Output
        /* Main method start thread
         * Main method end thread
         * Thread ID: 4 says 1
         * Thread ID: 5 says 1
         * Thread ID: 3 says 1
         */
    }
}
