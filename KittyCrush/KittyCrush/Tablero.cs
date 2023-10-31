using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KittyCrush
{
    internal class Tablero
    {
        public int cantFilas {  get; set; }
        public int cantColumnas { get; set; }
        public int[,] valores { get; set; }
        public Tablero(int cantFilas, int cantColumnas, int cantKittys)
        {
            this.cantFilas = cantFilas;
            this.cantColumnas = cantColumnas;
            this.valores = new int[cantFilas,cantColumnas];
            iniciarJuego(cantKittys);
        }

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
    }
}
