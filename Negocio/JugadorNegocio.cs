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

        public void agregar(Jugador jugador)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into jugadores (nombre, partidasGanadas, partidasJugadas) values (@nombre, 0, 0)");
                //datos.setearParametro("@id", jugador.Id);
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
    }
}
