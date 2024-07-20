using ReflectionDemo.Models;
using System.Reflection;

namespace ReflectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(101, "Allen", 10000);
            Account account2 = new Account(102, "Mary");

            Assembly executing = Assembly.GetExecutingAssembly();

            Type[] types = executing.GetTypes();
            foreach (var item in types)
            {
                // Display each type 
                Console.WriteLine($"Class : {item.Name}\n");
                int methodCount = 0;
                // Array to store methods 
                MethodInfo[] methods = item.GetMethods();
                foreach (var method in methods)
                {
                    // Display each method 
                    Console.WriteLine($"--> Method : {method.Name}");
                    methodCount++;
                }
                Console.WriteLine("\nNumber Of Methods: "+methodCount+"\n");
                int propertyCount = 0;
                // Array to store properties 
                PropertyInfo[] properties = item.GetProperties();
                foreach (var property in properties)
                {
                    // Display each property 
                    Console.WriteLine($"--> Property : {property.Name}");
                    propertyCount++;
                }
                Console.WriteLine("\nNumber Of Properties: " + propertyCount+"\n\n");


                int constructorCount = 0;
                // Array to store constructors
                ConstructorInfo[] constructors = item.GetConstructors();
                foreach (var constructor in constructors)
                {
                    // Display each constructor
                    Console.WriteLine($"--> Constructor : {constructor.Name}");
                    constructorCount++;
                }
                Console.WriteLine("\nNumber Of Constructors: " + constructorCount + "\n\n");
            }
        }
    }
}
/*Reflection is the process of describing the metadata of types, methods and fields in a code. 
 * The namespace System.Reflection enables you to obtain data about the loaded assemblies, the 
 * elements within them like classes, methods and value types. */
