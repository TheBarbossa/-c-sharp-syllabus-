using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, num;
            Console.WriteLine("Input the base number to power : ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            for (i = 0; i < n; i++)
            { 
                result = Pow(num,n);
            }
            Console.WriteLine($"\nValue of the number {num} to the power of {n} is {result} ");
            Console.ReadKey();
        }
        static int Pow(int number, int times)
        {
            var a = number;
            for (var i = times; i > 1; i--)
            {
                a *= number;
            }
            return a;
        }
    }
}
