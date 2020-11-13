using System;

namespace Ejercicio_4_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] numeros;
            numeros = new int[2][];
            numeros[0] = new int[10];
            numeros[1] = new int[10];
            int i = -1;
            int j = -1;

            for (i = 0; i < numeros.Length; i++)
            {
                for (j = 0; j <numeros[i].Length; j++)
                {
                    Console.Write("Introduce un numero:");

                    numeros[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int max = Int32.MinValue;/* Int32.MinValue coge el minimo numero posible */
            //int maximo = numeros[0][0]; esta es otra opción cogiendo el primer numero de cada bloque
            for (i = 0; i < numeros.Length; i++)
            {
                for (j = 0; j < numeros[i].Length; j++)
                    if (numeros[i][j] > max)
                    {
                        max = numeros[i][j];
                    }
                Console.WriteLine(max);
                max = Int32.MinValue;
            }


        }
    } 
}
