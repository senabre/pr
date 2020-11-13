using System;
using System.Runtime.Serialization.Formatters;

namespace Ejercicio_2_2_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int veces = 0;
            for (veces = 1; veces <= 4; veces++)
            {
                for (numero = 1; numero <= 5; numero++)
                {
                    Console.Write("{0}", numero);   
                }
                Console.WriteLine();

            }
             


        }
    }
}
