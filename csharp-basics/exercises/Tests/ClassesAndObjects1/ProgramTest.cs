using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects1
{
    public class Product
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
        public string PrintProduct()
        {
            return $"{Name}, price {PriceAtStart}, amount {AmountAtStart}";
        }
    }
}