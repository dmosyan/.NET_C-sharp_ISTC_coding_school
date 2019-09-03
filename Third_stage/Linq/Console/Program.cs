using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqLibrary;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = LoadingData.LoadData();
            foreach (var person in people)
            {
                System.Console.WriteLine($"{person.FirstName} {person.LastName} ({person.Birthday.ToShortDateString()}): Experienc {person.YearsExperience}");
            }
            System.Console.ReadLine();

            /*Tim Corey (2/25/1970): Experienc 14
              Joe Smith (2/28/1982): Experienc 3
              Sue Storm (4/11/1995): Experienc 6
              Sara Jones (7/6/1963): Experienc 11
              Jamie Doe (3/30/1991): Experienc 18
              Mary Smith (11/7/1989): Experienc 9
              Ana Traversy (10/9/1990): Experienc 7 */
            #region
            //OrderBy Names
            List<Person> OrderedByNames = people.OrderBy(x => x.LastName).ToList();

            foreach (var person in OrderedByNames)
            {
                System.Console.WriteLine($"{person.FirstName} {person.LastName} ({person.Birthday.ToShortDateString()}): Experienc {person.YearsExperience}");
            }
            System.Console.ReadLine();

            /*Tim Corey(2 / 25 / 1970): Experienc 14
              Jamie Doe(3 / 30 / 1991): Experienc 18
              Sara Jones(7 / 6 / 1963): Experienc 11
              Joe Smith(2 / 28 / 1982): Experienc 3
              Mary Smith(11 / 7 / 1989): Experienc 9
              Sue Storm(4 / 11 / 1995): Experienc 6
              Ana Traversy(10 / 9 / 1990): Experienc 7 */
            

            List<Person> OrderedByNamesDesc = people.OrderByDescending(x => x.LastName).ToList(); //Descending order

            foreach (var person in OrderedByNamesDesc)
            {
                System.Console.WriteLine($"{person.FirstName} {person.LastName} ({person.Birthday.ToShortDateString()}): Experienc {person.YearsExperience}");
            }
            System.Console.ReadLine();
            #endregion

            //Ordering using 2 fields.
            List<Person> OrderingNamesAndExperience = people.OrderByDescending(x => x.LastName).ThenByDescending(x => x.YearsExperience).ToList();
            foreach (var person in OrderingNamesAndExperience)
            {
                System.Console.WriteLine($"{person.FirstName} {person.LastName} ({person.Birthday.ToShortDateString()}): Experienc {person.YearsExperience}");
            }
            System.Console.ReadLine();

            //Using WHERE
            List<Person> filtered = people.Where(x => x.YearsExperience > 9 && x.Birthday.Month == 2).ToList();
            foreach (var person in filtered)
            {
                System.Console.WriteLine($"{person.FirstName} {person.LastName} ({person.Birthday.ToShortDateString()}): Experienc {person.YearsExperience}");
            }
            System.Console.ReadLine();
            //Tim Corey (2/25/1970): Experienc 1

            int yearsExperienceTotal = people.Sum(x => x.YearsExperience);
            System.Console.WriteLine(yearsExperienceTotal); //68


        }
    }
}
