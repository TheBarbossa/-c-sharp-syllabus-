using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name, Eyes, Teeth, Hair;
            int Age;
            double Height, Weight;

            Name = "Zed A. Shaw";
            Age = 35;
            Height = Math.Round((74*2.54),2);
            Weight = Math.Round((180 * 0.453592),2);
            Eyes = "Blue";
            Teeth = "White";
            Hair = "Brown";

            Console.WriteLine("Let's talk about " + Name + ".");
            Console.WriteLine("He's " + Height + " centimeters tall.");
            Console.WriteLine("He's " + Weight + " kilos heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + Eyes + " eyes and " + Hair + " hair.");
            Console.WriteLine("His teeth are usually " + Teeth + " depending on the coffee.");

            Console.WriteLine("If I add " + Age + ", " + Height + ", and " + Weight
                              + " I get " + (Age + Height + Weight) + ".");

            Console.ReadKey();
        }
    }
}