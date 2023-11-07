using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OO_Abstração
{
    internal class Professor : Pessoa
    {
        public Professor(string nome, int idade) : base(nome, idade)
        {
        }

        public string Disciplina {  get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Professor: {Nome}, Idade: {Idade}, Disciplina: {Disciplina}");
        }
    }
}
