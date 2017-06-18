using Microsoft.VisualStudio.TestTools.UnitTesting;
using StACS.System.StringExtensions;
using System;
using StACS.Core.Exceptions;

namespace StACS.System.Extensions.UnitTests.StringTests
{
    [TestClass]
    public class IsGuidExtensionTests
    {
        private Guid _guidToTest = Guid.NewGuid();

        [TestMethod]
        public void IsGuid_GuidFormatN_True()
        {
            // Arrange
            string guidString = _guidToTest.ToString("N");

            // Act
            bool actualResult = guidString.IsGuid();

            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void IsGuid_GuidFormatD_True()
        {
            // Arrange
            string guidString = _guidToTest.ToString("D");

            // Act
            bool actualResult = guidString.IsGuid();

            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void IsGuid_GuidFormatB_True()
        {
            // Arrange
            string guidString = _guidToTest.ToString("B");

            // Act
            bool actualResult = guidString.IsGuid();

            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void IsGuid_GuidFormatP_True()
        {
            // Arrange
            string guidString = _guidToTest.ToString("P");

            // Act
            bool actualResult = guidString.IsGuid();

            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void IsGuid_DoubleLengthGuid_False()
        {
            // Arrange
            string guidString = Guid.NewGuid().ToString("D") + Guid.NewGuid().ToString("D");

            // Act
            var actualResult = guidString.IsGuid();

            // Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void IsGuid_ShortGuid_False()
        {
            // Arrange
            string guidString = Guid.NewGuid().ToString("D").Substring(0,5);

            // Act
            var actualResult = guidString.IsGuid();

            // Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(SourceEmptyOrNullException))]
        public void IsGuid_NullGuid_Exception()
        {
            // Arrange
            string guidString = null;

            // Act
            bool actualResult = guidString.IsGuid();

            // Assert
            Assert.Fail($"Exception should have been thrown.  Actual Result: {actualResult}");
        }
    }
}