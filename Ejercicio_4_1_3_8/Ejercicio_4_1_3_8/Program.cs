using System;
using System.Diagnostics.CodeAnalysis;

namespace Ejercicio_4_1_3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] num = new double[3];
            int i;
            double suma = 0;
            double resultado;

            for (i = 0; i < 3;i++)
            {
                Console.WriteLine("Número {0}", i + 1);
                num[i] = Convert.ToDouble(Console.ReadLine());
                suma += num[i];
            }
            resultado = Math.Pow(Math.Sqrt(suma), 2);
            Console.WriteLine(resultado);
        }
    }
}
