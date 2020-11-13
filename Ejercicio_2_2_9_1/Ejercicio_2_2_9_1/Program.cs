using System;

namespace Ejercicio_2_2_9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int i = 0;
            

            Console.WriteLine("Introduce un número");
            numero = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= numero; i++)
            {
                Console.WriteLine("9 * {0} = {1}", i, 9 * i);
            }

        }
    }
}
