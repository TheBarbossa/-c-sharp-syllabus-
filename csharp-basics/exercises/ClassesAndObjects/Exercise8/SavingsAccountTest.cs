using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How much money is in the account?: ");
            var savings = new SavingsAccount(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Enter the annual interest rate: ");
            var interest = Convert.ToInt32(Console.ReadLine());
            Console.Write("How long has the account been opened? ");
            var months = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= months; i++) 
            {
                Console.Write($"Enter amount deposited for month {i}: ");
                savings.Deposit(Convert.ToInt32(Console.ReadLine()));
                Console.Write($"Enter amount withdrawn for {i}: ");
                savings.Withdraw(Convert.ToInt32(Console.ReadLine()));
                savings.Interest(interest);
            }
            Console.Write("Total deposited: $");
            savings.TotalDeposit();
            Console.Write("Total withdrawn: $");
            savings.TotalWithdraw();
            Console.Write("Interest earned: $");
            savings.TotalInterest();
            Console.Write("Ending balance: $");
            savings.TotalBalance();
            Console.ReadKey();
        }
    }
}
