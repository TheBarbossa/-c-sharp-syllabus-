using System;
using System.Threading;

namespace Exercise10
{
    class NumberSquare
    {
        static void Main(string[] args)
        {
            int min, max, min2, count, count2;
            Console.Write("Min? ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Max? ");
            max = Convert.ToInt32(Console.ReadLine());
            min2 = min;
            count = max - 1;
            count2 = 0;
            for (int i = min; i <= max; i++)
            {
                Console.Write(i);
            }
            Console.WriteLine("");
            do
            {
                min++;
                for (int i = min; i <= max; i++)
                {
                    if (i == max)
                    {
                        Console.Write(i);
                        for (int j = min2; j <= max - count; j++)
                        {
                            Console.Write(j);
                        }
                        count--;
                    }
                    else Console.Write(i);
                }
                Console.WriteLine("");
                count2++;
            } while (count2 != max);
            Console.ReadKey();
        }
    }
}