using System;
using Arithmetics8;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arithmetics8Tests
{
    [TestClass]
    public class Arithmetics8ExtensionTests
    {
        [TestMethod]
        public void TestTooLittlePay()
        {
            int employee = 1;
            //Console.Write($"Please input employees nr.{i} worked hours: ");
            var hoursEmp = 45;
            //Console.Write($"Please input employees nr.{i} base pay: $");
            var basePayEmp = 3.56;

            var test = Arithmetics8Extension.Employees(employee,basePayEmp,hoursEmp);

            Assert.IsTrue(Arithmetics8Extension.TooLittlePay(basePayEmp));
            Assert.IsFalse(Arithmetics8Extension.TooManyHours(hoursEmp));
            Assert.AreEqual("error, too little pay.\n", test);
        }

        [TestMethod]
        public void TestTooManyHours()
        {
            int employee = 2;
            //Console.Write($"Please input employees nr.{i} worked hours: ");
            var hoursEmp = 90;
            //Console.Write($"Please input employees nr.{i} base pay: $");
            var basePayEmp = 9.80;

            var test = Arithmetics8Extension.Employees(employee, basePayEmp, hoursEmp);

            Assert.IsFalse(Arithmetics8Extension.TooLittlePay(basePayEmp));
            Assert.IsTrue(Arithmetics8Extension.TooManyHours(hoursEmp));
            Assert.AreEqual("error, too many hours.\n",test);
        }

        [TestMethod]
        public void TestBothErrors()
        {
            int employee = 2;
            //Console.Write($"Please input employees nr.{i} worked hours: ");
            var hoursEmp = 90;
            //Console.Write($"Please input employees nr.{i} base pay: $");
            var basePayEmp = 3.80;

            var test = Arithmetics8Extension.Employees(employee, basePayEmp, hoursEmp);

            Assert.IsTrue(Arithmetics8Extension.TooLittlePay(basePayEmp));
            Assert.IsTrue(Arithmetics8Extension.TooManyHours(hoursEmp));
            Assert.AreEqual("error, too many hours.\n", test);
        }

        [TestMethod]
        public void TestOvertime()
        {
            int employee = 3;
            //Console.Write($"Please input employees nr.{i} worked hours: ");
            var hoursEmp = 55;
            //Console.Write($"Please input employees nr.{i} base pay: $");
            var basePayEmp = 9.00;

            var test = Arithmetics8Extension.Employees(employee, basePayEmp, hoursEmp);

            Assert.IsFalse(Arithmetics8Extension.TooLittlePay(basePayEmp));
            Assert.IsFalse(Arithmetics8Extension.TooManyHours(hoursEmp));
            Assert.IsTrue(Arithmetics8Extension.Overtime(hoursEmp));
        }

        [TestMethod]
        public void TestNormalPay()
        {
            int employee = 4;
            //Console.Write($"Please input employees nr.{i} worked hours: ");
            var hoursEmp = 40;
            //Console.Write($"Please input employees nr.{i} base pay: $");
            var basePayEmp = 8.60;

            var test = Arithmetics8Extension.Employees(employee, basePayEmp, hoursEmp);

            Assert.IsFalse(Arithmetics8Extension.TooLittlePay(basePayEmp));
            Assert.IsFalse(Arithmetics8Extension.TooManyHours(hoursEmp));
            Assert.IsFalse(Arithmetics8Extension.Overtime(hoursEmp));
        }
    }
}
