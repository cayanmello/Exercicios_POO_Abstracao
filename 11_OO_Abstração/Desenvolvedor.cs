using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OO_Abstração
{
    internal class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string nome, double salario) : base(nome, salario)
        {
        }

        public override double CalcularBonus()
        {

            return Salario * 0.05;
        }

        public void MostrarFuncao()
        {
            Console.WriteLine("Desenvolvedor: Responsável pelo desenvolvimento de software.");
        }
    }
}
