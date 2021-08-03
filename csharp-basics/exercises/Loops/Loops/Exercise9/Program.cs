using System;

namespace Exercise9
{
    class ProgramRollTwoDice
    {
        static void Main(string[] args)
        {
            int desiredNumber;
            do
            {
                Console.Write("Desired sum (from 2 to 12): ");
                desiredNumber = Convert.ToInt32(Console.ReadLine());
                if (desiredNumber < 2 | desiredNumber > 12)
                    Console.WriteLine("Please enter a valid number!\n");
            } while (desiredNumber < 2 | desiredNumber > 12);
            Random r = new Random();
            var rNum = 0;
            var rNum2 = 0;
            while (rNum + rNum2 != desiredNumber)
            {
                rNum = r.Next(1, 6);
                rNum2 = r.Next(1, 6);
                int sum = rNum + rNum2;
                Console.WriteLine($"{rNum} and {rNum2} = {sum} ");
            }
            Console.ReadKey();
        }
    }
}