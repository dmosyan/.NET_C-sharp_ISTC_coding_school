using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Changing the first letter case
            string input = Console.ReadLine();
            string newInput = input.FirstLetterCase();
            Console.WriteLine(newInput);

            //Checking the polindrome
            string input2 = Console.ReadLine();
            Console.WriteLine(input2.CheckIfPolindrome());

            //Counts the duplicate of an array
            int numberOfInts;
            Console.Write("Input the number of elements to be stored in the array :");

            numberOfInts = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[numberOfInts];

            for (int i = 0; i < numberOfInts; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(array.CountDuplicate());
            

        }
    }
}
