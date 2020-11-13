using System;

namespace Ejercicio_2_1_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;

            Console.WriteLine("Escribe un numero");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("numero introducido es par");

        }
    }
}
