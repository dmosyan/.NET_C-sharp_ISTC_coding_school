using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_Inheritance
{
    class Hyena : Carnivore
    {
        public string family = "Hyaenidae";
        public string location = "Africa";

        public Hyena(string family, string location, int NumberTeeth, bool Hair, string gender, int age) 
            : base(NumberTeeth, Hair, gender, age)
        {

        }

        public override bool Eat(string plant)
        {
            return false;
        }

    }
}
