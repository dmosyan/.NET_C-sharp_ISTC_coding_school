using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog hulk = new Dog("Hulk", 20, 0.7f, Breed.Boxer);
            Dog charlie = new Dog("Charlie", 18, 0.6f, Breed.Akita);
            Dog Layma = new Dog("Layma", 19, 0.9f, Breed.Bulldog);

            charlie.PintInfo();
        }
    }
}
