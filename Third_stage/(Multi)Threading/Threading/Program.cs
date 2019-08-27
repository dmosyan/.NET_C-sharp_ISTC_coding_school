using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    class Program
    {
        //Main Thread execution
        static void Main(string[] args)
        {
            Thread thread = Thread.CurrentThread;
            thread.Name = "Main Thread";
            Console.WriteLine($"This is {thread.Name}");
        }
    }
}
