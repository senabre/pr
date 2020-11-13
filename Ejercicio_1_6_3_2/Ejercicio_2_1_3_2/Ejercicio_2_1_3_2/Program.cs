using System;

namespace Ejercicio_2_1_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int primerNumero = 0;
            int segundoNumero = 0;
            int producto = 0;

            Console.WriteLine("Introduce un numero");
            primerNumero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce un numero");
            segundoNumero = Convert.ToInt32(Console.ReadLine());

            if (segundoNumero == 0)
                Console.WriteLine("Error: No se puede dividir entre cero");
            else
            {
                producto = primerNumero / segundoNumero;
                Console.WriteLine("{0} dividido entre {1} es igual a {2}", primerNumero, segundoNumero, producto);
            }

        }
    }
}
