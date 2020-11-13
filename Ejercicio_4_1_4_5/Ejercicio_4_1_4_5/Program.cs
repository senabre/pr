using System;

namespace Ejercicio_4_1_4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombre = new string[10];
            int capacidad = 10; // Capacidad maxima del array
            int posicion = 0;
            int posicionInsertar;
            string accion;
            string nombres;
            int i;
            do
            {
                Console.WriteLine("1 --- Añadir un dato al final de los ya existentes.");
                Console.WriteLine("2 --- Insertar un dato en una cierta posición");
                Console.WriteLine("3 --- Borrar el dato que hay en una cierta posición");
                Console.WriteLine("4 --- Mostrar los datos que contiene el array.");
                Console.WriteLine("5 --- Salir del programa.");

                Console.Write("Escoge la acción a realizar (1-5):");
                accion = Console.ReadLine();

                if (accion == "1")
                {
                    Console.Write("Nombre:");
                    nombres = Console.ReadLine();

                    if (posicion < capacidad)
                    {
                        nombre[posicion] = nombres;
                        posicion++;
                    }
                    else
                    {
                        Console.WriteLine("Lleno");
                    }
                }

                if (accion == "2")
                {
                    if (posicion < capacidad)
                    {
                        Console.WriteLine("Nombre a insertar:");
                        nombres = Console.ReadLine();

                        Console.WriteLine("Posición a insertar:");
                        posicionInsertar = Convert.ToInt32(Console.ReadLine());

                        posicionInsertar--;
                        for (i = posicion; i > posicionInsertar; i--)
                            nombre[i] = nombre[i - 1];
                        nombre[posicionInsertar] = nombres;
                        posicion++;
                    }

                }

                if (accion == "3")
                {
                    if (posicion < capacidad)
                    { 
                        Console.Write("Posicion a borrar:");
                        int posicionBorrar = Convert.ToInt32(Console.ReadLine());

                        for (i = posicionBorrar- 1; i < capacidad - 1; i++)
                            nombre[i] = nombre[i + 1];
                    }
                    posicion--;
                }

                if (accion == "4")
                {
                    for (int j = 0; j < nombre.Length; j++)
                    {
                        Console.Write("{0} ", nombre[j]);
                    }
                    Console.WriteLine();
                }
            }

            while (accion != "5");

        }
    }
}
