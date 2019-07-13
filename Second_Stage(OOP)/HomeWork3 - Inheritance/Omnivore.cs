using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_Inheritance
{
    class Omnivore : Animal
    {
        public bool Hair { get; set; }
        protected int NumberTeeth { get; set; }

        public Omnivore(int NumberTeeth, bool Hair, string gender, int age)
            : base(gender, age, "Omnivore")
        {
            this.NumberTeeth = NumberTeeth;
            this.Hair = Hair;
        }

        public override bool Eat(string plant)
        {
            return true;
        }
    }
}
