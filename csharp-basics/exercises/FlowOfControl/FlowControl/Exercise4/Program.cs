using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace PrintDayInWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input your number of day: ");
            var dayNumber = Console.ReadLine();
            if (int.TryParse(dayNumber, out int n))
            {
                if (n < 0 & n > 6)
                {
                    switch (n)
                    {
                        case 0:
                            Console.WriteLine("Sunday");
                            break;
                        case 1:
                            Console.WriteLine("Monday");
                            break;
                        case 2:
                            Console.WriteLine("Tuesday");
                            break;
                        case 3:
                            Console.WriteLine("Thursday");
                            break;
                        case 4:
                            Console.WriteLine("Wednesday");
                            break;
                        case 5:
                            Console.WriteLine("Friday");
                            break;
                        case 6:
                            Console.WriteLine("Saturday");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Not a valid day!");
                }
            }
            else
            {
                Console.WriteLine("Not a valid number!");
            }
            Console.ReadKey();
        }
    }
}
