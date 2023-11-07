using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OO_Abstração
{
    internal class Calculadora
    {
        public int Somar(params int[] numeros)
        {
            int resultado = 0;
            foreach (int numero in numeros)
            {
                resultado += numero;
            }
            return resultado;
        }

        public decimal Somar(params decimal[] numeros)
        {
            decimal resultado = 0;
            foreach (decimal numero in numeros)
            {
                resultado += numero;
            }
            return resultado;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public decimal Subtrair(decimal a, decimal b)
        {
            return a - b;
        }

        public int Multiplicar(params int[] numeros)
        {
            int resultado = 1;
            foreach (int numero in numeros)
            {
                resultado *= numero;
            }
            return resultado;
        }

        public decimal Multiplicar(params decimal[] numeros)
        {
            decimal resultado = 1;
            foreach (decimal numero in numeros)
            {
                resultado *= numero;
            }
            return resultado;
        }

        public int Dividir(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("O divisor não pode ser zero.");
            }
            return a / b;
        }

        public decimal Dividir(decimal a, decimal b)
        {
            if (b == 0)
            {
                throw new ArgumentException("O divisor não pode ser zero.");
            }
            return a / b;
        }
    }
}
