using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            var myList = new List<string>{"cabbage","eggs","milk"};
            foreach (var food in myList)
            {
                Console.WriteLine(food);
            }

            var colors = new List<string>();
            colors.Add("Red");
            colors.Add("Blue");
            colors.Add("Purple");
            colors.Add("Green");
            colors.Add("Yellow");
            foreach (var rainbow in colors)
            {
                Console.WriteLine(rainbow);
            }
            Console.ReadKey();
        }
    }
}
