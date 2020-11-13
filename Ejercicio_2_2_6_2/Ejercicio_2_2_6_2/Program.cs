using System;

namespace Ejercicio_2_2_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int primerNum = 0;
            int segundoNum = 0;
            int ancho = 0;
            int alto = 0;

            Console.WriteLine("Introduce el ancho del rectangulo");
            primerNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el alto del rectangulo");
            segundoNum = Convert.ToInt32(Console.ReadLine());

            for (alto = 1; alto <= segundoNum; alto++)
            {
                for (ancho = 1; ancho <= primerNum; ancho++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                    }

        }
    }
}
