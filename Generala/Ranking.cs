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
            JugadorNegocio jugadorNegocio = new JugadorNegocio();
            List<Jugador> jugadores = jugadorNegocio.listar();
            dgvRanking.DataSource = jugadores;
        }
        private BindingList<Jugador> ordenarDeMayorAMenorPorGanadas()
        {
            /*
            BindingList<Jugador> listaOrdenadaDeMayorAmenor = new BindingList<Jugador>();
            for (int i = 0; i < cantJugadores; i++)
            {
                int indice = 0;
                Player j = new Player(0, "");
                int mayor = 0;
                foreach (Player p in ListaDePlayers)
                {
                    if (indice == 0)
                    {
                        j = p;
                        mayor = int.Parse(p.TotalPuntaje);
                        indice++;
                    }
                    else if (int.Parse(p.TotalPuntaje) > mayor)
                    {
                        mayor = int.Parse(p.TotalPuntaje);
                        j = p;
                    }
                }
                listaOrdenadaDeMayorAmenor.Add(j);
                ListaDePlayers.Remove(j);
            }
            ListaDePlayers = listaOrdenadaDeMayorAmenor;
       
            */
            /* 
             * Proposito: Devuelve una lista de Jugadores ordenada de mayor a menor en base a su cantidad de Partidas ganadas.
             * Precondicion: Ninguna.
             * Tipo: BindingList de Jugadores.
             * Observacion: Es un recorrido de procesamiento.
             *         Recorre cada jugador de la lista de jugadores y se queda con el jugador con mayor partidas ganadas y lo agrega a la lista de mayor a menor.
             */
                int indice = 0;
                BindingList<Jugador> jugadoresDesordenada = new BindingList<Jugador>();
                BindingList<Jugador> listaDeMayorAMenor = new BindingList<Jugador>();
                Jugador mayorHastaAhora;
                while (indice > jugadoresDesordenada.Count ) // no hay mas elementos por recorrer 
            {
                    indice++; 
                    Jugador jugadorActual = jugadoresDesordenada[indice];

                    mayorHastaAhora =  AgregarMayorEntre(jugadorActual, )// comparo entre 2 jugadores y agrego al jugador que tenga mayor cantidad de partidas ganadas en la variable "mayor".
            }
                 return (listaDeMayorAMenor);
        }

        private Jugador AgregarMayorEntre(Jugador jugador,Jugador jugador2)
        {
            if( jugador.PartidasGanadas > jugador2.PartidasGanadas)
            {
                return jugador;
            } else
            {
                return jugador2;
            }
        }



        private void btnAlMenu_Click(object sender, EventArgs e)
        {
            MenuPrincipal principal = new MenuPrincipal();
            this.Close();
            principal.Show();
        }
    }


}
