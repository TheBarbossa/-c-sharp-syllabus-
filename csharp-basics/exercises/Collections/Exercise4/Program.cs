using System;
using System.Collections.Generic;
namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            string num = Console.ReadLine();
            double sum=0;
            while (num != "1")
            {
                foreach (char c in num)
                {
                    sum += Math.Pow((Char.GetNumericValue(c)),2);
                }
                num = Convert.ToString(sum);
            }
            Console.WriteLine("happy");
            Console.ReadKey();
        }
    }
}
