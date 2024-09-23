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

namespace Generala
{
    public partial class Game : Form
    {
        private BindingList<Jugador> Jugadores;
        int cantJugadores;
        public Game(BindingList<Jugador> jugadores, int cantJugadores)
        {
            InitializeComponent();
            this.Jugadores = jugadores;
            this.cantJugadores = cantJugadores;
        }
        private void Game_Load(object sender, EventArgs e)
        {
            cerrarLobby();
        }

        private void btnDadoUno_Click(object sender, EventArgs e)
        {
            Dado dadoUno = new Dado(7);
            lblDadoUno.Text = dadoUno.tirar().ToString();
            lblDadoDos.Text = dadoUno.tirar().ToString();
            lblDadoTres.Text = dadoUno.tirar().ToString();
            lblDadoCuatro.Text = dadoUno.tirar().ToString();
            lblDadoCinco.Text = dadoUno.tirar().ToString();
        }

        private void cerrarLobby()
        {
            foreach (Form item in Application.OpenForms)
            {
                if(item.GetType() == typeof(Lobby))
                {
                    item.Close();
                }
            }
        }
    }
}
