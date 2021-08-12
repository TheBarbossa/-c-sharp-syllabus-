using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;

            do
            {
                choice = getMenu();

                if (choice == 1)
                {
                    Console.WriteLine("\nYou chose 1");
                    calculateCircleArea();
                    Console.ReadKey();
                }
                else if (choice == 2)
                {
                    Console.WriteLine("\nYou chose 2");
                    calculateRectangleArea();
                    Console.ReadKey();
                }
                else if (choice == 3)
                {
                    Console.WriteLine("\nYou chose 3");
                    calculateTriangleArea();
                    Console.ReadKey();
                }
                else if (choice == 4)
                {
                    Console.WriteLine("\nThanks for calculating!");
                    Console.ReadKey();
                }

            } while (choice != 4);
        }

        public static int getMenu()
        {
            int userChoice;

            Console.WriteLine("\nGeometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            var keyboard = Console.ReadKey();

            int.TryParse(keyboard.KeyChar.ToString(), out userChoice);

            while (userChoice < 1 | userChoice > 4)
            {
                Console.WriteLine("\nError, please enter a valid number in range: 1, 2, 3, or 4");
                keyboard = Console.ReadKey();
                userChoice = keyboard.KeyChar;
                int.TryParse(keyboard.KeyChar.ToString(), out userChoice);
            }
            return userChoice;
        }

        public static void calculateCircleArea()
        {
            Console.WriteLine("What is the circle's radius? ");
            var keyboard = Console.ReadLine();

            decimal.TryParse(keyboard, out var radius);

            Console.WriteLine("The circle's area is "
                    + Geometry.areaOfCircle(radius));
            Console.WriteLine("\nPress enter to continue.");
        }

        public static void calculateRectangleArea()
        {
            decimal length = 0;
            decimal width = 0;

            Console.WriteLine("Enter length? ");
            length = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter width? ");
            width = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("The rectangle's area is "
                    + Geometry.areaOfRectangle(length, width));
            Console.WriteLine("\nPress enter to continue.");
        }

        public static void calculateTriangleArea()
        {
            decimal ground = 0;
            decimal height = 0;

            Console.WriteLine("Enter length of the triangle's base? ");
            ground = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter triangle's height? ");
            height = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("The triangle's area is "
                    + Geometry.areaOfTriangle(ground, height));
            Console.WriteLine("\nPress enter to continue.");
        }
    }
}