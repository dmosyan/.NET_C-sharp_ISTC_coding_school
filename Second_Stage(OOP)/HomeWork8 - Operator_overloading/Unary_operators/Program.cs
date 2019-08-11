using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unary_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(3, 4);

            Console.WriteLine(point1++); //(3, 4)
            Console.WriteLine(point1--); //(4, 5)
            Console.WriteLine(--point1); //(2, 3)
            Console.WriteLine(++point1); //(3, 4)
        }
    }
}
