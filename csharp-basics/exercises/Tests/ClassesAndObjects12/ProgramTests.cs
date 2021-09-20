using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    public class Account
    {
        private string _name;
        private double _money;

        public Account(string v1, double v2)
        {
            _name = v1;
            _money = v2;
        }

        public double Withdrawal(double i)
        {
            if (_money >= i)
            {
                _money -= i;
                return _money;
            }
            else throw new ArgumentException("You cant withdraw or transfer more money that you have in your account", nameof(_money));
        }

        public double Deposit(double i)
        {
            if (i > 0)
            {
                _money += i;
                return _money;
            }
            else throw new ArgumentException("You cant deposit negative amount of money into your account", nameof(_money));
        }

        public double Balance()
        {
            return _money;
        }

        public override string ToString()
        {
            return $"{_name}: {_money}";
        }
    }
}