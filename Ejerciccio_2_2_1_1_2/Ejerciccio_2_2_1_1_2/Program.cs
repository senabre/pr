using System;

namespace Ejerciccio_2_2_1_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;

            while (numero != 0)
            {
                Console.WriteLine("Introduce un numero para saber su cuadrado");
                numero = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("El cuadrado de {0} es {1}", numero, numero * numero);
            }

        }
    }
}
