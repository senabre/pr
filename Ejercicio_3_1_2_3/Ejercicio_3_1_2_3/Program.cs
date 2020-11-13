using System;

namespace Ejercicio_3_1_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            long numero1 = 0;
            long numero2 = 0;
            long suma = 0;
            long resta = 0;
            long mult = 0;

            Console.Write("numero1:");
            numero1 = Convert.ToInt64(Console.ReadLine());

            Console.Write("numero2:");
            numero2 = Convert.ToInt64(Console.ReadLine());

            suma = numero1 + numero2;

            resta = numero1 - numero2;

            mult = numero1 * numero2;

            Console.WriteLine("{0} + {1} = {2}", numero1, numero2, suma);

            Console.WriteLine("{0} - {1} = {2}", numero1, numero2, resta);

            Console.WriteLine("{0} * {1} = {2}", numero1, numero2, mult);


        }
    }
}
