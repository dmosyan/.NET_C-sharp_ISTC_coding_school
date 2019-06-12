using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Task 1: Calculate the average number of 3 digit number ///
            
            Console.WriteLine("Please entery any 3 digit number"); //ex. 345
            int number = Convert.ToInt32(Console.ReadLine());

            int thirdNumber = number % 10; // we should get: 5
            int newNumber1 = number / 10; //we should get: 34
            int secondNumber = newNumber1 % 10; //we should get: 4
            int firstNumber = number / 100; //we should get: 3

            int mean = (firstNumber + secondNumber + thirdNumber) / 3;
            Console.WriteLine("Here is the avarage number of digits:");
            Console.WriteLine(number);

            //////////////////////////////////////////////////////////////


            /// Task 2: Take 5 negative numbers and calculate absolute value of their multiplication ///
            Console.WriteLine("Please enter 5 negative numbers");

            int firstDigit = Convert.ToInt32(Console.ReadLine());
            int secondDigit = Convert.ToInt32(Console.ReadLine());
            int thirdDigit = Convert.ToInt32(Console.ReadLine());
            int forthDigit = Convert.ToInt32(Console.ReadLine());
            int fifthDigit = Convert.ToInt32(Console.ReadLine());

            int absValue = Math.Abs(firstDigit * secondDigit * thirdDigit * forthDigit * fifthDigit);
            Console.WriteLine("The multiplied absolute value is: ");
            Console.WriteLine(absValue);

            /////////////////////////////////////////////////////////////////////////////////////////

            /// Task 3: Calculate the income for 1.3% month percentage yield for 3 years ///

            Console.WriteLine("Please enter amount:");
            int amount = Convert.ToInt32(Console.ReadLine());
            float percentage = 1.3f;

            float finalAmount = amount * percentage / 100 * 36;
            Console.WriteLine(finalAmount);
            
            /////////////////////////////////////////////////////////////////////////////////

        }
    }
}
