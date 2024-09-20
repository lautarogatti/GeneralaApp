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
        private BindingList<Jugador> jugadores;
        private List<Jugador> perfiles;
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
            dgvPerfiles.Columns["Id"].Visible = false;
            dgvJugadores.Columns["Id"].Visible = false;


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
    }
}
