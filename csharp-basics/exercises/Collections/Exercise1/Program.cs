using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "Volkswagen", "Mercedes", "Tesla" };

            List<string> array1 = new List<string>
                {"Audi", "BMW", "Honda", "Mercedes", "Volkswagen", "Mercedes", "Tesla"};
            foreach (string gee in array1)
            {
                Console.WriteLine(gee);
            }
            HashSet<string> array2 = new HashSet<string> { "Audi", "BMW", "Honda", "Mercedes", "Volkswagen", "Mercedes", "Tesla" };
            foreach (string gee in array2)
            {
                Console.WriteLine(gee);
            }
            Dictionary<string, string> array3 = new Dictionary<string, string>()
            {
                {"Audi","Germany"},{"BMW","Germany"},{"Honda","Japan"},{"Mercedes","Germany"},{"Volkswagen","Germany"},{"Tesla","USA"}
            };
            foreach (var gee in array3)
            {
                Console.WriteLine("Key: {0}, Value: {1}", gee.Key, gee.Value);
            }
            Console.ReadKey();
        }
    }
}
