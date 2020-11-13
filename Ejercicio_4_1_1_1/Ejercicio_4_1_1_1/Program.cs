using System;
using System.Net.Http.Headers;

namespace Ejercicio_4_1_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numeros = new double[4];
            double primerNumero = 0;
            double segundoNumero = 0;
            double tercerNumero = 0;
            double cuartoNumero = 0;

            Console.Write("numero 1:");
            numeros[0] = Convert.ToDouble(Console.ReadLine());

            Console.Write("numero 2:");
            numeros[1] = Convert.ToDouble(Console.ReadLine());

            Console.Write("numero 3:");
            numeros[2] = Convert.ToDouble(Console.ReadLine());

            Console.Write("numero 4:");
            numeros[3] = Convert.ToDouble(Console.ReadLine());

            double media = (numeros[0] + numeros[1] + numeros[2] + numeros[3]) / 4;

            Console.WriteLine("La media de {0}, {1}, {2} y {3} es {4}", numeros[0], numeros[1], numeros[2], numeros[3], media);

        }
    }
}
