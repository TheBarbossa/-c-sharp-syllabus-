using System;

namespace SumAverageRunningInt
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            int count = 0;
            double average;

            const int lowerBound = 1;
            const int upperBound = 100;

            for (var number = lowerBound; number <= upperBound; ++number)
            {
                sum += number;
                count++;
            }

            average = sum / (double)count;

            Console.WriteLine($"The sum of {lowerBound} and {upperBound} is {sum}");
            Console.WriteLine($"The average is {Math.Round(average,2)}");
            Console.ReadKey();
        }
    }
}