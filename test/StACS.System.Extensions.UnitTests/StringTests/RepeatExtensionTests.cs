using Microsoft.VisualStudio.TestTools.UnitTesting;
using StACS.Core.Exceptions;
using System;
using StACS.System.StringExtensions;

namespace StACS.System.Extensions.UnitTests.StringTests
{
    [TestClass]
    public class RepeatExtensionTests
    {
        [TestMethod]
        [ExpectedException(typeof(SourceEmptyOrNullException))]
        public void Repeat_NullString_RepeatTen_Exception()
        {
            // Arrange
            string stringToTest = null;

            // Act
            string actualResults = stringToTest.Repeat(10);

            // Assert
            Assert.Fail($"Exception should have been thrown. Actual Results: {actualResults}");
        }

        [TestMethod]
        [ExpectedException(typeof(SourceEmptyOrNullException))]
        public void Repeat_EmptyString_RepeatTen_Exception()
        {
            // Arrange
            string stringToTest = string.Empty;

            // Act
            string actualResults = stringToTest.Repeat(10);

            // Assert
            Assert.Fail($"Exception should have been thrown. Actual Results: {actualResults}");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Repeat_TestString_RepeatZero_Exception()
        {
            // Arrange
            string stringToTest = "TestString";

            // Act
            string actualResults = stringToTest.Repeat(0);

            // Assert
            Assert.Fail($"Exception should have been thrown. Actual Results: {actualResults}");
        }

        [TestMethod]
        public void Repeat_TestString_RepeatTen_TestStringTimesTen()
        {
            // Arrange
            string stringToTest = "TestString";
            string expectedResults = "TestStringTestStringTestStringTestStringTestStringTestStringTestStringTestStringTestStringTestString";

            // Act
            string actualResults = stringToTest.Repeat(10);

            // Assert
            Assert.AreEqual(expectedResults, actualResults);
        }
    }
}