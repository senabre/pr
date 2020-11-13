using System;
using System.Diagnostics.CodeAnalysis;

namespace Ejecicio_4_1_3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] num = new double [3];
            double suma = 0;
            double i;
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("Numero {0}", i + 1);
                num[i] = Convert.ToDouble(Console.ReadLine());
                Math.Pow(Math.Sqrt(suma += num[i]), 2);
            }
            
        }
    }
}
