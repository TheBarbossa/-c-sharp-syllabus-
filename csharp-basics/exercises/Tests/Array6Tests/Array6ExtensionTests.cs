using System;
using System.Linq;
using Arrays6;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Array6Tests
{
    [TestClass]
    public class Array6ExtensionTests
    {
        [TestMethod]
        public void Test_NumbersInArray_RightRange()
        {
            // Arrange
            var rand = new Random();
            int[] numuri1 = new int[]{1,2,3,4,5,6,78,9,10,100};

            // Act
            var _rightRange = Array6Extensions.IsRightRange(numuri1);
            
            //Assert
            Assert.AreEqual(true, _rightRange); // parbauda, vai ir istie skaitli masiva
        }

        [TestMethod]
        public void Test_NumbersInArray_WrongRange()
        {
            // Arrange
            var rand = new Random();
            int[] numuri1 = new int[] { 1, 2, 3, 4, 5, 6, 78, 9, 10, 200 };

            // Act
            var _rightRange = Array6Extensions.IsRightRange(numuri1);

            //Assert
            Assert.AreEqual(false, _rightRange);
        }

        [TestMethod]
        public void Test_NumbersInArray_SameArrays()
        {
            // Arrange
            var rand = new Random();
            int[] numuri1 = new int[] { 1, 2, 3, 4, 5, 6, 78, 9, 10, 100 };
            int[] numuri2 = new int[10];

            // Act
            Array.Copy(numuri1, numuri2, 10);
            var _sameArray = Array6Extensions.IsFirstSecond(numuri1, numuri2);

            //Assert
            Assert.AreEqual(10, numuri1.Length);
            Assert.AreEqual(10, numuri2.Length);
            Assert.AreEqual(true, _sameArray); //parbauda, vai ir tie pasi masivi pirms pedeja indeksa mainas
        }

        [TestMethod]
        public void Test_NumbersInArray_DifferentArrays()
        {
            // Arrange
            var rand = new Random();
            int[] numuri1 = new int[] { 1, 2, 3, 4, 5, 6, 78, 9, 10, 100 };
            int[] numuri2 = new int[] { 1, 2, 3, 4, 5, 6, 78, 9, 10, 99 };

            // Act
            var _sameArray = Array6Extensions.IsFirstSecond(numuri1, numuri2);

            //Assert
            Assert.AreEqual(10, numuri1.Length);
            Assert.AreEqual(10, numuri2.Length);
            Assert.AreEqual(false, _sameArray);
        }

        [TestMethod]
        public void Test_NumbersInArray_LastIndexChange()
        {
            // Arrange
            var rand = new Random();
            int[] numuri1 = new int[] { 1, 2, 3, 4, 5, 6, 78, 9, 10, 100 };

            // Act
            Array6Extensions.LastIndex(numuri1);

            //Assert
            Assert.AreEqual(-7, numuri1[^1]); //parbauda, vai pedejais indeks pirmajam masivam ir -7
        }
    }
}
