using System;

namespace Ejercicio_4_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string [][] cadena;
            cadena = new string[2][];
            cadena[0] = new string[6];
            cadena[1] = new string[6];
            int i = -1;
            int j = -1;

            for (i= 0; i < cadena.Length; i++)
            {
                for (j = 0; j < cadena[i].Length; j++)
                {
                    Console.Write("Introduce una cadena:");
                        cadena[i][j] = Console.ReadLine();
                }
                Console.WriteLine();
            }

            Console.Write("Introduce una cadena para buscar:");
            string buscar = Console.ReadLine();

            for (i= 0;i < cadena.Length; i++ )
            {
                int encontrado = 0;
                for (j = 0; j < cadena[i].Length; j++)
                {
                    
                    if (buscar == cadena[i][j])
                    {
                        Console.WriteLine("{0} se ha encontrado en el bloque {1} posicion {2}", buscar, i + 1, j + 1);
                        encontrado = 1;
                        break;
                        
                    }
                    
                }
                if (encontrado == 1)
                {
                    break;
                }
                
            }

            if (j == cadena[1].Length)
            {
                Console.WriteLine("no se ha encontrado");
            }
        }
    }
}
