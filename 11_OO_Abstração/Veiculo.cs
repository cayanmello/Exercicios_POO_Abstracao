using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OO_Abstração
{
    internal abstract class Veiculo
    {
        public string Marca { get; set; }
        public int Modelo {  get; set; }
        public int Ano { get; set; }

        public Veiculo(string marca, int modelo, int ano)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
        }

        public abstract void Dirigir();

        public virtual void Apresentar()
        {
            Console.WriteLine($"Marca: {Marca}, Ano: {Ano}");
        }
    }
}
