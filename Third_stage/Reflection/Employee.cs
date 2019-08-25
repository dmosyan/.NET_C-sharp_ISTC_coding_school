using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class Employee : IInterface1, IInterface2
    {
        //Fields
        public int employeeId;
        private string companyName = "Microsoft";

        //Constructors
        public Employee() { }
        public Employee(int employeeId)
        {
            this.employeeId = employeeId;
        }

        //Properties
        public int idProperty
        {
            get { return employeeId; }
            set { employeeId = value; }
        }
        public string CompanyName
        {
            get { return companyName; }
        }

        //Methods from Interfaces
        public void Method1()
        {
            Console.WriteLine("IInterface1 method");
        }
        public void Method2()
        {
            Console.WriteLine("IInterface2 method");
        }

        private void Method3(string str1, string str2)
        {
            Console.WriteLine(str1 + str2);
        }

        public void classMethod(int integer1, int integer2) { }
    }
}
