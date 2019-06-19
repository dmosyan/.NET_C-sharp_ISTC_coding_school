using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASK 6. We have x,y,x1,y1,x2,y2 > 0 integers. Print "YES" if dot with coordinates (x,y) is inside the 
            // rectangulare which left upside corner has coordinates (x1,y1) and right bottom side corner has coordinates (x2,y2)
            uint x = UInt32.Parse(Console.ReadLine());
            uint y = UInt32.Parse(Console.ReadLine());
            uint x1 = UInt32.Parse(Console.ReadLine());
            uint y1 = UInt32.Parse(Console.ReadLine());
            uint x2 = UInt32.Parse(Console.ReadLine());
            uint y2 = UInt32.Parse(Console.ReadLine());

            if (x1<x && y1>y && x2>x && y2<y)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            //TASK 7: We have a,b,c natural numbers. Print "YES" if we can make triangle using numbers as sides length
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int c = Int32.Parse(Console.ReadLine());

            if (a + b > c || a + c > b || b + c > a)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            //TASK 8 a,b,c are triangle sides. Print "YES" if 1: we can make equitable triangle
            // 2: we can make triangle where 2 sides are equal to each other, 3: we can make triangle where one angle is 90 degree
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int c = Int32.Parse(Console.ReadLine());

            //Option 1
            if (a == b && a==c)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            //Option 2
            if (a == b && a != c || c==b && c!=a || a==c && c!=b)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            //Option 3
            if ((Math.Pow(a,2) + Math.Pow(b,2) == Math.Pow(c, 2)) || (Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2))
                || (Math.Pow(c, 2) + Math.Pow(b, 2) == Math.Pow(a, 2)))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            //TASK 9: we have x,y numbers from 1 to 8 and we have chess board. Each number represents
            // one coordinate and (x,y) gives us any cell in chess. Given x and y we should determine if
            // the cell with that location is black or white.
            int x = Int32.Parse(Console.ReadLine());
            int y = Int32.Parse(Console.ReadLine());

            if (x==1 && y==1 || x%2 == 1 && y%2 ==1 || x%2==0 && y%2==0)
            {
                Console.WriteLine("black");
            }
            else
            {
                Console.WriteLine("White");
            }

            //TASK 10:we have x1,y1,x2,y2 numbers from 1 to 8 and we have chess board. Each number represents
            // one coordinate and (x,y) gives us any cell in chess. Determine if (x1,y1) cell has the same
            // color as (x2,y2)
            int x1 = Int32.Parse(Console.ReadLine());
            int y1 = Int32.Parse(Console.ReadLine());
            int x2 = Int32.Parse(Console.ReadLine());
            int y2 = Int32.Parse(Console.ReadLine());

            if ((x1+y1 %2 == 0 && x2+y2 %2 ==0) || (x1+y1 %2 != 0 && x2+y2 %2 != 0))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
