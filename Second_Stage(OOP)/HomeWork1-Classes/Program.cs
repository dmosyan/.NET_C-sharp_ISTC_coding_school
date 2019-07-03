using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{

    class Animal
    {
        public string type;
        public int foot;
        public int age;
        public string color;
        
        public void Walk()
        {
            Console.WriteLine("Animal walks");
        }

        public void Breath()
        {
            Console.WriteLine("Animal Breath");
        }

        public Animal(int age, string type)
        {
            this.type = type;
            this.age = age;
        }

        public Animal()
        {
            foot = 4;
            color = "Black";
        }

        public Animal(string _type, int foot, int age, string color)
        {
            type = _type;
            this.foot =foot;
            this.age = age;
            this.color = color;
        }

        public void Constructor(string type, int foot, int age)
        {
            this.type = type;
            this.foot = foot;
            this.age = age;
        }
    }

    


    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal(15, "Dog");

            Console.WriteLine($"Animal type - {animal.type}, Animal age - {animal.age}");

            animal.Walk();
            animal.Breath();
            Animal animal1 = new Animal();
            Console.WriteLine($"Animal foot count - {animal1.foot}, Animal color - {animal1.color}");

            Animal animal2 = new Animal("Cat", 4, 7, "Gray");
            Console.WriteLine(animal2.type+" " + animal2.foot + " " + animal2.color + " " + animal2.age);

            
        }
    }
}
