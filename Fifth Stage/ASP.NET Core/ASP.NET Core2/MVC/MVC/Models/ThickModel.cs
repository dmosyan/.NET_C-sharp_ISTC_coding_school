using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class ThickModel
    {
        public string Company { get; set; }
        public int Employees { get; set; }
        public int Salary { get; set; }

        public ThickModel(string company, int employees, int salary)
        {
            Company = company;
            Employees = employees;
            Salary = salary;
        }

        public int TotalSalary()
        {
            return Employees * Salary;
        }
    }
}
