using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StACS.Core.Exceptions;
using StACS.System.StringExtensions;

namespace StACS.System.Extensions.UnitTests.StringTests
{
    [TestClass]
    public class IsNumberExtensionTests
    {
        #region Decimal Tests

        [TestMethod]
        public void IsNumeric_Decimal_MaxValue_True()
        {
            // Arrange
            string stringToTest = decimal.MaxValue.ToString();

            // Act
            bool actualResult = stringToTest.IsNumeric();

            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void IsNumeric_Decimal_ZeroValue_True()
        {
            // Arrange
            string stringToTest = new decimal().ToString();

            // Act
            bool actualResult = stringToTest.IsNumeric();

            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void IsNumeric_Decimal_MinValue_True()
        {
            // Arrange
            string stringToTest = decimal.MinValue.ToString();

            // Act
            bool actualResult = stringToTest.IsNumeric();

            // Assert
            Assert.IsTrue(actualResult);
        }

        #endregion

        #region Double Tests

        /// <summary>
        ///     While this should be true it returns false due to a 'old issue' in the double.tryparse / double.parse
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(MaximumDoubleLimitException))]
        public void IsNumeric_Double_MaxValue_Exception()
        {
            // Arrange
            string stringToTest = double.MaxValue.ToString();

            // Act
            bool actualResult = stringToTest.IsNumeric();

            // Assert
            Assert.Fail($"Exception should have been thrown.  Actual Result: {actualResult}");
        }

        [TestMethod]
        public void IsNumeric_Double_ZeroValue_True()
        {
            // Arrange
            string stringToTest = new double().ToString();

            // Act
            bool actualResult = stringToTest.IsNumeric();

            // Assert
            Assert.IsTrue(actualResult);
        }

        /// <summary>
        ///     While this should be true it returns false due to a 'old issue' in the double.tryparse / double.parse
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(MinimumDoubleLimitException))]
        public void IsNumeric_Double_MinValue_Exception()
        {
            // Arrange
            string stringToTest = double.MinValue.ToString();

            // Act
            bool actualResult = stringToTest.IsNumeric();

            // Assert
            Assert.Fail($"Exception should have been thrown.  Actual Result: {actualResult}");
        }

        #endregion

        #region Float Tests

        [TestMethod]
        public void IsNumeric_Float_MaxValue_True()
        {
            // Arrange
            string stringToTest = float.MaxValue.ToString();

            // Act
            bool actualResult = stringToTest.IsNumeric();

            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void IsNumeric_Float_ZeroValue_True()
        {
            // Arrange
            string stringToTest = new float().ToString();

            // Act
            bool actualResult = stringToTest.IsNumeric();

            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void IsNumeric_Float_MinValue_True()
        {
            // Arrange
            string stringToTest = float.MinValue.ToString();

            // Act
            bool actualResult = stringToTest.IsNumeric();

            // Assert
            Assert.IsTrue(actualResult);
        }

        #endregion

        #region AlphaNumeric Tests

        [TestMethod]
        public void IsNumeric_AlphaNumeric_False()
        {
            // Arrange
            string stringToTest = Guid.NewGuid().ToString().Replace("-", "");

            // Act
            bool actualResult = stringToTest.IsNumeric();

            // Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void IsNumeric_AlphaOnly_False()
        {
            // Arrange
            string stringToTest = "Lorem ipsum dolor sit amet consectetuer adipiscing elit Aenean commodo";

            // Act
            bool actualResult = stringToTest.IsNumeric();

            // Assert
            Assert.IsFalse(actualResult);
        }

        #endregion

        #region General String Tests

        [TestMethod]
        [ExpectedException(typeof(SourceEmptyOrNullException))]
        public void IsNumeric_Null_Exception()
        {
            // Arrange
            string stringToTest = null;

            // Act
            bool actualResult = stringToTest.IsNumeric();

            // Assert
            Assert.Fail($"Exception should have been thrown.  Actual Result: {actualResult}");
        }

        [TestMethod]
        [ExpectedException(typeof(SourceEmptyOrNullException))]
        public void IsIsNumeric_Empty_False()
        {
            // Arrange
            string stringToTest = string.Empty;

            // Act
            bool actualResult = stringToTest.IsNumeric();

            // Assert
            Assert.Fail($"Exception should have been thrown.  Actual Result: {actualResult}");
        }

        #endregion

        #region Integer Tests

        [TestMethod]
        public void IsNumeric_Integer_MaxValue_True()
        {
            // Arrange
            string stringToTest = int.MaxValue.ToString();

            // Act
            bool actualResult = stringToTest.IsNumeric();

            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void IsNumeric_Integer_ZeroValue_True()
        {
            // Arrange
            string stringToTest = new int().ToString();

            // Act
            bool actualResult = stringToTest.IsNumeric();

            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void IsNumeric_Integer_MinValue_True()
        {
            // Arrange
            string stringToTest = int.MinValue.ToString();

            // Act
            bool actualResult = stringToTest.IsNumeric();

            // Assert
            Assert.IsTrue(actualResult);
        }

        #endregion

        #region Long Tests

        [TestMethod]
        public void IsNumeric_Long_MaxValue_True()
        {
            // Arrange
            string stringToTest = long.MaxValue.ToString();

            // Act
            bool actualResult = stringToTest.IsNumeric();

            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void IsNumeric_Long_ZeroValue_True()
        {
            // Arrange
            string stringToTest = new long().ToString();

            // Act
            bool actualResult = stringToTest.IsNumeric();

            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void IsNumeric_Long_MinValue_True()
        {
            // Arrange
            string stringToTest = long.MinValue.ToString();

            // Act
            bool actualResult = stringToTest.IsNumeric();

            // Assert
            Assert.IsTrue(actualResult);
        }

        #endregion

        #region Short Tests

        [TestMethod]
        public void IsNumeric_Short_MaxValue_True()
        {
            // Arrange
            string stringToTest = short.MaxValue.ToString();

            // Act
            bool actualResult = stringToTest.IsNumeric();

            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void IsNumeric_Short_ZeroValue_True()
        {
            // Arrange
            string stringToTest = new short().ToString();

            // Act
            bool actualResult = stringToTest.IsNumeric();

            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void IsNumeric_Short_MinValue_True()
        {
            // Arrange
            string stringToTest = short.MinValue.ToString();

            // Act
            bool actualResult = stringToTest.IsNumeric();

            // Assert
            Assert.IsTrue(actualResult);
        }

        #endregion
    }
}
