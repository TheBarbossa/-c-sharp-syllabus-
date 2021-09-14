using System;
using Arithmetics2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arithmetics2Tests
{
    [TestClass]
    public class Arithmetics2ExtensionTests
    {
        [TestMethod]
        public void TestNumberEven()
        {
            //Console.Write("Please input your number: ");
            int inputNumber = 14;

            var isEven = Arithmetics2Extension.NumberEven(inputNumber);
            var isOdd = Arithmetics2Extension.NumberOdd(inputNumber);

            Assert.AreEqual(true,isEven);
            Assert.AreEqual(false,isOdd);
        }

        [TestMethod]
        public void TestNumberOdd()
        {
            //Console.Write("Please input your number: ");
            int inputNumber = 17;

            var isEven = Arithmetics2Extension.NumberEven(inputNumber);
            var isOdd = Arithmetics2Extension.NumberOdd(inputNumber);

            Assert.AreEqual(false, isEven);
            Assert.AreEqual(true, isOdd);
        }
    }
}
