using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetics8
{
    public class Arithmetics8Extension
    {
        public static string Employees(int employee, double pay_rate, int hours)
        {
           return Payment(employee,pay_rate,hours);
        }

        public static bool TooLittlePay(double pay)
        {
            return pay < 8.00;
        }

        public static bool TooManyHours(int h)
        {
            return h > 60;
        }

        public static bool Overtime(int h)
        {
            return (h > 40 && h <= 60);
        }

        private static string Payment(int i,double pay, int h)
        {
            if (TooManyHours(h))
            {
                return "error, too many hours.\n";
            }
            else if (TooLittlePay(pay))
            {
                return "error, too little pay.\n";
            }
            else if (Overtime(h))
            {
                var overtimeHours = h - 40;
                var overtimePay = pay * 1.5 * overtimeHours;
                var totalSum = pay * (h - overtimeHours) + overtimePay;
                return ($" Employee nr.{i} is earning ${totalSum}\n\n");
            }
            else
            { 
                var totalSum = pay * h;
                return ($" Employee nr.{i} is earning ${totalSum}\n\n");
            }
        }
    }
}
