using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            double userHeight, userWeight, heightInches, weightPounds, BMI;
            Console.Write("Welcome, please enter your height in meters: ");
            userHeight = Math.Round(Convert.ToDouble(Console.ReadLine()),2);
            Console.Write("Please enter your weight in kilos: ");
            userWeight = Math.Round(Convert.ToDouble(Console.ReadLine()), 3);
            heightInches = userHeight* 39.3701;
            weightPounds = userWeight* 2.20462;
            BMI = weightPounds * 703 / (Math.Pow(heightInches,2));
            if (BMI < 18.5)
            {
                Console.WriteLine("Sorry to say this, but by telling from your BMI calculation, you are underweight!");
            }
            else if (BMI > 25)
            {
                Console.WriteLine("Sorry to say this, but by telling from your BMI calculation, you are overweight!");
            }
            else
            {
                Console.WriteLine("Congrats, by telling from your BMI calculation, you have an optimal weight");
            }
            Console.ReadKey();
        }
    }
}
