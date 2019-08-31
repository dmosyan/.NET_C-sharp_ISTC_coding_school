using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadSafety
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting main thread");
            Thread thread1 = new Thread(new ThreadStart(AddList));
            thread1.Start();
            Thread thread2 = new Thread(new ThreadStart(AddList));
            thread2.Start();
            Thread thread3 = new Thread(new ThreadStart(AddList));
            thread3.Start();
            Console.WriteLine("Finishing main thread");
        }

        private static object myLock = new object();
        private static Random random = new Random();
        private static List<int> list = new List<int>();
        private static void AddList()
        {
            for (int i = 0; i < 100; i++)
            {
                lock (myLock)
                {
                    Thread.Sleep(random.Next(1, 1000));
                    list.Add(i);
                }
            }
        }
        // Without LOCK: Unhandled Exception: System.ArgumentException: Destination array was 
        // not long enough.Check destIndex and length, and the array's lower bounds.
    }
}
