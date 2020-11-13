using System;

namespace Ejercicio_2_1_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int primerNumero = 0;
            int segundoNumero = 0;

            Console.WriteLine("Introduce un numero");
            primerNumero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce otro numero");
            segundoNumero = Convert.ToInt32(Console.ReadLine());

            if (primerNumero % segundoNumero == 0)
                Console.WriteLine("{0} es multiplo de {1}", primerNumero, segundoNumero);
            else
                Console.WriteLine("{0} no es multiplo de {1}", primerNumero, segundoNumero);
        }
    }
}
