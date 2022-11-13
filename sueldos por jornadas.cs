/* 
joseph isaac asencio ortiz 0907-22-11933

Importación de las bibliotecas que se necesitan para que el programa se ejecute. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Creando un espacio de nombres llamado PruebaVector3. */
namespace PruebaVector3
{
   /* *|CURSOR_MARCADOR|* */
    class PruebaVector3
    {
     /* Declarar una variable de tipo matriz flotante. */
        private float[] turnoMan;
        private float[] turnoTar;

        public void Cargar() 
        {
           /* Declarar una variable de tipo cadena y luego declarar dos matrices de tipo flotante.
           Luego está imprimiendo un mensaje en la consola y luego está creando un ciclo for que se
           ejecutará 4 veces. */
            string linea;
            turnoMan=new float[4];
            turnoTar=new float[4];
            Console.WriteLine("Sueldos de empleados del turno de la mañana.");
            for(int f = 0; f < 4; f++) 
            {
               /* Le pide al usuario que ingrese un valor y luego lo almacena en la matriz. */
                Console.Write("Ingrese sueldo:");
                linea = Console.ReadLine();              
                turnoMan[f]=float.Parse(linea);
            }
            /* Imprime un mensaje en la consola y luego crea un bucle for que se ejecutará 4 veces. */
            Console.WriteLine("Sueldos de empleados del turno de la tarde.");
            for(int f = 0; f < 4; f++) 
            {
              /* Le pide al usuario que ingrese un valor y luego lo almacena en la matriz. */
                Console.Write("Ingrese sueldo:");
                linea = Console.ReadLine();              
                turnoTar[f]=float.Parse(linea);
            }
        }

        public void CalcularGastos() 
        {
            /* Declarando dos variables de tipo float y luego creando un bucle for que se ejecutará 4
            veces. */
            float man=0;
            float tar=0;
            for(int f = 0; f < 4; f++)
            {
                /* Sumando los valores de las matrices. */
                man=man+turnoMan[f];
                tar=tar+turnoTar[f];
            }
           /* Impresión del total de los gastos de los turnos de mañana y tarde. */
            Console.WriteLine("Total de gastos del turno de la mañana:"+man);
            Console.WriteLine("Total de gastos del turno de la tarde:"+tar);
            Console.ReadKey();
        }


    /// <summary>
    /// La función `Main` se llama cuando se inicia el programa. Crea una instancia de la clase
    /// `PruebaVector3` y llama a las funciones `Cargar` y `CalcularGastos` en esa instancia
    /// </summary>
    /// <param name="args">Los argumentos de la línea de comandos.</param>
        static void Main(string[] args)
        {
            PruebaVector3 pv = new PruebaVector3();
            pv.Cargar();
            pv.CalcularGastos();
        }
    }
}