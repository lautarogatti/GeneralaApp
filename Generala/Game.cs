using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Helpers;

namespace Generala
{
    public partial class Game : Form
    {
        int tiradaActual = 1;
        List<CheckBox> checkboxes;

        Dado dado = new Dado(7);
        //binding list contenedora de los objetos jugador participantes de la partida
        private BindingList<Jugador> jugadores;

        // variable contenedora del numero de jugadores participantes de la partida
        private int cantJugadores;

        //binding list contenedora de objetos player, rellenados con los datos de cada objeto jugador para mantener trackeo de los scores actuales de la partida
        private BindingList<Player> players;

        //variable contenedora del numero maximo de rondas a jugar la partida
        private int rondas;

        //variable contenedora del numero de la ronda que se esta jugando en el momento
        private int rondaActual = 1;

        //vector contenedor de los numeros obtenidos de la ultima tirada de dados
        private int[] tiradaDados = new int[5];

        //variable contenedora del numero de turno actual, cada player tiene un numero asignado en el vector de players "turnos" representado por su indice de ubicacion en el mismo vector
        private int turnoActual;

        //vector de objetos Player utilizado para definir de que jugador es el turno basado en el indice de su ubicacion en el mismo
        Player[] turnos;

        //lista contenedora de pictureboxes que dan imagen a los dados
        List<PictureBox> pictureBoxes;

        //
        //
        //
        //
        //
        //////////////////////////////////////////////////////CONSTRUCTOR////////////////////////////////////////////////////
        //
        //
        //constructor del formulario que pide por parametro una bindinglist de objetos jugador y un entero que represente la cantidad de jugadores dentro de la lista
        public Game(BindingList<Jugador> jugadores, int cantJugadores)
        {
            InitializeComponent();
            this.jugadores = jugadores;
            this.cantJugadores = cantJugadores;
        }

        /////////////////////////////////////////////// EVENTOS ///////////////////////////////////////////////////////

        private void Game_Load(object sender, EventArgs e)
        {
            players = generarListaPlayers(jugadores);
            dgvScores.DataSource = players;
            pictureBoxes = new List<PictureBox>
            {
                pbxDUno, pbxDDos, pbxDTres, pbxDCuatro, pbxDCinco
            };
            checkboxes = new List<CheckBox>() {
                ckbDuno,
                ckbDDos,
                ckbDTres,
                ckbDCuatro,
                ckbDCinco
                };
            setupFormGui();
            iniciarPbx();
            iniciarGeneralaClassic();
            Helper.ocultarColumna(dgvScores, "Id");
            Helper.cargarImagen("C:\\Users\\Cloud\\Desktop\\proyectoGenerala\\GeneralaApp\\Generala\\assets\\img\\roca.gif", pbxJumbotron);
            mostrarResolucion();
            actualizarLblTiradaActual();
        }

        private void btnDadoUno_Click(object sender, EventArgs e)
        {
            if (tiradaActual == 1)
            {
                tirarDados();
                actualizarPbx();
                actualizarTiradaActual();
                actualizarLblTiradaActual();
                deseleccionarDados(checkboxes);
                escondeBotonTirarSiesUltimaTirada();
                EsconderOMostrarBtnAnotar();
            }
            else if (hayDadosSeleccionados())
            {
                tirarSeleccionados(generarListaDeSeleccionados(checkboxes));
                actualizarPbx();
                actualizarTiradaActual();
                actualizarLblTiradaActual();
                deseleccionarDados(checkboxes);
                escondeBotonTirarSiesUltimaTirada();
                EsconderOMostrarBtnAnotar();
            }
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

        private void btnGenerala_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                tiradaDados[i] = i + 1;
            }
            actualizarPbx();
        }

        private void btnAnotar_Click(object sender, EventArgs e)
        {
            if (anotar())
            {
                actualizarRondaActual();
                finalizarTurno();
                actualizarLblTiradaActual();
                escondeBotonTirarSiesUltimaTirada();
                actualizarlBLTurnoActual();
                actualizarLblRondaActual();
                turnoActualEnDgv();
                dgvScores.DataSource = players;
                deseleccionarDados(checkboxes);
                iniciarPbx();
                EsconderOMostrarBtnAnotar();
            }

        }

        private void pbxDUno_Click(object sender, EventArgs e)
        {
            if (tiradaActual != 1)
            {
                if (!ckbDuno.Checked == true)
                {
                    ckbDuno.Checked = true;
                    Helper.cargarImagen(crearRutaAlt(0), pbxDUno);
                }
                else
                {
                    ckbDuno.Checked = false;
                    Helper.cargarImagen(crearRuta(0), pbxDUno);
                }

            }
        }

