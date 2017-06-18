using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StACS.System.Extensions.UnitTests.IntegerTests
{
    [TestClass]
    public class IsOddExtensionTests
    {
        [TestMethod]
        public void IsOdd_NegativeTwo_False()
        {
            // Arrange
            var intToTest = -2;

            // Act
            var actualResult = intToTest.IsOdd();

            // Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void IsOdd_NegativeOne_True()
        {
            // Arrange
            var intToTest = -1;

            // Act
            var actualResult = intToTest.IsOdd();

            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void IsOdd_Zero_False()
        {
            // Arrange
            var intToTest = 0;

            // Act
            var actualResult = intToTest.IsOdd();

            // Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void IsOdd_One_True()
        {
            // Arrange
            var intToTest = 1;

            // Act
            var actualResult = intToTest.IsOdd();

            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void IsOdd_Two_False()
        {
            // Arrange
            var intToTest = 2;

            // Act
            var actualResult = intToTest.IsOdd();

            // Assert
            Assert.IsFalse(actualResult);
        }
    }
}
