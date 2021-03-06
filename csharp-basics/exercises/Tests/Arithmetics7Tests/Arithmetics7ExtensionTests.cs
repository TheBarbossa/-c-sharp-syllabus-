using Arithmetics7;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arithmetics7Tests
{
    [TestClass]
    public class Arithmetics7ExtensionTests
    {
        [TestMethod]
        public void TestFinalPosition()
        {
            // Arrange
            double gravity = -9.81;
            double initialVelocity = 0.0;
            double fallingTime = 10.0;
            double initialPosition = 0.0;

            // Act
            double finalPos = Arithmetics7Extension.FinalPosition(gravity, fallingTime, initialVelocity, initialPosition);

            // Assert
            Assert.AreEqual(-490.5,finalPos);
        }
    }
}
