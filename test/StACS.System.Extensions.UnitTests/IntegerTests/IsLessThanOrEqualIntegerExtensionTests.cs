using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StACS.System.Extensions.UnitTests.IntegerTests
{
    [TestClass]
    public class IsLessThanOrEqualIntegerExtensionTests
    {
        [TestMethod]
        public void IsLessThanOrEqual_Zero_NegativeOne_False()
        {
            // Arrange
            int integerToTest = 0;

            // Act
            bool actualResult = integerToTest.IsLessThanOrEqual(-1);

            // Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void IsLessThanOrEqual_Zero_Zero_True()
        {
            // Arrange
            int integerToTest = 0;

            // Act
            bool actualResult = integerToTest.IsLessThanOrEqual(0);

            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void IsLessThanOrEqual_Zero_One_True()
        {
            // Arrange
            int integerToTest = 0;

            // Act
            bool actualResult = integerToTest.IsLessThanOrEqual(1);

            // Assert
            Assert.IsTrue(actualResult);
        }
    }
}
