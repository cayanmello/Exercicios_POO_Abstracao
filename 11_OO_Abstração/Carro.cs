using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OO_Abstração
{
    internal class Carro : Veiculo
    {
        public int QuantidadeDePortas { get; set; }

        public override void Dirigir()
        {
            Console.WriteLine($"Dirigindo o {Marca} {Modelo} com {QuantidadeDePortas} portas");
        }

        public override void Apresentar()
        {
            base.Apresentar();
            Console.WriteLine($"Número de Portas: {QuantidadeDePortas}");
        }
    }
}
