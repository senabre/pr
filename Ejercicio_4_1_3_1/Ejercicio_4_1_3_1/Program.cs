using System;

namespace Ejercicio_4_1_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numero = new double[6];

            Console.Write("Numerom 1:");
            numero[0] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Numerom 2:");
            numero[1] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Numerom 3:");
            numero[2] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Numerom 4:");
            numero[3] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Numerom 5:");
            numero[4] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Numerom 6:");
            numero[5] = Convert.ToDouble(Console.ReadLine());

            for (int i = 5; i > -1; i--)
                Console.WriteLine("{0}",numero[i]);

        }
    }
}
