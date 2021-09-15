using ClassesAndObjects1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassesAndObjects1Tests
{
    [TestClass]
    public class ClassesAndObjects1ExtensionTests
    {
        [TestMethod]
        public void TestDifferentPrice()
        {
            Product p1 = new Product("Logitech mouse", 70.00, 14);
            p1.PriceAtStart = 33.45;
            var price = p1.PriceAtStart;
            Assert.AreEqual(price, 33.45);
        }

        [TestMethod]
        public void TestDifferentAmount()
        {
            Product p2 = new Product("Logitech mouse", 70.00, 14);
            p2.AmountAtStart = 334;
            var amount = p2.AmountAtStart;
            Assert.AreEqual(amount, 334);
        }

        [TestMethod]
        public void TestReturnPriceInfo()
        {
            Product p3 = new Product("Logitech mouse", 70.00, 14);
            var data = p3.PrintProduct();
            Assert.AreEqual(data, "Logitech mouse, price 70, amount 14");
        }
    }
}
