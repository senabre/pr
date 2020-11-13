using System;

namespace Ejercicio_2_1_8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int primerNumero = 0;
            int segundoNumero = 0;
            int result = 0;

            Console.WriteLine("Escribe un numero");
            primerNumero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escribe un numero");
            segundoNumero = Convert.ToInt32(Console.ReadLine());

            result = primerNumero < segundoNumero ? primerNumero : segundoNumero;

            Console.WriteLine("El menor numero es {0}", result);

            


        }
    }
}
