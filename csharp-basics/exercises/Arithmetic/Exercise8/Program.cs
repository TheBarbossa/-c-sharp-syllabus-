using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome, please input the number of your employees: ");
            int countEmp = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= countEmp;i++)
            {
                Console.Write($"Please input employees nr.{i} worked hours: ");
                var hoursEmp = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Please input employees nr.{i} base pay: $");
                var basePayEmp = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Employees(i,basePayEmp, hoursEmp);
            }
            Console.ReadKey();
        }
        static void Employees(int i,double num1, int num2)
        {
            double totalSum;
            int overtimeHours = 0;
            double overtimePay = 0;
            if (num1 < 8.00)
            {
                Console.WriteLine(" error, too little pay\n");
                return;
            }

            if (num2 > 60)
            {
                Console.WriteLine(" error, too many hours\n");
                return;
            }

            if (num2 > 40 & num2 <=60)
            {
                overtimeHours = num2 - 40;
                overtimePay = num1 * 1.5 * overtimeHours;
                totalSum = num1 * (num2-overtimeHours) + overtimePay;
                Console.WriteLine($" Employee nr.{i} is earning ${totalSum}\n\n");
            }
            else
            {
                totalSum = num1 * num2;
                Console.WriteLine($" Employee nr.{i} is earning ${totalSum}\n\n");
            }
        }
    }
}
