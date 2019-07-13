using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_Inheritance
{
    class Rabbit : Herbivore
    {
        public bool fur = true;

        public Rabbit(bool fur, int NumberTeeth, string Gender, int age) 
            : base(NumberTeeth, Gender, age)
        {

        }
        public override bool Eat(string plant)
        {
            return true;
        }


    }
}
