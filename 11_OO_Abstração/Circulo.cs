using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OO_Abstração
{
    internal class Circulo
    {
        public double Raio { get; set; }

        public double CalcularArea()
        {
            return Math.PI * Raio * Raio;
        }

        public double CalcularPerimetro()
        {
            return 2 * Math.PI * Raio;
        }
    }
}
