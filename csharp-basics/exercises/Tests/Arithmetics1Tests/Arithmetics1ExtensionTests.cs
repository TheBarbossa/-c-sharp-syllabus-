using System;
using Arithmetics1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arithmetics1Tests
{
    [TestClass]
    public class Arithmetics1ExtensionTests
    {
        [TestMethod]
        public void TestOutcomeTrue()
        {
            int numOne = 15;
            int numTwo = 15;

            var numberCheck = Arithmetics1Extension.IsNumber15(numOne);
            var numberCheck2 = Arithmetics1Extension.IsNumber15(numTwo);
            var sumCheck = Arithmetics1Extension.IsNumberSum15(numOne, numTwo);
            var diffCheck = Arithmetics1Extension.IsNumberDiff15(numOne, numTwo);
            var diffCheck2 = Arithmetics1Extension.IsNumberDiff15(numTwo, numOne);
            var taskChecker = Arithmetics1Extension.TaskCheck(numOne, numTwo);

            Assert.AreEqual(true, numberCheck);
            Assert.AreEqual(true, numberCheck2);
            Assert.AreEqual(false, sumCheck);
            Assert.AreEqual(false, diffCheck);
            Assert.AreEqual(false, diffCheck2);
            Assert.AreEqual(true, taskChecker);
        }

        [TestMethod]
        public void TestOutcomeFalse()
        {
            int numOne = 20;
            int numTwo = 40;

            var numberCheck = Arithmetics1Extension.IsNumber15(numOne);
            var numberCheck2 = Arithmetics1Extension.IsNumber15(numTwo);
            var sumCheck = Arithmetics1Extension.IsNumberSum15(numOne, numTwo);
            var diffCheck = Arithmetics1Extension.IsNumberDiff15(numOne, numTwo);
            var diffCheck2 = Arithmetics1Extension.IsNumberDiff15(numTwo, numOne);
            var taskChecker = Arithmetics1Extension.TaskCheck(numOne, numTwo);

            Assert.AreEqual(false, numberCheck);
            Assert.AreEqual(false, numberCheck2);
            Assert.AreEqual(false, sumCheck);
            Assert.AreEqual(false, diffCheck);
            Assert.AreEqual(false, diffCheck2);
            Assert.AreEqual(false, taskChecker);
        }
    }
}