        private void pbxDDos_Click(object sender, EventArgs e)
        {
            if (tiradaActual != 1)
            {
                if (!ckbDDos.Checked == true)
                {
                    ckbDDos.Checked = true;
                    Helper.cargarImagen(crearRutaAlt(1), pbxDDos);
                }
                else
                {
                    ckbDDos.Checked = false;
                    Helper.cargarImagen(crearRuta(1), pbxDDos);
                }
            }

        }

        private void pbxDTres_Click(object sender, EventArgs e)
        {
            if (tiradaActual != 1)
            {
                if (!ckbDTres.Checked == true)
                {
                    ckbDTres.Checked = true;
                    Helper.cargarImagen(crearRutaAlt(2), pbxDTres);
                }
                else
                {
                    ckbDTres.Checked = false;
                    Helper.cargarImagen(crearRuta(2), pbxDTres);
                }
            }

        }

        private void pbxDCuatro_Click(object sender, EventArgs e)
        {
            if (tiradaActual != 1)
            {
                if (!ckbDCuatro.Checked == true)
                {
                    ckbDCuatro.Checked = true;
                    Helper.cargarImagen(crearRutaAlt(3), pbxDCuatro);
                }
                else
                {
                    ckbDCuatro.Checked = false;
                    Helper.cargarImagen(crearRuta(3), pbxDCuatro);
                }
            }

        }

        private void pbxDCinco_Click(object sender, EventArgs e)
        {
            if (tiradaActual != 1)
            {
                if (!ckbDCinco.Checked == true)
                {
                    ckbDCinco.Checked = true;
                    Helper.cargarImagen(crearRutaAlt(4), pbxDCinco);
                }
                else
                {
                    ckbDCinco.Checked = false;
                    Helper.cargarImagen(crearRuta(4), pbxDCinco);
                }
            }

        }


        //////////////////////////////////////////////////METODOS///////////////////////////////////////////////////

        //funcion encargada de cargar los picturebox con la imagen de dado randomizado
        private void iniciarPbx()
        {
            string ruta = "C:\\Users\\Cloud\\Desktop\\proyectoGenerala\\GeneralaApp\\Generala\\assets\\img\\random.gif";
            foreach (PictureBox pbx in pictureBoxes)
            {
                Helper.cargarImagen(ruta, pbx);
            }
        }

        //funcion que configura la cantidad de rondas, la ronda actualy el turno actual para el inicio de una nueva partida de generala
        private void iniciarGeneralaClassic()
        {
            rondas = 11;
            turnoActual = 0;
            generarTurnero();
            definirTurnoActual();
            actualizarLblRondaActual();
            EsconderOMostrarBtnAnotar();
        }

        //funcion que genera una tirada de dados y la retorna dentro de un vector de enteros
        private void tirarDados()
        {
            for (int i = 0; i < 5; i++)
            {
                int r;
                r = dado.tirar();
                tiradaDados[i] = r;
            }
        }

        // funcion que se encarga de actualizar los labels con los resultados de la tirada de dados
        private void actualizarPbx()
        {
            int index = 0;
            foreach (PictureBox pbx in pictureBoxes)
            {
                Helper.cargarImagen(crearRuta(index), pbx);
                index++;
            }
        }

        private string crearRuta(int index)
        {
            string ruta = "C:\\Users\\Cloud\\Desktop\\proyectoGenerala\\GeneralaApp\\Generala\\assets\\img\\" + tiradaDados[index] + ".jpg";
            return ruta;
        }
        private string crearRutaAlt(int index)
        {
            string ruta = "C:\\Users\\Cloud\\Desktop\\proyectoGenerala\\GeneralaApp\\Generala\\assets\\img\\" + tiradaDados[index] + "alt.jpg";
            return ruta;
        }

        //funcion que toma una bindinglist de jugadores y retorna una nueva bindinglist de objetos player rellenados con la informacion de los jugadores para el manejo de puntaje de cada uno
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

        // funcion que definira el turno actual y actualizara el label que informa el turno que sera jugado en el momento
        private void definirTurnoActual()
        {
            if (turnoActual >= cantJugadores)
            {
                // turnoActual = 0;
                lblTurnoActual.Text = "Turno actual: " + turnos[turnoActual].Nombre;
            }
            else
            {
                lblTurnoActual.Text = "Turno actual: " + turnos[turnoActual].Nombre;
            }
        }

        // funcion que genera un vector de jugadores acomodados, que sera usado para definir el orden de los turnos
        private void generarTurnero()
        {
            turnos = new Player[cantJugadores];
            int index = 0;
            foreach (Player p in players)
            {
                turnos[index] = p;
                index++;
            }
        }

