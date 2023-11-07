using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public int cantKittys { get; set; }

        private Form1 form;

        //Constructor de la clase tablero 
        public Tablero(int cantFilas, int cantColumnas, int cantKittys, Form1 form)
        {
            this.cantFilas = cantFilas;
            this.cantColumnas = cantColumnas;
            this.valores = new int[cantFilas,cantColumnas];
            this.bools = new bool[cantFilas,cantColumnas];
            this.form = form;
            this.cantKittys = cantKittys;
            inizializar();
            inizializarBools();
            iniciarJuego();
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
        private void iniciarJuego()
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
        public void posicion(int fila, int columna)
        {
            contador++;
            bools[fila, columna] = true;
            if (contador == 5)
            {
                comprobarVertical();
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
                            if(!(j == valores.GetLength(1) - 1))
                            {
                                if (bools[i, j + 1] == true)
                                {
                                    bool vertical = false;
                                    comprobar(vertical, i, j);
                                }
                            }
                            if(!(i==valores.GetLength(0) - 1))
                            {
                                if (bools[i + 1, j] == true)
                                {
                                    bool vertical = true;
                                    comprobar(vertical, i, j);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                agregarPuntos(-5);
                inizializarBools();
                contador = 0;
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
            Random rand = new Random();
            for (int i = 0; i< valores.GetLength(0); i++)
            {
                for(int j = 0; j<valores.GetLength(1); j++)
                {
                    if (bools[i,j])
                    {
                        for(int k = i; k>=0; k--)
                        {
                            if (k == 0)
                            {
                                valores[k, j] = rand.Next(cantKittys);
                            }
                            else
                            {
                                valores[k,j] = valores[k-1,j];
                            }
                        }
                        bools[i,j] = false;
                    }
                }
            }
            form.ponerImagen();
        }

        public void agregarPuntos(int pum)
        {
            puntos += pum;
            form.mostrarPuntos();
        }

        public void validarJugadas()
        {
            for(int i = 0;i< valores.GetLength(0); i++)
            {
                for( int j = 0;j< valores.GetLength(1); j++)
                {
                    
                }
            }
        }
    }
}
