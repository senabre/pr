using System;

namespace Ejercicio_4_1_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros;
            int suma = 0;

            Console.Write("Cuantos números vas a introducir:");
            int num = Convert.ToInt32(Console.ReadLine());

            numeros = new int[num];

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("numeros:");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                suma += numeros[i];
            }
            suma /= num;
            Console.WriteLine("La media es {0}", suma);
        }
    }
}
