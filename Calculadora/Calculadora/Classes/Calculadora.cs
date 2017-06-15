using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Classes
{
    class Calculadora
    {
        private double numero1;
        private double numero2;
        private double total;

        public double Numero1 { get => numero1; set => numero1 = value; }
        public double Numero2 { get => numero2; set => numero2 = value; }
        public double Total { get => total; set => total = value; }
    }
}
