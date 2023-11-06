using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OO_Abstração
{
    internal class Aluno : Pessoa
    {
        public int Matricula {  get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Aluno: {Nome}, Idade: {Idade}, Matrícula: {Matricula}");
        }
    }
}
