using System;
using log4net;
namespace PooVueling
{
    public class Calculadora : ICalculadora, ICloneable
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Calculadora));

        public object Clone()
        {
            throw new NotImplementedException("The method is not implemented yet");
        }

        public int Division(int num1, int num2)
        {
            try
            {
                return num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                log.Error(e.Message);
                throw;
            }
        }

        public int Multiplicacion(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Resta(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Suma(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
