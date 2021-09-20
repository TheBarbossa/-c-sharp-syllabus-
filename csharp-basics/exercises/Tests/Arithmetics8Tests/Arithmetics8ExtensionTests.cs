using System;
using Arithmetics8;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arithmetics8Tests
{
    [TestClass]
    public class Arithmetics8ExtensionTests
    {
        [TestMethod]
        public void Test_IsPayEnough()
        {
            int employeeNr = 1;
            var hoursEmp = 45;
            var basePayEmp = 3.56;

            var test = Arithmetics8Extension.Employees(employeeNr,basePayEmp,hoursEmp);

            Assert.IsTrue(Arithmetics8Extension.TooLittlePay(basePayEmp));
            Assert.IsFalse(Arithmetics8Extension.TooManyHours(hoursEmp));
            Assert.AreEqual("error, too little pay.\n", test);
        }

        [TestMethod]
        public void Test_IsHoursTooMany()
        {
            int employeeNr = 2;
            var hoursEmp = 90;
            var basePayEmp = 9.80;

            var test = Arithmetics8Extension.Employees(employeeNr, basePayEmp, hoursEmp);

            Assert.IsFalse(Arithmetics8Extension.TooLittlePay(basePayEmp));
            Assert.IsTrue(Arithmetics8Extension.TooManyHours(hoursEmp));
            Assert.AreEqual("error, too many hours.\n",test);
        }

        [TestMethod]
        public void Test_IsBothErrors_PrintFirstErrorMessage()
        {
            int employeeNr = 2;
            var hoursEmp = 90;
            var basePayEmp = 3.80;

            var test = Arithmetics8Extension.Employees(employeeNr, basePayEmp, hoursEmp);

            Assert.IsTrue(Arithmetics8Extension.TooLittlePay(basePayEmp));
            Assert.IsTrue(Arithmetics8Extension.TooManyHours(hoursEmp));
            Assert.AreEqual("error, too many hours.\n", test);
        }

        [TestMethod]
        public void Test_IsOvertime()
        {
            int employeeNr = 3;
            var hoursEmp = 55;
            var basePayEmp = 9.00;

            var test = Arithmetics8Extension.Employees(employeeNr, basePayEmp, hoursEmp);

            Assert.IsFalse(Arithmetics8Extension.TooLittlePay(basePayEmp));
            Assert.IsFalse(Arithmetics8Extension.TooManyHours(hoursEmp));
            Assert.IsTrue(Arithmetics8Extension.Overtime(hoursEmp));
        }

        [TestMethod]
        public void Test_NormalPay()
        {
            int employeeNr = 4;
            var hoursEmp = 40;
            var basePayEmp = 8.60;

            var test = Arithmetics8Extension.Employees(employeeNr, basePayEmp, hoursEmp);

            Assert.IsFalse(Arithmetics8Extension.TooLittlePay(basePayEmp));
            Assert.IsFalse(Arithmetics8Extension.TooManyHours(hoursEmp));
            Assert.IsFalse(Arithmetics8Extension.Overtime(hoursEmp));
        }
    }
}
