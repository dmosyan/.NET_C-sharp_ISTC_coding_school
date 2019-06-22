using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASK21: Print all numbers that given number can be divided
            int n = Int32.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //TASK22: Count the some of all numbers that given number can be divided
            int n = Int32.Parse(Console.ReadLine()), sum = 0;

            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);

            //TASK23: Count the division of all numbers that given number can be divided and 
            // the count of that numbers.
            int n = Int32.Parse(Console.ReadLine());
            double sum = 0, count = 1;

            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                    count += 1;
                }
            }
            double division = sum / count;
            Console.WriteLine(division);

            //TASK24: Find out if the given number is any degree of 3 or no.
            int n = Int32.Parse(Console.ReadLine());
            int num1 = 3;

            for (int i = 3; i <= n; i *= 3)
            {
                num1 = i;
            }
            Console.WriteLine(num1 == n);

            //TASK25: Find the first number which is less then given n number and is any degree of 2.
            int n = Int32.Parse(Console.ReadLine());
            int num1 = 2;
            for (int i = 2; i <= n; i *= 2)
            {
                num1 = i;
            }
            Console.WriteLine(num1);


            //TASK26: Find the first number which is larger then given n number and is any degree of 2.
            int n = Int32.Parse(Console.ReadLine());
            int num1 = 2;
            for (int i = 2; i <= n; i *= 2)
            {
                num1 = i;
            }
            Console.WriteLine(num1 * 2);

            //TASK27: Take number from console, revers it and put 0 in the middle of any digit
            // example: 124 becoms 402010
            int number = Int32.Parse(Console.ReadLine());
            string reverseNumber = "";

            while (number > 0)
            {
                int digit = number % 10;
                reverseNumber = reverseNumber + digit + "0";
                number /= 10;
            }
            Console.WriteLine(reverseNumber);

            //TASK28: Take number from console. Print "YES" if it's equal to the sum of their digits
            //multiplied by 2.
            int number = Int32.Parse(Console.ReadLine());
            int sumOfDigits = 0;

            while (number > 0)
            {
                int digit = number % 10;
                sumOfDigits += digit;
                number /= 10;
            }
            if (sumOfDigits * 2 == number)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            //TASK29: Delete first igit of the given 3 digit number, if after that we can 
            //multiply and get the same number. Find this kind of numbers.

            for (int i = 110; i < 1000; i++)
            {
                int firstDigit = i / 100;
                if ((i - firstDigit * 100) * 7 == i)
                {
                    Console.WriteLine(i);
                }
            }

            //TASK30: Find 4 digits number, where every digit is unique and the sum of the first 
            // third and forth digits is equal to 


            for (int i = 1000; i <= 9999; i++)
            {
                int forthDigit = i % 10, thirdDigit = (i / 10) % 10,
                secondDigit = (i / 100) % 10, firstDigit = i / 1000;
                if (firstDigit!=secondDigit && thirdDigit!= secondDigit && thirdDigit != forthDigit &&
                    firstDigit!= forthDigit)
                {
                    if  (firstDigit * 10 + secondDigit - (thirdDigit * 10 + forthDigit) == 
                            firstDigit + secondDigit + thirdDigit + forthDigit)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
