using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            var fAccount = new Account("Fathers account", 100.00);
            var mAccount = new Account("Matt's account", 1000.00);
            var myAccount = new Account("My account", 0);
            var aAccount = new Account("A", 100.0);
            var bAccount = new Account("B", 0.0);
            var cAccount = new Account("C", 0.0);
            Console.WriteLine("Initial state");
            Console.WriteLine(fAccount);
            Console.WriteLine(mAccount);
            Console.WriteLine(myAccount);
            Console.WriteLine(aAccount);
            Console.WriteLine(bAccount);
            Console.WriteLine(cAccount);
            fAccount.Deposit(20.0);
            Console.WriteLine("Fathers account's balance is now: " + fAccount.Balance());
            mAccount.Withdrawal(100.0);
            fAccount.Deposit(100.0);
            Console.WriteLine("Fathers account's balance is now: " + fAccount.Balance());
            Console.WriteLine("Matt account's balance is now: " + mAccount.Balance());
            Transfer(aAccount, bAccount, 50.0);
            Transfer(bAccount, cAccount, 25.0);

            Console.WriteLine("Final state");
            Console.WriteLine(fAccount);
            Console.WriteLine(mAccount);
            Console.WriteLine(myAccount);
            Console.WriteLine(aAccount);
            Console.WriteLine(bAccount);
            Console.WriteLine(cAccount);
            Console.ReadKey();
        }

        public static void Transfer(Account from, Account to, double howMuch)
        {
            to.Deposit(from.Withdrawal(howMuch));
        }
    }
}
