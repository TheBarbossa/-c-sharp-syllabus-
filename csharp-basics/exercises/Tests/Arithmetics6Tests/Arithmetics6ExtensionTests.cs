using Arithmetics6;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arithmetics6Tests
{
    [TestClass]
    public class Arithmetics6ExtensionTests
    {
        [TestMethod]
        public void TestPrintNumber()
        {
            int i = 1;
            string eachForLoop = "";
            eachForLoop += Arithmetics6Extension.PrintNumber(i);
            eachForLoop += Arithmetics6Extension.PrintCoza(i);
            eachForLoop += Arithmetics6Extension.PrintLoza(i);
            eachForLoop += Arithmetics6Extension.PrintWoza(i);
            
        Assert.AreEqual("1",eachForLoop);
        }
        [TestMethod]
        public void TestPrintCoza()
        {
            int i = 3;
            string eachForLoop = "";
            eachForLoop += Arithmetics6Extension.PrintNumber(i);
            eachForLoop += Arithmetics6Extension.PrintCoza(i);
            eachForLoop += Arithmetics6Extension.PrintLoza(i);
            eachForLoop += Arithmetics6Extension.PrintWoza(i);

            Assert.AreEqual("Coza", eachForLoop);
        }
        [TestMethod]
        public void TestPrintLoza()
        {
            int i = 25;
            string eachForLoop = "";
            eachForLoop += Arithmetics6Extension.PrintNumber(i);
            eachForLoop += Arithmetics6Extension.PrintCoza(i);
            eachForLoop += Arithmetics6Extension.PrintLoza(i);
            eachForLoop += Arithmetics6Extension.PrintWoza(i);

            Assert.AreEqual("Loza", eachForLoop);
        }
        [TestMethod]
        public void TestPrintWoza()
        {
            int i = 14;
            string eachForLoop = "";
            eachForLoop += Arithmetics6Extension.PrintNumber(i);
            eachForLoop += Arithmetics6Extension.PrintCoza(i);
            eachForLoop += Arithmetics6Extension.PrintLoza(i);
            eachForLoop += Arithmetics6Extension.PrintWoza(i);

            Assert.AreEqual("Woza", eachForLoop);
        }
        [TestMethod]
        public void TestPrintCozaLozaWoza()
        {
            int i = 105;
            string eachForLoop = "";
            eachForLoop += Arithmetics6Extension.PrintNumber(i);
            eachForLoop += Arithmetics6Extension.PrintCoza(i);
            eachForLoop += Arithmetics6Extension.PrintLoza(i);
            eachForLoop += Arithmetics6Extension.PrintWoza(i);

            Assert.AreEqual("CozaLozaWoza", eachForLoop);
        }
    }
}