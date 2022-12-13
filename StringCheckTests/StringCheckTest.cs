using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using StringCheckLibrary;
using System.Collections.Generic;

namespace StringCheckTests
{
    [TestClass]
    public class StringCheckTest
    {
        //Тест оусских букв
        [TestMethod]
        public void GetLetters_RusLetter_True()
        {
            
            //Arrange
            string text = "Ананас";
            List<char> expected = new List<char> { 'А', 'Н', 'С' };
            //Act
            List<char> actual = StringCheckClass.GetLetters(text);
            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

    }
}