        private string verificarJuego()
        {
            if (verificarGenerala(tiradaDados))
            {
                return "generala";
            }
            else if (verificarPoker(tiradaDados))
            {
                return "poker";
            }
            else if (verificarFull(tiradaDados))
            {
                return "full";
            }
            else if (verificarEscalera(tiradaDados))
            {
                return "escalera";
            }
            return "nada";
        }

        private bool verificarEscalera(int[] tiradadDados)
        {
            List<int> escaleraUno = new List<int>()
            {
                1, 2, 3, 4, 5
            };
            List<int> escaleraDos = new List<int>()
            {
                2, 3, 4, 5, 6
            };
            if (estanTodosPresentes(tiradaDados, escaleraUno))
            {
                return true;
            }
            else if (estanTodosPresentes(tiradaDados, escaleraDos))
            {
                return true;
            }
            return false;
        }

        private bool estanTodosPresentes(int[] tiradaDados, List<int> listaEscalera)
        {
            foreach (int num in listaEscalera)
            {
                if (!estaPresente(num, tiradaDados))
                {
                    return false;
                }
            }
            return true;
        }

        private bool estaPresente(int num, int[] tiradaDados)
        {
            for (int i = 0; i < 5; i++)
            {
                if (num == tiradaDados[i])
                {
                    return true;
                }
            }
            return false;
        }

        private bool verificarFull(int[] tiradaDados)
        {
            if (cuantoSeRepite(tiradaDados[0], tiradaDados) == 3)
            {
                if (cuantoSeRepite(buscarDistinto(tiradaDados[0], tiradaDados), tiradaDados) == 2)
                {
                    return true;
                }
            }
            else if (cuantoSeRepite(tiradaDados[0], tiradaDados) == 2)
            {
                if (cuantoSeRepite(buscarDistinto(tiradaDados[0], tiradaDados), tiradaDados) == 3)
                {
                    return true;
                }
            }
            return false;
        }

