using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int numberPC = rng.Next(1, 101);
            Console.WriteLine("I'm thinking of a number between 1-100.  Try to guess it.");
            int userGuess = Convert.ToInt32(Console.ReadLine());
            if (userGuess == numberPC)
            {
                Console.WriteLine("You guessed it!  What are the odds?!?");
            }
            else if (userGuess < numberPC)
            {
                Console.WriteLine($"Sorry, you are too low.  I was thinking of {numberPC}, better luck next time!");
            }
            else
            {
                Console.WriteLine($"Sorry, you are too high.  I was thinking of {numberPC}, better luck next time!");
            }
            Console.ReadKey();
        }
    }
}
