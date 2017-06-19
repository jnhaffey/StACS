using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StACS.System.Extensions.UnitTests.EnumTests
{
    [TestClass]
    public class GetDescriptionExtensionTests
    {
#if NET452
        [TestMethod]
        public void GetDescription_TestEnum_FirstElement_NET452()
        {
            // Arrange
            TestEnum enumToTest = TestEnum.FirstElement;

            // Act
            string actualResults = enumToTest.GetDescription();

            // Assert
            Assert.AreEqual("FirstElement", actualResults);
        }

        [TestMethod]
        public void GetDescription_TestEnum_SecondElement_NET452()
        {
            // Arrange
            TestEnum enumToTest = TestEnum.SecondElement;

            // Act
            string actualResults = enumToTest.GetDescription();

            // Assert
            Assert.AreEqual("SecondElementDescription", actualResults);
        }

        [TestMethod]
        public void GetDescription_TestEnum_ThirdElement_NET452()
        {
            // Arrange
            TestEnum enumToTest = TestEnum.ThirdElement;

            // Act
            string actualResults = enumToTest.GetDescription();

            // Assert
            Assert.AreEqual("ThirdElement", actualResults);
        }
#endif
#if NETCOREAPP1_1
        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void GetDescription_TestEnum_FirstElement_NETCOREAPP1_1()
        {
            // Arrange
            TestEnum enumToTest = TestEnum.FirstElement;

            // Act
            string actualResults = enumToTest.GetDescription();

            // Assert
            Assert.AreEqual("FirstElement", actualResults);
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void GetDescription_TestEnum_SecondElement_NETCOREAPP1_1()
        {
            // Arrange
            TestEnum enumToTest = TestEnum.SecondElement;

            // Act
            string actualResults = enumToTest.GetDescription();

            // Assert
            Assert.AreEqual("SecondElementDescription", actualResults);
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void GetDescription_TestEnum_ThirdElement_NETCOREAPP1_1()
        {
            // Arrange
            TestEnum enumToTest = TestEnum.ThirdElement;

            // Act
            string actualResults = enumToTest.GetDescription();

            // Assert
            Assert.AreEqual("ThirdElement", actualResults);
        }

#endif
    }
}
