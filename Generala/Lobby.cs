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
using Helpers;
using Negocio;

namespace Generala
{
    public partial class Lobby : Form
    {
        private BindingList<Jugador> jugadores;
        private List<Jugador> perfiles;
        private int maxJugadores = 12;
        public Lobby()
        {
            InitializeComponent();
        }

        private void Lobby_Load(object sender, EventArgs e)
        {
            jugadores = new BindingList<Jugador>();
            JugadorNegocio jNegocio = new JugadorNegocio();
            perfiles = jNegocio.listar();
            dgvPerfiles.DataSource = perfiles;
            dgvJugadores.DataSource = jugadores;
            ocultarColumnas();
            actualizarEstadoLobby();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dgvPerfiles.CurrentRow.DataBoundItem != null)
            {
                Jugador seleccionado = (Jugador)dgvPerfiles.CurrentRow.DataBoundItem;
                jugadores.Add(seleccionado);
                //refreshDgv(dgvJugadores, jugadores);
                dgvJugadores.DataSource = jugadores;
                ocultarColumnas();
                actualizarEstadoLobby();
            }
        }

        private void btnEliminarPerfil_Click(object sender, EventArgs e)
        {
            if (dgvPerfiles.CurrentRow != null)
            {
                JugadorNegocio negocio = new JugadorNegocio();
                Jugador seleccionado = (Jugador)dgvPerfiles.CurrentRow.DataBoundItem;
                DialogResult validacion = MessageBox.Show("Esta seguro que desea eliminar este perfil?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (validacion == DialogResult.Yes)
                {
                    try
                    {
                        negocio.eliminar(seleccionado);
                        perfiles = negocio.listar();
                        refreshDgv(dgvPerfiles, perfiles);
                        ocultarColumnas();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }

        }

        private void refreshDgv(DataGridView dgv, List<Jugador> dataSource)
        {
            dgv.DataSource = null;
            dgv.DataSource = dataSource;
        }
        private void ocultarColumnas()
        {
            Helper.ocultarColumna(dgvPerfiles, "Id");
            Helper.ocultarColumna(dgvJugadores, "Id");

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            JugadorNegocio negocio = new JugadorNegocio();
            AltaPerfil alta = new AltaPerfil();
            alta.ShowDialog();
            perfiles = negocio.listar();
            refreshDgv(dgvPerfiles, perfiles);
            ocultarColumnas();
        }

        private void btnQuitarLobby_Click(object sender, EventArgs e)
        {
            if(dgvJugadores.CurrentRow != null)
            {
            Jugador seleccionado = (Jugador)dgvJugadores.CurrentRow.DataBoundItem;
            jugadores.Remove(seleccionado);
                actualizarEstadoLobby();
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Game partida = new Game(jugadores, contarJugadores());
            partida.Show();
            this.Close();
        }

        private int contarJugadores()
        {
            int cantidad = 0;
            foreach (Jugador item in jugadores)
            {
                cantidad++;
            }
            return cantidad;
        }

        private string estadoActualLobby()
        {
            string mensaje;
            int cantidad = contarJugadores();
            mensaje = cantidad + "/" + maxJugadores;
            return mensaje;
        }

        private void actualizarEstadoLobby()
        {
            lblEstadoLobby.Text = estadoActualLobby();
        }
    }
}
