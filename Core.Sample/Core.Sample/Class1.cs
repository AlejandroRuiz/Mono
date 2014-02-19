using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calc.Core
{
    public class Calculadora
    {
        public double Numero1 { get; set; }
        public double Numero2 { get; set; }
        public Calculadora()
        {
            Numero1 = 0;
            Numero2 = 0;
        }
        public double Suma()
        {
            return Numero1 + Numero2;
        }
        public double Resta()
        {
            return Numero1 - Numero2;
        }
        public double Multiplicacion()
        {
            return Numero1 * Numero2;
        }
        public double Division()
        {
            if (Numero1 == 0 || Numero2 == 0)
            {
                throw new Exception("Error Disicion 0");
            }
            return Numero1 / Numero2;
        }
    }
}
