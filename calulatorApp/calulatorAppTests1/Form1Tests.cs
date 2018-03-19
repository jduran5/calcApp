using Microsoft.VisualStudio.TestTools.UnitTesting;
using calulatorApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calulatorApp.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void addTest()
        {
            // Arrange
           var currentForm1 = new Form1();
            // Act
            var result = currentForm1.Add(1, 9);
            //Assert
           Assert.AreEqual(10, result);
        }
    }
}