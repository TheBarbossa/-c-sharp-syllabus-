using System;
using ClassesAndObjects5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassesAndObjects5Tests
{
    [TestClass]
    public class ClassesAndObjects5ExtensionTests
    {
        [TestMethod]
        public void TestWrongDay()
        {
            Assert.ThrowsException<ArgumentException>(() => new Date(33, 12, 2015));
        }

        [TestMethod]
        public void TestWrongMonth()
        {
            Assert.ThrowsException<ArgumentException>(() => new Date(23, 22, 2015));
        }

        [TestMethod]
        public void TestAllWorks()
        {
            Date day1 = new Date(23, 12, 2015);
            var answ = day1.DisplayDate();
            Assert.AreEqual(answ,"12/23/2015");
        }
    }
}
