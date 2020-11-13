using System;

namespace Ejercicio_2_1_8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int result = 0;

            Console.WriteLine("Introduce un numero");
            numero = Convert.ToInt32(Console.ReadLine());

            result = numero >= 0 ? numero : -numero;

            Console.WriteLine("{0}", result);

        }
    }
}
