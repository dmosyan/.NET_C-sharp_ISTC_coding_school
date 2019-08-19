using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Serialization
{
    [Serializable()]
    public class Employee : ISerializable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public static int EmployeeID { get; set; }

        public Employee() { }
        
        public Employee(string firstName, string lastName, string department, int employeeID)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
            EmployeeID = employeeID;
        }

        public override string ToString()
        {
            return string.Format($"firstName: {FirstName}, lastName: {LastName}, department: {Department}" +
                $"ID: {EmployeeID}");
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("firstName", FirstName);
            info.AddValue("lastName", LastName);
            info.AddValue("department", Department);
            info.AddValue("ID", EmployeeID);
        }

        public Employee(SerializationInfo info, StreamingContext context)
        {
            FirstName = (string)info.GetValue("firstName", typeof(string));
            LastName = (string)info.GetValue("lastName", typeof(string));
            Department = (string)info.GetValue("department", typeof(string));
            EmployeeID = (int)info.GetValue("ID", typeof(int));

        }
    }
}
