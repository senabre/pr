using System;

namespace Ejercicio_4_1_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dias = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int mes;
            int dia;
            int suma = 0;
            Console.WriteLine("mes");
            mes = Convert.ToInt32(Console.ReadLine());
            mes--;

            Console.WriteLine("dia");
            dia = Convert.ToInt32(Console.ReadLine());

            for (int i= 0; i< mes; i++)
            {
                suma += dias[i];
            }
            suma += dia;
            Console.WriteLine("El dia {0} del mes {1} es el dia {2} del año", dia, mes + 1, suma);
        }
    }
}
