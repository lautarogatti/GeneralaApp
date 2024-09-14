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
        private Random random;

        public Dado(int lados) {
            this.Lados = lados;
            random = new Random();  
        }

        public int tirar()
        {
            ValorActual = random.Next(1, Lados);
            return ValorActual;
        }

    }
}
