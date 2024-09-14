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
using Negocio;

namespace Generala
{
    public partial class Lobby : Form
    {
        private List<Jugador> jugadores;
        public Lobby()
        {
            InitializeComponent();
        }

        private void Lobby_Load(object sender, EventArgs e)
        {
            jugadores = new List<Jugador>();
            JugadorNegocio jNegocio = new JugadorNegocio();
            dgvPerfiles.DataSource = jNegocio.listar();
            dgvJugadores.DataSource = jugadores;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dgvPerfiles.CurrentRow.DataBoundItem != null)
            {
                Jugador seleccionado = (Jugador)dgvPerfiles.CurrentRow.DataBoundItem;
                jugadores.Add(seleccionado);
                refreshDgv(dgvJugadores, jugadores);
            }
        }

        private void refreshDgv(DataGridView dgv, List<Jugador> dataSource)
        {
            dgv.DataSource = null;
            dgv.DataSource = dataSource;
        }
    }
}
