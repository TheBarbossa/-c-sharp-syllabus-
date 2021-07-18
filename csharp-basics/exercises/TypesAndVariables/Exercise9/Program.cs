using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your distance (in meters)!");
            float inputMeters = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Please input your time in:");
            Console.Write($"Hours: ");
            int inputHours = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Minutes: (0-59)");
            int inputMinutes = Convert.ToInt32(Console.ReadLine());
            if (inputMinutes >= 60)
            {
                Console.WriteLine("Sorry, please try again!");
                return;
            }

            Console.Write($"Seconds: (0-59)");
            int inputSeconds = Convert.ToInt32(Console.ReadLine());
            if (inputSeconds >= 60)
            {
                Console.WriteLine("Sorry, please try again!");
                return;
            }

            float timeSec = (inputHours * 3600) + (inputMinutes * 60) + inputSeconds;
            float mps = inputMeters / timeSec;
            float kph = (inputMeters / 1000.0f) / (timeSec / 3600.0f);
            float mileph = kph / 1.609f;

            Console.WriteLine($"\nYour calculated speed is {Math.Round(mps, 3)} meters per second");
            Console.WriteLine($"Your calculated speed is {Math.Round(kph, 3)} kilometers per hour");
            Console.WriteLine($"Your calculated speed is {Math.Round(mileph, 3)} miles per hour: ");
            Console.ReadKey();

        }
    }
}
