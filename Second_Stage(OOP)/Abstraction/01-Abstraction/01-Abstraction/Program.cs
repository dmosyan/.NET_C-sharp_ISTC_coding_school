using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Abstraction
{
    public abstract class AbstractClass
    {
        public abstract void Method();
        //abstract method is th same as Virtual method
    }

    public class ConcreteClass : AbstractClass
    {
        public override void Method()
        {
            Console.WriteLine("Implementation");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass instance = new ConcreteClass();
            instance.Method();
            Console.ReadKey();
        }
    }
}
