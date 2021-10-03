using Arithmetics6;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arithmetics6Tests
{
    [TestClass]
    public class Arithmetics6ExtensionTests
    {
        [TestMethod]
        public void Test_IsPrintNumber()
        {
            // Arrange
            int i = 1;
            string eachForLoop = "";

            // Act
            eachForLoop += Arithmetics6Extension.PrintNumber(i);
            eachForLoop += Arithmetics6Extension.PrintCoza(i);
            eachForLoop += Arithmetics6Extension.PrintLoza(i);
            eachForLoop += Arithmetics6Extension.PrintWoza(i);
            
            // Assert
            Assert.AreEqual("1",eachForLoop);
        }
        [TestMethod]
        public void Test_IsPrintCoza()
        {
            // Arrange
            int i = 3;
            string eachForLoop = "";

            // Act
            eachForLoop += Arithmetics6Extension.PrintNumber(i);
            eachForLoop += Arithmetics6Extension.PrintCoza(i);
            eachForLoop += Arithmetics6Extension.PrintLoza(i);
            eachForLoop += Arithmetics6Extension.PrintWoza(i);

            // Assert
            Assert.AreEqual("Coza", eachForLoop);
        }
        [TestMethod]
        public void Test_IsPrintLoza()
        {
            // Arrange
            int i = 25;
            string eachForLoop = "";

            // Act
            eachForLoop += Arithmetics6Extension.PrintNumber(i);
            eachForLoop += Arithmetics6Extension.PrintCoza(i);
            eachForLoop += Arithmetics6Extension.PrintLoza(i);
            eachForLoop += Arithmetics6Extension.PrintWoza(i);

            // Assert
            Assert.AreEqual("Loza", eachForLoop);
        }
        [TestMethod]
        public void Test_IsPrintWoza()
        {
            // Arrange
            int i = 14;
            string eachForLoop = "";

            // Act
            eachForLoop += Arithmetics6Extension.PrintNumber(i);
            eachForLoop += Arithmetics6Extension.PrintCoza(i);
            eachForLoop += Arithmetics6Extension.PrintLoza(i);
            eachForLoop += Arithmetics6Extension.PrintWoza(i);

            // Assert
            Assert.AreEqual("Woza", eachForLoop);
        }
        [TestMethod]
        public void Test_IsPrintCozaLozaWoza()
        {
            // Arrange
            int i = 105;
            string eachForLoop = "";

            // Act
            eachForLoop += Arithmetics6Extension.PrintNumber(i);
            eachForLoop += Arithmetics6Extension.PrintCoza(i);
            eachForLoop += Arithmetics6Extension.PrintLoza(i);
            eachForLoop += Arithmetics6Extension.PrintWoza(i);

            // Assert
            Assert.AreEqual("CozaLozaWoza", eachForLoop);
        }
    }
}