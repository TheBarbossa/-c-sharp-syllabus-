using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class SavingsAccount
    {
        public double _balance;
        private double Withd;
        private double Depos;
        private double Inter;
        public SavingsAccount(int balance) {
            _balance = balance;
        }
        public double Withdraw(int num) {
            Withd += num;
            _balance -= num;
            return _balance;
        }
        public double Deposit(int num) {
            Depos += num;
            _balance += num;
            return _balance;
        }
        public double Interest(double interest) {
            double annualInter = interest / 12;
            double interSum = _balance * annualInter;
            Inter += interSum;
            _balance += interSum;
            return _balance;
        }
        public void TotalDeposit() {
            Console.WriteLine(Math.Round(Depos,2).ToString("N2"));
        }
        public void TotalWithdraw() {
            Console.WriteLine(Math.Round(Withd, 2).ToString("N2"));
        }
        public void TotalInterest() {
            Console.WriteLine(Math.Round(Inter, 2).ToString("N2"));
        }
        public void Total_balance() {
            Console.WriteLine(Math.Round(_balance, 2).ToString("N2"));
        }
    }
}
