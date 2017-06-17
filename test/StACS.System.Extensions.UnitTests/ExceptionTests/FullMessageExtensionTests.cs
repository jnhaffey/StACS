using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StACS.System.Extensions.UnitTests.ExceptionTests
{
    [TestClass]
    public class FullMessageExtensionTests
    {
        private const string FirstExceptionMessage = "First Message";
        private const string SecondExceptionMessage = "Second Message";
        private const string ThirdExceptionMessage = "Third Message";

        [TestMethod]
        public void FullMessage_SingleException_Message()
        {
            // Arrange
            string expectedResult = $"{FirstExceptionMessage}{Environment.NewLine}";
            Exception test = new Exception(FirstExceptionMessage);

            // Act
            string actualResult = test.FullMessage();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void FullMessage_InnerException_Messages()
        {
            // Arrange
            string expectedResult = $"{FirstExceptionMessage}{Environment.NewLine}{SecondExceptionMessage}{Environment.NewLine}";
            Exception secondExceptionTest = new Exception(SecondExceptionMessage);
            Exception firstExceptionTest = new Exception(FirstExceptionMessage, secondExceptionTest);
            
            // Act
            string actualResult = firstExceptionTest.FullMessage();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void FullMessage_InnerInnerException_Message()
        {
            // Arrange
            string expectedResult = $"{FirstExceptionMessage}{Environment.NewLine}{SecondExceptionMessage}{Environment.NewLine}{ThirdExceptionMessage}{Environment.NewLine}";
            Exception thirdExceptionTest = new Exception(ThirdExceptionMessage);
            Exception secondExceptionTest = new Exception(SecondExceptionMessage, thirdExceptionTest);
            Exception firstExceptionTest = new Exception(FirstExceptionMessage, secondExceptionTest);

            // Act
            string actualResult = firstExceptionTest.FullMessage();

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}