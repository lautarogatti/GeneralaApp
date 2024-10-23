using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Generala;
using Helpers;
namespace Generala
{
    public partial class PantallaGanadores : Form
    {
        BindingList<Player> ListaDePlayers;

        public int cantJugadores { get; set; }

        public PantallaGanadores(BindingList<Player> players, int cantJugadores)
        {
            InitializeComponent();
            ListaDePlayers = players;
            this.cantJugadores = cantJugadores;
        }

        private void PantallaGanadores_Load(object sender, EventArgs e)
        {
            sumarPuntaje();
            ordenarPorMayorPuntaje();
            elegirGanador();
            dgvTablaScore.DataSource = ListaDePlayers;
            ocultarColumnas();
        }

        private void ocultarColumnas()
        {
            List<string> categorias = new List<string>
            {
                "Id", "Uno", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Escalera", "Full", "Poker",
                "Generala", "GeneralaDoble"
            };
            foreach(string s in categorias)
            {
                Helper.ocultarColumna(dgvTablaScore, s);
            }
        }
        private void sumarPuntaje()
        {
            foreach(Player p in ListaDePlayers)
            {
                int total = 0;
                if( p.Uno != "-" && p.Uno != "x")
                {
                    total += int.Parse(p.Uno);
                }
                if(p.Dos != "-" && p.Dos != "x")
                {
                    total += int.Parse(p.Dos);
                }
                if (p.Tres != "-" && p.Tres != "x")
                {
                    total += int.Parse(p.Tres);
                }
                if (p.Cuatro != "-" && p.Cuatro != "x")
                {
                    total += int.Parse(p.Cuatro);
                }
                if (p.Cinco != "-" && p.Cinco != "x")
                {
                    total += int.Parse(p.Cinco);
                }
                if (p.Seis != "-" && p.Seis != "x")
                {
                    total += int.Parse(p.Seis);
                }
                if (p.Escalera != "-" && p.Escalera != "x")
                {
                    total += int.Parse(p.Escalera);
                }
                if (p.Full != "-" && p.Full != "x")
                {
                    total += int.Parse(p.Full);
                }
                if (p.Poker != "-" && p.Poker != "x")
                {
                    total += int.Parse(p.Poker);
                }
                if (p.Generala != "-" && p.Generala != "x")
                {
                    total += int.Parse(p.Generala);
                }
                if (p.GeneralaDoble != "-" && p.GeneralaDoble != "x")
                {
                    total += int.Parse(p.GeneralaDoble);
                }
                p.TotalPuntaje = total.ToString();
            }
        }
        private void elegirGanador()
        {
            Player jugadorMasPuntaje = ListaDePlayers.First();

            lblGanador.Text = "El ganador es: " + jugadorMasPuntaje.Nombre;
        }

        private void ordenarPorMayorPuntaje()
        {
            BindingList<Player> listaOrdenadaDeMayorAmenor = new BindingList<Player>();
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
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == typeof(MenuPrincipal))
                {
                    item.Show();
                }
            }
            this.Close();
        }

        private void btnJugarDenuevo_Click(object sender, EventArgs e)
        {
            Lobby lobby = new Lobby();
            lobby.Show();
            this.Close();
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            Ranking rank = new Ranking();
            rank.Show();
            this.Close();
        }
    }
}

