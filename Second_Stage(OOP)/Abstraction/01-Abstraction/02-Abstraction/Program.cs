using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Abstraction
{
    public class ClassA
    {
        public void Operation()
        {
            Console.WriteLine("Method from ClassA");
        }
    }

    public abstract class AbstractClass : ClassA
    {
        public abstract void Method();
    }

    public class ClassB : AbstractClass
    {
        public override void Method()
        {
            Console.WriteLine("Implementing abstract class method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass instance = new ClassB();
            instance.Method();
            instance.Operation();
            Console.ReadKey();

        }
    }
}
