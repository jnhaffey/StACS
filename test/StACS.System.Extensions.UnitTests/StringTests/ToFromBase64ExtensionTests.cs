using Microsoft.VisualStudio.TestTools.UnitTesting;
using StACS.Core.Exceptions;
using StACS.System.Extensions.String;
using System.Text;

namespace StACS.System.Extensions.UnitTests.StringTests
{
    [TestClass]
    public class ToFromBase64ExtensionTests
    {
        private string _baseString;
        private string _asciiBase64String;
        private string _utf7Base64String;
        private string _utf8Base64String;
        private string _utf32Base64String;
        private string _unicodeBase64String;

        [TestInitialize]
        public void TestSetup()
        {
            _baseString = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo";
            //Console.WriteLine($"BaseString => {_baseString}");
            _asciiBase64String = "TG9yZW0gaXBzdW0gZG9sb3Igc2l0IGFtZXQsIGNvbnNlY3RldHVlciBhZGlwaXNjaW5nIGVsaXQuIEFlbmVhbiBjb21tb2Rv";
            //Console.WriteLine($"AsciiBase64String => {_asciiBase64String}");
            _utf7Base64String = "TG9yZW0gaXBzdW0gZG9sb3Igc2l0IGFtZXQsIGNvbnNlY3RldHVlciBhZGlwaXNjaW5nIGVsaXQuIEFlbmVhbiBjb21tb2Rv";
            //Console.WriteLine($"Utf7Base64String => {_utf7Base64String}");
            _utf8Base64String = "TG9yZW0gaXBzdW0gZG9sb3Igc2l0IGFtZXQsIGNvbnNlY3RldHVlciBhZGlwaXNjaW5nIGVsaXQuIEFlbmVhbiBjb21tb2Rv";
            //Console.WriteLine($"Utf8Base64String => {_utf8Base64String}");
            _utf32Base64String = "TAAAAG8AAAByAAAAZQAAAG0AAAAgAAAAaQAAAHAAAABzAAAAdQAAAG0AAAAgAAAAZAAAAG8AAABsAAAAbwAAAHIAAAAgAAAAcwAAAGkAAAB0AAAAIAAAAGEAAABtAAAAZQAAAHQAAAAsAAAAIAAAAGMAAABvAAAAbgAAAHMAAABlAAAAYwAAAHQAAABlAAAAdAAAAHUAAABlAAAAcgAAACAAAABhAAAAZAAAAGkAAABwAAAAaQAAAHMAAABjAAAAaQAAAG4AAABnAAAAIAAAAGUAAABsAAAAaQAAAHQAAAAuAAAAIAAAAEEAAABlAAAAbgAAAGUAAABhAAAAbgAAACAAAABjAAAAbwAAAG0AAABtAAAAbwAAAGQAAABvAAAA";
            //Console.WriteLine($"Utf32Base64String => {_utf32Base64String}");
            _unicodeBase64String = "TABvAHIAZQBtACAAaQBwAHMAdQBtACAAZABvAGwAbwByACAAcwBpAHQAIABhAG0AZQB0ACwAIABjAG8AbgBzAGUAYwB0AGUAdAB1AGUAcgAgAGEAZABpAHAAaQBzAGMAaQBuAGcAIABlAGwAaQB0AC4AIABBAGUAbgBlAGEAbgAgAGMAbwBtAG0AbwBkAG8A";
            //Console.WriteLine($"UnicodeBase64String => {_unicodeBase64String}");
        }

        #region ToBase64 Method

        [TestMethod]
        [ExpectedException(typeof(SourceEmptyOrNullException))]
        public void ToBase64_EmptyString_AsciiEncoding_Exception()
        {
            // Arrange
            string stringToTest = string.Empty;

            // Act
            string actualResult = stringToTest.ToBase64<ASCIIEncoding>();

            // Assert
            Assert.Fail($"Exception should have been thrown.  Actual Result: {actualResult}");
        }

