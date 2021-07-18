using System;
using System.Runtime.CompilerServices;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your name/surname!");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your year of birth!");
            int birthYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"My name is {name} and I was born in {birthYear}");
            Console.ReadKey();
        }
    }
}
