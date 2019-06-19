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
            // TASK 1: We have 2 positive numbers. Print "YES" if 1: Both of them are odd numbers 
            // 2: One of them is odd number, 3: At least one og them is odd, 4: Both are odd numbers or both are even numbers 
            uint A = UInt32.Parse(Console.ReadLine());
            uint B = UInt32.Parse(Console.ReadLine());

            // Option 1
            if (A % 2 == 1 && B % 2 == 1) 
            {
                Console.WriteLine("YES");
            } 
            else
            {
                Console.WriteLine("NO");
            }

            // Option 2
            if (A % 2 == 1 || B % 2 == 1)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            // Option 3
            if (A % 2 == 1 && B % 2 == 0 || A % 2 == 0 && B % 2 == 1)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            //Option 4
            if (A % 2 == 1 && B % 2 == 1 || A % 2 == 0 && B % 2 == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            //TASK 2: We have 3 integers (A,B and C). Print "YES" if 1: 3 of them are >0 2: At lesast one of the >0
            //3: only one of them is > 0, 4: Both of them are > 0, 5: At least 2 of them are equal numbers, 6: At least 2 of them differ by sign.
            int A = Int32.Parse(Console.ReadLine());
            int B = Int32.Parse(Console.ReadLine());
            int C = Int32.Parse(Console.ReadLine());

            //Option 1
            if (A>0 && B>0 && C>0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            //Option 2
            if (A>0 || B>0 || C>0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            //Option 3
            if ((A > 0 && B < 0 && C < 0
                || A < 0 && B > 0 && C < 0
                || A < 0 && B < 0 && C > 0
                ))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            //Option 4
            if ((A > 0 && B > 0 && C < 0
                || A > 0 && B < 0 && C > 0
                || A < 0 && B > 0 && C > 0
                ))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            // Option 5
            if ((A==B && C!=A)
                || (A==C && B!=A)
                || (B==C && B!= A))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            //Option 6
            if ((Math.Abs(A) == Math.Abs(B) && Math.Abs(C) != Math.Abs(A))
                || (Math.Abs(A) == Math.Abs(C) && Math.Abs(B) != Math.Abs(A))
                || (B == C && B != A))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

             

            //TASK 3: We have A > 0 number. If A is 2 digit number and even number, A is 3 digit number 
            // and odd number print YES, else print NO
            uint A = uint.Parse(Console.ReadLine());

            if ((A>9 && A<100 &&  A%2==0)
                || A>99 && A<1000 && A%2==1)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }


            // TASK 4: We have A 3 digits integer. Print "YES" if 1: there are no equal digits, 2: every digit is smaller than the next one
            // 3: if the number is polindrome, else print "NO"
            int A = Int32.Parse(Console.ReadLine()); // for example 345
            int thirdDigit = A % 10;                 // we should get 5
            int newNumber = A / 10;                  // we should get 34
            int secondDigit = A % 10;                // we should get 4               
            int firstDigit = newNumber / 10;         // we should get 3 

            //Option 1
            if (firstDigit != secondDigit && firstDigit != thirdDigit && secondDigit != thirdDigit)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            //Option 2
            if (firstDigit<secondDigit && secondDigit<thirdDigit)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            //Option 3
            if (firstDigit<secondDigit && secondDigit<thirdDigit)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            //Option 4
            if (firstDigit == thirdDigit)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }


            //TASK 5: We have X and Y integers. Print "YES", if 1: Dot with (X,Y) coordinates is in second Quadrant
            // 2: Dot with (X,Y) coordinates is in forth Quadrant, 3: Dot with (X,Y) coordinates is in second or third Quadrant
            // 4: Dot with (X,Y) coordinates is in first or third Quadrant
            
            int X = Int32.Parse(Console.ReadLine());
            int Y = Int32.Parse(Console.ReadLine());


            //Option 1
            if (X<0 && Y>0) 
             {
                Console.WriteLine("YES");
             }
            else
            { 
                Console.WriteLine("NO");
            }

            //Option 2
            if (X>0 && Y<0) 
             {
                Console.WriteLine("YES");
             }
            else
            { 
                Console.WriteLine("NO");
            }

            //Option 3
            if (X<0 && Y!=0) 
             {
                Console.WriteLine("YES");
             }
            else
            { 
                Console.WriteLine("NO");
            }

            //Option 4
            if (X>0 && Y>0 || X<0 && Y<0 ) 
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
