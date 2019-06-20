using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASK1: Count the sum of the digits of the given 4 digit number
            int number = Int32.Parse(Console.ReadLine());
            int sum = 0, theLastDigit;
            while (number > 0)
            {
                theLastDigit = number % 10;
                sum += theLastDigit;
                number /= 10;
            }
            Console.WriteLine(sum);

            //TASK2: We have K and N (N>0) numbers. N times print K number
            int K = Int32.Parse(Console.ReadLine());
            uint N = UInt32.Parse(Console.ReadLine());
            while (N > 0)
            {
                Console.WriteLine(K);
                --N;
            }

            //TASK3: WE have n 1 digit number. Print all numbers that are less then n.
            Console.WriteLine("Please enter the number between 0 and 9");
            uint n = UInt32.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine("There is no number>0 that is less than 0");
            }

            while (n > 0)
            {
                Console.WriteLine(n--);
            }
            Console.WriteLine(0);

            //TASK4: Take number n from console and print starting n to the power of 1 till to the power of 9
            int K = Int32.Parse(Console.ReadLine());

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(Math.Pow(K, i));
            }

            //TASK5: Count the sum of the even numbers that are less then given n natural number(without checking if numbers are even or odd)
            uint n = UInt32.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 2; i <= n; i += 2)
            {
                sum += i;
            }
            Console.WriteLine(sum);

            //TASK6: We have A and B integers where (A<B). Print the numbers between A and B and also the count
            int A = Int32.Parse(Console.ReadLine());
            int B = Int32.Parse(Console.ReadLine());
            if (A >= B)
            {
                Console.WriteLine("Plase enter numbers where first number is less then the second one");
            }

            int difference = B - A - 1;
            int count = B - A + 1;
            while (difference >= 0)
            {
                Console.WriteLine(A++);

                difference--;
            }
            Console.WriteLine(B);
            Console.WriteLine("Number of printed integers is: " + count);

            //TASK7: WE have A and B ingtegers where (A<B). Print the sum of [A,B] numbers
            int A = Int32.Parse(Console.ReadLine());
            int B = Int32.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = A; i <= B; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);

            //TASK 8: WE have A and B ingtegers where (A<B). Find the first number between [A,b] which we can divide by 3
            int A = Int32.Parse(Console.ReadLine());
            int B = Int32.Parse(Console.ReadLine());
            int difference = B - A;

            if (difference == 1 && A % 3 != 0 && B % 3 != 0)
            {
                Console.WriteLine("There is no number in this area that we can divide by 3");
            }


            while (A % 3 != 0 && A <= B)
            {
                ++A;
            }
            Console.WriteLine(A);

            //TASK9: Given n real number. Count 1 + 1/2 + 1/3 + … + 1/N (this is also real number)
            double sum = 1;
            int n = int.Parse(Console.ReadLine());
            for (double i = 2; i <= n; i++)
            {
                double current = 1.0 / i;
                sum += current;
            }

            Console.WriteLine(sum);
            Console.WriteLine(Math.Round(sum, 0));

            //TASK 10: Given n real number. Count the sum of N2 + (N + 1)2 + (N + 2)2 + … + (2·N)2
            int n = Int32.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i <= n; i++)
            {
                int current = (n + i) * 2;
                sum += current; 
            }
            Console.WriteLine(sum);
        }
    }
}
