using System;

namespace Ejercicio_2_1_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int  primerNumero;
            int segundoNumero;

            Console.WriteLine("Introduce un numero");
            primerNumero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce otro numero");
            segundoNumero = Convert.ToInt32(Console.ReadLine());

            if (primerNumero > segundoNumero)
            
                Console.WriteLine("{0} es mayor que {1}", primerNumero, segundoNumero);
            else
                    Console.WriteLine("{0} es mayor que {1}", segundoNumero, primerNumero);
            
        }
    }
}
