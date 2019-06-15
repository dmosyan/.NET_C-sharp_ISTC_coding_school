using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASK 1: get 2 numbers and compair first number to the power of 2
            //        with the second number. Use if-else and switch-case
            int firstNumber = Int32.Parse(Console.ReadLine());
            int secondNumber = Int32.Parse(Console.ReadLine());
            double firstNumberSquere = Math.Pow(firstNumber, 2);

            if (firstNumberSquere > secondNumber)
            {
                Console.WriteLine("first number to the power of 2 is greater then the second number");
            }
            else if (firstNumberSquere < secondNumber)
            {
                Console.WriteLine("first number to the power of 2 is less then the second number");
            }
            else
            {
                Console.WriteLine("first number to the power of 2 is equal to the second number");
            }

            //SWITCH-CASE method
            int compare = firstNumberSquere > secondNumber ? 0 : (firstNumberSquere < secondNumber ? 1 : 2);

            switch (compare)
            {
                case 0:
                    Console.WriteLine("first number to the power of 2 is greater then the second number");
                    break;
                case 1:
                    Console.WriteLine("first number to the power of 2 is less then the second number");
                    break;
                case 2:
                    Console.WriteLine("first number to the power of 2 is equal to the second number");
                    break;
            }

            //TASK 2: get 4 numbers (X,Y,Z,K). Check if X^Y is equal to the Z^K
            int X = Int32.Parse(Console.ReadLine());
            int Y = Int32.Parse(Console.ReadLine());
            int Z = Int32.Parse(Console.ReadLine());
            int K = Int32.Parse(Console.ReadLine());

            double X_power_Y = Math.Pow(X, Y);
            double Z_power_K = Math.Pow(Z, K);

            double compare = X_power_Y == Z_power_K ? 0 : 1;
            switch (compare)
            {
                case 0:
                    Console.WriteLine("X^Y is equal to the Z^K");
                    break;
                case 1:
                    Console.WriteLine("X^Y is NOT equal to the Z^K");
                    break;
            }

            //TASK 3: Write a number from 1 to 8 and know solar system planets from smallest to largest
            //        8 -smallest one, 1-largest one

            Console.WriteLine("Please write a number between 1 and 8");

            int number = Int32.Parse(Console.ReadLine());

            
            switch (number)
            {
                case 1:
                    Console.WriteLine("Largest planet is Saturn - (diameter = 120,660 km)");
                    break;
                case 2:
                    Console.WriteLine("Second largest planet is Uranus - (diameter = 51,118 km)");
                    break;
                case 3:
                    Console.WriteLine("Third largest planet is Neptune - (diameter = 49,528 km)");
                    break;
                case 4:
                    Console.WriteLine("Forth largest planet is Earth - (diameter = 12,756 km)");
                    break;
                case 5:
                    Console.WriteLine("Fifth largest planet is Venus - (diameter = 12,104 km)");
                    break;
                case 6:
                    Console.WriteLine("Sixth largest planet is Mars - (diameter = 6787 km)");
                    break;
                case 7:
                    Console.WriteLine("Seventh largest planet is Mercury - (diameter = 4879.4 km)");
                    break;
                case 8:
                    Console.WriteLine("Smallest planet is Pluto (dwarf planet) - (diameter = 2300 km)");
                    break;
                default:
                    Console.WriteLine("Please entery a number between 1 and 8");
                    break;
            }

        



        }
    }
}
