﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OO_Abstração
{
    internal class Livro : Produto
    {
        public override double CalcularDesconto()
        {
            return Preco * 0.05;
        }
    }
}
