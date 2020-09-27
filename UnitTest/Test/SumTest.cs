using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.Test
{
    [TestClass]
    public class SumTest
    {
        [TestMethod]
        public void TestSumaCincoMasDos()
        {
            //Arrange
            ApplicationCore.Services.Sum sum = new ApplicationCore.Services.Sum();
            int num1 = 5;
            int num2 = 2;

            var result = sum.SumValues(num1, num2);

            Assert.AreEqual(7,result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            ApplicationCore.Services.Sum sum = new ApplicationCore.Services.Sum();
            int num1 = 5;
            int num2 = 2;

            var result = sum.SumValues(num1, num2);

            Assert.AreEqual(7, result);
        }
    }
}
