using Microsoft.VisualStudio.TestTools.UnitTesting;
using PooVueling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling.Tests
{
    [TestClass()]
    public class CalculadoraTests
    {
        ICalculadora iCalculadora = new Calculadora();
        //[TestMethod()]
        //public void CloneTest()
        //{
        //    Assert.Fail();
        //}

        [DataRow(10, 5, 2)]
        [DataRow(30, 6, 5)]
        [DataTestMethod()]
        public void DivisionTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Division(num1, num2) == resultado);
        }

        [DataRow(9, 0, 0)]
        [DataTestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivisionDivideByZeroExceptionTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Division(num1, num2) == resultado);
        }

        [DataRow(10, 5, 50)]
        [DataRow(30, 6, 180)]
        [DataRow(4, 2, 8)]
        [DataTestMethod()]
        public void MultiplicacionTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Multiplicacion(num1, num2) == resultado);
        }

        [DataRow(10, 5, 5)]
        [DataRow(30, 6, 24)]
        [DataRow(4, 2, 2)]
        [DataTestMethod()]
        public void RestaTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Resta(num1, num2) == resultado);
        }

        [DataRow(10, 5, 15)]
        [DataRow(30, 6, 36)]
        [DataRow(4, 2, 6)]
        [DataTestMethod()]
        public void SumaTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Suma(num1, num2) == resultado);
        }
    }
}