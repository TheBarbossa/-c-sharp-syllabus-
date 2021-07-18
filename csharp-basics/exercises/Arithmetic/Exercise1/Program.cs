using System;
using System.Runtime.CompilerServices;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input first integer!");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input second integer!");
            int numTwo = Convert.ToInt32(Console.ReadLine());

            bool seekingNr15()
            {
                if (numOne == 15 | numTwo == 15 | numOne + numTwo == 15 | numOne - numTwo == 15 | numTwo - numOne == 15)
                {
                    return true;
                }
                else return false;
            }
            Console.WriteLine(seekingNr15());
            Console.ReadKey();
        }
    }
}
