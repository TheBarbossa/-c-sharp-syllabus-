using System;

namespace CozaLozaWoza
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 111; i++)
            {
                if (i % 3 != 0 & i % 5 != 0 & i % 7 != 0)
                {
                    Console.Write(i);
                }
                else
                {
                    if (i % 3 == 0)
                    {
                        Console.Write("Coza");
                    }
                    if (i % 5 == 0)
                    {
                        Console.Write("Loza");
                    }
                    if (i % 7 == 0)
                    {
                        Console.Write("Woza");
                    }
                }
                Console.Write(" ");

                if (i % 11 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
