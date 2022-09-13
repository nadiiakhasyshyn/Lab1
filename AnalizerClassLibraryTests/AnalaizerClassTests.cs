using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AnalaizerClassLibrary.Tests
{
    [TestClass]
    public class AnalaizerClassTests
    {
        public TestContext TestContext { get; set; }
        
        
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "testData.xml", "ValidTest", DataAccessMethod.Sequential)]
        public void IsOperator_WhenIncomingDataIsValid_ReturnsTrue()
        {
            //Arrange
            bool expected = Convert.ToBoolean(TestContext.DataRow["expected"]);
            string initial = Convert.ToString(TestContext.DataRow["incomingData"]);
            //Actual
            bool actualResult = AnalaizerClass.IsOperator(initial);
            //Assert
            Assert.AreEqual(expected, actualResult);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "testData.xml", "InValidTest", DataAccessMethod.Sequential)]
        public void IsOperator_WhenIncomingDataIsValid_ReturnsFalse()
        {
            //Arrange
            bool expected = Convert.ToBoolean(TestContext.DataRow["expected"]);
            string initial = Convert.ToString(TestContext.DataRow["incomingData"]);
            //Actual
            bool actualResult = AnalaizerClass.IsOperator(initial);
            //Assert
            Assert.AreEqual(expected, actualResult);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "testData.xml", "ValidTest2", DataAccessMethod.Sequential)]
        public void IsDelimeter_WhenIncomingDataIsValid_ReturnsTrue()
        {
            //Arrange
            bool expected = Convert.ToBoolean(TestContext.DataRow["expected"]);
            char initial = Convert.ToChar(TestContext.DataRow["incomingData"]);
            //Actual
            bool actualResult = AnalaizerClass.IsDelimeter(initial);
            //Assert
            Assert.AreEqual(expected, actualResult);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "testData.xml", "InValidTest2", DataAccessMethod.Sequential)]
        public void IsDelimeter_WhenIncomingDataIsValid_ReturnsFalse()
        {
            //Arrange
            bool expected = Convert.ToBoolean(TestContext.DataRow["expected"]);
            char initial = Convert.ToChar(TestContext.DataRow["incomingData"]);
            //Actual
            bool actualResult = AnalaizerClass.IsDelimeter(initial);
            //Assert
            Assert.AreEqual(expected, actualResult);
        }

    }
}