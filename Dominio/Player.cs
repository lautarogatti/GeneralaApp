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
        public int Uno { get; set; }
        public int Dos { get; set; }
        public int Tres { get; set; }
        public int Cuatro { get; set; }
        public int Cinco { get; set; }
        public int Seis { get; set; }
        public int Escalera { get; set; }
        public int Full { get; set; }
        public int Poker { get; set; }
        public int Generala { get; set; }
        public int GeneralaDoble { get; set; }

        public Player(int id,string nombre)
        {
            this.Id = id;
            this.Nombre = nombre;
            Uno = 0;
            Dos = 0;
            Tres = 0;
            Cuatro = 0;
            Cinco = 0;
            Seis = 0;
            Escalera = 0;
            Full = 0;
            Poker = 0;
            Generala = 0;
            GeneralaDoble = 0;
        }
    }
}
