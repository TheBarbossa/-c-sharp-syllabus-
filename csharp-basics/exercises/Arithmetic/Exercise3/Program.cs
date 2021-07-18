using System;

namespace SumAverageRunningInt
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            int count = 0;
            int average;
            //i don't know how to get double without changing the variable int, it always throws out errors if i try to combine int with double to get result as double.

            const int lowerBound = 1;
            const int upperBound = 100;

            for (var number = lowerBound; number <= upperBound; ++number)
            {
                sum += number;
                count++;
            }

            double average2 = sum / (double)count;

            Console.WriteLine($"The sum of {lowerBound} and {upperBound} is {sum}");
            Console.WriteLine($"The average is {Math.Round(average2,2)}");
            Console.ReadKey();
        }
    }
}