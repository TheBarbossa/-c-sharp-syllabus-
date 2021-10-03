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
            // Arrange
            int employeeNr = 1;
            var hoursEmp = 45;
            var basePayEmp = 3.56;

            // Act
            var test = Arithmetics8Extension.Employees(employeeNr,basePayEmp,hoursEmp);

            // Assert
            Assert.IsTrue(Arithmetics8Extension.IsPayEnough(basePayEmp));
            Assert.IsFalse(Arithmetics8Extension.IsHoursTooMany(hoursEmp));
            Assert.AreEqual("error, too little pay.\n", test);
        }

        [TestMethod]
        public void Test_IsHoursTooMany()
        {
            // Arrange
            int employeeNr = 2;
            var hoursEmp = 90;
            var basePayEmp = 9.80;

            // Act
            var test = Arithmetics8Extension.Employees(employeeNr, basePayEmp, hoursEmp);

            // Assert
            Assert.IsFalse(Arithmetics8Extension.IsPayEnough(basePayEmp));
            Assert.IsTrue(Arithmetics8Extension.IsHoursTooMany(hoursEmp));
            Assert.AreEqual("error, too many hours.\n",test);
        }

        [TestMethod]
        public void Test_IsBothErrors_PrintFirstErrorMessage()
        {
            // Arrange
            int employeeNr = 2;
            var hoursEmp = 90;
            var basePayEmp = 3.80;

            // Act
            var test = Arithmetics8Extension.Employees(employeeNr, basePayEmp, hoursEmp);

            // Assert
            Assert.IsTrue(Arithmetics8Extension.IsPayEnough(basePayEmp));
            Assert.IsTrue(Arithmetics8Extension.IsHoursTooMany(hoursEmp));
            Assert.AreEqual("error, too many hours.\n", test);
        }

        [TestMethod]
        public void Test_IsOvertime()
        {
            // Arrange
            int employeeNr = 3;
            var hoursEmp = 55;
            var basePayEmp = 9.00;

            // Act
            var test = Arithmetics8Extension.Employees(employeeNr, basePayEmp, hoursEmp);

            // Assert
            Assert.IsFalse(Arithmetics8Extension.IsPayEnough(basePayEmp));
            Assert.IsFalse(Arithmetics8Extension.IsHoursTooMany(hoursEmp));
            Assert.IsTrue(Arithmetics8Extension.IsOvertime(hoursEmp));
        }

        [TestMethod]
        public void Test_IsNormalPay()
        {
            // Arrange
            int employeeNr = 4;
            var hoursEmp = 40;
            var basePayEmp = 8.60;

            // Act
            var test = Arithmetics8Extension.Employees(employeeNr, basePayEmp, hoursEmp);

            // Assert
            Assert.IsFalse(Arithmetics8Extension.IsPayEnough(basePayEmp));
            Assert.IsFalse(Arithmetics8Extension.IsHoursTooMany(hoursEmp));
            Assert.IsFalse(Arithmetics8Extension.IsOvertime(hoursEmp));
        }
    }
}
