using System;

namespace Ejercicio_4_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double [][] numeros;
            numeros = new double[2][];
            numeros[0] = new double[2];
            numeros[1] = new double[2];
            int i = -1;
            int j = -1;

            for(i = 0; i < numeros.Length; i++)
            {
                for(j= 0; j < numeros[i].Length; j++)
                {
                    Console.Write("Numero:");
                    numeros[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            double resultado = (numeros[0][0] * numeros[1][1]) - (numeros[0][1] * numeros[1][0]);
            Console.WriteLine(resultado);
        }
    }
}
