using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to \"Check your number!\"");
            Console.Write("Please input your number: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            if (inputNumber % 2 == 0)
            {
                Console.WriteLine("Even number\n");
            }
            else
            {
                Console.WriteLine("Odd number\n");
            }
            Console.WriteLine("bye!");
            Console.ReadKey();
        }
    }
}
