using System;

namespace Ejercicio_2_2_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            for (numero = 10; numero <= 20; numero++)
            {
                    if (numero % 5 == 0)
                    Console.WriteLine("{0} es divisible entre 5", numero);
                else
                    if (numero % 6 == 0)
                    Console.WriteLine("{0} es divisible entre 6", numero);
                else;
                    if (numero % 7 == 0)
                    Console.WriteLine("{0} es divisible entre 7", numero);

            }
        }
    }
}
