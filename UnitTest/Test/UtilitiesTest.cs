using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.Test
{
    [TestClass]
    public class UtilitiesTest
    {
        [TestMethod]

        public void ContarDivisoresDeSeis()
        {

            //Arrange
            ApplicationCore.Services.Utilities utilities
            = new ApplicationCore.Services.Utilities();

            var numero = 6;

            //Act 
            var result = utilities.ContarDivisores(numero);

            //Assert

            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void ObtenerValorProductoMouse()
        {

            //Arrange
            ApplicationCore.Services.Utilities utilities
            = new ApplicationCore.Services.Utilities();

            var codigo = 1250;

            //Act 
            var result = utilities.ContarDivisores(codigo);

            //Assert

            Assert.AreEqual(15500, result);
        }
    }
}

