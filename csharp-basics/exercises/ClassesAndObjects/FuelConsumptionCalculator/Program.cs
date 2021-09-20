using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            int endKilometers;
            int liters;
            
            Console.WriteLine();

            Car c1 = new Car(0);
            Car c2 = new Car(0);

            Console.Write("Enter first cars reading: ");
                endKilometers = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter liters reading: ");
                liters = Convert.ToInt32(Console.ReadLine());
                c1.FillUp(endKilometers, liters);

                Console.Write("Enter second cars reading: ");
                endKilometers = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter liters reading: ");
                liters = Convert.ToInt32(Console.ReadLine());
                c2.FillUp(endKilometers, liters);
                
            Console.WriteLine("Kilometers per liter are " + c1.CalculateConsumption() + " gasHog:" + c1.GasHog());
            Console.WriteLine("Car1 Kilometers per liter are " + c2.CalculateConsumption()+ " economyCar:" + c2.EconomyCar());
            Console.ReadKey();
        }
    }
}
