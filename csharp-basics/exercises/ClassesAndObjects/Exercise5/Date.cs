using System;

namespace Exercise5
{
    class Date
    {
        public int year;
        public int month;
        public int day;
        public Date(int day, int month, int year)
        {
            Year = year;
            Month = month;
            Day = day;
        }
        public int Year { get; set; }
        public int Month { get; set;}
        public int Day { get; set;}
        public void DisplayDate()
        {
            Console.WriteLine($"{Month}/{Day}/{Year}");
        }
    }
}
