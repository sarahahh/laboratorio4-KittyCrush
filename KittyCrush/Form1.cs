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
    public partial class Form1 : Form
    {
        Tablero tablero = new Tablero(8, 8, 6);
        public Form1()
        {
            InitializeComponent();
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
