using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StACS.System.Extensions.UnitTests.StringTests
{
    [TestClass]
    public class HasValueExtensionTests
    {
        [TestMethod]
        public void HasValue_EmptyString_False()
        {
            // Arrange
            string test = string.Empty;

            // Act
            bool actualResult = test.HasValue();

            // Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void HasValue_StringWithValue_True()
        {
            // Arrange
            string test = "Test String";

            // Act
            bool actualResult = test.HasValue();

            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void HasValue_NullString_False()
        {
            // Arrange
            string test = null;

            // Act
            bool actualResult = test.HasValue();

            // Assert
            Assert.IsFalse(actualResult);
        }
    }
}