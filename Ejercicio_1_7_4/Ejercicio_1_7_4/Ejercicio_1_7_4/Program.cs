using System;

namespace Ejercicio_1_7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int número1 = 0;
            int número2 = 0;
            int producto = 0;

            número1 = 87;
            número2 = 94;
            producto = número1 * número2;
            Console.WriteLine("El producto de {0} y {1} es {2}", número1, número2, producto);

            /* Tener cuidad con los acentos en los identificadores porque pueden dar error */
        }
    }
}
