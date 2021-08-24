using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var myList = new List<string>{"one","two","three","four","five"};
            myList.Add("six");
            myList.Add("seven");
            myList.Add("eight");
            myList.Add("nine");
            myList.Add("ten");
            myList.Insert(4,"gee");
            myList.RemoveAt(myList.Count-1);
            myList.Add("hmm");
            myList.Sort();
            Console.WriteLine(myList.Contains("Foobar"));
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
