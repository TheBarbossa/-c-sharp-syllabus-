using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        private const string Path = "C:\\Users\\SB00366\\OneDrive - Riga Technical University\\Desktop\\Codelex\\-c-sharp-syllabus-\\csharp-basics\\exercises\\Collections\\Histogram\\midtermscores.txt";

        private static void Main(string[] args)
        {
            var readText = File.ReadAllLines(Path);
            List<string> myList = new List<string>();
            var dictionary = new Dictionary<string, List<string>>()
            {
                {"00-09",new List<string>()},{"10-19",new List<string>()},{"20-29",new List<string>()},{"30-39",new List<string>()},{"40-49",new List<string>()},
                {"50-59",new List<string>()},{"60-69",new List<string>()},{"70-79",new List<string>()},{"80-89",new List<string>()},{"90-99",new List<string>()},
                {"100",new List<string>()}
            };
            foreach (var s in readText)
            {
                string[] thisArray = s.Split(' '); 
                myList.AddRange(thisArray);
            }
            foreach (var number in myList)
            {
                int num = Convert.ToInt32(number);
                if (num < 10)
                    dictionary["00-09"].Add("*");
                else if (num < 20)
                    dictionary["10-19"].Add("*");
                else if (num < 30)
                    dictionary["20-29"].Add("*");
                else if (num < 40)
                    dictionary["30-39"].Add("*");
                else if (num < 50)
                    dictionary["40-49"].Add("*");
                else if (num < 60)
                    dictionary["50-59"].Add("*");
                else if (num < 70)
                    dictionary["60-69"].Add("*");
                else if (num < 80)
                    dictionary["70-79"].Add("*");
                else if (num < 90)
                    dictionary["80-89"].Add("*");
                else if (num < 100)
                    dictionary["90-99"].Add("*");
                else 
                    dictionary["100"].Add("*");
            }
            Console.Write("00-09: ");
            foreach (var listMember in dictionary["00-09"])
                Console.Write(listMember);
            Console.Write("\n10-19: ");
            foreach (var listMember in dictionary["10-19"])
                Console.Write(listMember);
            Console.Write("\n20-29: ");
            foreach (var listMember in dictionary["20-29"])
                Console.Write(listMember);
            Console.Write("\n30-39: ");
            foreach (var listMember in dictionary["30-39"])
                Console.Write(listMember);
            Console.Write("\n40-49: ");
            foreach (var listMember in dictionary["40-49"])
                Console.Write(listMember);
            Console.Write("\n50-59: ");
            foreach (var listMember in dictionary["50-59"])
                Console.Write(listMember);
            Console.Write("\n60-69: ");
            foreach (var listMember in dictionary["60-69"])
                Console.Write(listMember);
            Console.Write("\n70-79: ");
            foreach (var listMember in dictionary["70-79"])
                Console.Write(listMember);
            Console.Write("\n80-89: ");
            foreach (var listMember in dictionary["80-89"])
                Console.Write(listMember);
            Console.Write("\n90-99: ");
            foreach (var listMember in dictionary["90-99"])
                Console.Write(listMember);
            Console.Write("\n  100: ");
            foreach (var listMember in dictionary["100"])
                Console.Write(listMember);
            Console.ReadKey();
        }
    }
}
