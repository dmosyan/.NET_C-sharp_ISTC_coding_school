using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_Inheritance
{
    class Lion : Carnivore
    {
        public int Weight { get; set; }

        public Lion(int weight, int NumberTeeth, bool Hair, string gender, int age)
            : base(NumberTeeth, Hair, gender, age)
        {
            Weight = weight;
        }

        public override bool Eat(string plant)
        {
            return false;
        }
    }
}
