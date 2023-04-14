using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calcul;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcul.Tests
{
    [TestClass()]
    public class MainWindowTests
    {
        [TestMethod()]
        public void MainWindowTest()
        {
            int a = 25;
            int b = 25;
            string sum = (a + b).ToString();
            Assert.IsTrue(sum == "50");
        }
        [TestMethod()]
        public void MainWindowTest1()
        {
            int a = 25;
            int b = 10;
            string sum = (a - b).ToString();
            Assert.IsTrue(sum == "15");
        }
        [TestMethod()]
        public void MainWindowTest2()
        {
            int a = 80;
            int b = 10;
            string sum = (a / b).ToString();
            Assert.IsTrue(sum == "8");
        }
        [TestMethod()]
        public void MainWindowTest3()
        {
            int a = 25;
            int b = 10;
            string sum = (a * b).ToString();
            Assert.IsTrue(sum == "250");
        }
    }
}