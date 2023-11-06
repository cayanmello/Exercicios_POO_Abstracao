using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OO_Abstração
{
    internal class ContaCorrente : ContaBancaria
    {
        public override void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de {valor} realizado na conta corrente. Saldo atual: {Saldo}");
        }

        public override void Sacar(double valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor} realizado na conta corrente. Saldo atual: {Saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque na conta corrente.");
            }
        }
    }
}
