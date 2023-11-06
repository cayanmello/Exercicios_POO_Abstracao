using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OO_Abstração
{
    internal abstract class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo {  get; set; }

        public abstract void Dirigir();
    }
}
