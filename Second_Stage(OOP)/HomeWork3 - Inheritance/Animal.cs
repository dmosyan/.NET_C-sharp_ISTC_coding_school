using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_Inheritance
{
    class Animal
    {
        private string gender;
        public int Age { get; set; }
        public string AnimalClass { get; protected set; }

        public Animal(string gender, int age, string animalClass)
        {
            Gender = gender;
            this.Age = age;
            this.AnimalClass = animalClass;
        }
  
        public string Gender
        {
            get { return gender; }
            set
            {
                if(value == "Male" || value == "Female")
                {
                    gender = value;
                } else
                {
                    gender = "No information";
                }
            }
        }

        public virtual bool Eat(string plant)
        {
            return true;
        }
        
        public bool Move()
        {
            return true;
        }

    }
}
