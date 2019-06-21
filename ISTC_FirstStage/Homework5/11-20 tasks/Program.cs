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
            // task 11: given n natural number. count 1.1 · 1.2 · 1.3 · … (till n).
            int n = int32.parse(console.readline());
            double multiply = 1;

            for (double i = 1.1; n >= 1; i += 0.1)
            {
                multiply *= i;
                n--;
            }
            console.writeline(multiply);

            //task 12: given n natural number. count 1.1 – 1.2 + 1.3 – … (till n).
            int n = int32.parse(console.readline());
            int n1 = n;
            int n2 = n;
            double sum1 = 0;
            double sum2 = 0;

            for (double i = 1.1; n1 >= 1; i += 0.2)
            {
                sum1 += i;
                n1--;

            }

            for (double j = 1.2; n2 >= 1; j += 0.2)
            {
                sum2 += j;
                n2--;

            }
            //console.writeline(sum1);
            //console.writeline(-1.0 * (sum2));
            console.writeline((-1.0 * (sum2)) + sum1);

            //task 13: we have n number. count the n square usin this formula: n^2 = 1 + 3 + 5 + … + (2*n – 1). before adding 
            // the next number print current value.
            int n = int32.parse(console.readline());
            int lastnumber = 2 * n - 1;
            int sum = 0;

            for (int i = 1; i <= lastnumber; i += 2)
            {
                console.writeline(sum);
                sum += i;

            }
            console.writeline(sum);

            //task 14: given n number. print "yes" if n is equal to the sum of its' digits.
            int n = int32.parse(console.readline());
            int sum = 0;

            for (int i = n % 10; i != 0; i = n / 10)
            {
                sum += i;
                if (sum == n)
                {
                    console.writeline("yes");
                }
                else
                {
                    console.writeline("no");
                    break;
                }
            }

            //task 15: delete the first digit of given 3 digit number. if we multiply with 7 we should get 
            // initial number

            for (int i = 100; i <= 999; i++)
            {
                int number = i % 100 * 7;
                if (number == i)
                {
                    console.writeline(number);
                }
            }

            //task 16: count the sum of the digits, count and multiplication of given number.
            int n = int32.parse(console.readline());
            int count = 0;
            int sum = 0;
            int mult = 1, thelastdigit;


            while (n > 0)
            {
                thelastdigit = n % 10;
                sum += thelastdigit;
                mult *= thelastdigit;
                n /= 10;
                count += 1;
            }
            console.writeline("the sum is {0}, the count is {1} and the multiplication is {2}", sum, count, mult);


            //task 17: find the smallest odd digit in given number
            int number = int32.parse(console.readline());
            int num1 = 9;
            int num2 = 9;

            while (number > 0)
            {
                num2 = number % 10;
                if (num2 % 2 != 0)
                {
                    if (num2 < num1)
                    {
                        num1 = num2;
                    }
                }
                number /= 10;
            }
            console.writeline(num1);

            //task 18: count the sum of odd digits if they are bigger then 4 (given n number)
            int number = int32.parse(console.readline());
            int num1 = 9;
            int sum = 0;

            while (number > 0)
            {
                num1 = number % 10;
                if (num1 % 2 != 0)
                {
                    if (num1 > 4)
                    {
                        sum += num1;
                    }

                }
                number /= 10;
            }
            console.writeline(sum);

            //task19: count mulitplication of the even digits if they are less then 7 (given n number)
            int number = int32.parse(console.readline());
            int mult = 1;
            int num1 = 8;

            while (number > 0)
            {
                num1 = number % 10;
                if (num1 % 2 == 0 && num1 < 7)
                {
                    mult *= num1;

                }
                number /= 10;
            }
            console.writeline(mult);

            //TASK20: Count the square of the difference biggest and smallest digits in given n number
            int number = Int32.Parse(Console.ReadLine());
            int x = 0;
            int y = 9;
            int digit = 0;

            while (number > 0)
            {
                digit = number % 10;
                if (digit > x)
                {
                    x = digit;
                }
                if (digit < y)
                {
                    y = digit;
                }
                number /= 10;
            }
            Console.WriteLine("smallest digit is : {0}. Largest digit is: {1}", y, x);
            double difference = (x - y);
            Console.WriteLine(difference*difference);
        }

    }
    
    
}
