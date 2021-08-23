using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account benben = new Account("Benson", -17.5);
            Console.WriteLine(benben.ShowUserNameAndBalance()); 
            Console.ReadKey();
        }
    }
    class Account
    {
        public Account(string name,double balance)
        {
            this.Name = name;
            this.Balance = balance;
        }
        public string Name;
        public double Balance;
        public string ShowUserNameAndBalance()
        {
            if (Balance<0) return $"{Name}, - $"+(Math.Abs(Balance)).ToString("N2");
            else return $"{Name}, $"+(Balance).ToString("N2");
        }
    }
}
