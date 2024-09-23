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
using Helpers;

namespace Generala
{
    public partial class Game : Form
    {
        private BindingList<Jugador> Jugadores;
        int cantJugadores;
        private BindingList<Player> Players;
        public Game(BindingList<Jugador> jugadores, int cantJugadores)
        {
            InitializeComponent();
            this.Jugadores = jugadores;
            this.cantJugadores = cantJugadores;
        }
        private void Game_Load(object sender, EventArgs e)
        {
            cerrarLobby();
            iniciarPbx();
            Players = generarListaPlayers(Jugadores);
            dgvScores.DataSource = Players;
        }

        private void btnDadoUno_Click(object sender, EventArgs e)
        {
            Dado dadoUno = new Dado(7);
        }

        private void cerrarLobby()
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Lobby))
                {
                    item.Close();
                }
            }
        }
        private void iniciarPbx()
        {
            string ruta = "C:\\Users\\Usuario\\Desktop\\proyecto-generala\\GeneralaApp\\Generala\\assets\\img\\dados\\random.gif";
            Helper.cargarImagen(ruta, pbxDUno);
            Helper.cargarImagen(ruta, pbxDDos);
            Helper.cargarImagen(ruta, pbxDTres);
            Helper.cargarImagen(ruta, pbxDCuatro);
            Helper.cargarImagen(ruta, pbxDCinco);
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == typeof(MenuPrincipal))
                {
                    item.Show();
                }
            }
        }
        private BindingList<Player> generarListaPlayers(BindingList<Jugador> jugadores)
        {
            BindingList<Player> lista = new BindingList<Player>();
            foreach (Jugador j in jugadores)
            {
                Player p = new Player(j.Id, j.Nombre);
                lista.Add(p);
            }
            return lista;
        }
    }
}
