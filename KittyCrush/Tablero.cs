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
    public class Tablero
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

        //Crear instancias
        private Form1 form;
        public Jugador[] vectorJugadores;

        private int cantidadJugadores;

        //Constructor de la clase tablero 
        public Tablero(int cantFilas, int cantColumnas, int cantKittys, Form1 form)
        {
            vectorJugadores = new Jugador[5];
            cantidadJugadores = 0;
            this.cantFilas = cantFilas;
            this.cantColumnas = cantColumnas;
            this.valores = new int[cantFilas,cantColumnas];
            this.bools = new bool[cantFilas,cantColumnas];
            this.form = form;
            this.cantKittys = cantKittys;
            inizializar();
            inizializarBools();
            iniciarJuego();
            posible();
        }

        /// <summary>
        /// Funcion inicializar valores de la matriz
        /// </summary>
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

        /// <summary>
        /// Funcion inicializar bools de matriz
        /// </summary>
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

        /// <summary>
        /// Funcion asignar valores aleatorios a matriz
        /// </summary>
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

        /// <summary>
        /// Funcion que vuelve verdadera la posicion que llega
        /// </summary>
        /// <param name="fila"></param>
        /// <param name="columna"></param>
        public void posicion(int fila, int columna)
        {
            contador++;
            bools[fila, columna] = true;
            if (contador == 5)
            {
                comprobarVertical();
            }
        }

        /// <summary>
        /// Funcion para validar si es vertical o horizotal
        /// </summary>
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
                                    // Llama el metodo comprobar, el false significa que es horizotal
                                    comprobar(false, i, j);
                                }
                            }
                            if(!(i==valores.GetLength(0) - 1))
                            {
                                if (bools[i + 1, j] == true)
                                {
                                    comprobar(true, i, j);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                //Si el contador es menor a 3 se le quita puntos
                agregarPuntos(-5);
                inizializarBools();
                contador = 0;
            }
        }

        //Comprueba si los botones seleccionados por el jugador si estan buenos
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
                //Se le agrega la cantidad de puntos dependiendo de la cantidad de botones seleccionados
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
                        inizializarBools();
                        break;
                }
            }
            else
            {
                agregarPuntos(-5);
                inizializarBools();
            }
            //Se llama la cascada, se reinician los bools y se verifica si hay jugadas posibles
            cascada();
            contador = 0;
            inizializarBools();
            posible();
        }

        /// <summary>
        /// Metodo para eliminar los que se seleccionan y hacer "caer" los otros
        /// </summary>
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
            //Se llama el metodo ponerImagen para que se actualicen las imagenes de los botones
            form.ponerImagen();
        }

        /// <summary>
        /// Metodo para agregar puntos
        /// </summary>
        /// <param name="pum"></param>
        public void agregarPuntos(int pum)
        {
            puntos += pum;
            form.mostrarPuntos();
        }

        /// <summary>
        /// Metodo para saber si es necesario llamar el form del nombre
        /// </summary>
        public void posible()
        {
            if (!validarJugadas())
            {
                form.llamarForm();
            }
        }

        /// <summary>
        /// Metodo para validar si hay mas jugadas posibles
        /// </summary>
        /// <returns>Retorna el verdadero si hay mas jugadas posibles</returns>
        public bool validarJugadas()
        {
            for (int i = 0; i < valores.GetLength(0); i++)
            {
                for (int j = 0; j < valores.GetLength(1); j++)
                {
                    if (j < valores.GetLength(1) - 2)
                    {
                        if(valores[i, j] == valores[i, j + 1])
                        {
                            if (verificar(i, j, false))
                            {
                                return verificar(i, j, false);
                            }
                        }
                    }
                    if (i < valores.GetLength(0) - 2)
                    {
                        if(valores[i, j] == valores[i + 1, j])
                        {
                            if (verificar(i, j, true))
                            {
                                return verificar(i, j, true);
                            }
                        }
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Verifica si en la posicion mandada hay una jugada
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        /// <param name="vertical"></param>
        /// <returns>Retorna verdadero si es una jugada posible</returns>
        public bool verificar(int n, int m, bool vertical)
        {
            if (vertical)
            {
                for (int i = 1; i < 3; i++)
                {
                    if (valores[n, m] != valores[n + i, m])
                    {
                        return false;
                    }
                }
            }
            else
            {
                for (int i = 1; i < 3; i++)
                {
                    if (valores[n, m] != valores[n, m + i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        
        /// <summary>
        /// Metodo para agregar y ordenar los jugadores
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="puntaje"></param>
        /// <param name="fecha"></param>
        public void agregarJugador(string nombre, int puntaje, DateTime fecha)
        {
            if (cantidadJugadores == 4)
            {
                //Si ya hay inscritos 5 jugadores se eliminara al peor y se agregara el nuevo
                for (int i = 0; i < 5; i++)
                {
                    if (vectorJugadores[i].puntaje < puntaje)
                    {
                        for (int j = 4; j > i; j--)
                        {
                            vectorJugadores[j] = vectorJugadores[j - 1];
                        }
                        vectorJugadores[i] = new Jugador(nombre, fecha, puntaje);
                        i = 5;
                    }
                }
            }
            else
            {
                //Si no hay inscritos 5 jugadores se agrega el nuevo y se organiza de forma desendente
                vectorJugadores[cantidadJugadores] = new Jugador(nombre, fecha, puntaje);
                int index = cantidadJugadores;
                while (index > 0 && vectorJugadores[index].puntaje > vectorJugadores[index - 1].puntaje)
                {
                    Jugador temp = vectorJugadores[index];
                    vectorJugadores[index] = vectorJugadores[index - 1];
                    vectorJugadores[index - 1] = temp;

                    index--;
                }
                cantidadJugadores++;
            }
            //Luego de que se guarda la informacion se reinicia el tablero
            form.mostrarJugadores();
            inizializarBools();
            iniciarJuego();
            puntos = 0;
            form.ponerImagen();
            form.mostrarPuntos();
            posible();
        }

    }
}
