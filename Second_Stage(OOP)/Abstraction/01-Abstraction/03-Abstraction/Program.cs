using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Abstraction
{
    public abstract class AbstractClassA
    {
        public abstract void OperationA();
    }
    public abstract class AbstractClassB : AbstractClassA
    {
        public abstract void OperationB();
    }
    public class Concrete : AbstractClassA
    {
        public override void OperationA()
        {
            Console.WriteLine("AbstractClassA's Method Implementation");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            AbstractClassA instance = new Concrete();
            instance.OperationA();
            //we cannot call instance.OperationB() Method
            Console.ReadKey();
        }
    }
}
