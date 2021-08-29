﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new List<string> {"Red", "Green", "Violet", "White", "Black"};
            Console.WriteLine(string.Join(",", colors));

            colors.Remove(colors[2]);
            colors.Insert(2,"Yellow");

            Console.WriteLine(string.Join(",", colors));
            Console.ReadKey();
        }
    }
}
