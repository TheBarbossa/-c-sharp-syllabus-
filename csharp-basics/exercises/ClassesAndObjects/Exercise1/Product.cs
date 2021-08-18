using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Product
    {
        public Product(string name, double priceAtStart, int amountAtStart)
        {
            Name = name;
            PriceAtStart = priceAtStart;
            AmountAtStart = amountAtStart;
        }
        private string Name
        { get; set; }
        public double PriceAtStart
        { get; set; }
        public int AmountAtStart
        { get; set; }

        public void PrintProduct()
        {
            Console.WriteLine($"{Name}, price {PriceAtStart}, amount {AmountAtStart}");
        }
    }
}
