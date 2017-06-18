using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StACS.System.Extensions.UnitTests.IntegerTests
{
    [TestClass]
    public class IsGreaterThanOrEqualIntegerExtensionTests
    {
        [TestMethod]
        public void IsGreaterThanOrEqual_Zero_NegativeOne_True()
        {
            // Arrange
            int integerToTest = 0;

            // Act
            bool actualResult = integerToTest.IsGreaterThanOrEqual(-1);

            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void IsGreaterThanOrEqual_Zero_Zero_True()
        {
            // Arrange
            int integerToTest = 0;

            // Act
            bool actualResult = integerToTest.IsGreaterThanOrEqual(0);

            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void IsGreaterThanOrEqual_Zero_One_False()
        {
            // Arrange
            int integerToTest = 0;

            // Act
            bool actualResult = integerToTest.IsGreaterThanOrEqual(1);

            // Assert
            Assert.IsFalse(actualResult);
        }
    }
}
