using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class JugadorNegocio
    {
        public List<Jugador> listar()
        {
            List<Jugador> lista = new List<Jugador>();
            AccesoDatos datos = new AccesoDatos();
            datos.setearConsulta("SELECT id,nombre,partidasGanadas,partidasJugadas FROM jugadores");
            try
            {
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Jugador aux = new Jugador();
                    aux.Id = (int)datos.Lector["id"];
                    aux.Nombre = (string)datos.Lector["nombre"];
                    aux.PartidasGanadas = (int)datos.Lector["partidasGanadas"];
                    aux.PartidasJugadas = (int)datos.Lector["partidasJugadas"];

                    lista.Add(aux);

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
            return lista;
        }
    }
}
