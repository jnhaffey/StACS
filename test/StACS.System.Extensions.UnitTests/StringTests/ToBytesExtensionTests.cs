using System;
using System.Collections;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StACS.Core.Exceptions;
using StACS.System.Extensions.String;

namespace StACS.System.Extensions.UnitTests.StringTests
{
    [TestClass]
    public class ToBytesExtensionTests
    {
        private string _stringToTest;
        private byte[] _byteArrayToTest;

        [TestInitialize]
        public void TestSetup()
        {
            _stringToTest = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo";
            _byteArrayToTest = new byte[]
            {
                76, 0, 111, 0, 114, 0, 101, 0, 109, 0, 32, 0, 105, 0, 112, 0, 115, 0, 117, 0, 109, 0, 32, 0, 100, 0,
                111, 0, 108, 0, 111, 0, 114, 0, 32, 0, 115, 0, 105, 0, 116, 0, 32, 0, 97, 0, 109, 0, 101, 0, 116, 0, 44,
                0, 32, 0, 99, 0, 111, 0, 110, 0, 115, 0, 101, 0, 99, 0, 116, 0, 101, 0, 116, 0, 117, 0, 101, 0, 114, 0,
                32, 0, 97, 0, 100, 0, 105, 0, 112, 0, 105, 0, 115, 0, 99, 0, 105, 0, 110, 0, 103, 0, 32, 0, 101, 0, 108,
                0, 105, 0, 116, 0, 46, 0, 32, 0, 65, 0, 101, 0, 110, 0, 101, 0, 97, 0, 110, 0, 32, 0, 99, 0, 111, 0,
                109, 0, 109, 0, 111, 0, 100, 0, 111, 0
            };
        }

        [TestMethod]
        [ExpectedException(typeof(SourceEmptyOrNullException))]
        public void ToBytes_Empty_Exception()
        {
            // Arrange
            string stringToTest = string.Empty;

            // Act
            var actualResult = stringToTest.ToBytes();

            // Assert
            Assert.Fail($"Exception should have been thrown.  Actual Result: {actualResult}");
        }

        [TestMethod]
        public void ToBytes_StringToTest_ByteArrayToTest()
        {
            // Arrange
            // Setup as class fields in test class

            // Act
            byte[] actualResult = _stringToTest.ToBytes();

            // Assert
            Assert.AreEqual(_byteArrayToTest.Length, actualResult.Length);
            Assert.IsTrue(StructuralComparisons.StructuralEqualityComparer.Equals(_byteArrayToTest, actualResult));
        }
    }
}