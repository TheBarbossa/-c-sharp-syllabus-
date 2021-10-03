using ClassesAndObjects1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassesAndObjects1Tests
{
    [TestClass]
    public class ClassesAndObjects1ExtensionTests
    {
        [TestMethod]
        public void Test_IsPriceDifferent()
        {
            // Arrange
            Product p1 = new Product("Logitech mouse", 70.00, 14);

            // Act
            p1.PriceAtStart = 33.45;
            var price = p1.PriceAtStart;

            //Assert
            Assert.AreEqual(price, 33.45);
        }

        [TestMethod]
        public void Test_IsAmmountDifferent()
        {
            // Arrange
            Product p2 = new Product("Logitech mouse", 70.00, 14);

            // Act
            p2.AmountAtStart = 334;
            var amount = p2.AmountAtStart;

            //Assert
            Assert.AreEqual(amount, 334);
        }

        [TestMethod]
        public void Test_IsPriceInfoReturned()
        {
            // Arrange
            Product p3 = new Product("Logitech mouse", 70.00, 14);

            // Act
            var data = p3.PrintProduct();

            //Assert
            Assert.AreEqual(data, "Logitech mouse, price 70, amount 14");
        }
    }
}
