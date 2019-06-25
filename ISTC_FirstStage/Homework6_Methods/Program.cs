using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6_Methods
{
    class Program
    {
        ///task1: write a method that will count the sum of the digitsl
        /// <summary>
        /// this method will count the sum of the given digit
        /// </summary>
        static int sumofdigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {

                int digit = number % 10;
                sum += digit;
                number /= 10;
            }
            return sum;
        }

        //task2. write a method that will print k number n times
        /// <summary>
        /// n times print k number
        /// </summary>
        /// <param name="k"></param>
        /// <param name="n"></param>
        static void ntimesknumber(int k, int n)
        {
            while (n > 0)
            {
                console.writeline(k);
                --n;
            }
        }

        //task3. insert 0< n <10 number and print all numbers that are less then n
        /// <summary>
        /// print numbers that are less then n
        /// </summary>
        /// <param name="n"></param>
        static void printlessthennnumbers(int n)
        {
            while (n > 0)
            {
                console.writeline(--n);
            }
        }

        //task4: take number n from console and print starting n to the power of 1 
        //till to the power of 9
        /// <summary>
        /// gives the power of n from 1 to 9
        /// </summary>
        /// <param name="args"></param>
        static void thepowerof(int n)
        {
            for (int i = 1; i <= 9; i++)
            {
                console.writeline(math.pow(n, i));
            }
        }

        //task5: count the sum of the even numbers that are less then given n natural number
        //(without checking if numbers are even or odd)
        /// <summary>
        /// gives the sum of the even numbers that are less then n.
        /// </summary>
        /// <param name="args"></param>
        static int thesumofevennumbers(int number)
        {
            int sum = 0;
            for (int i = 0; i <= number; i += 2)
            {
                sum += i;
            }
            return sum;
        }

        //task6: we have a and b integers where (a<b). print the 
        //numbers between a and b and also the count
        /// <summary>
        /// return the numbers from a to b ([a,b]) and the count.
        /// </summary>
        /// <param name="args"></param>
        static void thenumbersbetween(int a, int b)
        {
            int count = 0;
            for (int i = a; i <= b; i++)
            {
                count += 1;
                console.writeline(i);

            }
            console.writeline(count);
        }

        //task7:we have a and b ingtegers where (a<b). print the sum of [a,b] numbers
        /// <summary>
        /// print the sum of integers between given a and b numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static int printsumofnumbers(int a, int b)
        {
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i;
            }
            return sum;
        }

        //task8:we have a and b ingtegers where (a<b). find the first number 
        //between [a,b] which we can divide by 3
        /// <summary>
        /// find the first number which can be divided by 3
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int findthenumber(int a, int b)
        {
            while (a % 3 != 0 && a <= b)
            {
                ++a;
            }
            return a;
        }

        //task9://task9: given n real number. count 1 + 1/2 + 1/3 + … + 1/n (this is also real number)
        /// <summary>
        /// count 1 + 1/2 + 1/3 + … + 1/n for given number
        /// </summary>
        /// <param name="args"></param>
        static double countthesequence(double n)
        {
            double sum = 0;
            for (double i = 1; i <= n; i++)
            {
                sum += 1.0 / i;
            }
            return sum;
        }

        //task10: given n real number. count the sum of n2 + (n + 1)2 + (n + 2)2 + … + (2·n)2
        /// <summary>
        /// count n2 + (n + 1)2 + (n + 2)2 + … + (2·n)2 for given n number
        /// </summary>
        /// <param name="args"></param>
        static double countthesequence2(double n)
        {
            double sum = 0;
            for (double i = 0; i <= n; i++)
            {
                double current = math.pow(n + i, 2);
                sum += current;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            TASK 1
            int number = 1456;
            int sumOfDigits = SumOfDigits(number);
            Console.WriteLine(sumOfDigits);

            //TASK 2
            int n = Int32.Parse(Console.ReadLine());
            int k = Int32.Parse(Console.ReadLine());
            NtimesKnumber(n, k);

            //TASK 3
            PrintLessThenNnumbers(7);

            //TASK 4
            int n = Int32.Parse(Console.ReadLine());
            ThePowerOf(n);

            //TASK 5
            int number = Int32.Parse(Console.ReadLine());
            Console.WriteLine(TheSumOfEvenNumbers(number));

            //TASK 6 
            int A = Int32.Parse(Console.ReadLine());
            int B = Int32.Parse(Console.ReadLine());
            TheNumbersBetween(A, B);

            //TASK 7
            int A = Int32.Parse(Console.ReadLine());
            int B = Int32.Parse(Console.ReadLine());
            Console.WriteLine(PrintSumOfNumbers(A, B));

            //TASK 8
            int A = Int32.Parse(Console.ReadLine());
            int B = Int32.Parse(Console.ReadLine());
            Console.WriteLine(FindTheNumber(A, B));

            //TASK 9
            double n = Double.Parse(Console.ReadLine());
            Console.WriteLine(CountTheSequence(n));

            //TASK 10
            double n = Double.Parse(Console.ReadLine());
            Console.WriteLine(CountTheSequence2(n));

        }
    }
}
