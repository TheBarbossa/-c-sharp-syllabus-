using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie m1 = new Movie("Casino Royale","Eon Productions","PG­13");
            Movie m2 = new Movie("Glass", "Buena Vista International", "PG­13");
            Movie m3 = new Movie("Spider - Man: Into the Spider - Verse", "Columbia Pictures");
            Movie.getPG();
            Console.ReadKey();
        }
    }
}
