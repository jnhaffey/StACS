using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StACS.System.Extensions.UnitTests.IntegerTests
{
    [TestClass]
    public class IsGreaterThanIntegerExtensionTests
    {
        [TestMethod]
        public void IsGreaterThan_Zero_NegativeOne_True()
        {
            // Arrange
            int integerToTest = 0;

            // Act
            bool actualResult = integerToTest.IsGreaterThan(-1);

            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void IsGreaterThan_Zero_Zero_False()
        {
            // Arrange
            int integerToTest = 0;

            // Act
            bool actualResult = integerToTest.IsGreaterThan(0);

            // Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void IsGreaterThan_Zero_One_False()
        {
            // Arrange
            int integerToTest = 0;

            // Act
            bool actualResult = integerToTest.IsGreaterThan(1);

            // Assert
            Assert.IsFalse(actualResult);
        }
    }
}
