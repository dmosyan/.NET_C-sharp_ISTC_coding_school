using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_Inheritance
{
    class Man : Omnivore
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialization { get; set; }

        public Man(string firstName, string lastName, string specialization, int NumberTeeth,
            bool Hair, string gender, int age)
            : base(NumberTeeth, Hair, gender, age)
        {
            FirstName = firstName;
            LastName = lastName;
            Specialization = specialization;
        }

        public string GetFullInfo()
        {
            return "first name is : " + FirstName + "\n"
                   + "last name is : " + LastName + "\n"
                   + "specialization is : " + Specialization;
        }
    }
}
