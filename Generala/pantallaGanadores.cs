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
using Helpers;
namespace Generala
{
    public partial class PantallaGanadores : Form
    {
        BindingList<Player> ListaDePlayers;

        public int cantJugadores { get; private set; }

        public PantallaGanadores(BindingList<Player> players, int cantJugadores)
        {
            InitializeComponent();
            ListaDePlayers = players;
            this.cantJugadores = cantJugadores;
        }

        private void PantallaGanadores_Load(object sender, EventArgs e)
        {
            dgvTablaScore.DataSource = ListaDePlayers;
            Helper.ocultarColumna(dgvTablaScore, "Id");
            Helper.ocultarColumna(dgvTablaScore, "Uno");
            Helper.ocultarColumna(dgvTablaScore, "Dos");
            Helper.ocultarColumna(dgvTablaScore, "Tres");
            Helper.ocultarColumna(dgvTablaScore, "Cuatro");
            Helper.ocultarColumna(dgvTablaScore, "Cinco");
            Helper.ocultarColumna(dgvTablaScore, "Seis");
            Helper.ocultarColumna(dgvTablaScore, "Escalera");
            Helper.ocultarColumna(dgvTablaScore, "Full");
            Helper.ocultarColumna(dgvTablaScore, "Poker");
            Helper.ocultarColumna(dgvTablaScore, "Generala");
            Helper.ocultarColumna(dgvTablaScore, "GeneralaDoble");
        }
        private void sumarPuntaje()
        {
            foreach(Player p in ListaDePlayers)
            {
                int total = 0;
                if( p.Uno != "-" || p.Uno != "x")
                {
                    total += int.Parse(p.Uno);
                }
                if(p.Dos != "-" || p.Dos != "x")
                {
                    total += int.Parse(p.Dos);
                }
                if (p.Tres != "-" || p.Tres != "x")
                {
                    total += int.Parse(p.Tres);
                }
                if (p.Cuatro != "-" || p.Cuatro != "x")
                {
                    total += int.Parse(p.Cuatro);
                }
                if (p.Cinco != "-" || p.Cinco != "x")
                {
                    total += int.Parse(p.Cinco);
                }
                if (p.Seis != "-" || p.Seis != "x")
                {
                    total += int.Parse(p.Seis);
                }
                if (p.Escalera != "-" || p.Escalera != "x")
                {
                    total += int.Parse(p.Escalera);
                }
                if (p.Full != "-" || p.Full != "x")
                {
                    total += int.Parse(p.Full);
                }
                if (p.Poker != "-" || p.Poker != "x")
                {
                    total += int.Parse(p.Poker);
                }
                if (p.Generala != "-" || p.Generala != "x")
                {
                    total += int.Parse(p.Generala);
                }
                if (p.GeneralaDoble != "-" || p.GeneralaDoble != "x")
                {
                    total += int.Parse(p.GeneralaDoble);
                }
                p.TotalPuntaje = total.ToString();
            }
        }
    }
}

