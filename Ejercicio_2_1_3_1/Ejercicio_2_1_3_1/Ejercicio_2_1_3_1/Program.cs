using System;

namespace Ejercicio_2_1_3_1
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

            if (primerNumero == 0)
                Console.WriteLine("El producto de 0 por cualquier número es 0");
            else
                Console.WriteLine("Introduce un numero");
                segundoNumero = Convert.ToInt32(Console.ReadLine());
                producto = primerNumero * segundoNumero;
                Console.WriteLine("El producto de {0} por {1} es {2}", primerNumero, segundoNumero, producto);


        }
    }
}
