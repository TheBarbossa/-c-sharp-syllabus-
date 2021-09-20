using System;
using System.Reflection.Metadata;
using CalculateArea;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arithmetics10Tests
{
    [TestClass]
    public class Arithmetics10GeometryTests
    {
        [TestMethod]
        public void Test_Circle_RightCalculus()
        {
            int choice = 1;
            decimal radius = 23.4m;
            var answ = Geometry.areaOfCircle(radius);

            Assert.AreEqual(147.0265361880023,answ);
        }

        [TestMethod]
        public void Test_CircleError_InvalidRadius()
        {
            int choice = 1;
            decimal radius = -28;
            Assert.ThrowsException<ArgumentException>(() => Geometry.areaOfCircle(radius));
        }

        [TestMethod]
        public void Test_Rectangle_RightCalculus()
        {
            int choice = 2;
            decimal length = 234.5m;
            decimal width = 23;
            var answ = Geometry.areaOfRectangle(length,width);

            Assert.AreEqual(5393.5,answ);
        }

        [TestMethod]
        public void Test_RectangleError_InvalidLength()
        {
            int choice = 2;
            decimal length = -666m;
            decimal width = 23;
            Assert.ThrowsException<ArgumentException>(() => Geometry.areaOfRectangle(length, width));
        }

        [TestMethod]
        public void Test_RectangleError_InvalidWidth()
        {
            int choice = 2;
            decimal length = 234.5m;
            decimal width = -2322;
            Assert.ThrowsException<ArgumentException>(() => Geometry.areaOfRectangle(length, width));
        }

        [TestMethod]
        public void Test_Triangle_RightCalculus()
        {
            int choice = 3;
            decimal ground = 23;
            decimal h = 23.4m;
            var answ = Geometry.areaOfTriangle(ground,h);

            Assert.AreEqual(269.1,answ);
        }

        [TestMethod]
        public void Test_TriangleError_InvalidBase()
        {
            int choice = 3;
            decimal ground = 0;
            decimal h = 23.4m;
            Assert.ThrowsException<ArgumentException>(() => Geometry.areaOfTriangle(ground, h));
        }

        [TestMethod]
        public void Test_TriangleError_InvalidHeight()
        {
            int choice = 3;
            decimal ground = 23;
            decimal h = -3;
            Assert.ThrowsException<ArgumentException>(() => Geometry.areaOfTriangle(ground, h));
        }
    }
}
