using System;
using System.Reflection.Metadata;
using Arithmetics10;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arithmetics10Tests
{
    [TestClass]
    public class Arithmetics10GeometryTests
    {
        [TestMethod]
        public void TestCircle()
        {
            int choice = 1;
            decimal radius = 23.4m;
            //Console.WriteLine("\nYou chose 1");
            var answ = Geometry.areaOfCircle(radius);

            Assert.AreEqual(147.0265361880023,answ);
        }

        [TestMethod]
        public void TestCircleError_WrongRadius()
        {
            int choice = 1;
            decimal radius = -28;
            //Console.WriteLine("\nYou chose 1");
            Assert.ThrowsException<ArgumentException>(() => Geometry.areaOfCircle(radius));
        }

        [TestMethod]
        public void TestRectangle()
        {
            int choice = 2;
            decimal length = 234.5m;
            decimal width = 23;
            //Console.WriteLine("\nYou chose 2");
            var answ = Geometry.areaOfRectangle(length,width);

            Assert.AreEqual(5393.5,answ);
        }

        [TestMethod]
        public void TestRectangleError_WrongLength()
        {
            int choice = 2;
            decimal length = -666m;
            decimal width = 23;
            //Console.WriteLine("\nYou chose 2");
            Assert.ThrowsException<ArgumentException>(() => Geometry.areaOfRectangle(length, width));
        }

        [TestMethod]
        public void TestRectangleError_WrongWidth()
        {
            int choice = 2;
            decimal length = 234.5m;
            decimal width = -2322;
            //Console.WriteLine("\nYou chose 2");
            Assert.ThrowsException<ArgumentException>(() => Geometry.areaOfRectangle(length, width));
        }

        [TestMethod]
        public void TestTriangle()
        {
            int choice = 3;
            decimal ground = 23;
            decimal h = 23.4m;
            //Console.WriteLine("\nYou chose 3");
            var answ = Geometry.areaOfTriangle(ground,h);

            Assert.AreEqual(269.1,answ);
        }

        [TestMethod]
        public void TestTriangleError_WrongBase()
        {
            int choice = 3;
            decimal ground = 0;
            decimal h = 23.4m;
            //Console.WriteLine("\nYou chose 3");
            Assert.ThrowsException<ArgumentException>(() => Geometry.areaOfTriangle(ground, h));
        }

        [TestMethod]
        public void TestTriangleError_WrongHeight()
        {
            int choice = 3;
            decimal ground = 23;
            decimal h = -3;
            //Console.WriteLine("\nYou chose 3");
            Assert.ThrowsException<ArgumentException>(() => Geometry.areaOfTriangle(ground, h));
        }
    }
}
