using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OO_Abstração
{
    internal class ContaPoupanca : ContaBancaria
    {
        public override void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de {valor} realizado na conta poupança. Saldo atual: {Saldo}");
        }

        public override void Sacar(double valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor} realizado na conta poupança. Saldo atual: {Saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque na conta poupança.");
            }

            double custoDoSaque = 0.10;
            if (valor + custoDoSaque <= Saldo)
            {
                Saldo -= valor + custoDoSaque;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }
    }
}
