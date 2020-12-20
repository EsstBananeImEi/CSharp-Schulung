using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoApp.Business;

namespace ToDoApp.Unittests
{
    [TestClass]
    public class ToDoCategoryTest
    {
        [TestMethod]
        public void ToDoCategory_ID_Testcase1()
        {
            ToDoCategory myToDo = new ToDoCategory();

            myToDo.ID = 1;

            Assert.AreEqual(1, myToDo.ID);
        }

        [TestMethod]
        public void ToDoCategory_Title_Testcase1()
        {
            ToDoCategory myToDo = new ToDoCategory();

            myToDo.Title = "Test";

            Assert.AreEqual("Test", myToDo.Title);
        }

    }
}
