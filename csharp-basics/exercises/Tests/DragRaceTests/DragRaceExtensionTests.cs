using System.Collections.Generic;
using DragRace;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragRaceTests
{
    [TestClass]
    public class DragRaceExtensionTests
    {
        [TestMethod]
        public void Test_UseNitro_SpeedUp_ShowResults()
        {
            // Arrange
            var L = new Lexus("RCF", 10);
            var B = new Bmw("M3", 10);
            List<ICar> cars = new List<ICar>() {L, B};

            // Act
            var Lex = L.ShowCurrentSpeed();
            var Beemer = B.ShowCurrentSpeed();
            foreach (var myCars in cars)
            {
                myCars.SpeedUp();
                myCars.SpeedUp();
            }
            B.UseNitrousOxideEngine();
            L.UseNitrousOxideEngine();
            Lex = L.ShowCurrentSpeed();
            Beemer = B.ShowCurrentSpeed();

            // Assert
            Assert.AreEqual(Beemer, "70");
            Assert.AreEqual(Lex, "80");
        }

        [TestMethod]
        public void Test_SpeedUp_SlowDown_ShowResults()
        {
            // Arrange
            var L = new Lexus("RCF", 10);
            var W = new Wolksvagen("Golf-8", 10);
            var B = new Bmw("M3", 10);
            var A = new Audi("A5", 10);
            var F = new Ford("Focus", 10);
            var T = new Tesla("Model-3", 10);

            // Act
            List<ICar> cars = new List<ICar>()
                {L, W, B, A, F, T};

            var Tes = T.ShowCurrentSpeed();
            var Beemer = B.ShowCurrentSpeed();
            var Audi = A.ShowCurrentSpeed();
            var Ford = F.ShowCurrentSpeed();
            var Lex = L.ShowCurrentSpeed();
            var Wolks = W.ShowCurrentSpeed();

            foreach (var myCars in cars)
            {
                myCars.SpeedUp();
                myCars.SpeedUp();
                myCars.SlowDown();
            }

            Tes = T.ShowCurrentSpeed();
            Beemer = B.ShowCurrentSpeed();
            Audi = A.ShowCurrentSpeed();
            Ford = F.ShowCurrentSpeed();
            Lex = L.ShowCurrentSpeed();
            Wolks = W.ShowCurrentSpeed();

            // Assert
            Assert.AreEqual(Wolks, "25");
            Assert.AreEqual(Lex, "45");
            Assert.AreEqual(Tes, "50");
            Assert.AreEqual(Beemer, "30");
            Assert.AreEqual(Audi, "25");
            Assert.AreEqual(Ford, "15");
        }

        [TestMethod]
        public void Test_StartEngine_ShowsRightMessage()
        {
            // Arrange
            var L = new Lexus("RCF", 10);
            var W = new Wolksvagen("Golf-8", 10);
            var B = new Bmw("M3", 10);
            var A = new Audi("A5", 10);
            var F = new Ford("Focus", 10);
            var T = new Tesla("Model-3", 10);

            // Act
            List<ICar> cars = new List<ICar>()
                {L, W, B, A, F, T};

            var Lex = L.StartEngine();
            var Wolks = W.StartEngine();
            var Tes = T.StartEngine();
            var Beemer = B.StartEngine();
            var Audi = A.StartEngine();
            var Ford = F.StartEngine();

            // Assert
            Assert.AreEqual(Lex, "Rrrrrrr.....");
            Assert.AreEqual(Wolks, "Rrrrrrr.....");
            Assert.AreEqual(Tes, "-- silence ---");
            Assert.AreEqual(Beemer, "Rrrrrrr.....");
            Assert.AreEqual(Audi, "Rrrrrrr.....");
            Assert.AreEqual(Ford, "Rrrrrrr.....");
        }

        [TestMethod]
        public void Test_GetNameOfCar()
        {
            // Arrange
            var L = new Lexus("RCF", 10);
            var W = new Wolksvagen("Golf-8", 10);
            var B = new Bmw("M3", 10);
            var A = new Audi("A5", 10);
            var F = new Ford("Focus", 10);
            var T = new Tesla("Model-3", 10);

            // Act
            List<ICar> cars = new List<ICar>()
                {L, W, B, A, F, T};

            var Lex = L._name;
            var Wolks = W._name;
            var Tes = T._name;
            var Beemer = B._name;
            var Audi = A._name;
            var Ford = F._name;

            // Assert
            Assert.AreEqual(Lex, "RCF");
            Assert.AreEqual(Wolks, "Golf-8");
            Assert.AreEqual(Tes, "Model-3");
            Assert.AreEqual(Beemer, "M3");
            Assert.AreEqual(Audi, "A5");
            Assert.AreEqual(Ford, "Focus");
        }
    }
}
