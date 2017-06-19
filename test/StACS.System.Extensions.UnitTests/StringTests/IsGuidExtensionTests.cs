using Microsoft.VisualStudio.TestTools.UnitTesting;
using StACS.System.StringExtensions;
using System;
using StACS.Core.Exceptions;

namespace StACS.System.Extensions.UnitTests.StringTests
{
    [TestClass]
    public class IsGuidExtensionTests
    {
        [TestMethod]
        public void IsGuid_GuidFormatN_True()
        {
            // Arrange
            string guidString = ConstantStringTestData.GuidFormatN;

            // Act
            bool actualResult = guidString.IsGuid();

            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void IsGuid_GuidFormatD_True()
        {
            // Arrange
            string guidString = ConstantStringTestData.GuidFormatD;

            // Act
            bool actualResult = guidString.IsGuid();

            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void IsGuid_GuidFormatB_True()
        {
            // Arrange
            string guidString = ConstantStringTestData.GuidFormatB;

            // Act
            bool actualResult = guidString.IsGuid();

            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void IsGuid_GuidFormatP_True()
        {
            // Arrange
            string guidString = ConstantStringTestData.GuidFormatP;

            // Act
            bool actualResult = guidString.IsGuid();

            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void IsGuid_AlphanumericStirng_False()
        {
            // Arrange
            string guidString = ConstantStringTestData.AlphanumericStirng;

            // Act
            var actualResult = guidString.IsGuid();

            // Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(SourceEmptyOrNullException))]
        public void IsGuid_NullString_Exception()
        {
            // Arrange
            string guidString = ConstantStringTestData.NullString;

            // Act
            bool actualResult = guidString.IsGuid();

            // Assert
            Assert.Fail($"Exception should have been thrown.  Actual Result: {actualResult}");
        }

        [TestMethod]
        [ExpectedException(typeof(SourceEmptyOrNullException))]
        public void IsGuid_EmptyString_Exception()
        {
            // Arrange
            string guidString = ConstantStringTestData.EmptyString;

            // Act
            bool actualResult = guidString.IsGuid();

            // Assert
            Assert.Fail($"Exception should have been thrown.  Actual Result: {actualResult}");
        }
    }
}