using System;
using ClassesAndObjects5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassesAndObjects5Tests
{
    [TestClass]
    public class ClassesAndObjects5ExtensionTests
    {
        [TestMethod]
        public void Test_IsInvalidDay()
        {
            Assert.ThrowsException<ArgumentException>(() => new Date(33, 12, 2015));
        }

        [TestMethod]
        public void Test_IsInvalidMonth()
        {
            Assert.ThrowsException<ArgumentException>(() => new Date(23, 22, 2015));
        }

        [TestMethod]
        public void Test_IsInvalidYear()
        {
            Assert.ThrowsException<ArgumentException>(() => new Date(23, 22, -1987));
        }

        [TestMethod]
        public void Test_IsCorrectDate()
        {
            // Arrange
            Date day1 = new Date(23, 12, 2015);

            // Act
            var answ = day1.DisplayDate();
            
            // Assert
            Assert.AreEqual(answ,"12/23/2015");
        }
    }
}
