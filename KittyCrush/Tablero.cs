using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace KittyCrush
{
    //Clase tablero
    internal class Tablero
    {
        //Funciones getters, setters y valores de matriz
        public int cantFilas { get; set; }
        public int cantColumnas { get; set; }
        public int[,] valores { get; set; }
        public bool[,] bools { get; set; }
        public int contador { get; set; } = 0;
        public bool valido { get; set; }
        public int puntos { get; set; } = 0;


        //Constructor de la clase tablero 
        public Tablero(int cantFilas, int cantColumnas, int cantKittys)
        {
            this.cantFilas = cantFilas;
            this.cantColumnas = cantColumnas;
            this.valores = new int[cantFilas,cantColumnas];
            this.bools = new bool[cantFilas,cantColumnas];
            inizializar();
            inizializarBools();
            iniciarJuego(cantKittys);
        }

        //Funcion inicializar valores de la matriz
        private void inizializar()
        {
            for (int i = 0; i < valores.GetLength(0); i++)
            {
                for (int j = 0; j < valores.GetLength(1); j++)
                {
                    valores[i, j] = 0;
                }
            }
        }

        //Funcion inicializar bools de matriz
        private void inizializarBools()
        {
            for(int i = 0; i < bools.GetLength(0); i++)
            {
                for(int j = 0; j < bools.GetLength(1); j++)
                {
                    bools[i, j] = false;
                }
            }
        }

        //Funcion asignar valores aleatorios a matriz
        private void iniciarJuego(int cantKittys)
        {
            Random rand = new Random();
            for (int i = 0; i < valores.GetLength(0); i++)
            {
                for(int j = 0; j < valores.GetLength(1); j++)
                {
                    valores[i,j] = rand.Next(cantKittys);
                }
            }
        }

        public void comprobarVertical()
        {
            if(contador >= 3)
            {
                for (int i = 0; i < valores.GetLength(0); i++)
                {
                    for (int j = 0; j < valores.GetLength(1); j++)
                    {
                        if (bools[i, j] == true)
                        {
                            if (bools[i, j + 1] == true)
                            {
                                bool vertical = false;
                                comprobar(vertical, i, j);
                            }
                            else if (bools[i + 1, j] == true)
                            {
                                bool vertical = true;
                                comprobar(vertical, i, j);
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                agregarPuntos(-5);
            }
        }

        public void comprobar(bool vertical, int filaInicio, int columnaInicio)
        {
            valido = true;
            if (vertical==true)
            {
                for(int i = 0; i < valores.GetLength(0); i++)
                {
                    for ( int j = 0;j < valores.GetLength(1); j++)
                    {
                        if (bools[i, j] == true)
                        {
                            if (!(valores[i, j] == valores[filaInicio, columnaInicio] && j == columnaInicio))
                            {
                                valido = false;
                            }
                        }
                    }
                }
            }
            if(vertical==false) 
            {
                for (int i = 0; i < valores.GetLength(0); i++)
                {
                    for (int j = 0; j < valores.GetLength(1); j++)
                    {
                        if (bools[i, j] == true)
                        {
                            if (!(valores[i, j] == valores[filaInicio, columnaInicio] && i == filaInicio))
                            {
                                valido = false;
                            }
                        }
                    }
                }
            } 
            if(valido == true)
            {
                switch (contador)
                {
                    case 3:
                        agregarPuntos(6);
                        break;
                    case 4:
                        agregarPuntos(10);
                        break;
                    case 5:
                        agregarPuntos(15);
                        break;
                    default:
                        agregarPuntos(-5);
                        break;
                }
            }
            else
            {
                agregarPuntos(-5);
            }
            cascada();
            contador = 0;
            inizializarBools();
        }

        public void cascada()
        {
            for(int i = 0; i < valores.GetLength(0); i++)
            {
                for(int j = 0; j < valores.GetLength(1); j++)
                {

                }
            }
            Form1 form = new Form1();
            form.ponerImagen();
        }

        public void agregarPuntos(int pum)
        {
            puntos += pum;
            MessageBox.Show(puntos.ToString());
        }

        public void posicion(int fila, int columna)
        {
            contador++;
            bools[fila, columna] = true;
            if (contador == 5)
            {
                comprobarVertical();
            }
        }

    }
}
