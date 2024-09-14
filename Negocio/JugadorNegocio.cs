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
            Jugador j1 = new Jugador("Pancho");
            Jugador j2 = new Jugador("Corcho");
            Jugador j3 = new Jugador("Nicox");
            lista.Add(j1);
            lista.Add(j2);
            lista.Add(j3);
            return lista;
        }
    }
}
