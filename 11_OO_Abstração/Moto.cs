using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OO_Abstração
{
    internal class Moto : Veiculo
    {
        public Moto(string marca, int modelo, int ano) : base(marca, modelo, ano)
        {
        }

        public int Cilindrada { get; set; }

        public override void Dirigir()
        {
            Console.WriteLine($"Dirigindo a {Marca} {Modelo} com {Cilindrada} cilindradas");
        }

        public override void Apresentar()
        {
            Console.WriteLine($"Dirigindo a {Marca} {Modelo}");
        }
    }
}
