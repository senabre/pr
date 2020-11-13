using System;

namespace Ejercicio_2_1_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            Console.WriteLine("Introduce un numero");
            numero = Convert.ToInt32(Console.ReadLine());

            if ((numero % 2 == 0) || (numero % 3 == 0))
                Console.WriteLine("{0} es multiplo de dos o de tres",numero);
            else
                Console.WriteLine("{0} no es multiplo de dos o de tres",numero);




        }
    }
}
