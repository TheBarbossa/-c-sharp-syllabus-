using System;

namespace Exercise7
{
    class Piglet
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Piglet!");
            Console.WriteLine("Shall we begin? (yes/no)");
            string answer = Console.ReadLine();

            Random r = new Random();
            int score = 0;
            while (true)
            {
                if (answer == "yes")
                {
                    var rNum = r.Next(1, 6);
                    if (rNum == 1)
                    {
                        Console.WriteLine("You rolled a 1!\nYou got 0 points.\nGAME OVER!");
                        break;
                    }
                    score += rNum;
                    Console.WriteLine($"You rolled a {rNum}!");
                    Console.Write("Roll again? ");
                    answer = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"You got {score} points.");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}