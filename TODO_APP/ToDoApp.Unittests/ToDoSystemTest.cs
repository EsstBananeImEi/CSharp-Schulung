using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoApp.Business;

namespace ToDoApp.Unittests
{
    [TestClass]
    public class ToDoSystemTest
    {
        [TestMethod]
        public void ToDoSystem_CalculateWorkingDays_Return()
        {
            DateTime myStart = new DateTime(2017, 1, 1);
            DateTime myEnd = new DateTime(2017, 1, 31);
            double result = ToDoSystem.CalculateWorkingDays(myStart, myEnd);
            Assert.AreEqual(22, result);
        }
    }
}
