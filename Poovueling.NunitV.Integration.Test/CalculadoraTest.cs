using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PooVueling;

namespace Poovueling.NunitV.Integration.Test
{
    using System;
    using NUnit.Framework;

    [TestFixture]
     public class CalculadoraTest
    {
        private readonly ICalculadora calculadora = new Calculadora();

        [TestCase(5, 5, 10)]
        public void SumaTest(int num1, int num2, int resultado)
        {
            Assert.AreEqual(calculadora.Suma(num1, num2), resultado);
        }

        [TestCase(3, 0, 0)]
        public void DivideTest(int num1, int num2, int resultado)
        {
            Assert.AreEqual(calculadora.Division(num1, num2), resultado);
        }
    }
}
