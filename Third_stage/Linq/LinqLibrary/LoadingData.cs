using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibrary
{
    public class LoadingData
    {
        public static List<Person> LoadData()
        {
            List<Person> data = new List<Person>();
            data.Add(new Person { FirstName = "Tim", LastName = "Corey", Birthday = Convert.ToDateTime("2/25/1970"), YearsExperience = 14 });
            data.Add(new Person { FirstName = "Joe", LastName = "Smith", Birthday = Convert.ToDateTime("2/28/1982"), YearsExperience = 3 });
            data.Add(new Person { FirstName = "Sue", LastName = "Storm", Birthday = Convert.ToDateTime("4/11/1995"), YearsExperience = 6 });
            data.Add(new Person { FirstName = "Sara", LastName = "Jones", Birthday = Convert.ToDateTime("7/6/1963"), YearsExperience = 11 });
            data.Add(new Person { FirstName = "Jamie", LastName = "Doe", Birthday = Convert.ToDateTime("3/30/1991"), YearsExperience = 18 });
            data.Add(new Person { FirstName = "Mary", LastName = "Smith", Birthday = Convert.ToDateTime("11/7/1989"), YearsExperience = 9 });
            data.Add(new Person { FirstName = "Ana", LastName = "Traversy", Birthday = Convert.ToDateTime("10/9/1990"), YearsExperience = 7 });

            return data;
        }
    }
}
