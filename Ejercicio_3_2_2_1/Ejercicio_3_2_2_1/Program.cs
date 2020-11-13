using System;

namespace Ejercicio_3_2_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int primerNumero = 13;
            int segundoNumero = 6;
            int divionEntero;

            divionEntero = primerNumero / segundoNumero;
            Console.WriteLine("{0}",divionEntero);

            Console.WriteLine("----------------------");

            float primerNumeroSimpleF = 13;
            float segundoNumeroSimpleF = 6;
            float divionEnteroF ;

            divionEnteroF = primerNumeroSimpleF / segundoNumeroSimpleF;
            Console.WriteLine("{0}", divionEnteroF);

            Console.WriteLine("----------------------");

            double primerNumeroDobleD = 13;
            double segundoNumeroDobleD = 6;
            double divionEnteroD;

            divionEnteroD = primerNumeroDobleD / segundoNumeroDobleD;
            Console.WriteLine("{0}", divionEnteroD);

        }
    }
}
