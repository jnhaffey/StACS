using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StACS.System.Extensions.UnitTests.DecimalTests
{
    [TestClass]
    public class IsGreaterThanDecimalExtensionTests
    {
        [TestMethod]
        public void IsGreaterThan_Zero_NegativeOne_True()
        {
            // Arrange
            decimal decimalToTest = new decimal(0.0);

            // Act
            bool actualResult = decimalToTest.IsGreaterThan(new decimal(-0.1));

            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void IsGreaterThan_Zero_Zero_False()
        {
            // Arrange
            decimal decimalToTest = new decimal(0.0);

            // Act
            bool actualResult = decimalToTest.IsGreaterThan(new decimal(0.0));

            // Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void IsGreaterThan_Zero_One_False()
        {
            // Arrange
            decimal decimalToTest = new decimal(0.0);

            // Act
            bool actualResult = decimalToTest.IsGreaterThan(new decimal(0.1));

            // Assert
            Assert.IsFalse(actualResult);
        }
    }
}
