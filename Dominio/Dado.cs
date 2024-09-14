using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Dado
    {
        public int Lados { get; set; }
        public int ValorActual { get; set; }

        public Dado(int lados) {
            this.Lados = lados;
        }

        public int tirar()
        {
            Random random = new Random();
            ValorActual = random.Next(1, Lados);
            return ValorActual;
        }

    }
}
