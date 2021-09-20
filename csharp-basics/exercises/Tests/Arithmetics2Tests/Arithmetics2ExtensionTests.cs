using System;
using Arithmetics2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arithmetics2Tests
{
    [TestClass]
    public class Arithmetics2ExtensionTests
    {
        [TestMethod]
        public void Test_IsNumberEven()
        {
            int inputNumber = 14;

            var isEven = Arithmetics2Extension.NumberEven(inputNumber);

            Assert.AreEqual(true,isEven);
        }

        [TestMethod]
        public void Test_IsNumberEven_False()
        {
            int inputNumber = 15;

            var isEven = Arithmetics2Extension.NumberEven(inputNumber);

            Assert.AreEqual(false, isEven);
        }

        [TestMethod]
        public void Test_IsNumberOdd()
        {
            int inputNumber = 17;

            var isOdd = Arithmetics2Extension.NumberOdd(inputNumber);

            Assert.AreEqual(true, isOdd);
        }

        [TestMethod]
        public void Test_IsNumberOdd_False()
        {
            int inputNumber = 16;

            var isOdd = Arithmetics2Extension.NumberOdd(inputNumber);

            Assert.AreEqual(false, isOdd);
        }
    }
}
