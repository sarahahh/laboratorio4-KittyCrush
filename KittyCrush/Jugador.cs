using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KittyCrush
{
    public class Jugador
    {
        // Gets y Sets de las variables
        public int puntaje { get; set; }
        public string nombreJugador { get; set; }
        public DateTime fecha { get; set; }

        /// <summary>
        /// Creacion de jugador
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="fecha"></param>
        /// <param name="puntaje"></param>
        public Jugador(String nombre, DateTime fecha, int puntaje)
        {
            this.nombreJugador = nombre;
            this.fecha = fecha;
            this.puntaje = puntaje;
        }
    }
}
