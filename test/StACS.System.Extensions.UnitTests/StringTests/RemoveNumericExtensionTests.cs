using Microsoft.VisualStudio.TestTools.UnitTesting;
using StACS.Core.Exceptions;
using StACS.System.StringExtensions;

namespace StACS.System.Extensions.UnitTests.StringTests
{
    [TestClass]
    public class RemoveNumericExtensionTests
    {
        [TestMethod]
        [ExpectedException(typeof(SourceEmptyOrNullException))]
        public void RemoveNumeric_NullString_Exception()
        {
            // Arrange
            string stringToTest = null;

            // Act
            string actualResults = stringToTest.RemoveNumeric();

            // Assert
            Assert.Fail($"Exception should have been thrown. Actual Results: {actualResults}");
        }

        [TestMethod]
        [ExpectedException(typeof(SourceEmptyOrNullException))]
        public void RemoveNumeric_EmptyString_Exception()
        {
            // Arrange
            string stringToTest = string.Empty;

            // Act
            string actualResults = stringToTest.RemoveNumeric();

            // Assert
            Assert.Fail($"Exception should have been thrown. Actual Results: {actualResults}");
        }

        [TestMethod]
        public void RemoveNumeric_AlphanumericspecialString_AlphaspecialString()
        {
            // Arrange
            string stringToTest = ConstantStringTestData.AlphanumericspecialString;

            // Act
            string actualResult = stringToTest.RemoveNumeric();

            // Assert
            Assert.AreEqual(ConstantStringTestData.AlphaspecialString, actualResult);
        }

        [TestMethod]
        public void RemoveNumeric_AlphanumericStirng_AlphaOnlyString()
        {
            // Arrange
            string stringToTest = ConstantStringTestData.AlphanumericStirng;

            // Act
            string actualResult = stringToTest.RemoveNumeric();

            // Assert
            Assert.AreEqual(ConstantStringTestData.AlphaOnlyString, actualResult);
        }

        [TestMethod]
        public void RemoveNumeric_NumericspecialString_SpecialOnlyString()
        {
            // Arrange
            string stringToTest = ConstantStringTestData.NumericspecialString;

            // Act
            string actualResult = stringToTest.RemoveNumeric();

            // Assert
            Assert.AreEqual(ConstantStringTestData.SpecialOnlyString, actualResult);
        }

        [TestMethod]
        public void RemoveNumeric_NumericOnlyString_EmptyString()
        {
            // Arrange
            string stringToTest = ConstantStringTestData.NumericOnlyString;

            // Act
            string actualResult = stringToTest.RemoveNumeric();

            // Assert
            Assert.AreEqual(ConstantStringTestData.EmptyString, actualResult);
        }
    }
}