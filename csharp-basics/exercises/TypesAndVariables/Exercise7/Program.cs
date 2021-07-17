using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Please input your string!");
            string mySentence = Console.ReadLine();

            char[] charArr = mySentence.ToCharArray();
            foreach (char ch in charArr)
            {
                if (Char.IsUpper(ch))
                {
                    sum++;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Your correct input summed up number is: {sum}");
            Console.ReadKey();
        }
    }
}
