using System;

namespace Ejercicio_3_1_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numero1 = 0;
            byte numero2 = 0;
            ushort resultado = 0;

            Console.WriteLine("Número 1 (0-255):");
            numero1 = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Número 2 (0-255):");
            numero2 = Convert.ToByte(Console.ReadLine());

            resultado = (ushort)(numero1 * numero2);

            Console.WriteLine("{0} * {1} = {2}",numero1,numero2, resultado);

        }
    }
}
