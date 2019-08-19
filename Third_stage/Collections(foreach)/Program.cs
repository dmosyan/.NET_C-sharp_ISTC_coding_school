using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee_collection collection = new Employee_collection();

            Console.WriteLine("Employee information");
            foreach (Employee item in collection)
            {
                Console.WriteLine($"Name: {item.FirstName}, LastName: {item.LastName}, Department: {item.Department}" +
                    $"Age: {item.Age}");
            }

            Console.WriteLine(new string('-', 20));
            //The same without Foreach
            Console.WriteLine("The same without foreach");
            Employee_collection collectionElements = new Employee_collection();
            IEnumerable enumerable = collectionElements as IEnumerable;
            IEnumerator enumerator = enumerable.GetEnumerator();

            while(enumerator.MoveNext())
            {
                Employee item = enumerator.Current as Employee;
                Console.WriteLine($"Name: {item.FirstName}, LastName: {item.LastName}, Department: {item.Department}" +
                    $"Age: {item.Age}");
            }
            enumerator.Reset();

            Console.WriteLine();
        }
    }
}
