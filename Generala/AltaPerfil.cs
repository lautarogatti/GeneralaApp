using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generala
{
    public partial class AltaPerfil : Form
    {
        public AltaPerfil()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            JugadorNegocio negocio = new JugadorNegocio();
            string nuevoNombre = txbNombre.Text;
            Jugador nuevo = new Jugador();
            nuevo.Nombre = nuevoNombre;
            try
            {
                negocio.agregar(nuevo);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
