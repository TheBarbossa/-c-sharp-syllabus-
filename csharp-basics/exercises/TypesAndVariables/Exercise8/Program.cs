using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input time, that you want to convert (in minutes)");
            double convYears, convDays, inputTime;
            inputTime = Convert.ToInt32(Console.ReadLine());
            convYears = inputTime/ (24 * 60 * 365);
            convDays = inputTime/(24 * 60);
            Console.WriteLine($"Your converted time is {convDays} days");
            Console.WriteLine($"Your converted time is {convYears} years");
            Console.ReadKey();
        }
    }
}
