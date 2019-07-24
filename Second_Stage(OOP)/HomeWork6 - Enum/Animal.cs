using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    class Animal
    {
        protected string name;
        protected int maxAge;
        protected float happiness;

        public Animal(string name, int maxAge, float happiness)
        {
            this.name = name;
            this.maxAge = maxAge;
            this.happiness = happiness;
        }
    }
}
