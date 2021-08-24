using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        private static void Main(string[] args)
        {
            var mySet = new HashSet<string>();
            mySet.Add("Red");
            mySet.Add("Black");
            mySet.Add("Yellow");
            mySet.Add("Green");
            mySet.Add("Orange");

            Console.WriteLine("Should have 5 elements: ");
            Console.WriteLine(string.Join(",", mySet));
            foreach (var color in mySet) 
            {
                Console.WriteLine(color);
            }
          
            mySet.Clear();
            Console.WriteLine("Is mySet empty: ");
            Console.WriteLine(mySet.Count == 0);

            mySet.Add("Green");
            mySet.Add("Orange");
            mySet.Add("Green");
            mySet.Add("Purple");

            Console.WriteLine(string.Join(",", mySet));
            Console.ReadKey();
        }
    }
}
