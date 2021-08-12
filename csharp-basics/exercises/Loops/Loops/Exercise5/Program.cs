using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first word:");
            var first = Console.ReadLine();
            Console.WriteLine("Enter second word:");
            var second = Console.ReadLine();
            int dot = 30 - first.Length - second.Length;
            Console.Write(first);
            for (int i = 0; i < dot; i++)
            {
                Console.Write(".");
            }
            Console.Write(second);
            Console.ReadKey();
        }
    }
}
