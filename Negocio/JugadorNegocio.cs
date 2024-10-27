using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Configuration;

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

        public void agregar(Jugador jugador)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into jugadores (nombre, partidasGanadas, partidasJugadas) values (@nombre, 0, 0)");
                datos.setearParametro("@nombre", jugador.Nombre);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }

        public void eliminar(Jugador seleccionado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("DELETE from jugadores WHERE id = @id");
                datos.setearParametro("@id", seleccionado.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void ActualizarEstadisticas(List<int> idsParticipantes, int idGanador)
        {
            AccesoDatos datos = null;

            // Incrementa partidasJugadas para cada jugador participante.
            foreach (int jugadorId in idsParticipantes)
            {
                try
                {
                    datos = new AccesoDatos(); // Crea una nueva instancia de AccesoDatos.
                    datos.setearConsulta($"UPDATE jugadores SET partidasJugadas = partidasJugadas + 1 WHERE id = {jugadorId}");
                    datos.ejecutarAccion();
                }
                catch (Exception ex)
                {
                    // Si ocurre un error, lanza una excepción con un mensaje específico.
                    throw new Exception("Error al actualizar partidasJugadas para el jugador con ID: " + jugadorId, ex);
                }
                finally
                {
                    // Asegura que la conexión se cierra, incluso si ocurre un error.
                    if (datos != null)
                    {
                        datos.cerrarConexion(); // Asegura que la conexión se cierra después de cada operación.
                    }
                }
            }

            // Incrementa `partidasGanadas` solo para el jugador que ganó la partida.
            try
            {
                datos = new AccesoDatos(); // Nueva instancia para el ganador.
                datos.setearConsulta($"UPDATE jugadores SET partidasGanadas = partidasGanadas + 1 WHERE id = {idGanador}");
                // Define la consulta SQL para incrementar `partidasGanadas` del jugador ganador que le pasamos por parametro.
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar partidasGanadas para el jugador ganador con ID: " + idGanador, ex);
            }
            finally
            {
                // Asegura que la conexión se cierra después de la operación para el ganador.
                if (datos != null)
                {
                    datos.cerrarConexion(); // Asegura que la conexión se cierra después de la operación del ganador.
                }
            }
        }



    }
}
