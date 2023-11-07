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
        public double Preco { get; set; }
        public int Estoque { get; set; }

        public abstract double CalcularDesconto();

        public Produto(string nome)
        {
            Nome = nome;
            Preco = 0;
            Estoque = 0;
        }

        public Produto(string nome, double preco, int estoque)
        {
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }
    }
}
