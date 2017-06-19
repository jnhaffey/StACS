using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StACS.Core.Exceptions;
using StACS.System.StringExtensions;

namespace StACS.System.Extensions.UnitTests.StringTests
{
    [TestClass]
    public class RemoveNonAlphaNumericExtensionTests
    {
        [TestMethod]
        [ExpectedException(typeof(SourceEmptyOrNullException))]
        public void RemoveNonAlphaNumeric_NullString_Exception()
        {
            // Arrange
            string stringToTest = null;

            // Act
            string actualResults = stringToTest.RemoveNonAlphaNumeric();

            // Assert
            Assert.Fail($"Exception should have been thrown. Actual Results: {actualResults}");
        }

        [TestMethod]
        [ExpectedException(typeof(SourceEmptyOrNullException))]
        public void RemoveNonAlphaNumeric_EmptyString_Exception()
        {
            // Arrange
            string stringToTest = string.Empty;

            // Act
            string actualResults = stringToTest.RemoveNonAlphaNumeric();

            // Assert
            Assert.Fail($"Exception should have been thrown. Actual Results: {actualResults}");
        }

        [TestMethod]
        public void RemoveNonAlphaNumeric_AlphanumericspecialString_AlphanumericStirng()
        {
            // Arrange
            string stringToTest = ConstantStringTestData.AlphanumericspecialString;

            // Act
            string actualResult = stringToTest.RemoveNonAlphaNumeric();

            // Assert
            Assert.AreEqual(ConstantStringTestData.AlphanumericStirng, actualResult);
        }

        [TestMethod]
        public void RemoveNonAlphaNumeric_AlphaspecialString_AlphaOnlyString()
        {
            // Arrange
            string stringToTest = ConstantStringTestData.AlphaspecialString;

            // Act
            string actualResult = stringToTest.RemoveNonAlphaNumeric();

            // Assert
            Assert.AreEqual(ConstantStringTestData.AlphaOnlyString, actualResult);
        }

        [TestMethod]
        public void RemoveNonAlphaNumeric_NumericspecialString_NumericOnlyString()
        {
            // Arrange
            string stringToTest = ConstantStringTestData.NumericspecialString;

            // Act
            string actualResult = stringToTest.RemoveNonAlphaNumeric();

            // Assert
            Assert.AreEqual(ConstantStringTestData.NumericOnlyString, actualResult);
        }

        [TestMethod]
        public void RemoveNonAlphaNumeric_SpecialOnlyString_EmptyString()
        {
            // Arrange
            string stringToTest = ConstantStringTestData.SpecialOnlyString;

            // Act
            string actualResult = stringToTest.RemoveNonAlphaNumeric();

            // Assert
            Assert.AreEqual(ConstantStringTestData.EmptyString, actualResult);
        }
    }
}
