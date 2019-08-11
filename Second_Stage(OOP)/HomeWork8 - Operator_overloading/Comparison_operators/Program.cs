using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparison_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(4, 8);
            Point point2 = new Point(3, 7);

            Console.WriteLine(point1!=point2);      //true
            Console.WriteLine(point1 == point2);    //false

            Console.WriteLine(point1 > point2);     //true
            Console.WriteLine(point1 < point2);     //false
            Console.WriteLine(point1 >= point2);    //true
            Console.WriteLine(point1 <= point2);    //false
        }
    }
}
