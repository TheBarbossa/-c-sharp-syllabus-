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
            // Arrange
            int inputNumber = 14;

            // Act
            var isEven = Arithmetics2Extension.IsNumberEven(inputNumber);

            // Assert
            Assert.AreEqual(true,isEven);
        }

        [TestMethod]
        public void Test_IsNumberEven_False()
        {
            // Arrange
            int inputNumber = 15;

            // Act
            var isEven = Arithmetics2Extension.IsNumberEven(inputNumber);

            // Assert
            Assert.AreEqual(false, isEven);
        }

        [TestMethod]
        public void Test_IsNumberOdd()
        {
            // Assert
            int inputNumber = 17;

            // Act
            var isOdd = Arithmetics2Extension.IsNumberOdd(inputNumber);

            // Assert
            Assert.AreEqual(true, isOdd);
        }

        [TestMethod]
        public void Test_IsNumberOdd_False()
        {
            // Arrange
            int inputNumber = 16;

            // Act
            var isOdd = Arithmetics2Extension.IsNumberOdd(inputNumber);

            // Assert
            Assert.AreEqual(false, isOdd);
        }
    }
}
