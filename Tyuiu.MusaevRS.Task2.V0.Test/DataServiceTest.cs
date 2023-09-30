using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MusaevRS.Task2.V0.Lib;

namespace Tyuiu.MusaevRS.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassageValid()
        {
            var name = "Руслан";
            var res = DataService.GetMassage(name);

            Assert.AreEqual("Привет, Руслан", res);
        }
    }
}
