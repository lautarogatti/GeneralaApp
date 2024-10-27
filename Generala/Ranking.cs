using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Generala;
using Negocio;


namespace Generala
{
    public partial class Ranking : Form
    {
        public Ranking()
        {
            InitializeComponent();
        }

        private void Ranking_Load(object sender, EventArgs e)
        {
            /* Proposito: Este metodo se ejecuta cuando el formulario ranking se carga.  */
            JugadorNegocio jugadorNegocio = new JugadorNegocio();  // Creo una instancia/variable de jugador negocio.
            List<Jugador> jugadores = jugadorNegocio.listar(); //  en la variable "jugadores" guardo todos los jugadores listados de la base de datos.
            BindingList<Jugador> jugadoresBindingList = new BindingList<Jugador>(jugadores);//convierto la list<Jugador> por una BindingList<Jugador> ya que listar me devuelve una lista y no una bindingList.
            BindingList<Jugador> jugadoresOrdenados = OrdenarJugadoresPorPartidasGanadas(jugadoresBindingList); // LLamo a la funcion "OrdenarJugadoresPorPartidasGanadas" para que me ordene de mayor a menor de los jugadores segun sus partidas ganadas en "jugadoresOrdenadods".

            dgvRanking.DataSource = jugadoresOrdenados;
        }
        private BindingList<Jugador> OrdenarJugadoresPorPartidasGanadas(BindingList<Jugador> jugadores)
        /*
         Propósito: Este método recibe una lista de jugadores (BindingList<Jugador> jugadores) y los ordena de mayor a menor en función de las PartidasGanadas.
         */
        {
            BindingList<Jugador> jugadoresOrdenados = new BindingList<Jugador>(); //inicializo BindingList<Jugador> que va a guardar a los jugadores ya ordenados por sus partidas ganadas.
            List<Jugador> listaTemporal = new List<Jugador>(jugadores);  // Desde la lista dada por parametro, creo una nueva listaTemporal para ordenar 

            while (listaTemporal.Count > 0) // Mientras haya jugadores en listaTemporal, el bucle sigue. (basicamente cuando listaTemporal está vacia termina el bucle)
            {
                Jugador jugadorConMasGanadas = listaTemporal[0]; //Inicializo una variable que va a contener el jugador con más partidas ganadas, le guardo el primer jugador de la lista temporal.

                foreach (Jugador jugador in listaTemporal) // aca comparo "jugadorConMasGanadas" con cada jugador de lista temporal.
                {
                    if (jugador.PartidasGanadas > jugadorConMasGanadas.PartidasGanadas) // Si el jugador actual tiene más partidas ganadas que jugadorConMasGanadas, entonces jugadorConMasGanadas se actualiza a este jugador.
                    {
                        jugadorConMasGanadas = jugador;
                    }
                }

                jugadoresOrdenados.Add(jugadorConMasGanadas); // guardo el jugador con mas ganadas a la lista de jugadores ordenados de mayor a menor.
                listaTemporal.Remove(jugadorConMasGanadas);//elimino de listaTemporal al "jugadorConMasGanadas" ya que, ya lo agregé a la lista que quiero retornar y no hace falta que lo verifique devuelta.
            } 

            return jugadoresOrdenados; // retorno la lista ordenada de mayor a menor segun sus partidas ganadas.
        }
        private void btnAlMenu_Click(object sender, EventArgs e)
        {
            MenuPrincipal principal = new MenuPrincipal();
            this.Close();
            principal.Show();
        }
    }


}
