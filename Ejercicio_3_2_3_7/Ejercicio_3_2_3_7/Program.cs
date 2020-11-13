using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Ejercicio_3_2_3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 0;
            double i = 0;
            double resultado = 0;
            double j = 0;

            Console.Write("Numero:");
            num = Convert.ToDouble(Console.ReadLine());

            for (i = 0; i < num; i++ )
            {
               resultado = Math.Pow((-1), i) /(2 * i + 1);

                j = j + resultado; 

            }
            Console.WriteLine("{0}", j);


        }
    }
}
