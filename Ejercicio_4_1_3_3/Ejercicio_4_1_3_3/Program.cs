using System;
using System.Diagnostics.CodeAnalysis;

namespace Ejercicio_4_1_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numero= new double[10];
            double suma = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Numero {0}", i + 1);
                numero [i]= Convert.ToDouble(Console.ReadLine());
                suma += numero[i];
            }
            suma /= 10;
            Console.WriteLine("La media es {0}", suma);
        }
    }
}
