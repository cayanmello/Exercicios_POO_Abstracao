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
        public string Curso { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Aluno: {Nome}, Idade: {Idade}, Matrícula: {Matricula}");
        }

        public Aluno(string nome, int idade, int matricula, string curso) : base(nome, idade)
        {
            Matricula = matricula;
            Curso = curso;
        }
    }
}
