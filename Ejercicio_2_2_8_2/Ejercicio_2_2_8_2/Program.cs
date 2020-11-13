using System;

namespace Ejercicio_2_2_8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ancho = 0;
            int alto = 0;
            int filaActual = 0;
            int ColumnaActual = 0;

            Console.WriteLine("Introduce el ancho del rectangulo");
            ancho = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el alto del rectangulo");
            alto = Convert.ToInt32(Console.ReadLine());

            for (ColumnaActual = 1; ColumnaActual <= alto; ColumnaActual++)
            {
                for (filaActual = 1; filaActual <= ancho; filaActual++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
        }
    }
}
