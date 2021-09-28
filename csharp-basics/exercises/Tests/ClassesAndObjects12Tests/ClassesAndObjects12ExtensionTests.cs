using System;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ClassesAndObjects12Tests
{
    [TestClass]
    public class ClassesAndObjects12ExtensionTests
    {
        [TestMethod]
        public void Test_IsCorrectPrint()
        {
            // Arrange
            var fAccount = new Account.Account("Fathers account", 100.00);

            // Act
            string print = fAccount.ToString();

            // Assert
            Assert.AreEqual(print, "Fathers account: 100");
        }

        [TestMethod]
        public void Test_IsCorrectBalance()
        {
            // Arrange
            var fAccount = new Account.Account("Fathers account", 100.00);

            // Act
            var balance = fAccount.Balance();

            // Assert
            Assert.AreEqual(balance,100);
        }

        [TestMethod]
        public void Test_IsCorrectDeposit()
        {
            // Arrange
            var fAccount = new Account.Account("Fathers account", 100.00);

            // Act
            var deposit = fAccount.Deposit(230);

            // Assert
            Assert.AreEqual(deposit, 330);
        }

        [TestMethod]
        public void Test_IsInvalidAmount_Deposit()
        {
            // Arrange
            var fAccount = new Account.Account("Fathers account", 100.00);

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => fAccount.Deposit(-230));
        }

        [TestMethod]
        public void Test_IsCorrectWithdrawn()
        {
            // Arrange
            var fAccount = new Account.Account("Fathers account", 100.00);

            // Act
            var withdraw = fAccount.Withdrawal(30);

            // Assert
            Assert.AreEqual(withdraw, 70);
        }

        [TestMethod]
        public void Test_IsInvalidAmount_Account()
        {
            // Arrange
            var fAccount = new Account.Account("Fathers account", 100.00);

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => fAccount.Withdrawal(230));
        }
    }
}
