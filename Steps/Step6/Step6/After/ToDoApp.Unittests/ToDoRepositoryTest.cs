using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoApp.Business;
using System.Linq;

namespace ToDoApp.Unittests
{
    [TestClass]
    public class ToDoRepositoryTest
    {
        [TestMethod]
        public void ToDoRepository_GetAll_Testcase1()
        {
            ToDoRepository myRepository = new ToDoRepository();

            List<ToDo> myResult = myRepository.GetAll().ToList();

            Assert.AreEqual(0, myResult.Count);
        }

        [TestMethod]
        public void ToDoRepository_Create_Testcase1()
        {
            ToDoRepository myRepository = new ToDoRepository();

            ToDo myResult = myRepository.Create(); ;

            Assert.AreEqual(1, myResult.ID);
            Assert.AreEqual("Neue Aufgabe", myResult.Title);
        }

        [TestMethod]
        public void ToDoRepository_Update_Testcase1()
        {
            ToDoRepository myRepository = new ToDoRepository();
            ToDo myTestToDo = myRepository.Create();
            myTestToDo.Title = "Test1";
                        
            myRepository.Update(myTestToDo);

            Assert.AreEqual("Test1", myTestToDo.Title);
        }

        [TestMethod]
        public void ToDoRepository_Delete_Testcase1()
        {
            ToDoRepository myRepository = new ToDoRepository();
            ToDo myTestToDo = myRepository.Create();
            myTestToDo.Title = "Test1";

            myRepository.Delete(myTestToDo);

            Assert.AreEqual(0, myRepository.GetAll().ToList().Count);
        }
    }
}
