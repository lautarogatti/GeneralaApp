using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dominio
{
    public class ClassicGeneralaHandler
    {
        private int cantPlayers;
        private int cantRondas;
        private int rondaActual = 0;
        private BindingList<Player> players;
       
        public ClassicGeneralaHandler(BindingList<Player> lista, int cantJugadores, int cantRondas)
        {
            players = lista;
            cantPlayers = cantJugadores;
            this.cantRondas = cantRondas;
        }
    }
}
