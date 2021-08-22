using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDrinks
{
    class Program
    {
        private const int NumberedSurveyed = 12467;
        private const double PurchasedEnergyDrinks = 0.14;
        private const double PreferCitrusDrinks = 0.64;

        private static void Main(string[] args)
        {
            Console.WriteLine("Total number of people surveyed " + NumberedSurveyed);
            Console.WriteLine("Approximately " + EnergyDrinkers() + " bought at least one energy drink");
            Console.WriteLine(PreferCitrus() + " of those prefer citrus flavored energy drinks."); 
            Console.ReadKey();
        }
        static double EnergyDrinkers()
        {
            return Math.Ceiling(NumberedSurveyed * PurchasedEnergyDrinks);
        }
        static double PreferCitrus()
        {
            return Math.Ceiling(EnergyDrinkers() * PreferCitrusDrinks);
        }
    }
}
