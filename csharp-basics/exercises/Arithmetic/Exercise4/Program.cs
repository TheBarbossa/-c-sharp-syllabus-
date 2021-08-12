using System;

namespace Product1ToN
{
    class Program
    {
        static void Main(string[] args)
        {
            const int lowNum = 1;
            const int upNum = 10;
            int factorialNum = upNum;

            for (var number = upNum-1; number >= lowNum; --number)
            {
                factorialNum = factorialNum*number;
            }
            Console.WriteLine($"The factorial is {factorialNum}");
            Console.ReadKey();
        }
    }
}
