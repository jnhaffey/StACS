using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StACS.Core.Exceptions;
using StACS.System.StringExtensions;

namespace StACS.System.Extensions.UnitTests.StringTests
{
    [TestClass]
    public class RemoveAlphaExtensionTests
    {
        [TestMethod]
        [ExpectedException(typeof(SourceEmptyOrNullException))]
        public void RemoveAlpha_NullString_Exception()
        {
            // Arrange
            string stringToTest = null;

            // Act
            string actualResults = stringToTest.RemoveAlpha();

            // Assert
            Assert.Fail($"Exception should have been thrown. Actual Results: {actualResults}");
        }

        [TestMethod]
        [ExpectedException(typeof(SourceEmptyOrNullException))]
        public void RemoveAlpha_EmptyString_Exception()
        {
            // Arrange
            string stringToTest = string.Empty;

            // Act
            string actualResults = stringToTest.RemoveAlpha();

            // Assert
            Assert.Fail($"Exception should have been thrown. Actual Results: {actualResults}");
        }

        [TestMethod]
        public void RemoveAlpha_AlphanumericspecialString_NumericspecialString()
        {
            // Arrange
            string stringToTest = ConstantStringTestData.AlphanumericspecialString;

            // Act
            string actualResult = stringToTest.RemoveAlpha();

            // Assert
            Assert.AreEqual(ConstantStringTestData.NumericspecialString, actualResult);
        }

        [TestMethod]
        public void RemoveAlpha_AlphanumericStirng_NumericOnlyString()
        {
            // Arrange
            string stringToTest = ConstantStringTestData.AlphanumericStirng;

            // Act
            string actualResult = stringToTest.RemoveAlpha();

            // Assert
            Assert.AreEqual(ConstantStringTestData.NumericOnlyString, actualResult);
        }

        [TestMethod]
        public void RemoveAlpha_AlphaspecialString_SpecialOnlyString()
        {
            // Arrange
            string stringToTest = ConstantStringTestData.AlphaspecialString;

            // Act
            string actualResult = stringToTest.RemoveAlpha();

            // Assert
            Assert.AreEqual(ConstantStringTestData.SpecialOnlyString, actualResult);
        }

        [TestMethod]
        public void RemoveAlpha_AlphaOnlyString_EmptyString()
        {
            // Arrange
            string stringToTest = ConstantStringTestData.AlphaOnlyString;

            // Act
            string actualResult = stringToTest.RemoveAlpha();

            // Assert
            Assert.AreEqual(ConstantStringTestData.EmptyString, actualResult);
        }
    }
}
