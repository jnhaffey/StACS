using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StACS.System.Extensions.UnitTests.EnumTests
{
    [TestClass]
    public class GetNameExtensionTests
    {
        [TestMethod]
        public void GetName_TestEnum_FirstElement()
        {
            // Arrange
            TestEnum enumToTest = TestEnum.FirstElement;
            
            // Act
            string actualResults = enumToTest.GetName();

            // Assert
            Assert.AreEqual("FirstElement", actualResults);
        }

        [TestMethod]
        public void GetName_TestEnum_SecondElement()
        {
            // Arrange
            TestEnum enumToTest = TestEnum.SecondElement;

            // Act
            string actualResults = enumToTest.GetName();

            // Assert
            Assert.AreEqual("SecondElement", actualResults);
        }

        [TestMethod]
        public void GetName_TestEnum_ThirdElement()
        {
            // Arrange
            TestEnum enumToTest = TestEnum.ThirdElement;

            // Act
            string actualResults = enumToTest.GetName();

            // Assert
            Assert.AreEqual("ThirdElement", actualResults);
        }
    }
}
