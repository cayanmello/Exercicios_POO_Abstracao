using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OO_Abstração
{
    internal class Gerente : Funcionario
    {
        public Gerente(string nome, double salario) : base(nome, salario)
        {
        }

        public override double CalcularBonus()
        {
            return Salario * 0.15;
        }

        public void MostrarFuncao()
        {
            Console.WriteLine("Gerente: Responsável pela gestão de equipe.");
        }
    }
}
