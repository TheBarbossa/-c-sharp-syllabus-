using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class SavingsAccount
    {
        public SavingsAccount(int balance) {
            Balance = balance;
        }
        public double Balance;
        private double Withd;
        private double Depos;
        private double Inter;
        public double Withdraw(int num) {
            Withd += num;
            Balance -= num;
            return Balance;
        }
        public double Deposit(int num) {
            Depos += num;
            Balance += num;
            return Balance;
        }
        public double Interest(double interest) {
            double annualInter = interest / 12;
            double interSum = Balance * annualInter;
            Inter += interSum;
            Balance += interSum;
            return Balance;
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
        public void TotalBalance() {
            Console.WriteLine(Math.Round(Balance, 2).ToString("N2"));
        }
    }
}
