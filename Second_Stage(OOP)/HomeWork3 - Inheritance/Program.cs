using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("Male", 74, "Carnovore");
            Console.WriteLine(animal.Eat("Plant"));

            Herbivore Horse = new Herbivore(47, "Female", 14);
            Console.WriteLine(Horse.NumberTeeth);

            Lion Simba = new Lion(47, 14, true, "Male", 2);
            Console.WriteLine(Simba.Eat("plant"));

            //Will continue in this file...

        }
    }
}
