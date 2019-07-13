using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_Inheritance
{
    class Carnivore : Animal
    {
        public bool Hair { get; set; }
        public int NumberTeeth { get; set; }

        public Carnivore(int NumberTeeth, bool Hair, string gender, int age) 
            :base(gender, age, "Carnivore")
        {
            this.NumberTeeth = NumberTeeth;
            this.Hair = Hair;
        }
        public override bool Eat(string plant)
        {
            return false;
        }
    }
}
