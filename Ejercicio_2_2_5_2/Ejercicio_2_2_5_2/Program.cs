using System;

namespace Ejercicio_2_2_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int veces = 0;
            while (veces < 5)
            {
                numero = 0;
                while (numero < 5)
                {
                    numero++;
                    Console.Write("{0}", numero);

                }
                veces++;
            }        
        }
    }
}
