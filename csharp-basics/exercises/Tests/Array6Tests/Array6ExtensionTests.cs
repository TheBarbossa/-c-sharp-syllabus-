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
        public void TestMethod1()
        {
            var rand = new Random();
            int[] numuri1 = new int[10];
            int[] numuri2 = new int[10];
            for (int i = 0; i < numuri1.Length; i++)
            {
                numuri1[i] = rand.Next(1, 101);
            }
            Array.Copy(numuri1, numuri2, 10);

            var _rightRange = Array6Extensions.RightRange(numuri1);
            var _sameArray = Array6Extensions.FirstIsSecond(numuri1, numuri2);
            Array6Extensions.LastIndex(numuri1);

            Assert.AreEqual(10, numuri1.Length);
            Assert.AreEqual(10, numuri2.Length);
            Assert.AreEqual(true, _rightRange); //parbauda, vai ir istie skaitli masiva
            Assert.AreEqual(true, _sameArray); //parbauda, vai ir tie pasi masivi pirms pedeja indeksa mainas
            Assert.AreEqual(-7, numuri1[^1]); //parbauda, vai pedejais indeks pirmajam masivam ir -7
        }
    }
}
