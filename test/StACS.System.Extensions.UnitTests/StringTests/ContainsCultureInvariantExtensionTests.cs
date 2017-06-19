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
            string emptyString = ConstantStringTestData.EmptyString;
            string compareWith = ConstantStringTestData.EmptyString;

            // Act
            bool actualResult = emptyString.ContainsCultureInvariant(compareWith);

            // Assert
            Assert.IsFalse(actualResult, $"Result => test: {emptyString} | compareWith: {compareWith}");
        }

        [TestMethod]
        public void ContainsCultureInvariant_EmptyString_NonEmptyString_IgnoreCase_False()
        {
            // Arrange
            string emptyString = ConstantStringTestData.EmptyString;
            string compareWith = "NonEmptyString";

            // Act
            bool actualResult = emptyString.ContainsCultureInvariant(compareWith);

            // Assert
            Assert.IsFalse(actualResult, $"Result => test: {emptyString} | compareWith: {compareWith}");
        }

        [TestMethod]
        public void ContainsCultureInvariant_AlphanumericspecialString_EmptyString_IgnoreCase_False()
        {
            // Arrange
            string stringToTest = ConstantStringTestData.AlphanumericspecialString;
            string compareWith = ConstantStringTestData.EmptyString;

            // Act
            bool actualResult = stringToTest.ContainsCultureInvariant(compareWith);

            // Assert
            Assert.IsFalse(actualResult, $"Result => test: {stringToTest} | compareWith: {compareWith}");
        }

        [TestMethod]
        public void ContainsCultureInvariant_AlphanumericspecialString_AlphanumericspecialString_IgnoreCase_True()
        {
            // Arrange
            string stringToTest = ConstantStringTestData.AlphanumericspecialString;
            string compareWith = ConstantStringTestData.AlphanumericspecialString;

            // Act
            bool actualResult = stringToTest.ContainsCultureInvariant(compareWith);

            // Assert
            Assert.IsTrue(actualResult, $"Result => test: {stringToTest} | compareWith: {compareWith}");
        }

        [TestMethod]
        public void ContainsCultureInvariant_AlphanumericspecialString_AlphanumericspecialString_DoNotIgnoreCase_True()
        {
            // Arrange
            string stringToTest = ConstantStringTestData.AlphanumericspecialString;
            string compareWith = ConstantStringTestData.AlphanumericspecialString;

            // Act
            bool actualResult = stringToTest.ContainsCultureInvariant(compareWith, false);

            // Assert
            Assert.IsTrue(actualResult, $"Result => test: {stringToTest} | compareWith: {compareWith}");
        }

        [TestMethod]
        public void ContainsCultureInvariant_AlphanumericspecialStringLowered_AlphanumericspecialString_DoNotIgnoreCase_False()
        {
            // Arrange
            string stringToTest = ConstantStringTestData.AlphanumericspecialString.ToLower();
            string compareWith = ConstantStringTestData.AlphanumericspecialString;

            // Act
            bool actualResult = stringToTest.ContainsCultureInvariant(compareWith, false);

            // Assert
            Assert.IsFalse(actualResult, $"Result => test: {stringToTest} | compareWith: {compareWith}");
        }

        [TestMethod]
        public void ContainsCultureInvariant_AlphanumericspecialString_AlphanumericspecialStringLowered_DoNotIgnoreCase_False()
        {
            // Arrange
            string stringToTest = ConstantStringTestData.AlphanumericspecialString;
            string compareWith = ConstantStringTestData.AlphanumericspecialString.ToLower();

            // Act
            bool actualResult = stringToTest.ContainsCultureInvariant(compareWith, false);

            // Assert
            Assert.IsFalse(actualResult, $"Result => test: {stringToTest} | compareWith: {compareWith}");
        }
    }
}