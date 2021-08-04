using System;
using System.ComponentModel.DataAnnotations;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Max value? ");
            var max = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= max; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.Write("FizzBuzz");
                else if (i % 3 == 0)
                    Console.Write("Fizz");
                else if (i % 5 == 0)
                    Console.Write("Buzz");
                else Console.Write(i);
                    Console.Write(" ");
                if (i % 20 == 0)
                    Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
