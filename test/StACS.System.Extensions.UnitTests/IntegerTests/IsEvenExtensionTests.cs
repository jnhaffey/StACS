using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StACS.System.Extensions.UnitTests.IntegerTests
{
    [TestClass]
    public class IsEvenExtensionTests
    {
        [TestMethod]
        public void IsEven_NegativeTwo_True()
        {
            // Arrange
            var intToTest = -2;

            // Act
            var actualResult = intToTest.IsEven();

            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void IsEven_NegativeOne_False()
        {
            // Arrange
            var intToTest = -1;

            // Act
            var actualResult = intToTest.IsEven();

            // Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void IsEven_Zero_True()
        {
            // Arrange
            var intToTest = 0;

            // Act
            var actualResult = intToTest.IsEven();

            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void IsEven_One_False()
        {
            // Arrange
            var intToTest = 1;

            // Act
            var actualResult = intToTest.IsEven();

            // Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void IsEven_Two_True()
        {
            // Arrange
            var intToTest = 2;

            // Act
            var actualResult = intToTest.IsEven();

            // Assert
            Assert.IsTrue(actualResult);
        }
    }
}