        [TestMethod]
        public void ToBase64_BaseString_AsciiEncoding_Base64String()
        {
            // Arrange
            // Setup as const values in test class

            // Act
            string actualResult = _baseString.ToBase64<ASCIIEncoding>();

            // Assert
            Assert.AreEqual(_asciiBase64String, actualResult);
        }

        [TestMethod]
        public void ToBase64_BaseString_Utf8Encoding_Base64String()
        {
            // Arrange
            // Setup as const values in test class

            // Act
            string actualResult = _baseString.ToBase64<UTF8Encoding>();

            // Assert
            Assert.AreEqual(_utf8Base64String, actualResult);
        }

        [TestMethod]
        public void ToBase64_BaseString_Utf32Encoding_Base64String()
        {
            // Arrange
            // Setup as const values in test class

            // Act
            string actualResult = _baseString.ToBase64<UTF32Encoding>();

            // Assert
            Assert.AreEqual(_utf32Base64String, actualResult);
        }

        [TestMethod]
        public void ToBase64_BaseString_Utf7Encoding_Base64String()
        {
            // Arrange
            // Setup as const values in test class

            // Act
            string actualResult = _baseString.ToBase64<UTF7Encoding>();

            // Assert
            Assert.AreEqual(_utf7Base64String, actualResult);
        }

        [TestMethod]
        public void ToBase64_BaseString_UnicodeEncoding_Base64String()
        {
            // Arrange
            // Setup as const values in test class

            // Act
            string actualResult = _baseString.ToBase64<UnicodeEncoding>();

            // Assert
            Assert.AreEqual(_unicodeBase64String, actualResult);
        }

        #endregion

        #region FromBase64 Method

        [TestMethod]
        [ExpectedException(typeof(SourceEmptyOrNullException))]
        public void FromBase64_EmptyString_AsciiEncoding_Exception()
        {
            // Arrange
            string stringToTest = string.Empty;

            // Act
            string actualResult = stringToTest.FromBase64<ASCIIEncoding>();

            // Assert
            Assert.Fail($"Exception should have been thrown.  Actual Result: {actualResult}");
        }

        [TestMethod]
        public void FromBase64_AsciiBase64String_AsciiEncoding_Base64String()
        {
            // Arrange
            // Setup as const values in test class

            // Act
            string actualResult = _asciiBase64String.FromBase64<ASCIIEncoding>();

            // Assert
            Assert.AreEqual(_baseString, actualResult);
        }

        [TestMethod]
        public void FromBase64_Utf7Base64String_Utf7Encoding_Base64String()
        {
            // Arrange
            // Setup as const values in test class

            // Act
            string actualResult = _utf7Base64String.FromBase64<UTF7Encoding>();

            // Assert
            Assert.AreEqual(_baseString, actualResult);
        }

        [TestMethod]
        public void FromBase64_Utf8Base64String_Utf8Encoding_Base64String()
        {
            // Arrange
            // Setup as const values in test class

            // Act
            string actualResult = _utf8Base64String.FromBase64<UTF8Encoding>();

            // Assert
            Assert.AreEqual(_baseString, actualResult);
        }

        [TestMethod]
        public void FromBase64_Utf32Base64String_Utf32Encoding_Base64String()
        {
            // Arrange
            // Setup as const values in test class

            // Act
            string actualResult = _utf32Base64String.FromBase64<UTF32Encoding>();

            // Assert
            Assert.AreEqual(_baseString, actualResult);
        }

        [TestMethod]
        public void FromBase64_UnicodeBase64String_UnicodeEncoding_Base64String()
        {
            // Arrange
            // Setup as const values in test class

            // Act
            string actualResult = _unicodeBase64String.FromBase64<UnicodeEncoding>();

            // Assert
            Assert.AreEqual(_baseString, actualResult);
        }

        #endregion
    }
}
