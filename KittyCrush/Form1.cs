using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KittyCrush
{
    public partial class Form1 : Form
    {
        Tablero tablero;
        public Form1()
        {
            //Creacion de tablero
            InitializeComponent();
            tablero = new Tablero(8, 8, 6, this);
            ponerImagen();
        }

        /// <summary>
        /// metodo que devuelve una imagen dependiendo del numero
        /// </summary>
        /// <param name="recurso"></param>
        /// <returns></returns>
        private Image seleccionarImagen(int recurso)
        {
            switch (recurso)
            {
                case 0:
                    return global::KittyCrush.Properties.Resources.cina;
                case 1:
                    return global::KittyCrush.Properties.Resources.kuromi;
                case 2:
                    return global::KittyCrush.Properties.Resources.lukas;
                case 3:
                    return global::KittyCrush.Properties.Resources.melody;
                case 4:
                    return global::KittyCrush.Properties.Resources.pom;
                default:
                    return global::KittyCrush.Properties.Resources.sapo;
            }
        }

        //Boton validar
        private void botonValidar_Click(object sender, EventArgs e)
        {
            tablero.comprobarVertical();
        }

        /// <summary>
        /// Metodo que muestra los puntos en pantalla
        /// </summary>
        public void mostrarPuntos()
        {
            puntos.Text = tablero.puntos.ToString();
        }

        /// <summary>
        /// Metodo que muestra los mejores 5 jugadores en pantalla
        /// </summary>
        public void mostrarJugadores()
        {
            if (tablero.vectorJugadores[0] != null)
            {
                nombre0.Text = tablero.vectorJugadores[0].nombreJugador;
                fecha0.Text = tablero.vectorJugadores[0].fecha.ToString();
                puntaje0.Text = tablero.vectorJugadores[0].puntaje.ToString();
            }
            if (tablero.vectorJugadores[1] != null)
            {
                nombre1.Text = tablero.vectorJugadores[1].nombreJugador;
                fecha1.Text = tablero.vectorJugadores[1].fecha.ToString();
                puntaje1.Text = tablero.vectorJugadores[1].puntaje.ToString();
            }
            if (tablero.vectorJugadores[2] != null)
            {
                nombre2.Text = tablero.vectorJugadores[2].nombreJugador;
                fecha2.Text = tablero.vectorJugadores[2].fecha.ToString();
                puntaje2.Text = tablero.vectorJugadores[2].puntaje.ToString();
            }
            if (tablero.vectorJugadores[3] != null)
            {
                nombre3.Text = tablero.vectorJugadores[3].nombreJugador;
                fecha3.Text = tablero.vectorJugadores[3].fecha.ToString();
                puntaje3.Text = tablero.vectorJugadores[3].puntaje.ToString();
            }
            if (tablero.vectorJugadores[4] != null)
            {
                nombre4.Text = tablero.vectorJugadores[4].nombreJugador;
                fecha4.Text = tablero.vectorJugadores[4].fecha.ToString();
                puntaje4.Text = tablero.vectorJugadores[4].puntaje.ToString();
            }
        }

        /// <summary>
        /// Metodo para llamar el Form donde se ingresa el nombre
        /// </summary>
        public void llamarForm()
        {
            Form2 form2 = new Form2(tablero.puntos, tablero);
            form2.Show();
        }

        /// <summary>
        /// Metodo que le pone las imagenes a los botones
        /// </summary>
        public void ponerImagen()
        {
            boton00.BackgroundImage = seleccionarImagen(tablero.valores[0, 0]);
            boton01.BackgroundImage = seleccionarImagen(tablero.valores[0, 1]);
            boton02.BackgroundImage = seleccionarImagen(tablero.valores[0, 2]);
            boton03.BackgroundImage = seleccionarImagen(tablero.valores[0, 3]);
            boton04.BackgroundImage = seleccionarImagen(tablero.valores[0, 4]);
            boton05.BackgroundImage = seleccionarImagen(tablero.valores[0, 5]);
            boton06.BackgroundImage = seleccionarImagen(tablero.valores[0, 6]);
            boton07.BackgroundImage = seleccionarImagen(tablero.valores[0, 7]);
            boton10.BackgroundImage = seleccionarImagen(tablero.valores[1, 0]);
            boton11.BackgroundImage = seleccionarImagen(tablero.valores[1, 1]);
            boton12.BackgroundImage = seleccionarImagen(tablero.valores[1, 2]);
            boton13.BackgroundImage = seleccionarImagen(tablero.valores[1, 3]);
            boton14.BackgroundImage = seleccionarImagen(tablero.valores[1, 4]);
            boton15.BackgroundImage = seleccionarImagen(tablero.valores[1, 5]);
            boton16.BackgroundImage = seleccionarImagen(tablero.valores[1, 6]);
            boton17.BackgroundImage = seleccionarImagen(tablero.valores[1, 7]);
            boton20.BackgroundImage = seleccionarImagen(tablero.valores[2, 0]);
            boton21.BackgroundImage = seleccionarImagen(tablero.valores[2, 1]);
            boton22.BackgroundImage = seleccionarImagen(tablero.valores[2, 2]);
            boton23.BackgroundImage = seleccionarImagen(tablero.valores[2, 3]);
            boton24.BackgroundImage = seleccionarImagen(tablero.valores[2, 4]);
            boton25.BackgroundImage = seleccionarImagen(tablero.valores[2, 5]);
            boton26.BackgroundImage = seleccionarImagen(tablero.valores[2, 6]);
            boton27.BackgroundImage = seleccionarImagen(tablero.valores[2, 7]);
            boton30.BackgroundImage = seleccionarImagen(tablero.valores[3, 0]);
            boton31.BackgroundImage = seleccionarImagen(tablero.valores[3, 1]);
            boton32.BackgroundImage = seleccionarImagen(tablero.valores[3, 2]);
            boton33.BackgroundImage = seleccionarImagen(tablero.valores[3, 3]);
            boton34.BackgroundImage = seleccionarImagen(tablero.valores[3, 4]);
            boton35.BackgroundImage = seleccionarImagen(tablero.valores[3, 5]);
            boton36.BackgroundImage = seleccionarImagen(tablero.valores[3, 6]);
            boton37.BackgroundImage = seleccionarImagen(tablero.valores[3, 7]);
            boton40.BackgroundImage = seleccionarImagen(tablero.valores[4, 0]);
            boton41.BackgroundImage = seleccionarImagen(tablero.valores[4, 1]);
            boton42.BackgroundImage = seleccionarImagen(tablero.valores[4, 2]);
            boton43.BackgroundImage = seleccionarImagen(tablero.valores[4, 3]);
            boton44.BackgroundImage = seleccionarImagen(tablero.valores[4, 4]);
            boton45.BackgroundImage = seleccionarImagen(tablero.valores[4, 5]);
            boton46.BackgroundImage = seleccionarImagen(tablero.valores[4, 6]);
            boton47.BackgroundImage = seleccionarImagen(tablero.valores[4, 7]);
            boton50.BackgroundImage = seleccionarImagen(tablero.valores[5, 0]);
            boton51.BackgroundImage = seleccionarImagen(tablero.valores[5, 1]);
            boton52.BackgroundImage = seleccionarImagen(tablero.valores[5, 2]);
            boton53.BackgroundImage = seleccionarImagen(tablero.valores[5, 3]);
            boton54.BackgroundImage = seleccionarImagen(tablero.valores[5, 4]);
            boton55.BackgroundImage = seleccionarImagen(tablero.valores[5, 5]);
            boton56.BackgroundImage = seleccionarImagen(tablero.valores[5, 6]);
            boton57.BackgroundImage = seleccionarImagen(tablero.valores[5, 7]);
            boton60.BackgroundImage = seleccionarImagen(tablero.valores[6, 0]);
            boton61.BackgroundImage = seleccionarImagen(tablero.valores[6, 1]);
            boton62.BackgroundImage = seleccionarImagen(tablero.valores[6, 2]);
            boton63.BackgroundImage = seleccionarImagen(tablero.valores[6, 3]);
            boton64.BackgroundImage = seleccionarImagen(tablero.valores[6, 4]);
            boton65.BackgroundImage = seleccionarImagen(tablero.valores[6, 5]);
            boton66.BackgroundImage = seleccionarImagen(tablero.valores[6, 6]);
            boton67.BackgroundImage = seleccionarImagen(tablero.valores[6, 7]);
            boton70.BackgroundImage = seleccionarImagen(tablero.valores[7, 0]);
            boton71.BackgroundImage = seleccionarImagen(tablero.valores[7, 1]);
            boton72.BackgroundImage = seleccionarImagen(tablero.valores[7, 2]);
            boton73.BackgroundImage = seleccionarImagen(tablero.valores[7, 3]);
            boton74.BackgroundImage = seleccionarImagen(tablero.valores[7, 4]);
            boton75.BackgroundImage = seleccionarImagen(tablero.valores[7, 5]);
            boton76.BackgroundImage = seleccionarImagen(tablero.valores[7, 6]);
            boton77.BackgroundImage = seleccionarImagen(tablero.valores[7, 7]);
        }

        //Funciones botones de la matriz y ubicar en posicion de la matriz
        private void boton00_Click(object sender, EventArgs e)
        {
            tablero.posicion(0, 0);
        }

        private void boton01_Click(object sender, EventArgs e)
        {
            tablero.posicion(0, 1);
        }

        private void boton02_Click(object sender, EventArgs e)
        {
            tablero.posicion(0, 2);
        }

        private void boton03_Click(object sender, EventArgs e)
        {
            tablero.posicion(0, 3);
        }

        private void boton04_Click(object sender, EventArgs e)
        {
            tablero.posicion(0, 4);
        }

        private void boton05_Click(object sender, EventArgs e)
        {
            tablero.posicion(0, 5);
        }

        private void boton06_Click(object sender, EventArgs e)
        {
            tablero.posicion(0, 6);
        }

        private void boton07_Click(object sender, EventArgs e)
        {
            tablero.posicion(0, 7);
        }

        private void boton10_Click(object sender, EventArgs e)
        {
            tablero.posicion(1, 0);
        }

        private void boton11_Click(object sender, EventArgs e)
        {
            tablero.posicion(1, 1);
        }

        private void boton12_Click(object sender, EventArgs e)
        {
            tablero.posicion(1, 2);
        }

        private void boton13_Click(object sender, EventArgs e)
        {
            tablero.posicion(1, 3);
        }

        private void boton14_Click(object sender, EventArgs e)
        {
            tablero.posicion(1, 4);
        }

        private void boton15_Click(object sender, EventArgs e)
        {
            tablero.posicion(1, 5);
        }

        private void boton16_Click(object sender, EventArgs e)
        {
            tablero.posicion(1, 6);
        }

        private void boton17_Click(object sender, EventArgs e)
        {
            tablero.posicion(1, 7);
        }

        private void boton20_Click(object sender, EventArgs e)
        {
            tablero.posicion(2, 0);
        }

        private void boton21_Click(object sender, EventArgs e)
        {
            tablero.posicion(2, 1);
        }

        private void boton22_Click(object sender, EventArgs e)
        {
            tablero.posicion(2, 2);
        }

        private void boton23_Click(object sender, EventArgs e)
        {
            tablero.posicion(2, 3);
        }

        private void boton24_Click(object sender, EventArgs e)
        {
            tablero.posicion(2, 4);
        }

        private void boton25_Click(object sender, EventArgs e)
        {
            tablero.posicion(2, 5);
        }

        private void boton26_Click(object sender, EventArgs e)
        {
            tablero.posicion(2, 6);
        }

        private void boton27_Click(object sender, EventArgs e)
        {
            tablero.posicion(2, 7);
        }

        private void boton30_Click(object sender, EventArgs e)
        {
            tablero.posicion(3, 0);
        }

        private void boton31_Click(object sender, EventArgs e)
        {
            tablero.posicion(3, 1);
        }

        private void boton32_Click(object sender, EventArgs e)
        {
            tablero.posicion(3, 2);
        }

        private void boton33_Click(object sender, EventArgs e)
        {
            tablero.posicion(3, 3);
        }

        private void boton34_Click(object sender, EventArgs e)
        {
            tablero.posicion(3, 4);
        }

        private void boton35_Click(object sender, EventArgs e)
        {
            tablero.posicion(3, 5);
        }

        private void boton36_Click(object sender, EventArgs e)
        {
            tablero.posicion(3, 6);
        }

        private void boton37_Click(object sender, EventArgs e)
        {
            tablero.posicion(3, 7);
        }

        private void boton40_Click(object sender, EventArgs e)
        {
            tablero.posicion(4, 0);
        }

        private void boton41_Click(object sender, EventArgs e)
        {
            tablero.posicion(4, 1);
        }

        private void boton42_Click(object sender, EventArgs e)
        {
            tablero.posicion(4, 2);
        }

        private void boton43_Click(object sender, EventArgs e)
        {
            tablero.posicion(4, 3);
        }

        private void boton44_Click(object sender, EventArgs e)
        {
            tablero.posicion(4, 4);
        }

        private void boton45_Click(object sender, EventArgs e)
        {
            tablero.posicion(4, 5);
        }

        private void boton46_Click(object sender, EventArgs e)
        {
            tablero.posicion(4, 6);
        }

        private void boton47_Click(object sender, EventArgs e)
        {
            tablero.posicion(4, 7);
        }

        private void boton50_Click(object sender, EventArgs e)
        {
            tablero.posicion(5, 0);
        }

        private void boton51_Click(object sender, EventArgs e)
        {
            tablero.posicion(5, 1);
        }

        private void boton52_Click(object sender, EventArgs e)
        {
            tablero.posicion(5, 2);
        }

        private void boton53_Click(object sender, EventArgs e)
        {
            tablero.posicion(5, 3);
        }

        private void boton54_Click(object sender, EventArgs e)
        {
            tablero.posicion(5, 4);
        }

        private void boton55_Click(object sender, EventArgs e)
        {
            tablero.posicion(5, 5);
        }

        private void boton56_Click(object sender, EventArgs e)
        {
            tablero.posicion(5, 6);
        }

        private void boton57_Click(object sender, EventArgs e)
        {
            tablero.posicion(5, 7);
        }

        private void boton60_Click(object sender, EventArgs e)
        {
            tablero.posicion(6, 0);
        }

        private void boton61_Click(object sender, EventArgs e)
        {
            tablero.posicion(6, 1);
        }

        private void boton62_Click(object sender, EventArgs e)
        {
            tablero.posicion(6, 2);
        }

        private void boton63_Click(object sender, EventArgs e)
        {
            tablero.posicion(6, 3);
        }

        private void boton64_Click(object sender, EventArgs e)
        {
            tablero.posicion(6, 4);
        }

        private void boton65_Click(object sender, EventArgs e)
        {
            tablero.posicion(6, 5);
        }

        private void boton66_Click(object sender, EventArgs e)
        {
            tablero.posicion(6, 6);
        }

        private void boton67_Click(object sender, EventArgs e)
        {
            tablero.posicion(6, 7);
        }

        private void boton70_Click(object sender, EventArgs e)
        {
            tablero.posicion(7, 0);
        }

        private void boton71_Click(object sender, EventArgs e)
        {
            tablero.posicion(7, 1);
        }

        private void boton72_Click(object sender, EventArgs e)
        {
            tablero.posicion(7, 2);
        }

        private void boton73_Click(object sender, EventArgs e)
        {
            tablero.posicion(7, 3);
        }

        private void boton74_Click(object sender, EventArgs e)
        {
            tablero.posicion(7, 4);
        }

        private void boton75_Click(object sender, EventArgs e)
        {
            tablero.posicion(7, 5);
        }

        private void boton76_Click(object sender, EventArgs e)
        {
            tablero.posicion(7, 6);
        }

        private void boton77_Click(object sender, EventArgs e)
        {
            tablero.posicion(7, 7);
        }
    }
}
