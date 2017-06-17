using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StACS.Core.Exceptions;

namespace StACS.System.Extensions.UnitTests.DateTimeTests
{
    [TestClass]
    public class IsWeekendExtensionTests
    {
        [TestMethod]
        public void IsWeekend_DateSaturday_True()
        {
            // Arrange
            DateTime test = new DateTime(2000, 1, 1); // Saturday

            // Act
            var actualResult = test.IsWeekend();

            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void IsWeekend_DateSunday_True()
        {
            // Arrange
            DateTime test = new DateTime(2000, 1, 2); // Sunday

            // Act
            var actualResult = test.IsWeekend();

            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void IsWeekend_DateMonday_False()
        {
            // Arrange
            DateTime test = new DateTime(2000, 1, 3); // Monday

            // Act
            var actualResult = test.IsWeekend();

            // Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void IsWeekend_DateTuesday_False()
        {
            // Arrange
            DateTime test = new DateTime(2000, 1, 4); // Tuesday

            // Act
            var actualResult = test.IsWeekend();

            // Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void IsWeekend_DateWednesday_False()
        {
            // Arrange
            DateTime test = new DateTime(2000, 1, 5); // Wednesday

            // Act
            var actualResult = test.IsWeekend();

            // Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void IsWeekend_DateThursday_False()
        {
            // Arrange
            DateTime test = new DateTime(2000, 1, 6); // Thursday

            // Act
            var actualResult = test.IsWeekend();

            // Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void IsWeekend_DateFriday_False()
        {
            // Arrange
            DateTime test = new DateTime(2000, 1, 7); // Friday

            // Act
            var actualResult = test.IsWeekend();

            // Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(SourceEmptyOrNullException))]
        public void IsWeekend_NullableDateNull_Exception()
        {
            // Arrange
            DateTime? test = null;

            // Act
            var actualResult = test.IsWeekend();

            // Assert
            Assert.Fail($"Exception should have been thrown. Actual Result: {actualResult}");
        }

        [TestMethod]
        public void IsWeekend_NullableDateSaturday_False()
        {
            // Arrange
            DateTime? test = new DateTime(2000, 1, 1); // Saturday

            // Act
            var actualResult = test.IsWeekend();

            // Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void IsWeekend_NullableDateMonday_True()
        {
            // Arrange
            DateTime? test = new DateTime(2000, 1, 3);  // Monday

            // Act
            var actualResult = test.IsWeekend();

            // Assert
            Assert.IsFalse(actualResult);
        }
    }
}