using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the 1st number: ");
            var input1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the 2nd number: ");
            var input2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the 3rd number: ");
            var input3 = Convert.ToInt32(Console.ReadLine());

            if (input1 != input2 & input2 != input3 & input1 != input3)
            {
                if (input1 > input3 & input1 > input2)
                {
                    Console.WriteLine($"\nFirst number ({input1}) is the largest number!");
                }
                else if (input2 > input3 & input1 < input2)
                {
                    Console.WriteLine($"\nSecond number ({input2}) is the largest number!");
                }
                else
                {
                    Console.WriteLine($"\nThird number ({input3}) is the largest number!");
                }
            }
            else
            {
                Console.WriteLine("\nThere are multiple largest numbers!");
            }
            Console.ReadKey();
        }
    }
}