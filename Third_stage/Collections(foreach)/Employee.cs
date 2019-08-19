using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Employee
    {
        private string firstName;
        private string lastName;
        private string department;
        private int age;

        public Employee(string firstName, string lastName, string department, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.department = department;
            this.age = age;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
