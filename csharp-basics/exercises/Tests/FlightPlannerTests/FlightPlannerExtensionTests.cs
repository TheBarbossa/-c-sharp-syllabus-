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
        public void TestFileNotFound()
        {
            var fileNotFound = FlightPlannerExtension.FileExists("../flights.txt");
            Assert.AreEqual(false,fileNotFound);
        }

        [TestMethod]
        public void TestCityNotFound()
        {
            var dictionary = new Dictionary<string, List<string>>();
            dictionary.Add("title", new List<string>());
            dictionary["title"].Add("Latvia");
            dictionary["title"].Add("Estonia");
            var cityNotFound = FlightPlannerExtension.VerifyCity(dictionary,"Lithuania");
            Assert.AreEqual(false, cityNotFound);
        }
    }
}
