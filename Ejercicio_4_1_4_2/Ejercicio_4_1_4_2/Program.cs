using System;

namespace Ejercicio_4_1_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] datos = new int[6];
            int capacidad = 6; // Capacidad maxima del array
            int posicion = 0; // Número real de datos guardados
            int i;
            int numero;

            

                Console.Write("Numero para añadir:");
                numero = Convert.ToInt32(Console.ReadLine());

                if (posicion < capacidad)
                {
                    datos[posicion] = numero;
                    posicion++;
                }

            




        }
    }
}
