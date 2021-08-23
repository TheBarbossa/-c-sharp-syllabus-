using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Product
    {
        public string Name;
        public double PriceAtStart;
        public int AmountAtStart;
        public Product(string name, double priceAtStart, int amountAtStart)
        {
            Name = name;
            PriceAtStart = priceAtStart;
            AmountAtStart = amountAtStart;
        }
        public void PrintProduct()
        {
            Console.WriteLine($"{Name}, price {PriceAtStart}, amount {AmountAtStart}");
        }
    }
}
