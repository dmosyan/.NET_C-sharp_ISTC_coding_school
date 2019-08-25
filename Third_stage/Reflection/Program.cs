using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection
{
    //class MyClass { }

    static class Program
    {
        //General information about MyClass
        static void GeneralInfo(Employee employee)
        {
            Console.WriteLine("Information about Employee Class \n");
            Type type = employee.GetType();
            Console.WriteLine($"Full name: {type.FullName}");
            Console.WriteLine($"Base type: {type.BaseType}");
            Console.WriteLine($"Is abstract class: {type.IsAbstract}");
            Console.WriteLine($"Namespace: {type.Namespace}");
            Console.WriteLine($"Is sealed: {type.IsSealed}");
        }

        //Get all methods
        static void AllMethods(Employee employee)
        {
            Console.WriteLine(new string('-', 15));
            Type type = employee.GetType();
            MethodInfo[] methodinfo = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance
                | BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);

            foreach (MethodInfo item in methodinfo)
            {
                Console.WriteLine($"Methods: {item.Name}");
            }
        }

        //Get all Field info
        static void AllFields(Employee employee)
        {
            Console.WriteLine(new string('-', 15));
            Type type = employee.GetType();
            FieldInfo[] fieldInfos = type.GetFields(BindingFlags.Instance | BindingFlags.Static
                | BindingFlags.Public | BindingFlags.NonPublic);

            foreach (FieldInfo item in fieldInfos)
            {
                Console.WriteLine($"Field: {item.Name}");
            }
        }

        //Get all Properties
        static void AllProperties(Employee employee)
        {
            Console.WriteLine(new string('-', 15));
            Type type = employee.GetType();
            PropertyInfo[] propertyInfos = type.GetProperties();

            foreach (PropertyInfo item in propertyInfos)
            {
                Console.WriteLine($"Property name: {item.Name}");
            }
        }

        //Get all Interfaces
        static void AllInterfaces(Employee employee)
        {
            Console.WriteLine(new string('-', 15));
            Type type = employee.GetType();
            Type[] interfaces = type.GetInterfaces();

            foreach (Type item in interfaces)
            {
                Console.WriteLine($"Interface: {item.Name}");
            }
        }

        //Get all Constructors
        static void AllConstructors(Employee employee)
        {
            Console.WriteLine(new string('-', 15));
            Type type = employee.GetType();
            ConstructorInfo[] constructorInfos = type.GetConstructors();

            foreach (ConstructorInfo item in constructorInfos)
            {
                Console.WriteLine($"Constructor: {item.Name}");
            }
        }

        static void Main(string[] args)
        {
            Employee instance = new Employee();

            GeneralInfo(instance);
            AllMethods(instance);
            AllFields(instance);
            AllProperties(instance);
            AllInterfaces(instance);
            AllConstructors(instance);

            //MyClass my = new MyClass();
            //Type type;

            //// First option
            //type = my.GetType();
            //Console.WriteLine("1st option + " + type);

            ////Second Option
            //type = Type.GetType("Reflection.MyClass");
            //Console.WriteLine("2nd option + " + type);

            ////Third option
            //type = typeof(MyClass);
            //Console.WriteLine("3rd option + " + type);
        }
    }
}
