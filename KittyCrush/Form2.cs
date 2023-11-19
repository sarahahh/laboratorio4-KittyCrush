using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KittyCrush
{
    public partial class Form2 : Form
    {
        //Creacion variables
        int points;
        Tablero tablero;

        public Form2(int points, Tablero tablero)
        {
            //Asignacion de variables y mostrar puntos
            InitializeComponent();
            this.points = points;
            this.tablero = tablero;
            puntoos.Text = points.ToString();
        }

        //Boton de guardar
        private void guardar_Click(object sender, EventArgs e)
        {
            //Creacion de jugador
            String nombre = textBoxNombre.Text;
            DateTime fecha = DateTime.Now;
            int puntos = points;
            tablero.agregarJugador(nombre, puntos, fecha);

            //Cerrar
            Close();
        }
    }
}
