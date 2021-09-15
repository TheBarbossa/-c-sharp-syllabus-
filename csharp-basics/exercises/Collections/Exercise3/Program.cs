using System;
using System.Collections.Generic;
namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new HashSet<string>();
            do
            {
                Console.Write("Enter name: ");
                names.Add(Console.ReadLine());
            } while (!names.Contains(""));
            Console.Write("Unique name list contains: ");
            foreach (var _name in names)
            {
                Console.Write($"{_name} ");
            }
            Console.ReadKey();
        }
    }
}
