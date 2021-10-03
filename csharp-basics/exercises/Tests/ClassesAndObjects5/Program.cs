using System;

namespace ClassesAndObjects5
{
    class DateTest
    {
        static void Main(string[] args)
        {
            Date day1 = new Date(23, 12, 2015);
            Console.WriteLine(day1.DisplayDate());
            Console.ReadKey();
        }
    }
}
