using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StACS.System.Extensions.UnitTests.DecimalTests
{
    [TestClass]
    public class IsGreaterThanOrEqualDecimalExtensionTests
    {
        [TestMethod]
        public void IsGreaterThanOrEqual_Zero_NegativeOne_True()
        {
            // Arrange
            decimal decimalToTest = new decimal(0.0);

            // Act
            bool actualResult = decimalToTest.IsGreaterThanOrEqual(new decimal(-0.1));

            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void IsGreaterThanOrEqual_Zero_Zero_True()
        {
            // Arrange
            decimal decimalToTest = new decimal(0.0);

            // Act
            bool actualResult = decimalToTest.IsGreaterThanOrEqual(new decimal(0.0));

            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void IsGreaterThanOrEqual_Zero_One_False()
        {
            // Arrange
            decimal decimalToTest = new decimal(0.0);

            // Act
            bool actualResult = decimalToTest.IsGreaterThanOrEqual(new decimal(0.1));

            // Assert
            Assert.IsFalse(actualResult);
        }
    }
}
