using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Player
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Uno { get; set; }
        public string Dos { get; set; }
        public string Tres { get; set; }
        public string Cuatro { get; set; }
        public string Cinco { get; set; }
        public string Seis { get; set; }
        public string Escalera { get; set; }
        public string Full { get; set; }
        public string Poker { get; set; }
        public string Generala { get; set; }
        public string GeneralaDoble { get; set; }

        public Player(int id,string nombre)
        {
            this.Id = id;
            this.Nombre = nombre;
            Uno = "-";
            Dos = "-";
            Tres = "-";
            Cuatro = "-";
            Cinco = "-";
            Seis = "-";
            Escalera = "-";
            Full = "-";
            Poker = "-";
            Generala = "-";
            GeneralaDoble = "-";
        }
    }
}
