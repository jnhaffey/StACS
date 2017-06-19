using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StACS.System.Extensions.UnitTests.StringTests
{
    [TestClass]
    public class HasValueExtensionTests
    {
        [TestMethod]
        public void HasValue_NullString_False()
        {
            // Arrange
            string stringToTest = ConstantStringTestData.NullString;

            // Act
            bool actualResult = stringToTest.HasValue();

            // Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void HasValue_EmptyString_False()
        {
            // Arrange
            string stringToTest = ConstantStringTestData.EmptyString;

            // Act
            bool actualResult = stringToTest.HasValue();

            // Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void HasValue_AlphanumericspecialString_True()
        {
            // Arrange
            string stringToTest = ConstantStringTestData.AlphanumericspecialString;

            // Act
            bool actualResult = stringToTest.HasValue();

            // Assert
            Assert.IsTrue(actualResult);
        }
    }
}