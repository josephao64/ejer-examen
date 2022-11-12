/*  crea una matriz y luego imprime la primera fila, la última fila y la primera
columna. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz3
{
    class Matriz3
    {
        private int[,] mat;

        public void Cargar() 
        {
            mat=new int[3,4];
            for(int f = 0; f < 3; f++) 
            {
                for(int c = 0; c < 4; c++) 
                {
                    Console.Write("Ingrese componente:");
                    string linea;
                    linea = Console.ReadLine();
                    mat[f,c]=int.Parse(linea);
                }
            }
        }

        public void PrimerFila() 
        {
    	    Console.WriteLine("Primer fila de la matriz:");
            for(int c = 0; c < 4; c++) 
            {
                Console.WriteLine(mat[0,c]);
            }
        }

        public void UltimaFila() 
        {
    	    Console.WriteLine("Ultima fila de la matriz:");
            for(int c = 0; c < 4; c++) 
            {
                Console.WriteLine(mat[2,c]);
            }
        }

        public void PrimerColumna() 
        {
    	    Console.WriteLine("Primer columna:");
            for(int f = 0; f < 3; f++) 
            {
                Console.WriteLine(mat[f,0]);
            }
        }

        static void Main(string[] args)
        {
            Matriz3 ma = new Matriz3();
            ma.Cargar();
            ma.PrimerFila();
            ma.UltimaFila();
            ma.PrimerColumna();
            Console.ReadKey();
        }
    }
}