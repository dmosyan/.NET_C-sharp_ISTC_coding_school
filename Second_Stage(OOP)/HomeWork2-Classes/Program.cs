using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Human
    {
        private string firstName;
        private string lastName;
        private int age;
        private int weight;
        private string gender;

        public void PrintInfo()
        {
            Console.WriteLine("The all info is :" +
                "first name is: {0}," +
                "last name is: {1}," +
                "the age is: {2}," +
                "the weight is: {3} kg," +
                "the gender is: {4},", firstName, lastName, age, weight, gender);
        }

        public void PrintName()
        {
            Console.WriteLine("The name is: {0}", firstName);
        }

        public void PrintlastName()
        {
            Console.WriteLine("The last name is: {0}", lastName);
        }

        public void PrintAge()
        {
            Console.WriteLine("The age is: {0}", age);
        }

        public void PrintWeight()
        {
            Console.WriteLine("The weight is: {0}", weight);
        }

        public void PrintGender()
        {
            Console.WriteLine("The gender is: {0}", gender);
        }

        public void ChangeTheFirstName(string firstName)
        {
            this.firstName = firstName;
        }
        public void ChangeTheLastName(string lastName)
        {
            this.lastName = lastName;
        }
        public void ChangeTheAge(int age)
        {
            this.age = age;
        }
        public void ChangeTheWeight(int weight)
        {
            this.weight = weight;
        }
        public void ChangeTheGender(string gender)
        {
            this.gender = gender;
        }

        public Human(string firstName, string lastName, int age, int weight, string gender)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.weight = weight;
            this.gender = gender;
        }

    }



    class Program
    {
        static void Main(string[] args)
        {

            Human person1 = new Human("John", "Smith", 35, 75, "Male");
            Human person2 = new Human("Lara", "Johnson", 30, 65, "Female");

            person1.PrintInfo();
            person1.PrintName();
            person2.PrintWeight();

            person1.ChangeTheFirstName("Bob");
            person1.PrintInfo();
             
        }
    }
}
