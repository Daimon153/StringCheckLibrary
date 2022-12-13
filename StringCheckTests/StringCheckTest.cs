using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using StringCheckLibrary;
using System.Collections.Generic;

namespace StringCheckTests
{
    [TestClass]
    public class StringCheckTest
    {
        [TestMethod]
        public void StringCheckMethod()
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