        private bool verificarPoker(int[] tiradaDados)
        {
            int contador = 0;
            for (int i = 0; i < 5; i++)
            {
                int iguales = 0;
                for (int x = 0; x < 5; x++)
                {
                    if (tiradaDados[i] == tiradaDados[x])
                    {
                        iguales++;
                    }
                }
                if (iguales == 4)
                {
                    contador++;
                }
            }
            if (contador == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool verificarGenerala(int[] tirada)
        {
            int numAnterior = 0;
            bool primeraVuelta = true;

            for (int i = 0; i < 5; i++)
            {
                if (primeraVuelta)
                {
                    numAnterior = tirada[i];
                    primeraVuelta = false;
                }
                else if (numAnterior != tirada[i])
                {
                    return false;
                }
            }
            return true;
        }

        private int buscarDistinto(int numero, int[] tirada)
        {
            for (int i = 0; i < 5; i++)
            {
                if (tirada[i] != numero)
                {
                    return tirada[i];
                }
            }
            return 0;
        }

        private int cuantoSeRepite(int numero, int[] tirada)
        {
            int contador = 0;
            for (int i = 0; i < 5; i++)
            {
                if (tirada[i] == numero)
                {
                    contador++;
                }
            }
            return contador;
        }

        private void mostrarResolucion()
        {
            Size tamaño = this.Size;
            lblResolucion.Text = "altura: " + tamaño.Height + " ancho: " + tamaño.Width;
        }

        private void setupFormGui()
        {
            setupDgv();
            setupGb();
            setupPbxDados();
        }

        private void setupPbxDados()
        {
            setupPbxDadosSize();
            setupPbxDadosPosition();
        }

        private void setupPbxDadosSize()
        {
            foreach (PictureBox pbx in pictureBoxes)
            {
                pbx.Height = gbDados.Height * 30 / 100;
                pbx.Width = gbDados.Width * 30 / 100;
            }
        }

        private void setupPbxDadosPosition()
        {
            pbxDUno.Location = new Point(gbDados.Width * 5 / 100, gbDados.Height * 5 / 100);
            pbxDDos.Location = new Point((gbDados.Width - (gbDados.Width * 5 / 100)) - pbxDDos.Width, gbDados.Height * 5 / 100);
            pbxDTres.Location = new Point((gbDados.Width / 2) - (pbxDTres.Width / 2), (gbDados.Height / 2) - (pbxDTres.Height / 2));
            pbxDCuatro.Location = new Point(gbDados.Width * 5 / 100, (gbDados.Height - (gbDados.Height * 5 / 100)) - pbxDCuatro.Height);
            pbxDCinco.Location = new Point((gbDados.Width - (gbDados.Width * 5 / 100)) - pbxDCinco.Width, (gbDados.Height - (gbDados.Height * 5 / 100)) - pbxDCinco.Height);
        }

        private void setupGb()
        {
            setupGbSize();
            setupGbPosition();
        }

        private void setupGbSize()
        {
            gbDados.Width = this.Width * 30 / 100;
            gbDados.Height = this.Width * 30 / 100;
        }

        private void setupGbPosition()
        {
            gbDados.Top = this.Height * 10 / 100;
            gbDados.Left = this.Width / 3;
        }

        private void setupDgv()
        {
            setupDgvSize();
            dgvScores.RowHeadersVisible = false;
            setupDgvColumnWidth();
            setupDgvPosition();
        }

        private void setupDgvSize()
        {
            int ancho = this.Size.Width * 90 / 100;
            int alto = this.Size.Height * 20 / 100;
            dgvScores.Size = new Size(ancho, alto);
        }

        private void setupDgvColumnWidth()
        {
            foreach (DataGridViewColumn column in dgvScores.Columns)
            {
                column.Width = dgvScores.Width / 12;
            }
        }

        private void setupDgvPosition()
        {
            int x = (this.Size.Width - dgvScores.Width) / 2;
            int y = (this.Size.Height - dgvScores.Height) - (this.Size.Height * 15 / 100);
            dgvScores.Left = x;
            dgvScores.Top = y;
        }

        private void actualizarLblTiradaActual()
        {
            if (tiradaActual <= 3)
            {
                lblTiradaActual.Text = "Tirada Actual: " + tiradaActual + "/3";
            }
            else if (tiradaActual > 3)
            {
                lblTiradaActual.Text = "Tirada Actual: 3/3";
            }
        }

        private bool anotar()
        {
            if (hay1DadoSeleccionado())
            {
                int seleccionado = buscarDadoCorrespondiente(unicoDadoSeleccionado(checkboxes));
                int valorDelDado = tiradaDados[seleccionado];
                int repetido = cuantoSeRepite(valorDelDado, tiradaDados);
                bool validacion = anotarJuegoCorrespondiente(valorDelDado, repetido, turnos[turnoActual]);
                return validacion;
            }
            else if (noHayDadoSeleccionado() || estanTodosLosDadosSeleccionados())
            {
                if (verificarJuego() != "nada")
                {
                    bool validacion = anotarJuegoCorrespondiente(verificarJuego(), turnos[turnoActual]);
                    return validacion;
                }
            }
            return false;
        }
        private bool noHayDadoSeleccionado()
        {
            foreach (CheckBox ckb in checkboxes)
            {
                if (ckb.Checked == true)
                {
                    return false;
                }
            }
            return true;
        }

        private bool estanTodosLosDadosSeleccionados()
        {
            foreach (CheckBox ckb in checkboxes)
            {
                if (ckb.Checked == false)
                {
                    return false;
                }
            }
            return true;
        }
        private bool hay1DadoSeleccionado()
        {
            int contador = 0;
            foreach (CheckBox ckb in checkboxes)
            {
                if (ckb.Checked == true)
                {
                    contador++;
                }
            }
            if (contador == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool anotarJuegoCorrespondiente(int valorDelDado, int repetido, Player jugador)
        {
            if (valorDelDado == 1 && jugador.Uno == "-")
            {
                jugador.Uno = (valorDelDado * repetido).ToString();
                return true;
            }
            else if (valorDelDado == 2 && jugador.Dos == "-")
            {
                jugador.Dos = (valorDelDado * repetido).ToString();
                return true;
            }
            else if (valorDelDado == 3 && jugador.Tres == "-")
            {
                jugador.Tres = (valorDelDado * repetido).ToString();
                return true;
            }
            else if (valorDelDado == 4 && jugador.Cuatro == "-")
            {
                jugador.Cuatro = (valorDelDado * repetido).ToString();
                return true;
            }
            else if (valorDelDado == 5 && jugador.Cinco == "-")
            {
                jugador.Cinco = (valorDelDado * repetido).ToString();
                return true;
            }
            else if (valorDelDado == 6 && jugador.Seis == "-")
            {
                jugador.Seis = (valorDelDado * repetido).ToString();
                return true;
            }
            return false;
        }

        private bool anotarJuegoCorrespondiente(string juego, Player player)
        {
            int valorGenerala = 50;
            int valorPoker = 40;
            int valorFull = 30;
            int valorEscalera = 20;
            if (juego == "generala" && player.Generala == "-")
            {
                if (tiradaActual == 2)
                {
                    player.Generala = (valorGenerala + 5).ToString();
                    return true;
                }
                else
                {
                    player.Generala = valorGenerala.ToString();
                    return true;
                }
            }
            else if (juego == "poker" && player.Poker == "-")
            {
                if (tiradaActual == 2)
                {
                    player.Poker = (valorPoker + 5).ToString();
                    return true;
                }
                else
                {
                    player.Poker = valorPoker.ToString();
                    return true;
                }
            }
            else if (juego == "full" && player.Full == "-")
            {
                if (tiradaActual == 2)
                {
                    player.Full = (valorFull + 5).ToString();
                    return true;
                }
                else
                {
                    player.Full = valorFull.ToString();
                    return true;
                }
            }
            else if (juego == "escalera" && player.Escalera == "-")
            {
                if (tiradaActual == 2)
                {
                    player.Escalera = (valorEscalera + 5).ToString();
                    return true;
                }
                else
                {
                    player.Escalera = valorEscalera.ToString();
                    return true;
                }
            }
            return false;
        }

        private CheckBox unicoDadoSeleccionado(List<CheckBox> checkBoxes)
        {
            foreach (CheckBox checkBox in checkBoxes)
            {
                if (checkBox.Checked)
                {
                    return (checkBox);
                }
            }
            return null;
        }

        private void turnoActualEnDgv()
        {
            DataGridViewRow linea = dgvScores.Rows[turnoActual];
            linea.Selected = true;
        }
        private void actualizarlBLTurnoActual()
        {
            lblTurnoActual.Text = "Turno Actual: " + turnos[turnoActual].Nombre;
        }

        private void actualizarTurnoActual()
        {
            if (turnoActual < cantJugadores - 1)
            {
                turnoActual++;
            }
            else
            {
                turnoActual = 0;
            }
        }
        private void actualizarRondaActual()
        {
            if (rondaActual == 11 && turnoActual == cantJugadores - 1)
            {
                MessageBox.Show("Terminó el juego");
            }
            else if (turnoActual == cantJugadores - 1)
            {
                rondaActual++;
            }
        }
        private void actualizarLblRondaActual()
        {
            lblRondas.Text = "Ronda Actual: " + rondaActual + "/" + rondas;
        }

        private void deseleccionarDados(List<CheckBox> checkboxes)
        {
            foreach (CheckBox ckb in checkboxes)
            {
                ckb.Checked = false;
            }
        }
        private void escondeBotonTirarSiesUltimaTirada()
        {
            if (tiradaActual > 3)
            {
                btnDadoUno.Visible = false;
            }
            else
            {
                btnDadoUno.Visible = true;
            }
        }
        private void actualizarTiradaActual()
        {
            if (tiradaActual <= 3)
            {
                tiradaActual++;
            }
            else
            {
                tiradaActual = 1;
            }
        }
        private void finalizarTurno()
        {
            tiradaActual = 1;
            actualizarTurnoActual();
        }
        private bool hayDadosSeleccionados()
        {
            List<CheckBox> checkboxes = new List<CheckBox>() {
            ckbDuno,
            ckbDDos,
            ckbDTres,
            ckbDCuatro,
            ckbDCinco
            };
            foreach (CheckBox checkbox in checkboxes)
            {
                if (checkbox.Checked)
                {
                    return true;
                }
            }
            return false;
        }
        private List<int> generarListaDeSeleccionados(List<CheckBox> checkBoxes)
        {
            List<int> seleccionados = new List<int>();
            foreach (CheckBox checkbox in checkBoxes)
            {
                if (checkbox.Checked)
                {
                    int dado = buscarDadoCorrespondiente(checkbox);
                    seleccionados.Add(dado);
                }
            }
            return seleccionados;
        }
        private int buscarDadoCorrespondiente(CheckBox checkbox)
        {
            if (checkbox == ckbDuno)
            {
                return 0;
            }
            else if (checkbox == ckbDDos)
            {
                return 1;
            }
            else if (checkbox == ckbDTres)
            {
                return 2;
            }
            else if (checkbox == ckbDCuatro)
            {
                return 3;
            }
            else if (checkbox == ckbDCinco)
            {
                return 4;
            }
            return 5;
        }
        private void tirarSeleccionados(List<int> seleccionados)
        {
            foreach (int seleccionado in seleccionados)
            {
                tiradaDados[seleccionado] = dado.tirar();
            }
        }
        private void EsconderOMostrarBtnAnotar()
        {
            if (tiradaActual == 1)
            {
                btnAnotar.Visible = false;
            }
            else
            {
                btnAnotar.Visible = true;
            }
        }
    }
}