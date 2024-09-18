using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Jugador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int PartidasGanadas { get; set; }
        public int PartidasJugadas { get; set; }

        //private List<Categoria> puntajes;

        /*public void setPuntajes(List<Categoria> lista)
        {
            puntajes = lista;
        }

        public List<Categoria> getPuntajes()
        {
            return puntajes;
        }*/
    }
}
