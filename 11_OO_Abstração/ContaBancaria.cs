using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OO_Abstração
{
    internal abstract class ContaBancaria
    {
        public double Saldo {  get; set; }

        public abstract void Depositar(double valor);
        public abstract void Sacar(double valor);
    }
}
