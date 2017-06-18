using Microsoft.VisualStudio.TestTools.UnitTesting;
using StACS.Core.Exceptions;
using System.Text;

namespace StACS.System.Text.Extensions.UnitTests.StringBuilderTests
{
    [TestClass]
    public class AppendIfExtensionTests
    {
        [TestMethod]
        [ExpectedException(typeof(SourceEmptyOrNullException))]
        public void AppendIf_NullString_True_SomeText_Exception()
        {
            // Arrange
            StringBuilder stringBuilderToTest = null;

            // Act
            stringBuilderToTest.AppendIf(true, "SomeText");

            // Assert
            Assert.Fail($"Exception should have been thrown.");
        }

        [TestMethod]
        public void AppendIf_BaseText_True_SomeText_TypeOfStringBuilder()
        {
            // Arrange
            StringBuilder stringBuilderToTest = new StringBuilder("BaseText");

            // Act
            stringBuilderToTest.AppendIf(true, "SomeText");

            // Assert
            Assert.IsInstanceOfType(stringBuilderToTest, typeof(StringBuilder));
        }

        [TestMethod]
        public void AppendIf_BaseString_True_SomeText_BaseTextSomeText()
        {
            // Arrange
            StringBuilder stringBuilderToTest = new StringBuilder("BaseText");

            // Act
            stringBuilderToTest.AppendIf(true, "SomeText");

            // Assert
            Assert.AreEqual("BaseTextSomeText", stringBuilderToTest.ToString());
        }

        [TestMethod]
        public void AppendIf_BaseString_False_SomeText_BaseText()
        {
            // Arrange
            StringBuilder stringBuilderToTest = new StringBuilder("BaseText");

            // Act
            stringBuilderToTest.AppendIf(false, "SomeText");

            // Assert
            Assert.AreEqual("BaseText", stringBuilderToTest.ToString());
        }
    }
}