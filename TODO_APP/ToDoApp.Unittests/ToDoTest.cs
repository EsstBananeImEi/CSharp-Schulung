using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.Business;

namespace ToDoApp.Unittests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class ToDoTest
    {
        public ToDoTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void ToDo_ID_Testcase1()
        {
            // Arrage
            ToDo result = new ToDo();
            // Act
            result.ID = 1;
            // Assert
            Assert.AreEqual(1, result.ID);
            Assert.AreEqual("New ToDo", result.Title);
        }
        [TestMethod]
        public void ToDo_Title_Testcase2()
        {
            // Arrage
            ToDo result = new ToDo();
            // Act
            result.Title = "Test1";
            // Assert
            Assert.AreEqual("Test1", result.Title);
        }
        [TestMethod]
        public void ToDo_Date_Testcase3()
        {
            // Arrage
            ToDo result = new ToDo();
            DateTime dateTime = DateTime.Parse("2009-05-08 14:40:52"); 
            // Act
            result.Date = dateTime;
            // Assert
            Assert.AreEqual(dateTime, result.Date);
        }
        [TestMethod]
        public void ToDo_Categories_Testcase4()
        {
            // Arrage
            ToDo result = new ToDo();
            // Act
            result.Categories.Add(new ToDoCategory() { ID = 0, Title = "TestTitle" });
            // Assert
            Assert.AreEqual(1, result.Categories.Count);
        }
        [TestMethod]
        public void ToDo_Body_Testcase5()
        {
            // Arrage
            ToDo result = new ToDo();
            // Act
            result.Body = "TestBody";
            // Assert
            Assert.AreEqual("TestBody", result.Body);
        }

    }
}
