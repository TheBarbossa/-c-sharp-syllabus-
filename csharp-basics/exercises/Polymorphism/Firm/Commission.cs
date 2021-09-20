using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Commission : Hourly
    {
        private double _totalSales;
        private double _cRate;

        public Commission(string eName, string eAddress, string ePhone, string socSecNumber, double rate,
            double commissionRate)
            : base(eName, eAddress, ePhone, socSecNumber, rate)
        {
            _cRate = commissionRate;
            _totalSales = 0;
        }

        public void addSales(double totalSales)
        {
            _totalSales += totalSales;
        }

        public override double Pay()
        {
            var payment = base.Pay() + _totalSales * _cRate;
            _totalSales = 0;
            return payment;
        }

        public override string ToString()
        {
            var result = base.ToString();
            result += "\nTotal sales: " + _totalSales + "$";
            return result;
        }
    }
}
