using System;

namespace Ejercicio_2_2_8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int linea = 0;
            int numero = 0;

            for (linea = 0; linea < 6; linea++)
            {
                for (numero = 1; numero <= 7; numero++)
                {
                    Console.Write("{0}", numero);
                }
                Console.WriteLine();
            }
            
        }
    }
}
