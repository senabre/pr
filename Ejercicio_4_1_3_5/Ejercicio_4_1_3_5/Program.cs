using System;

namespace Ejercicio_4_1_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dias = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int fecha;
            int mes;
            int suma = 0;
            Console.WriteLine("Idica una fecha (1 al 31) ");
            fecha = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Idica un mes (1=enero, 12=diciembre)");
            mes = Convert.ToInt32(Console.ReadLine());
            mes--;

            for (int i = 0; i < mes; i++)
            {
                suma += dias[i];
            }
            suma += fecha;
            int fechaFinal = 365 - suma;
            Console.WriteLine("Quedan {0} para terminar el año", fechaFinal);
        }
    }
}
