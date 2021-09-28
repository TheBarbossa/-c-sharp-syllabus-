using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCount;

namespace WordCountTests
{
    [TestClass]
    public class WordCountExtensionTests
    {
        [TestMethod]
        public void Test_IsFileNotFound()
        {
            // Arrange
            var fileNotFound = WordCountExtension.FileExists("../lear.txt");

            // Act and Assert
            Assert.AreEqual(false, fileNotFound);
        }

        [TestMethod]
        public void Test_ManySpaces_IsTwoWords()
        {
            // Arrange
            int WordCount, index;
            WordCount = index = 0;
            string readText = "Dummy                  test";

            // Act
            while (index < readText.Length)
            {
                while (index < readText.Length && !WordCountExtension.WhiteSpace(readText, index))
                    index++;

                WordCount++;

                while (index < readText.Length && WordCountExtension.WhiteSpace(readText, index))
                    index++;
            }
           
            // Assert
            Assert.AreEqual(WordCount,2);
        }

        [TestMethod]
        public void Test_ManySpacesAndSlashes_IsTwoWords()
        {
            // Arrange
            int WordCount, index;
            WordCount = index = 0;
            string readText = "Dummy\\  test";

            // Act
            while (index < readText.Length)
            {
                int letterCount = 0;
                while (index < readText.Length && !WordCountExtension.WhiteSpace(readText, index) && !WordCountExtension.Slash(readText, index))
                {
                    letterCount++;
                    index++;
                }
                    
                if (letterCount>0) WordCount++;

                while (index < readText.Length && WordCountExtension.Slash(readText, index) || index < readText.Length && WordCountExtension.WhiteSpace(readText, index))
                    index++;
            }
            
            // Assert
            Assert.AreEqual(WordCount, 2);
        }
    }
}
