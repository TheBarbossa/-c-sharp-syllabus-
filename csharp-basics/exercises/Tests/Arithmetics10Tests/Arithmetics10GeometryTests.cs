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
        public void Test_Circle_IsRightCalculus()
        {
            // Arrange
            int choice = 1;
            decimal radius = 23.4m;

            // Act
            var calc = Geometry.areaOfCircle(radius);

            // Assert
            Assert.AreEqual(147.0265361880023,calc);
        }

        [TestMethod]
        public void Test_CircleError_IsInvalidRadius()
        {
            // Arrange
            int choice = 1;
            decimal radius = -28;

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => Geometry.areaOfCircle(radius));
        }

        [TestMethod]
        public void Test_Rectangle_IsRightCalculus()
        {
            // Arrange
            int choice = 2;
            decimal length = 234.5m;
            decimal width = 23;

            // Act
            var calc = Geometry.areaOfRectangle(length,width);

            // Assert
            Assert.AreEqual(5393.5,calc);
        }

        [TestMethod]
        public void Test_RectangleError_IsInvalidLength()
        {
            // Arrange
            int choice = 2;
            decimal length = -666m;
            decimal width = 23; ;
            
            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => Geometry.areaOfRectangle(length, width));
        }

        [TestMethod]
        public void Test_RectangleError_IsInvalidWidth()
        {
            // Arrange
            int choice = 2;
            decimal length = 234.5m;
            decimal width = -2322;

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => Geometry.areaOfRectangle(length, width));
        }

        [TestMethod]
        public void Test_Triangle_IsRightCalculus()
        {
            // Arrange
            int choice = 3;
            decimal ground = 23;
            decimal h = 23.4m;

            // Act
            var answ = Geometry.areaOfTriangle(ground,h);

            // Assert
            Assert.AreEqual(269.1,answ);
        }

        [TestMethod]
        public void Test_TriangleError_IsInvalidBase()
        {
            // Arrange
            int choice = 3;
            decimal ground = 0;
            decimal h = 23.4m;

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => Geometry.areaOfTriangle(ground, h));
        }

        [TestMethod]
        public void Test_TriangleError_IsInvalidHeight()
        {
            // Arrange
            int choice = 3;
            decimal ground = 23;
            decimal h = -3;

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => Geometry.areaOfTriangle(ground, h));
        }
    }
}
