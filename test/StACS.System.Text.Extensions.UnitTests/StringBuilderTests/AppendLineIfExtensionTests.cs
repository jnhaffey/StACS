using Microsoft.VisualStudio.TestTools.UnitTesting;
using StACS.Core.Exceptions;
using System;
using System.Text;

namespace StACS.System.Text.Extensions.UnitTests.StringBuilderTests
{
    [TestClass]
    public class AppendLineIfExtensionTests
    {
        [TestMethod]
        [ExpectedException(typeof(SourceEmptyOrNullException))]
        public void AppendLineIf_NullString_True_SomeText_Exception()
        {
            // Arrange
            StringBuilder stringBuilderToTest = null;

            // Act
            stringBuilderToTest.AppendLineIf(true, "Some Text To Add");

            // Assert
            Assert.Fail($"Exception should have been thrown.");
        }

        [TestMethod]
        public void AppendLineIf_BaseText_True_SomeText_TypeOfStringBuilder()
        {
            // Arrange
            StringBuilder stringBuilderToTest = new StringBuilder();
            stringBuilderToTest.AppendLine("BaseText");

            // Act
            stringBuilderToTest.AppendLineIf(true, "SomeText");

            // Assert
            Assert.IsInstanceOfType(stringBuilderToTest, typeof(StringBuilder));
        }

        [TestMethod]
        public void AppendLineIf_BaseString_True_SomeText_BaseText_NewLine_SomeText()
        {
            // Arrange
            StringBuilder stringBuilderToTest = new StringBuilder();
            stringBuilderToTest.AppendLine("BaseText");

            // Act
            stringBuilderToTest.AppendLineIf(true, "SomeText");

            // Assert
            Assert.AreEqual($"BaseText{Environment.NewLine}SomeText{Environment.NewLine}", stringBuilderToTest.ToString());
        }

        [TestMethod]
        public void AppendLineIf_BaseString_False_SomeText_BaseText_NewLine()
        {
            // Arrange
            StringBuilder stringBuilderToTest = new StringBuilder();
            stringBuilderToTest.AppendLine("BaseText");

            // Act
            stringBuilderToTest.AppendLineIf(false, "SomeText");

            // Assert
            Assert.AreEqual($"BaseText{Environment.NewLine}", stringBuilderToTest.ToString());
        }
    }
}