using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    class Dog : Animal
    {
        public Breed breed;

        public Dog(string name, int maxAge, float happiness, Breed breed)
            :base(name, maxAge, happiness)
        {
           
            this.breed = breed;
        }

        public void PintInfo()
        {
            Console.WriteLine("Name" + name);
            Console.WriteLine("Age: " + maxAge);
            Console.WriteLine("Happiness: " + happiness);
            Console.WriteLine("Breed: " + breed);
        }

    }
}
