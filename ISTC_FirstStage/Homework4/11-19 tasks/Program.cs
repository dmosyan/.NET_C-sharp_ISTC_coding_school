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
            //TASK 11: We have 3 numbers, 1: find the minimum number, 2: find the second largest number
            // 3: sum of largest and second largest numbers
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int c = Int32.Parse(Console.ReadLine());

            if (a <= b && a <= c)
            {
                Console.WriteLine(a);
            }
            else if (b <= a && b <= c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }

            //Option 2
            if (a <= b && a >= c || a >= b && a <= c)
            {
                Console.WriteLine(a);
            }
            else if (b <= a && b >= c || b >= a && b <= c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
            //Option 3
            if (a <= b && a >= c || a >= b && a <= c)
            {
                Console.WriteLine(a+c);
            }
            else if (b <= a && b >= c || b >= a && b <= c)
            {
                Console.WriteLine(b+a);
            }
            else
            {
                Console.WriteLine(c+b);
            }

            ////////////////////////////////////////////////////////////////////

            //TASK 12: We have a,b,c real numbers, if any number is smaller than the next one or if any number is bigger then
            // the next one, print a,b,c doubled, else change the signs
            double a = Double.Parse(Console.ReadLine());
            double b = Double.Parse(Console.ReadLine());
            double c = Double.Parse(Console.ReadLine());

            if(a<b && b<c || a>b && b>c)
            {
                Console.WriteLine(" The new a is {0}, b is {1} and c is {2}", a*2, b*2, c*2);
            }
            else
            {
                Console.WriteLine(" The new a is {0}, b is {1} and c is {2}", a * (-1), b * (-1), c * (-1));
            }


            /////////////////////////////////////////////////////////////////////
            
            ////TASK 13: we have a,b,c real numbers. Find out which one is closer to 'a' and print the value
            double a = Double.Parse(Console.ReadLine());
            double b = Double.Parse(Console.ReadLine());
            double c = Double.Parse(Console.ReadLine());

            if(Math.Abs(b-a)<Math.Abs(c-a))
            {
                Console.WriteLine("c is the farest number from a, c:{0}, distance:{1}", c, Math.Abs(c-a));
            }
            else
            {
                Console.WriteLine("b is the farest number from a, b:{0}, distance:{1}", b, Math.Abs(b - a));
            }

            ////////////////////////////////////////////////////////////////////

            //TASK 14: We have point with (x,y) coordinates. Print 0 if it's on the origin, print 1 if it's on the X axis,
            // print 2 if it's on the Y axis. Else print 3
            //double x = Double.Parse(Console.ReadLine());
            //double y = Double.Parse(Console.ReadLine());

            if(x==0 && y==0)
            {
                Console.WriteLine(0);
            }
            else if (x!=0 && y==0)
            {
                Console.WriteLine(1);
            }
            else if (y != 0 && x == 0)
            {
                Console.WriteLine(2);
            }
            else
            {
                Console.WriteLine(3);
            }
             
            ////////////////////////////////////////////////////////////////

            ////TASk: 15 We have point which is not rely on the X or Y axises. Print the number of Quadrant
            double x = Double.Parse(Console.ReadLine());
            double y = Double.Parse(Console.ReadLine());

            if(x>0 && y>0)
            {
                Console.WriteLine("Point is in Quadrant 1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Point is in Quadrant 2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Point is in Quadrant 3");
            }
            else
            {
                Console.WriteLine("Point is in Quadrant 4");
            }


            ////////////////////////////////////////////////////////////////////////
            
            //TASK 16. Print "YES" if the point with (x,y) coordinates is in the triangle which angle points have the following coordinates
            // (0,0),(0,-1) and (-1,0)
            double x = Double.Parse(Console.ReadLine());
            double y = Double.Parse(Console.ReadLine());

            if(x<0 && x>-1 && y<0 && y>-1)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            ///////////////////////////////////////////////////////////////////////////

            //TASK 17 In coordinate system we have rectangular. We know 3 angle points coordinates. Find out the last one.
            double x1 = Double.Parse(Console.ReadLine());
            double y1 = Double.Parse(Console.ReadLine());
            double x2 = Double.Parse(Console.ReadLine());
            double y2 = Double.Parse(Console.ReadLine());
            double x3 = Double.Parse(Console.ReadLine());
            double y3 = Double.Parse(Console.ReadLine());

            double x4 = x3;
            double y4 = y1;

            Console.WriteLine("x4 is {0}, y4 is {1}",x4,y4);

            ///////////////////////////////////////////////////////////////////////

            ////TASK 18. Import any 3 digit number. If the first digit is less then the third digit (with 3), print "1"
            //// else calculate n to the power of 2
            int n = Int32.Parse(Console.ReadLine()); //ex. 672

            int firstDigit = n / 100; //we should get 6
            int thirdDigit = n % 10;  //we should get 2

            if (thirdDigit == firstDigit+3)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine("The n to the power of 2 is: " + Math.Pow(n,2));

            }

            ////////////////////////////////////////////////////////////////////////

            //TASK 19. We have n>7 natural number. Find out a and b so that n=3*a + 5*b
            uint n = UInt32.Parse(Console.ReadLine());
            uint a, b;

            if (n%5 == 0)
            {
                Console.WriteLine("a = {0}, b = {1}", 0, b=n/5);
            }

            else if (n % 5 == 1)
            {
                Console.WriteLine("a = {0}, b = {1}", 2, b = (n-6) / 5);
            }

            else if (n % 5 == 2)
            {
                Console.WriteLine("a = {0}, b = {1}", 4, b = (n-12) / 5);
            }
            else if (n % 5 == 3)
            {
                Console.WriteLine("a = {0}, b = {1}", 1, b = (n - 3) / 5);
            }
            else
            {
                Console.WriteLine("a = {0}, b = {1}", 3, b = (n - 9) / 5);
            }


        }
    }
}
