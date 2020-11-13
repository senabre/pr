using System;
using System.Diagnostics.Tracing;

namespace Ejercicio_4_1_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dias = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int mes;
            
            Console.WriteLine("mes");
            mes = Convert.ToInt32(Console.ReadLine());
            mes--;
            Console.WriteLine("El mes {0} tiene {1} dias ", mes + 1, dias[mes]);

        }
    }
}
