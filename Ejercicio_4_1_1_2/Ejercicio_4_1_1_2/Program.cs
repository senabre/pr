using System;

namespace Ejercicio_4_1_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numero = new double[5];

            Console.Write("numeros 1:");
            numero[0] = Convert.ToDouble(Console.ReadLine());

            Console.Write("numeros 2:");
            numero[1] = Convert.ToDouble(Console.ReadLine());

            Console.Write("numeros 3:");
            numero[2] = Convert.ToDouble(Console.ReadLine());

            Console.Write("numeros 4:");
            numero[3] = Convert.ToDouble(Console.ReadLine());

            Console.Write("numeros 5:");
            numero[4] = Convert.ToDouble(Console.ReadLine());

            Console.Write("{0},{1},{2},{3},{4}", numero[4], numero[3], numero[2], numero[1], numero[0]);

        }
    }
}
