using System;

namespace Ejercicio_2_2_11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            for (numero = 0; numero <= 106; numero++ )
            {
                if (numero % 10 == 0)
                    continue;

                if (numero % 2 == 0)
                    Console.WriteLine("{0}", numero);   
            }
      
        }
    }
}
