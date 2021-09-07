using System;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * - Create an instant of class Student and an instant of class Employee with proper values for the attributes.
             * - Display the content of each class using Display() method.
             */
            Person sandis = new Person("Sandis", "Aizmirsu", "Valdlauči", 12200355);
            
            Student pēteris = new Student("Pēteris", "Briedis", "Rīga", 19303355, 4.5);
            
            Employee jānis = new Employee("Jānis", "Ozols", "Ikšķile", 12263364, "C# programmētājs");
            
            sandis.Display();
            pēteris.Display();
            jānis.Display();
            Console.ReadKey();
        }
    }
}