using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            // TASK 1 
            int firstNumber, secondNumber;
            firstNumber = Convert.ToInt32(Console.ReadLine());
            secondNumber = Convert.ToInt32(Console.ReadLine());

            //Counting sqrt of firstNumber
            Console.WriteLine("The square root of the first number is: " + Math.Sqrt(firstNumber));

            //Counting absolute value of their subtraction
            Console.WriteLine("Absolute value of their difference is: " + Math.Abs(firstNumber - secondNumber));

            //Biggest number to the power of 3
            Console.WriteLine(Math.Pow(Math.Max(firstNumber, secondNumber), 3));

            //Checking if the postfix value of the firstNumber equals to prefix value of the secondNumber
            Console.WriteLine(firstNumber++ == ++secondNumber);

            //TASK 2
            int number = Convert.ToInt32(Console.ReadLine());
            // Count the absolute value, square root and sum of number and his half to the power of 3

            Console.WriteLine(Math.Abs(number));
            Console.WriteLine(Math.Sqrt(number));
            Console.WriteLine(Math.Pow(number, 3) + Math.Pow(number/2 , 3));

        }
    }
}
