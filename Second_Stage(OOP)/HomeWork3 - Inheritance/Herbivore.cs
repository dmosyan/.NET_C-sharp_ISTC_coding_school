using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_Inheritance
{
    class Herbivore : Animal
    {
        public int NumberTeeth { get; set; }

        public Herbivore(int NumberTeeth, string gender, int age) 
            :base(gender, age, "Herbivore")
        {
            this.NumberTeeth = NumberTeeth;
        }
        public override bool Eat(string plant)
        {
            return true;
        }
    }
}
