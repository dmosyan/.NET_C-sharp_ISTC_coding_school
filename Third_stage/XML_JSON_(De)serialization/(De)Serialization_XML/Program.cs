using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;


namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee("Bob", "Johnson", "Marketing", 123456),
                new Employee("Tom", "Smith", "Accounting", 654321),
                new Employee("John", "Brown", "Development", 123654)
            };
            using (Stream xml = new FileStream(@"C:\Users\David\Desktop\Inheritance\Third_stage\XML_JSON_(De)serialization\Serialization\employee.xml",
                FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Employee>));
                serializer.Serialize(xml, employees);
            }
            employees = null;

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Employee>));
            using (FileStream xml2 = File.OpenRead(@"C:\Users\David\Desktop\Inheritance\Third_stage\XML_JSON_(De)serialization\Serialization\employee.xml"))
            {
                employees = (List<Employee>)xmlSerializer.Deserialize(xml2);
            }

            foreach(Employee person in employees)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}

