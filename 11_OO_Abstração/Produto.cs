using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OO_Abstração
{
    internal abstract class Produto
    {
        public string Nome { get; set; }
        public int Preco { get; set; }

        public abstract double CalcularDesconto();
    }
}
