using System;
using System.Data;

namespace Ejercicio_2_2_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;
            int numero;

            for(numero = 1; numero <=5; numero++)
            {
                for(letra='L'; letra <= 'M';letra++)
                    Console.Write("{0}",letra);
            }
            
        }
    }
}
