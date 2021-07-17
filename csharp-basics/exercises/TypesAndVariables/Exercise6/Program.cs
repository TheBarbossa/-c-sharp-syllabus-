using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("How many numbers do you want to input?");
            int howMany = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your numbers!");
            for (int n = 0; n < howMany; n++)
            {
                sbyte inNumber = Convert.ToSByte(Console.ReadLine());
                if (inNumber >= 10 | inNumber <= -10)
                {
                    Console.WriteLine("This is not a single digit number! Please input another!");
                }
                else sum = sum+inNumber;
            }

            Console.WriteLine();
            Console.WriteLine($"Your correct input summed up number is: {sum}");
            Console.ReadKey();
        }
    }
}
