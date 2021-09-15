using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product("Logitech mouse", 70.00, 14);
            Product p2 = new Product("iPhone 5s", 999.99, 3);
            Product p3 = new Product("Epson EB-U05", 440.46, 1);
            p1.PrintProduct();
            p2.PrintProduct();
            p3.PrintProduct();
            p2.PriceAtStart = 33.45;
            p3.AmountAtStart = 35;
            p2.PrintProduct();
            p3.PrintProduct();
            Console.ReadKey();
        }
    }
}
