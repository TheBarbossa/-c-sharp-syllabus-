using System;

namespace ClassesAndObjects5
{
    public class Date
    {
        private int _year;
        private int _month;
        private int _day;
        public Date(int day, int month, int year)
        {
            if (year >= 0)
                _year = year;
            else
                throw new ArgumentException("Years cannot be negative", nameof(year));
            if (month >= 1 && month <= 12)
                _month = month;
            else
                throw new ArgumentException("Months must be from 1 to 12",nameof(month));
            if (day >=1 && day <=31)
                _day = day;
            else
                throw new ArgumentException("Days must be from 1 to 31", nameof(day));
        }
        public string DisplayDate()
        {
            return $"{_month}/{_day}/{_year}";
        }
    }
}