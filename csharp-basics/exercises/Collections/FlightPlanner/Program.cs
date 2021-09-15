using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = "../FlightPlanner/flights.txt";

        private static void Main(string[] args)
        {
            string choice, _startCity, _endCity, _city, title, title2;
            var dictionary = new Dictionary<string, List<string>>();
            var readText = File.ReadAllLines(Path);
            foreach (var s in readText)
            {
                title = s.Substring(0, s.IndexOf('-')-1);
                title2 = s.Substring(s.IndexOf('>') + 2);
                if (!dictionary.ContainsKey(title))
                {
                    dictionary.Add(title, new List<string>());
                }
                dictionary[title].Add(title2);
            }
            foreach (var contents in dictionary.Keys)
            {
                foreach (var listMember in dictionary[contents])
                {
                    Console.WriteLine("Key : " + contents + " member :" + listMember);
                }
            }

            //Before we start - this task is case sensitive
            Console.WriteLine("What would you like to do:");
            choice = GetMenu();
            List<string> MyFlights = new List<string>();
                switch (choice)
                { 
                    case "1":
                        foreach (var city in dictionary)
                            Console.WriteLine("{0}", city.Key);
                        choice = GetMenu2();
                        switch (choice)
                        {
                            case "1":
                                Console.WriteLine("Please select your starting point:");
                                _startCity= ChooseCity();
                                Console.WriteLine("Please select your destination:");
                                foreach (var listMember in dictionary[_startCity])
                                {
                                    Console.WriteLine(listMember);
                                }
                                _endCity= ChooseCity();
                                MyFlights.Add($"{_startCity} => {_endCity}");
                                while (_endCity != _startCity)
                                {
                                    Console.WriteLine("Please select your next trip.");
                                    _city = _endCity;
                                    foreach (var listMember in dictionary[_city])
                                    {
                                        Console.WriteLine(listMember);
                                    }
                                    Console.WriteLine("Please select your destination:");
                                    _endCity = ChooseCity();
                                    MyFlights.Add($"{_city} => {_endCity}");
                                }
                                Console.WriteLine("\nYour flight plan looks like this: ");
                                foreach (string s in MyFlights)
                                {
                                    Console.WriteLine(s);
                                }
                                break;
                            case "#":
                                break;
                        }
                        break;
                    case "#":
                        break;
                };
                Console.WriteLine("\nThank you for choosing Codelex airlines!");
                Console.ReadKey();
        }
        public static string ChooseCity()
        {
            Console.Write("> ");
            return Console.ReadLine();
        }
        public static string GetMenu()
        {
            Console.WriteLine("To display list of the cities press 1");
            Console.WriteLine("To exit program press #");
            Console.Write("> ");
            var keyboard = Convert.ToString(Console.ReadLine());

            while (keyboard != "1" & keyboard != "#")
            {
                Console.WriteLine("\nError, please enter \"1\" or \"#\"");
                keyboard = Convert.ToString(Console.ReadLine());
            }
            return keyboard;
        }
        public static string GetMenu2()
        {
            Console.WriteLine("To select a city from which you would like to start press 1");
            Console.WriteLine("To exit program press #");
            Console.Write("> ");
            var keyboard = Convert.ToString(Console.ReadLine());

            while (keyboard != "1" & keyboard != "#")
            {
                Console.WriteLine("\nError, please enter \"1\" or \"#\"");
                keyboard = Convert.ToString(Console.ReadLine());
            }
            return keyboard;
        }
    }
}
