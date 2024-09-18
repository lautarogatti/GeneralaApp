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
using Negocio;

namespace Generala
{
    public partial class Lobby : Form
    {
        private List<Jugador> jugadores;
        private List<Jugador> perfiles;
        public Lobby()
        {
            InitializeComponent();
        }

        private void Lobby_Load(object sender, EventArgs e)
        {
            jugadores = new List<Jugador>();
            JugadorNegocio jNegocio = new JugadorNegocio();
            perfiles = jNegocio.listar();
            dgvPerfiles.DataSource = perfiles;
            dgvJugadores.DataSource = jugadores;
            ocultarColumnas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dgvPerfiles.CurrentRow.DataBoundItem != null)
            {
                Jugador seleccionado = (Jugador)dgvPerfiles.CurrentRow.DataBoundItem;
                jugadores.Add(seleccionado);
                refreshDgv(dgvJugadores, jugadores);
                ocultarColumnas();
            }
        }

        private void btnEliminarPerfil_Click(object sender, EventArgs e)
        {
            if (dgvPerfiles.CurrentRow != null)
            {
                Jugador seleccionado = (Jugador)dgvPerfiles.CurrentRow.DataBoundItem;
                Jugador encontrado = perfiles.Find(x => x.Nombre == seleccionado.Nombre);
                perfiles.Remove(encontrado);
                refreshDgv(dgvPerfiles, perfiles);
                ocultarColumnas();
            }
                
        }

        private void refreshDgv(DataGridView dgv, List<Jugador> dataSource)
        {
            dgv.DataSource = null;
            dgv.DataSource = dataSource;
        }
        private void ocultarColumnas()
        {
            dgvPerfiles.Columns["Id"].Visible = false;
            dgvJugadores.Columns["Id"].Visible = false;


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }
    }
}
