using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StACS.System.Extensions.UnitTests.IntegerTests
{
    [TestClass]
    public class IsLessThanIntegerExtensionTests
    {
        [TestMethod]
        public void IsLessThan_Zero_NegativeOne_False()
        {
            // Arrange
            int integerToTest = 0;

            // Act
            bool actualResult = integerToTest.IsLessThan(-1);

            // Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void IsLessThan_Zero_Zero_False()
        {
            // Arrange
            int integerToTest = 0;

            // Act
            bool actualResult = integerToTest.IsLessThan(0);

            // Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void IsLessThan_Zero_One_True()
        {
            // Arrange
            int integerToTest = 0;

            // Act
            bool actualResult = integerToTest.IsLessThan(1);

            // Assert
            Assert.IsTrue(actualResult);
        }
    }
}
