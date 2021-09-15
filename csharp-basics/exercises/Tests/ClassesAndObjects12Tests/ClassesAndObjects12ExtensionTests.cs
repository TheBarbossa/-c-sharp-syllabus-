using System;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ClassesAndObjects12Tests
{
    [TestClass]
    public class ClassesAndObjects12ExtensionTests
    {
        [TestMethod]
        public void TestPrint()
        {
            var fAccount = new Account.Account("Fathers account", 100.00);
            string print = fAccount.ToString();
            Assert.AreEqual(print, "Fathers account: 100");
        }

        [TestMethod]
        public void TestBalance()
        {
            var fAccount = new Account.Account("Fathers account", 100.00);
            var balance = fAccount.balance();
            Assert.AreEqual(balance,100);
        }

        [TestMethod]
        public void TestDeposit()
        {
            var fAccount = new Account.Account("Fathers account", 100.00);
            var deposit = fAccount.deposit(230);
            Assert.AreEqual(deposit, 330);
        }

        [TestMethod]
        public void TestDepositFail()
        {
            var fAccount = new Account.Account("Fathers account", 100.00);
            Assert.ThrowsException<ArgumentException>(() => fAccount.deposit(-230));
        }

        [TestMethod]
        public void TestWithdraw()
        {
            var fAccount = new Account.Account("Fathers account", 100.00);
            var withdraw = fAccount.withdrawal(30);
            Assert.AreEqual(withdraw, 70);
        }

        [TestMethod]
        public void TestWithdrawFail()
        {
            var fAccount = new Account.Account("Fathers account", 100.00);
            Assert.ThrowsException<ArgumentException>(() => fAccount.withdrawal(230));
        }
    }
}
