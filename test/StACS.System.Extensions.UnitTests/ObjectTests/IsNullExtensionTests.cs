using Microsoft.VisualStudio.TestTools.UnitTesting;
using StACS.System.ObjectExtensions;

namespace StACS.System.Extensions.UnitTests.ObjectTests
{
    [TestClass]
    public class IsNullExtensionTests
    {
        [TestMethod]
        public void IsNull_NullObject_True()
        {
            // Arrange
            object test = null;

            // Act
            var actual = test.IsNull();

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsNull_NonNullObject_False()
        {
            // Arrange
            object test = new object();

            // Act
            var actual = test.IsNull();

            // Assert
            Assert.IsFalse(actual);
        }
    }
}