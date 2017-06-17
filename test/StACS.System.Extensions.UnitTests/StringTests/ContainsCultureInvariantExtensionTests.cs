using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StACS.System.Extensions.UnitTests.StringTests
{
    [TestClass]
    public class ContainsCultureInvariantExtensionTests
    {
        [TestMethod]
        public void ContainsCultureInvariant_EmptyString_EmptyString_IgnoreCase_False()
        {
            // Arrange
            string test = string.Empty;
            string compareWith = string.Empty;

            // Act
            bool actualResult = test.ContainsCultureInvariant(compareWith);

            // Assert
            Assert.IsFalse(actualResult, $"Result => test: {test} | compareWith: {compareWith}");
        }

        [TestMethod]
        public void ContainsCultureInvariant_EmptyString_NonEmptyString_IgnoreCase_False()
        {
            // Arrange
            string test = string.Empty;
            string compareWith = "NonEmptyString";

            // Act
            bool actualResult = test.ContainsCultureInvariant(compareWith);

            // Assert
            Assert.IsFalse(actualResult, $"Result => test: {test} | compareWith: {compareWith}");
        }

        [TestMethod]
        public void ContainsCultureInvariant_NonEmptyString_EmptyString_IgnoreCase_False()
        {
            // Arrange
            string test = "NonEmptyString";
            string compareWith = string.Empty;

            // Act
            bool actualResult = test.ContainsCultureInvariant(compareWith);

            // Assert
            Assert.IsFalse(actualResult, $"Result => test: {test} | compareWith: {compareWith}");
        }

        [TestMethod]
        public void ContainsCultureInvariant_NonEmptyString_NonEmptyString_IgnoreCase_True()
        {
            // Arrange
            string test = "NonEmptyString";
            string compareWith = "NonEmptyString";

            // Act
            bool actualResult = test.ContainsCultureInvariant(compareWith);

            // Assert
            Assert.IsTrue(actualResult, $"Result => test: {test} | compareWith: {compareWith}");
        }

        [TestMethod]
        public void ContainsCultureInvariant_NonEmptyString_NonEmptyString_DoNotIgnoreCase_True()
        {
            // Arrange
            string test = "NonEmptyString";
            string compareWith = "NonEmptyString";

            // Act
            bool actualResult = test.ContainsCultureInvariant(compareWith, false);

            // Assert
            Assert.IsTrue(actualResult, $"Result => test: {test} | compareWith: {compareWith}");
        }

        [TestMethod]
        public void ContainsCultureInvariant_NonEmptyStringLowered_NonEmptyString_DoNotIgnoreCase_False()
        {
            // Arrange
            string test = "NonEmptyString".ToLower();
            string compareWith = "NonEmptyString";

            // Act
            bool actualResult = test.ContainsCultureInvariant(compareWith, false);

            // Assert
            Assert.IsFalse(actualResult, $"Result => test: {test} | compareWith: {compareWith}");
        }

        [TestMethod]
        public void ContainsCultureInvariant_NonEmptyString_NonEmptyStringLowered_DoNotIgnoreCase_False()
        {
            // Arrange
            string test = "NonEmptyString";
            string compareWith = "NonEmptyString".ToLower();

            // Act
            bool actualResult = test.ContainsCultureInvariant(compareWith, false);

            // Assert
            Assert.IsFalse(actualResult, $"Result => test: {test} | compareWith: {compareWith}");
        }
    }
}