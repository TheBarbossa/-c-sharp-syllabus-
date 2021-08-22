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
        private int Year { get; set; }
        private int Month { get; set;}
        private int Day { get; set;}
        public void DisplayDate()
        {
            Console.WriteLine($"{Month}/{Day}/{Year}");
        }
    }
}
