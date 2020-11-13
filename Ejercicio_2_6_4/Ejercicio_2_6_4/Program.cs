using System;

namespace Ejercicio_2_6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int altoLeido = 0;
            int anchoLeido = 0;
            int alto = 0;
            int ancho = 0;

            Console.Write("Introduce el alto:");
            altoLeido = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce el ancho:");
            anchoLeido = Convert.ToInt32(Console.ReadLine());

            for (alto = 1; alto <= altoLeido; alto++)
            {
                for (ancho = 1; ancho <= anchoLeido; ancho++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            



        }
    }
}
