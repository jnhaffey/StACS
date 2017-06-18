using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StACS.System.Extensions.UnitTests.DecimalTests
{
    [TestClass]
    public class IsLessThanDecimalExtensionTests
    {
        [TestMethod]
        public void IsLessThan_Zero_NegativeOne_False()
        {
            // Arrange
            decimal decimalToTest = new decimal(0.0);

            // Act
            bool actualResult = decimalToTest.IsLessThan(new decimal(-0.1));

            // Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void IsLessThan_Zero_Zero_False()
        {
            // Arrange
            decimal decimalToTest = new decimal(0.0);

            // Act
            bool actualResult = decimalToTest.IsLessThan(new decimal(0.0));

            // Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void IsLessThan_Zero_One_True()
        {
            // Arrange
            decimal decimalToTest = new decimal(0.0);

            // Act
            bool actualResult = decimalToTest.IsLessThan(new decimal(0.1));

            // Assert
            Assert.IsTrue(actualResult);
        }
    }
}
