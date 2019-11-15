using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            PlainModel model = new PlainModel()
            {
                Company = "Microsoft",
                Employees = 100000,
                Salary = 10000
            };


            int totalSalary = model.Employees * model.Salary;
            string company = $"Company: {model.Company}\n";
            string employees = $"Employees: {model.Employees}\n";
            string salary = $"Total salary: {totalSalary}\n";
            return company + employees + salary;
        }

    }
}
