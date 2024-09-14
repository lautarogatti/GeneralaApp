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
        public Game()
        {
            InitializeComponent();
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
    }
}
