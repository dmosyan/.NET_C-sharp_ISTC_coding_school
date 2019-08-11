using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Point_Arithmetic_operators point1 = new Point_Arithmetic_operators(3, 4);
            Point_Arithmetic_operators point2 = new Point_Arithmetic_operators(2, 3);

            Point_Arithmetic_operators point3 = point1 + point2;
            Console.WriteLine(point3); // (5, 7)
            Point_Arithmetic_operators point4 = point1 - point2;
            Console.WriteLine(point4); // (1, 1)
            Point_Arithmetic_operators point5 = point1 * point2;
            Console.WriteLine(point5); // (6, 12)
            Point_Arithmetic_operators point6 = point1 / point2;
            Console.WriteLine(point6); // (1, 1)
            Point_Arithmetic_operators point7 = point1 % point2;
            Console.WriteLine(point7); // (1, 1)
        }
    }
}
