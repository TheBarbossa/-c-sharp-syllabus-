using System.Collections.Generic;
using System.IO;
using FlightPlanner;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlightPlannerTests
{
    [TestClass]
    public class FlightPlannerExtensionTests
    {
        [TestMethod]
        public void Test_IsFileNotFound()
        {
            // Arrange
            var fileNotFound = FlightPlannerExtension.FileExists("../flights.txt");

            // Act and Assert
            Assert.AreEqual(false,fileNotFound);
        }

        [TestMethod]
        public void Test_IsCityNotFound()
        {
            // Arrange
            var dictionary = new Dictionary<string, List<string>>();
            dictionary.Add("title", new List<string>());
            dictionary["title"].Add("Latvia");
            dictionary["title"].Add("Estonia");

            // Act
            var cityNotFound = FlightPlannerExtension.VerifyCity(dictionary,"Lithuania");

            // Assert
            Assert.AreEqual(false, cityNotFound);
        }
    }
}
